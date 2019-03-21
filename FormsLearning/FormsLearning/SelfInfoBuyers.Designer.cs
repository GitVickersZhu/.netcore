namespace FormsLearning
{
    partial class SelfInfoBuyers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelfInfoBuyers));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NmLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.LinkLabel();
            this.CnoLabel = new System.Windows.Forms.Label();
            this.CnoDisplay = new System.Windows.Forms.Label();
            this.CsexDisplay = new System.Windows.Forms.LinkLabel();
            this.CsexLabel = new System.Windows.Forms.Label();
            this.CtelLabel = new System.Windows.Forms.Label();
            this.CtelDisplay = new System.Windows.Forms.LinkLabel();
            this.CstudyLabel = new System.Windows.Forms.Label();
            this.CstudyDisplay = new System.Windows.Forms.LinkLabel();
            this.CjobLabel = new System.Windows.Forms.Label();
            this.CjopDisplay = new System.Windows.Forms.LinkLabel();
            this.CaddrLabel = new System.Windows.Forms.Label();
            this.CaddrDisplay = new System.Windows.Forms.LinkLabel();
            this.CinfoLabel = new System.Windows.Forms.Label();
            this.CinfoDisplay = new System.Windows.Forms.LinkLabel();
            this.ClevelDisplay = new System.Windows.Forms.Label();
            this.SageLabel = new System.Windows.Forms.Label();
            this.CageDisplay = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(32, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NmLabel
            // 
            this.NmLabel.AutoSize = true;
            this.NmLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NmLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NmLabel.Location = new System.Drawing.Point(110, 38);
            this.NmLabel.Name = "NmLabel";
            this.NmLabel.Size = new System.Drawing.Size(69, 25);
            this.NmLabel.TabIndex = 1;
            this.NmLabel.Text = "姓名：";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.LinkColor = System.Drawing.Color.Navy;
            this.NameLabel.Location = new System.Drawing.Point(172, 44);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.TabStop = true;
            this.NameLabel.Text = "Bili";
            this.NameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NameLabel_LinkClicked);
            // 
            // CnoLabel
            // 
            this.CnoLabel.AutoSize = true;
            this.CnoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CnoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CnoLabel.Location = new System.Drawing.Point(110, 82);
            this.CnoLabel.Name = "CnoLabel";
            this.CnoLabel.Size = new System.Drawing.Size(69, 25);
            this.CnoLabel.TabIndex = 1;
            this.CnoLabel.Text = "番号：";
            // 
            // CnoDisplay
            // 
            this.CnoDisplay.AutoSize = true;
            this.CnoDisplay.ForeColor = System.Drawing.Color.Red;
            this.CnoDisplay.Location = new System.Drawing.Point(172, 88);
            this.CnoDisplay.Name = "CnoDisplay";
            this.CnoDisplay.Size = new System.Drawing.Size(55, 15);
            this.CnoDisplay.TabIndex = 3;
            this.CnoDisplay.Text = "label1";
            this.CnoDisplay.Click += new System.EventHandler(this.CnoDisplay_Click);
            // 
            // CsexDisplay
            // 
            this.CsexDisplay.AutoSize = true;
            this.CsexDisplay.Location = new System.Drawing.Point(89, 150);
            this.CsexDisplay.Name = "CsexDisplay";
            this.CsexDisplay.Size = new System.Drawing.Size(22, 15);
            this.CsexDisplay.TabIndex = 4;
            this.CsexDisplay.TabStop = true;
            this.CsexDisplay.Text = "♂";
            this.CsexDisplay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CsexDisplay_LinkClicked);
            // 
            // CsexLabel
            // 
            this.CsexLabel.AutoSize = true;
            this.CsexLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CsexLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CsexLabel.Location = new System.Drawing.Point(27, 144);
            this.CsexLabel.Name = "CsexLabel";
            this.CsexLabel.Size = new System.Drawing.Size(69, 25);
            this.CsexLabel.TabIndex = 1;
            this.CsexLabel.Text = "性别：";
            // 
            // CtelLabel
            // 
            this.CtelLabel.AutoSize = true;
            this.CtelLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CtelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CtelLabel.Location = new System.Drawing.Point(27, 200);
            this.CtelLabel.Name = "CtelLabel";
            this.CtelLabel.Size = new System.Drawing.Size(50, 25);
            this.CtelLabel.TabIndex = 1;
            this.CtelLabel.Text = "电话";
            // 
            // CtelDisplay
            // 
            this.CtelDisplay.AutoSize = true;
            this.CtelDisplay.Location = new System.Drawing.Point(89, 206);
            this.CtelDisplay.Name = "CtelDisplay";
            this.CtelDisplay.Size = new System.Drawing.Size(95, 15);
            this.CtelDisplay.TabIndex = 5;
            this.CtelDisplay.TabStop = true;
            this.CtelDisplay.Text = "18406587523";
            this.CtelDisplay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CtelDisplay_LinkClicked);
            // 
            // CstudyLabel
            // 
            this.CstudyLabel.AutoSize = true;
            this.CstudyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CstudyLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CstudyLabel.Location = new System.Drawing.Point(27, 260);
            this.CstudyLabel.Name = "CstudyLabel";
            this.CstudyLabel.Size = new System.Drawing.Size(69, 25);
            this.CstudyLabel.TabIndex = 1;
            this.CstudyLabel.Text = "学历：";
            // 
            // CstudyDisplay
            // 
            this.CstudyDisplay.AutoSize = true;
            this.CstudyDisplay.Location = new System.Drawing.Point(89, 266);
            this.CstudyDisplay.Name = "CstudyDisplay";
            this.CstudyDisplay.Size = new System.Drawing.Size(67, 15);
            this.CstudyDisplay.TabIndex = 6;
            this.CstudyDisplay.TabStop = true;
            this.CstudyDisplay.Text = "研究♀生";
            this.CstudyDisplay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CstudyDisplay_LinkClicked);
            // 
            // CjobLabel
            // 
            this.CjobLabel.AutoSize = true;
            this.CjobLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CjobLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CjobLabel.Location = new System.Drawing.Point(161, 260);
            this.CjobLabel.Name = "CjobLabel";
            this.CjobLabel.Size = new System.Drawing.Size(69, 25);
            this.CjobLabel.TabIndex = 1;
            this.CjobLabel.Text = "工作：";
            // 
            // CjopDisplay
            // 
            this.CjopDisplay.AutoSize = true;
            this.CjopDisplay.Location = new System.Drawing.Point(223, 266);
            this.CjopDisplay.Name = "CjopDisplay";
            this.CjopDisplay.Size = new System.Drawing.Size(37, 15);
            this.CjopDisplay.TabIndex = 7;
            this.CjopDisplay.TabStop = true;
            this.CjopDisplay.Text = "跤警";
            this.CjopDisplay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CjopDisplay_LinkClicked);
            // 
            // CaddrLabel
            // 
            this.CaddrLabel.AutoSize = true;
            this.CaddrLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CaddrLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaddrLabel.Location = new System.Drawing.Point(61, 352);
            this.CaddrLabel.Name = "CaddrLabel";
            this.CaddrLabel.Size = new System.Drawing.Size(69, 25);
            this.CaddrLabel.TabIndex = 1;
            this.CaddrLabel.Text = "地址：";
            // 
            // CaddrDisplay
            // 
            this.CaddrDisplay.AutoSize = true;
            this.CaddrDisplay.Location = new System.Drawing.Point(123, 358);
            this.CaddrDisplay.Name = "CaddrDisplay";
            this.CaddrDisplay.Size = new System.Drawing.Size(125, 15);
            this.CaddrDisplay.TabIndex = 8;
            this.CaddrDisplay.TabStop = true;
            this.CaddrDisplay.Text = "€8CWP0CXaKx3€";
            this.CaddrDisplay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CaddrDisplay_LinkClicked);
            // 
            // CinfoLabel
            // 
            this.CinfoLabel.AutoSize = true;
            this.CinfoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CinfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CinfoLabel.Location = new System.Drawing.Point(27, 440);
            this.CinfoLabel.Name = "CinfoLabel";
            this.CinfoLabel.Size = new System.Drawing.Size(69, 25);
            this.CinfoLabel.TabIndex = 1;
            this.CinfoLabel.Text = "备注：";
            // 
            // CinfoDisplay
            // 
            this.CinfoDisplay.AutoSize = true;
            this.CinfoDisplay.Location = new System.Drawing.Point(89, 446);
            this.CinfoDisplay.Name = "CinfoDisplay";
            this.CinfoDisplay.Size = new System.Drawing.Size(70, 15);
            this.CinfoDisplay.TabIndex = 9;
            this.CinfoDisplay.TabStop = true;
            this.CinfoDisplay.Text = "Oh♂Yeah";
            this.CinfoDisplay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CinfoDisplay_LinkClicked);
            // 
            // ClevelDisplay
            // 
            this.ClevelDisplay.AutoSize = true;
            this.ClevelDisplay.Location = new System.Drawing.Point(247, 539);
            this.ClevelDisplay.Name = "ClevelDisplay";
            this.ClevelDisplay.Size = new System.Drawing.Size(52, 15);
            this.ClevelDisplay.TabIndex = 10;
            this.ClevelDisplay.Text = "※※※";
            // 
            // SageLabel
            // 
            this.SageLabel.AutoSize = true;
            this.SageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SageLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SageLabel.Location = new System.Drawing.Point(161, 144);
            this.SageLabel.Name = "SageLabel";
            this.SageLabel.Size = new System.Drawing.Size(69, 25);
            this.SageLabel.TabIndex = 1;
            this.SageLabel.Text = "年龄：";
            // 
            // CageDisplay
            // 
            this.CageDisplay.AutoSize = true;
            this.CageDisplay.Location = new System.Drawing.Point(226, 153);
            this.CageDisplay.Name = "CageDisplay";
            this.CageDisplay.Size = new System.Drawing.Size(23, 15);
            this.CageDisplay.TabIndex = 11;
            this.CageDisplay.TabStop = true;
            this.CageDisplay.Text = "20";
            this.CageDisplay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CageDisplay_LinkClicked);
            // 
            // SelfInfoBuyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 593);
            this.Controls.Add(this.CageDisplay);
            this.Controls.Add(this.ClevelDisplay);
            this.Controls.Add(this.CinfoDisplay);
            this.Controls.Add(this.CaddrDisplay);
            this.Controls.Add(this.CjopDisplay);
            this.Controls.Add(this.CstudyDisplay);
            this.Controls.Add(this.CtelDisplay);
            this.Controls.Add(this.CsexDisplay);
            this.Controls.Add(this.CnoDisplay);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CaddrLabel);
            this.Controls.Add(this.CjobLabel);
            this.Controls.Add(this.CinfoLabel);
            this.Controls.Add(this.CstudyLabel);
            this.Controls.Add(this.CtelLabel);
            this.Controls.Add(this.SageLabel);
            this.Controls.Add(this.CsexLabel);
            this.Controls.Add(this.CnoLabel);
            this.Controls.Add(this.NmLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SelfInfoBuyers";
            this.Text = "SelfInfoBuyers";
            this.Load += new System.EventHandler(this.SelfInfoBuyers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NmLabel;
        private System.Windows.Forms.LinkLabel NameLabel;
        private System.Windows.Forms.Label CnoLabel;
        private System.Windows.Forms.Label CnoDisplay;
        private System.Windows.Forms.LinkLabel CsexDisplay;
        private System.Windows.Forms.Label CsexLabel;
        private System.Windows.Forms.Label CtelLabel;
        private System.Windows.Forms.LinkLabel CtelDisplay;
        private System.Windows.Forms.Label CstudyLabel;
        private System.Windows.Forms.LinkLabel CstudyDisplay;
        private System.Windows.Forms.Label CjobLabel;
        private System.Windows.Forms.LinkLabel CjopDisplay;
        private System.Windows.Forms.Label CaddrLabel;
        private System.Windows.Forms.LinkLabel CaddrDisplay;
        private System.Windows.Forms.Label CinfoLabel;
        private System.Windows.Forms.LinkLabel CinfoDisplay;
        private System.Windows.Forms.Label ClevelDisplay;
        private System.Windows.Forms.Label SageLabel;
        private System.Windows.Forms.LinkLabel CageDisplay;
    }
}