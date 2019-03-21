namespace FormsLearning
{
    partial class LoginInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignupLink = new System.Windows.Forms.LinkLabel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.PwdText = new System.Windows.Forms.Label();
            this.AccText = new System.Windows.Forms.Label();
            this.PwdInBox = new System.Windows.Forms.TextBox();
            this.AccInBox = new System.Windows.Forms.TextBox();
            this.LoginError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.LoginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SignupLink);
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 433);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SignupLink
            // 
            this.SignupLink.AutoSize = true;
            this.SignupLink.Location = new System.Drawing.Point(323, 354);
            this.SignupLink.Name = "SignupLink";
            this.SignupLink.Size = new System.Drawing.Size(127, 15);
            this.SignupLink.TabIndex = 2;
            this.SignupLink.TabStop = true;
            this.SignupLink.Text = "没有用户名？戳我";
            this.SignupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignupLink_LinkClicked);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConnectButton.Location = new System.Drawing.Point(158, 346);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.PwdText);
            this.LoginBox.Controls.Add(this.AccText);
            this.LoginBox.Controls.Add(this.PwdInBox);
            this.LoginBox.Controls.Add(this.AccInBox);
            this.LoginBox.Location = new System.Drawing.Point(146, 39);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(347, 253);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.TabStop = false;
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            // 
            // PwdText
            // 
            this.PwdText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PwdText.AutoSize = true;
            this.PwdText.Location = new System.Drawing.Point(6, 144);
            this.PwdText.Name = "PwdText";
            this.PwdText.Size = new System.Drawing.Size(71, 15);
            this.PwdText.TabIndex = 3;
            this.PwdText.Text = "Password";
            // 
            // AccText
            // 
            this.AccText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccText.AutoSize = true;
            this.AccText.Location = new System.Drawing.Point(9, 33);
            this.AccText.Name = "AccText";
            this.AccText.Size = new System.Drawing.Size(63, 15);
            this.AccText.TabIndex = 2;
            this.AccText.Text = "Account";
            // 
            // PwdInBox
            // 
            this.PwdInBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PwdInBox.Location = new System.Drawing.Point(6, 162);
            this.PwdInBox.Name = "PwdInBox";
            this.PwdInBox.Size = new System.Drawing.Size(192, 25);
            this.PwdInBox.TabIndex = 1;
            this.PwdInBox.TextChanged += new System.EventHandler(this.PwdInBox_TextChanged);
            // 
            // AccInBox
            // 
            this.AccInBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccInBox.Location = new System.Drawing.Point(6, 51);
            this.AccInBox.Name = "AccInBox";
            this.AccInBox.Size = new System.Drawing.Size(192, 25);
            this.AccInBox.TabIndex = 0;
            this.AccInBox.TextChanged += new System.EventHandler(this.AccInBox_TextChanged);
            // 
            // LoginError
            // 
            this.LoginError.ContainerControl = this;
            // 
            // loginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.panel1);
            this.Name = "loginInterface";
            this.Text = "LoginInterface";
            this.Load += new System.EventHandler(this.loginInterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Label PwdText;
        private System.Windows.Forms.Label AccText;
        private System.Windows.Forms.TextBox PwdInBox;
        private System.Windows.Forms.TextBox AccInBox;
        private System.Windows.Forms.ErrorProvider LoginError;
        private System.Windows.Forms.LinkLabel SignupLink;
    }
}

