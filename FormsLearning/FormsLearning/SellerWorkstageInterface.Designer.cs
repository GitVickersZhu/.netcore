namespace FormsLearning
{
    partial class SellerWorkstageInterface
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
            this.DataGridViewLeft = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridViewRight = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SelfInfoSellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房源管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HouseAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HouseLookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房产删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.合同管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PactLookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HousePactButton = new System.Windows.Forms.Button();
            this.PactHouseButton = new System.Windows.Forms.Button();
            this.PactRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLeft)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewLeft
            // 
            this.DataGridViewLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewLeft.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewLeft.Name = "DataGridViewLeft";
            this.DataGridViewLeft.RowTemplate.Height = 27;
            this.DataGridViewLeft.Size = new System.Drawing.Size(563, 372);
            this.DataGridViewLeft.TabIndex = 0;
            this.DataGridViewLeft.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLeft_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridViewLeft);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 372);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGridViewRight);
            this.panel2.Location = new System.Drawing.Point(716, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 372);
            this.panel2.TabIndex = 2;
            // 
            // DataGridViewRight
            // 
            this.DataGridViewRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewRight.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewRight.Name = "DataGridViewRight";
            this.DataGridViewRight.RowTemplate.Height = 27;
            this.DataGridViewRight.Size = new System.Drawing.Size(534, 372);
            this.DataGridViewRight.TabIndex = 0;
            this.DataGridViewRight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewRight_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelfInfoSellersToolStripMenuItem,
            this.RentInfoToolStripMenuItem,
            this.房源管理ToolStripMenuItem,
            this.合同管理ToolStripMenuItem,
            this.ClearAllToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SelfInfoSellersToolStripMenuItem
            // 
            this.SelfInfoSellersToolStripMenuItem.Name = "SelfInfoSellersToolStripMenuItem";
            this.SelfInfoSellersToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.SelfInfoSellersToolStripMenuItem.Text = "个人信息";
            this.SelfInfoSellersToolStripMenuItem.Click += new System.EventHandler(this.SelfInfoSellersToolStripMenuItem_Click);
            // 
            // RentInfoToolStripMenuItem
            // 
            this.RentInfoToolStripMenuItem.Name = "RentInfoToolStripMenuItem";
            this.RentInfoToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.RentInfoToolStripMenuItem.Text = "求租信息查询";
            this.RentInfoToolStripMenuItem.Click += new System.EventHandler(this.RentInfoToolStripMenuItem_Click);
            // 
            // 房源管理ToolStripMenuItem
            // 
            this.房源管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HouseAddToolStripMenuItem,
            this.HouseLookToolStripMenuItem,
            this.房产删除ToolStripMenuItem});
            this.房源管理ToolStripMenuItem.Name = "房源管理ToolStripMenuItem";
            this.房源管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.房源管理ToolStripMenuItem.Text = "房产管理";
            // 
            // HouseAddToolStripMenuItem
            // 
            this.HouseAddToolStripMenuItem.Name = "HouseAddToolStripMenuItem";
            this.HouseAddToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.HouseAddToolStripMenuItem.Text = "房产添加";
            this.HouseAddToolStripMenuItem.Click += new System.EventHandler(this.HouseAddToolStripMenuItem_Click);
            // 
            // HouseLookToolStripMenuItem
            // 
            this.HouseLookToolStripMenuItem.Name = "HouseLookToolStripMenuItem";
            this.HouseLookToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.HouseLookToolStripMenuItem.Text = "房产查询";
            this.HouseLookToolStripMenuItem.Click += new System.EventHandler(this.HouseLookToolStripMenuItem_Click);
            // 
            // 房产删除ToolStripMenuItem
            // 
            this.房产删除ToolStripMenuItem.Name = "房产删除ToolStripMenuItem";
            this.房产删除ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.房产删除ToolStripMenuItem.Text = "房产删除";
            // 
            // 合同管理ToolStripMenuItem
            // 
            this.合同管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PactRequestToolStripMenuItem,
            this.PactLookToolStripMenuItem,
            this.AddPactToolStripMenuItem});
            this.合同管理ToolStripMenuItem.Name = "合同管理ToolStripMenuItem";
            this.合同管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.合同管理ToolStripMenuItem.Text = "合同管理";
            // 
            // PactLookToolStripMenuItem
            // 
            this.PactLookToolStripMenuItem.Name = "PactLookToolStripMenuItem";
            this.PactLookToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.PactLookToolStripMenuItem.Text = "合同查询";
            this.PactLookToolStripMenuItem.Click += new System.EventHandler(this.PactLookToolStripMenuItem_Click);
            // 
            // AddPactToolStripMenuItem
            // 
            this.AddPactToolStripMenuItem.Name = "AddPactToolStripMenuItem";
            this.AddPactToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.AddPactToolStripMenuItem.Text = "合同添加";
            this.AddPactToolStripMenuItem.Click += new System.EventHandler(this.AddPactToolStripMenuItem_Click);
            // 
            // ClearAllToolStripMenuItem
            // 
            this.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem";
            this.ClearAllToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.ClearAllToolStripMenuItem.Text = "清屏";
            this.ClearAllToolStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItem_Click);
            // 
            // HousePactButton
            // 
            this.HousePactButton.Location = new System.Drawing.Point(92, 435);
            this.HousePactButton.Name = "HousePactButton";
            this.HousePactButton.Size = new System.Drawing.Size(150, 43);
            this.HousePactButton.TabIndex = 4;
            this.HousePactButton.Text = "查看房间合同";
            this.HousePactButton.UseVisualStyleBackColor = true;
            // 
            // PactHouseButton
            // 
            this.PactHouseButton.Location = new System.Drawing.Point(975, 435);
            this.PactHouseButton.Name = "PactHouseButton";
            this.PactHouseButton.Size = new System.Drawing.Size(150, 43);
            this.PactHouseButton.TabIndex = 4;
            this.PactHouseButton.Text = "查看合同房间";
            this.PactHouseButton.UseVisualStyleBackColor = true;
            // 
            // PactRequestToolStripMenuItem
            // 
            this.PactRequestToolStripMenuItem.Name = "PactRequestToolStripMenuItem";
            this.PactRequestToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.PactRequestToolStripMenuItem.Text = "合同请求查询";
            this.PactRequestToolStripMenuItem.Click += new System.EventHandler(this.PactRequestToolStripMenuItem_Click);
            // 
            // SellerWorkstageInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.PactHouseButton);
            this.Controls.Add(this.HousePactButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SellerWorkstageInterface";
            this.Text = "SellerWorkstageInterface";
            this.Load += new System.EventHandler(this.SellerWorkstageInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLeft)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataGridViewRight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SelfInfoSellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房源管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HouseLookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HouseAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 合同管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PactLookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房产删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RentInfoToolStripMenuItem;
        private System.Windows.Forms.Button HousePactButton;
        private System.Windows.Forms.Button PactHouseButton;
        private System.Windows.Forms.ToolStripMenuItem PactRequestToolStripMenuItem;
    }
}