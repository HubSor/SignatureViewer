namespace SignatureRetriever
{
    partial class LoginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.ResultBrowser = new System.Windows.Forms.WebBrowser();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GetLocalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(152, 36);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(276, 20);
            this.LoginBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(152, 62);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(276, 20);
            this.PasswordBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(93, 65);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(93, 39);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(26, 13);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Mail";
            // 
            // ResultBrowser
            // 
            this.ResultBrowser.Location = new System.Drawing.Point(12, 117);
            this.ResultBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ResultBrowser.Name = "ResultBrowser";
            this.ResultBrowser.Size = new System.Drawing.Size(549, 440);
            this.ResultBrowser.TabIndex = 5;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(152, 89);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(80, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Log in";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(128, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(329, 24);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Pass credentials to get email signature";
            // 
            // GetLocalButton
            // 
            this.GetLocalButton.Location = new System.Drawing.Point(353, 88);
            this.GetLocalButton.Name = "GetLocalButton";
            this.GetLocalButton.Size = new System.Drawing.Size(75, 23);
            this.GetLocalButton.TabIndex = 8;
            this.GetLocalButton.Text = "Get Local";
            this.GetLocalButton.UseVisualStyleBackColor = true;
            this.GetLocalButton.Click += new System.EventHandler(this.GetLocalButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(573, 586);
            this.Controls.Add(this.GetLocalButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.ResultBrowser);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "SignatureViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.WebBrowser ResultBrowser;
        private System.Windows.Forms.Button GetLocalButton;
    }
}

