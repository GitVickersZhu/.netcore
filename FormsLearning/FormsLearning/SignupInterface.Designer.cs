namespace FormsLearning
{
    partial class SignupInterface
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
            this.SignupGroup = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PwdBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.SellerButton = new System.Windows.Forms.RadioButton();
            this.BuyerButton = new System.Windows.Forms.RadioButton();
            this.PwdLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTypeLabel = new System.Windows.Forms.Label();
            this.SignupGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignupGroup
            // 
            this.SignupGroup.Controls.Add(this.SubmitButton);
            this.SignupGroup.Controls.Add(this.PwdBox);
            this.SignupGroup.Controls.Add(this.UsernameBox);
            this.SignupGroup.Controls.Add(this.IdBox);
            this.SignupGroup.Controls.Add(this.SellerButton);
            this.SignupGroup.Controls.Add(this.BuyerButton);
            this.SignupGroup.Controls.Add(this.PwdLabel);
            this.SignupGroup.Controls.Add(this.UsernameLabel);
            this.SignupGroup.Controls.Add(this.IdLabel);
            this.SignupGroup.Controls.Add(this.IdTypeLabel);
            this.SignupGroup.Location = new System.Drawing.Point(81, 27);
            this.SignupGroup.Name = "SignupGroup";
            this.SignupGroup.Size = new System.Drawing.Size(640, 480);
            this.SignupGroup.TabIndex = 0;
            this.SignupGroup.TabStop = false;
            this.SignupGroup.Enter += new System.EventHandler(this.SignupGroup_Enter);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(162, 387);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "提交";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PwdBox
            // 
            this.PwdBox.Location = new System.Drawing.Point(162, 322);
            this.PwdBox.Name = "PwdBox";
            this.PwdBox.Size = new System.Drawing.Size(189, 25);
            this.PwdBox.TabIndex = 9;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(162, 237);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(189, 25);
            this.UsernameBox.TabIndex = 8;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(162, 163);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(293, 25);
            this.IdBox.TabIndex = 7;
            this.IdBox.Text = "这里暗示你要输入身份证号";
            this.IdBox.TextChanged += new System.EventHandler(this.IdBox_TextChanged);
            // 
            // SellerButton
            // 
            this.SellerButton.AutoSize = true;
            this.SellerButton.Location = new System.Drawing.Point(347, 62);
            this.SellerButton.Name = "SellerButton";
            this.SellerButton.Size = new System.Drawing.Size(103, 19);
            this.SellerButton.TabIndex = 6;
            this.SellerButton.TabStop = true;
            this.SellerButton.Text = "万恶的房东";
            this.SellerButton.UseVisualStyleBackColor = true;
            this.SellerButton.CheckedChanged += new System.EventHandler(this.SellerButton_CheckedChanged);
            // 
            // BuyerButton
            // 
            this.BuyerButton.AutoSize = true;
            this.BuyerButton.Location = new System.Drawing.Point(284, 62);
            this.BuyerButton.Name = "BuyerButton";
            this.BuyerButton.Size = new System.Drawing.Size(58, 19);
            this.BuyerButton.TabIndex = 5;
            this.BuyerButton.TabStop = true;
            this.BuyerButton.Text = "房奴";
            this.BuyerButton.UseVisualStyleBackColor = true;
            this.BuyerButton.CheckedChanged += new System.EventHandler(this.BuyerButton_CheckedChanged);
            // 
            // PwdLabel
            // 
            this.PwdLabel.AutoSize = true;
            this.PwdLabel.Location = new System.Drawing.Point(159, 304);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(37, 15);
            this.PwdLabel.TabIndex = 3;
            this.PwdLabel.Text = "密码";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(159, 219);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(52, 15);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "用户名";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(159, 145);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(307, 15);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "根据国家有关法律法规，您必须暴露您的隐私";
            // 
            // IdTypeLabel
            // 
            this.IdTypeLabel.AutoSize = true;
            this.IdTypeLabel.Location = new System.Drawing.Point(170, 66);
            this.IdTypeLabel.Name = "IdTypeLabel";
            this.IdTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.IdTypeLabel.TabIndex = 0;
            this.IdTypeLabel.Text = "您想成为";
            // 
            // SignupInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.SignupGroup);
            this.Name = "SignupInterface";
            this.Text = "SignupInterface";
            this.Load += new System.EventHandler(this.SignupInterface_Load);
            this.SignupGroup.ResumeLayout(false);
            this.SignupGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SignupGroup;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox PwdBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.RadioButton SellerButton;
        private System.Windows.Forms.RadioButton BuyerButton;
        private System.Windows.Forms.Label PwdLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label IdTypeLabel;
    }
}