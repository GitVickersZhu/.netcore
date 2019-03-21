namespace FormsLearning
{
    partial class MainInterface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SelfInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoDiferLookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按小区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.楼层优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.户型优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有无家具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房屋属性优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.质量优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发布顺序优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.月租金优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.押金金额优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Beta = new System.Windows.Forms.ToolStripMenuItem();
            this.RentRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAllStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfirmChosenButton = new System.Windows.Forms.Button();
            this.RevokeButton = new System.Windows.Forms.Button();
            this.PactSentButton = new System.Windows.Forms.Button();
            this.PackLookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DisplayView);
            this.panel1.Location = new System.Drawing.Point(256, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 508);
            this.panel1.TabIndex = 0;
            // 
            // DisplayView
            // 
            this.DisplayView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayView.Location = new System.Drawing.Point(0, 0);
            this.DisplayView.Name = "DisplayView";
            this.DisplayView.RowTemplate.Height = 27;
            this.DisplayView.Size = new System.Drawing.Size(884, 508);
            this.DisplayView.TabIndex = 0;
            this.DisplayView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayView_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelfInfoToolStripMenuItem,
            this.SearchMenuItem,
            this.RentRequestToolStripMenuItem,
            this.PackLookToolStripMenuItem,
            this.ClearAllStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // SelfInfoToolStripMenuItem
            // 
            this.SelfInfoToolStripMenuItem.Name = "SelfInfoToolStripMenuItem";
            this.SelfInfoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.SelfInfoToolStripMenuItem.Text = "个人信息";
            this.SelfInfoToolStripMenuItem.Click += new System.EventHandler(this.SelfInfoToolStripMenuItem_Click);
            // 
            // SearchMenuItem
            // 
            this.SearchMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchallToolStripMenuItem,
            this.Beta});
            this.SearchMenuItem.Name = "SearchMenuItem";
            this.SearchMenuItem.Size = new System.Drawing.Size(81, 24);
            this.SearchMenuItem.Text = "房源查询";
            this.SearchMenuItem.Click += new System.EventHandler(this.SearchMenuItem_Click);
            // 
            // SearchallToolStripMenuItem
            // 
            this.SearchallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NoDiferLookToolStripMenuItem,
            this.按小区ToolStripMenuItem,
            this.SquareToolStripMenuItem,
            this.楼层优先ToolStripMenuItem,
            this.户型优先ToolStripMenuItem,
            this.有无家具ToolStripMenuItem,
            this.房屋属性优先ToolStripMenuItem,
            this.质量优先ToolStripMenuItem,
            this.发布顺序优先ToolStripMenuItem,
            this.月租金优先ToolStripMenuItem,
            this.押金金额优先ToolStripMenuItem});
            this.SearchallToolStripMenuItem.Name = "SearchallToolStripMenuItem";
            this.SearchallToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.SearchallToolStripMenuItem.Text = "属性分类";
            this.SearchallToolStripMenuItem.Click += new System.EventHandler(this.SearchallToolStripMenuItem_Click);
            // 
            // NoDiferLookToolStripMenuItem
            // 
            this.NoDiferLookToolStripMenuItem.Name = "NoDiferLookToolStripMenuItem";
            this.NoDiferLookToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.NoDiferLookToolStripMenuItem.Text = "无差别查询";
            this.NoDiferLookToolStripMenuItem.Click += new System.EventHandler(this.NoDiferLookToolStripMenuItem_Click);
            // 
            // 按小区ToolStripMenuItem
            // 
            this.按小区ToolStripMenuItem.Name = "按小区ToolStripMenuItem";
            this.按小区ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.按小区ToolStripMenuItem.Text = "小区优先";
            // 
            // SquareToolStripMenuItem
            // 
            this.SquareToolStripMenuItem.Name = "SquareToolStripMenuItem";
            this.SquareToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.SquareToolStripMenuItem.Text = "面积优先";
            this.SquareToolStripMenuItem.Click += new System.EventHandler(this.SquareToolStripMenuItem_Click);
            // 
            // 楼层优先ToolStripMenuItem
            // 
            this.楼层优先ToolStripMenuItem.Name = "楼层优先ToolStripMenuItem";
            this.楼层优先ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.楼层优先ToolStripMenuItem.Text = "楼层优先";
            // 
            // 户型优先ToolStripMenuItem
            // 
            this.户型优先ToolStripMenuItem.Name = "户型优先ToolStripMenuItem";
            this.户型优先ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.户型优先ToolStripMenuItem.Text = "户型优先";
            // 
            // 有无家具ToolStripMenuItem
            // 
            this.有无家具ToolStripMenuItem.Name = "有无家具ToolStripMenuItem";
            this.有无家具ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.有无家具ToolStripMenuItem.Text = "有无家具";
            // 
            // 房屋属性优先ToolStripMenuItem
            // 
            this.房屋属性优先ToolStripMenuItem.Name = "房屋属性优先ToolStripMenuItem";
            this.房屋属性优先ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.房屋属性优先ToolStripMenuItem.Text = "房屋属性优先";
            // 
            // 质量优先ToolStripMenuItem
            // 
            this.质量优先ToolStripMenuItem.Name = "质量优先ToolStripMenuItem";
            this.质量优先ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.质量优先ToolStripMenuItem.Text = "质量优先";
            // 
            // 发布顺序优先ToolStripMenuItem
            // 
            this.发布顺序优先ToolStripMenuItem.Name = "发布顺序优先ToolStripMenuItem";
            this.发布顺序优先ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.发布顺序优先ToolStripMenuItem.Text = "发布顺序优先";
            // 
            // 月租金优先ToolStripMenuItem
            // 
            this.月租金优先ToolStripMenuItem.Name = "月租金优先ToolStripMenuItem";
            this.月租金优先ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.月租金优先ToolStripMenuItem.Text = "月租金优先";
            // 
            // 押金金额优先ToolStripMenuItem
            // 
            this.押金金额优先ToolStripMenuItem.Name = "押金金额优先ToolStripMenuItem";
            this.押金金额优先ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.押金金额优先ToolStripMenuItem.Text = "押金金额优先";
            // 
            // Beta
            // 
            this.Beta.Name = "Beta";
            this.Beta.Size = new System.Drawing.Size(181, 26);
            this.Beta.Text = "自定义属性";
            this.Beta.Click += new System.EventHandler(this.BetaToolStripMenuItem_Click);
            // 
            // RentRequestToolStripMenuItem
            // 
            this.RentRequestToolStripMenuItem.Name = "RentRequestToolStripMenuItem";
            this.RentRequestToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.RentRequestToolStripMenuItem.Text = "已发出求租";
            this.RentRequestToolStripMenuItem.Click += new System.EventHandler(this.RentRequestToolStripMenuItem_Click);
            // 
            // ClearAllStripMenuItem
            // 
            this.ClearAllStripMenuItem.Name = "ClearAllStripMenuItem";
            this.ClearAllStripMenuItem.ShowShortcutKeys = false;
            this.ClearAllStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.ClearAllStripMenuItem.Text = "清屏";
            this.ClearAllStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItem_Click);
            // 
            // ConfirmChosenButton
            // 
            this.ConfirmChosenButton.Location = new System.Drawing.Point(1008, 568);
            this.ConfirmChosenButton.Name = "ConfirmChosenButton";
            this.ConfirmChosenButton.Size = new System.Drawing.Size(132, 52);
            this.ConfirmChosenButton.TabIndex = 2;
            this.ConfirmChosenButton.Text = "确认求租";
            this.ConfirmChosenButton.UseVisualStyleBackColor = true;
            this.ConfirmChosenButton.Click += new System.EventHandler(this.ConfirmChosenButton_Click);
            // 
            // RevokeButton
            // 
            this.RevokeButton.Location = new System.Drawing.Point(53, 339);
            this.RevokeButton.Name = "RevokeButton";
            this.RevokeButton.Size = new System.Drawing.Size(139, 52);
            this.RevokeButton.TabIndex = 3;
            this.RevokeButton.Text = "撤回求租信息";
            this.RevokeButton.UseVisualStyleBackColor = true;
            this.RevokeButton.Click += new System.EventHandler(this.RevokeButton_Click);
            // 
            // PactSentButton
            // 
            this.PactSentButton.Location = new System.Drawing.Point(53, 152);
            this.PactSentButton.Name = "PactSentButton";
            this.PactSentButton.Size = new System.Drawing.Size(139, 52);
            this.PactSentButton.TabIndex = 3;
            this.PactSentButton.Text = "请求升级为合同";
            this.PactSentButton.UseVisualStyleBackColor = true;
            this.PactSentButton.Click += new System.EventHandler(this.PactSentButton_Click);
            // 
            // PackLookToolStripMenuItem
            // 
            this.PackLookToolStripMenuItem.Name = "PackLookToolStripMenuItem";
            this.PackLookToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.PackLookToolStripMenuItem.Text = "合同查询";
            this.PackLookToolStripMenuItem.Click += new System.EventHandler(this.PackLookToolStripMenuItem_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.PactSentButton);
            this.Controls.Add(this.RevokeButton);
            this.Controls.Add(this.ConfirmChosenButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainInterface";
            this.Text = "MainInterface";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DisplayView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Beta;
        private System.Windows.Forms.Button ConfirmChosenButton;
        private System.Windows.Forms.ToolStripMenuItem ClearAllStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelfInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RentRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按小区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SquareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 楼层优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NoDiferLookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 户型优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 有无家具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房屋属性优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 质量优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发布顺序优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 月租金优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 押金金额优先ToolStripMenuItem;
        private System.Windows.Forms.Button RevokeButton;
        private System.Windows.Forms.Button PactSentButton;
        private System.Windows.Forms.ToolStripMenuItem PackLookToolStripMenuItem;
    }
}