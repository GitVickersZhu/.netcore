namespace FormsLearning
{
    partial class RentInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumIpt = new System.Windows.Forms.TextBox();
            this.UseforIpt = new System.Windows.Forms.TextBox();
            this.StartIpt = new System.Windows.Forms.TextBox();
            this.TimeIpt = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CashButton = new System.Windows.Forms.RadioButton();
            this.BankButton = new System.Windows.Forms.RadioButton();
            this.AlipayButton = new System.Windows.Forms.RadioButton();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "几人住";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "用途";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "开始日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "时长";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "支付方式";
            // 
            // NumIpt
            // 
            this.NumIpt.Location = new System.Drawing.Point(184, 84);
            this.NumIpt.Name = "NumIpt";
            this.NumIpt.Size = new System.Drawing.Size(100, 25);
            this.NumIpt.TabIndex = 1;
            // 
            // UseforIpt
            // 
            this.UseforIpt.Location = new System.Drawing.Point(422, 84);
            this.UseforIpt.Name = "UseforIpt";
            this.UseforIpt.Size = new System.Drawing.Size(100, 25);
            this.UseforIpt.TabIndex = 1;
            // 
            // StartIpt
            // 
            this.StartIpt.Location = new System.Drawing.Point(181, 197);
            this.StartIpt.Name = "StartIpt";
            this.StartIpt.Size = new System.Drawing.Size(100, 25);
            this.StartIpt.TabIndex = 1;
            // 
            // TimeIpt
            // 
            this.TimeIpt.Location = new System.Drawing.Point(422, 197);
            this.TimeIpt.Name = "TimeIpt";
            this.TimeIpt.Size = new System.Drawing.Size(100, 25);
            this.TimeIpt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AlipayButton);
            this.groupBox1.Controls.Add(this.BankButton);
            this.groupBox1.Controls.Add(this.CashButton);
            this.groupBox1.Location = new System.Drawing.Point(382, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // CashButton
            // 
            this.CashButton.AutoSize = true;
            this.CashButton.Location = new System.Drawing.Point(30, 11);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(58, 19);
            this.CashButton.TabIndex = 0;
            this.CashButton.TabStop = true;
            this.CashButton.Text = "现金";
            this.CashButton.UseVisualStyleBackColor = true;
            // 
            // BankButton
            // 
            this.BankButton.AutoSize = true;
            this.BankButton.Location = new System.Drawing.Point(30, 36);
            this.BankButton.Name = "BankButton";
            this.BankButton.Size = new System.Drawing.Size(73, 19);
            this.BankButton.TabIndex = 0;
            this.BankButton.TabStop = true;
            this.BankButton.Text = "银行卡";
            this.BankButton.UseVisualStyleBackColor = true;
            // 
            // AlipayButton
            // 
            this.AlipayButton.AutoSize = true;
            this.AlipayButton.Location = new System.Drawing.Point(30, 61);
            this.AlipayButton.Name = "AlipayButton";
            this.AlipayButton.Size = new System.Drawing.Size(73, 19);
            this.AlipayButton.TabIndex = 0;
            this.AlipayButton.TabStop = true;
            this.AlipayButton.Text = "支付宝";
            this.AlipayButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(31, 342);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(144, 58);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "我决定了";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // RentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UseforIpt);
            this.Controls.Add(this.TimeIpt);
            this.Controls.Add(this.StartIpt);
            this.Controls.Add(this.NumIpt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RentInterface";
            this.Text = "RentInterface";
            this.Load += new System.EventHandler(this.RentInterface_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumIpt;
        private System.Windows.Forms.TextBox UseforIpt;
        private System.Windows.Forms.TextBox StartIpt;
        private System.Windows.Forms.TextBox TimeIpt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AlipayButton;
        private System.Windows.Forms.RadioButton BankButton;
        private System.Windows.Forms.RadioButton CashButton;
        private System.Windows.Forms.Button ConfirmButton;
    }
}