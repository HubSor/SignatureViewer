﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Exchange.WebServices.Data;

namespace SignatureRetriever
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
            var mail = LoginBox.Text;
            var passwd = PasswordBox.Text;
            if (mail == null || passwd == null)
            {
                ResultBrowser.DocumentText = "Mail or password was not given.";
                return;
            }
            GetExchangeSignature(mail, passwd);
        }

        private void GetExchangeSignature(string mail, string password)
        {
            ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2013_SP1);
            service.Credentials = new WebCredentials(mail, password);
            service.AutodiscoverUrl(mail, RedirectionUrlValidationCallback);
            var owaConfig = UserConfiguration.Bind(service, "OWA.UserOptions", WellKnownFolderName.Root, UserConfigurationProperties.All);
            if (owaConfig == null)
            {
                ResultBrowser.DocumentText = "Connection error. Verify your credentials and internet connection.";
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
    }
}
