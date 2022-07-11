using System;
using System.Windows.Forms;
using Microsoft.Exchange.WebServices.Data;
using Redemption;

namespace SignatureRetriever
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ResultBrowser.DocumentText = "Email signature or error message will be displayed here.";
        }

        private static bool RedirectionUrlValidationCallback(string redirectionUrl)
        {
            // The default for the validation callback is to reject the URL.
            bool result = false;
            Uri redirectionUri = new Uri(redirectionUrl);
            // Validate the contents of the redirection URL. In this simple validation
            // callback, the redirection URL is considered valid if it is using HTTPS
            // to encrypt the authentication credentials. 
            if (redirectionUri.Scheme == "https")
            {
                result = true;
            }
            return result;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {  
            var mail = LoginBox.Text.Trim();
            var passwd = PasswordBox.Text.Trim();

            if (mail == "" || passwd == "")
            {
                ResultBrowser.DocumentText = "Mail or password was not given.";
                return;
            }

            if (mail.Length >= 256)
            {
                ResultBrowser.DocumentText = "Mail address is too long.";
                return;
            }
            
            GetExchangeSignature(mail, passwd);
        }

        private void GetExchangeSignature(string mail, string password)
        {
            ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2013_SP1);
            service.Credentials = new WebCredentials(mail, password);

            try
            {
                service.AutodiscoverUrl(mail, RedirectionUrlValidationCallback);
            }
            catch (AutodiscoverLocalException)
            {
                ResultBrowser.DocumentText = "Connection error. Verify your credentials and internet connection.";
                return;
            }
            catch (FormatException)
            {
                ResultBrowser.DocumentText = "Email is of incorrect format.";
                return;
            }

            var owaConfig = UserConfiguration.Bind(service, "OWA.UserOptions", WellKnownFolderName.Root, UserConfigurationProperties.All);
            if (owaConfig == null)
            {
                ResultBrowser.DocumentText = "Connection error. Could not access user's configuration.";
                return;
            }

            if (owaConfig.Dictionary.ContainsKey("signaturehtml"))
            {
                var signature = owaConfig.Dictionary["signaturehtml"];
                ResultBrowser.DocumentText = signature.ToString();
                return;
            }
            else 
            {
                ResultBrowser.DocumentText = "No signature found, make sure it's set at Exchange Admin Center.";
                return;
            }
        }

        private void GetLocalButton_Click(object sender, EventArgs e)
        {
            var session = new RDOSession();
            try
            {
                session.Logon();
            }
            catch (Exception)
            {
                ResultBrowser.DocumentText = "Unable to log in with local account";
                return;
            }
            
            var account = session.Accounts.Item(1);

            if (account == null)
            {
                ResultBrowser.DocumentText = "Unable to find local account data.";
                return;
            }

            if (account.NewMessageSignature == null)
            {
                ResultBrowser.DocumentText = "No signature is set to new messages.";
                return;
            }

            ResultBrowser.DocumentText = account.NewMessageSignature.HTMLBody;
        }
    }
}
