namespace Login_Form
{
    partial class IMS
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
            this.employeesBtn = new System.Windows.Forms.Button();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.prodCategories = new System.Windows.Forms.Button();
            this.allProducts = new System.Windows.Forms.Button();
            this.prodInStock = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Products = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.analyticsBtn = new System.Windows.Forms.Button();
            this.topSellingBtn = new System.Windows.Forms.Button();
            this.salesOverviewBtn = new System.Windows.Forms.Button();
            this.panelAnalytics = new System.Windows.Forms.Panel();
            this.salesChartBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameEmployeeLbl = new System.Windows.Forms.Label();
            this.userTypeLbl = new System.Windows.Forms.Label();
            this.employeePhoto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.productsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAnalytics.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panelAnalytics);
            this.panel1.Controls.Add(this.employeesBtn);
            this.panel1.Controls.Add(this.productsPanel);
            this.panel1.Controls.Add(this.orders);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 840);
            this.panel1.TabIndex = 0;
            // 
            // employeesBtn
            // 
            this.employeesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeesBtn.FlatAppearance.BorderSize = 0;
            this.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.employeesBtn.Location = new System.Drawing.Point(0, 492);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.employeesBtn.Size = new System.Drawing.Size(238, 58);
            this.employeesBtn.TabIndex = 9;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesBtn.UseVisualStyleBackColor = true;
            this.employeesBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.prodCategories);
            this.productsPanel.Controls.Add(this.allProducts);
            this.productsPanel.Controls.Add(this.prodInStock);
            this.productsPanel.Controls.Add(this.Products);
            this.productsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsPanel.Location = new System.Drawing.Point(0, 260);
            this.productsPanel.MaximumSize = new System.Drawing.Size(238, 232);
            this.productsPanel.MinimumSize = new System.Drawing.Size(238, 58);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(238, 232);
            this.productsPanel.TabIndex = 0;
            // 
            // prodCategories
            // 
            this.prodCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.prodCategories.FlatAppearance.BorderSize = 0;
            this.prodCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodCategories.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.prodCategories.Location = new System.Drawing.Point(0, 174);
            this.prodCategories.Name = "prodCategories";
            this.prodCategories.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.prodCategories.Size = new System.Drawing.Size(238, 58);
            this.prodCategories.TabIndex = 10;
            this.prodCategories.Text = "Categories";
            this.prodCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prodCategories.UseVisualStyleBackColor = true;
            this.prodCategories.Click += new System.EventHandler(this.prodCategories_Click);
            // 
            // allProducts
            // 
            this.allProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.allProducts.FlatAppearance.BorderSize = 0;
            this.allProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allProducts.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.allProducts.Location = new System.Drawing.Point(0, 116);
            this.allProducts.Name = "allProducts";
            this.allProducts.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.allProducts.Size = new System.Drawing.Size(238, 58);
            this.allProducts.TabIndex = 9;
            this.allProducts.Text = "All Products";
            this.allProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allProducts.UseVisualStyleBackColor = true;
            this.allProducts.Click += new System.EventHandler(this.allProducts_Click);
            // 
            // prodInStock
            // 
            this.prodInStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.prodInStock.FlatAppearance.BorderSize = 0;
            this.prodInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodInStock.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.prodInStock.Location = new System.Drawing.Point(0, 58);
            this.prodInStock.Name = "prodInStock";
            this.prodInStock.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.prodInStock.Size = new System.Drawing.Size(238, 58);
            this.prodInStock.TabIndex = 8;
            this.prodInStock.Text = "Products Stock";
            this.prodInStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prodInStock.UseVisualStyleBackColor = true;
            this.prodInStock.Click += new System.EventHandler(this.prodInStock_Click_1);
            // 
            // orders
            // 
            this.orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.orders.FlatAppearance.BorderSize = 0;
            this.orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.orders.Location = new System.Drawing.Point(0, 205);
            this.orders.Name = "orders";
            this.orders.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.orders.Size = new System.Drawing.Size(238, 55);
            this.orders.TabIndex = 3;
            this.orders.Text = "POS";
            this.orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click_1);
            // 
            // Dashboard
            // 
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Dashboard.Location = new System.Drawing.Point(0, 150);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Dashboard.Size = new System.Drawing.Size(238, 55);
            this.Dashboard.TabIndex = 3;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 150);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(238, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 48);
            this.panel3.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(238, 48);
            this.panelMenu.MinimumSize = new System.Drawing.Size(950, 562);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(950, 792);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Products
            // 
            this.Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.Products.FlatAppearance.BorderSize = 0;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Products.Image = global::Login_Form.Properties.Resources.collapse_arrow;
            this.Products.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Products.Location = new System.Drawing.Point(0, 0);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Products.Size = new System.Drawing.Size(238, 58);
            this.Products.TabIndex = 7;
            this.Products.Text = "Products";
            this.Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // analyticsBtn
            // 
            this.analyticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.analyticsBtn.FlatAppearance.BorderSize = 0;
            this.analyticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyticsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyticsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.analyticsBtn.Image = global::Login_Form.Properties.Resources.collapse_arrow;
            this.analyticsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.analyticsBtn.Location = new System.Drawing.Point(0, 0);
            this.analyticsBtn.Name = "analyticsBtn";
            this.analyticsBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.analyticsBtn.Size = new System.Drawing.Size(238, 58);
            this.analyticsBtn.TabIndex = 6;
            this.analyticsBtn.Text = "Analytics";
            this.analyticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analyticsBtn.UseVisualStyleBackColor = true;
            this.analyticsBtn.Click += new System.EventHandler(this.analyticsBtn_Click);
            // 
            // topSellingBtn
            // 
            this.topSellingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.topSellingBtn.FlatAppearance.BorderSize = 0;
            this.topSellingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topSellingBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topSellingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.topSellingBtn.Location = new System.Drawing.Point(0, 58);
            this.topSellingBtn.Name = "topSellingBtn";
            this.topSellingBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.topSellingBtn.Size = new System.Drawing.Size(238, 58);
            this.topSellingBtn.TabIndex = 9;
            this.topSellingBtn.Text = "Top Selling";
            this.topSellingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topSellingBtn.UseVisualStyleBackColor = true;
            this.topSellingBtn.Click += new System.EventHandler(this.topSellingBtn_Click_1);
            // 
            // salesOverviewBtn
            // 
            this.salesOverviewBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesOverviewBtn.FlatAppearance.BorderSize = 0;
            this.salesOverviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesOverviewBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOverviewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.salesOverviewBtn.Location = new System.Drawing.Point(0, 116);
            this.salesOverviewBtn.Name = "salesOverviewBtn";
            this.salesOverviewBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.salesOverviewBtn.Size = new System.Drawing.Size(238, 58);
            this.salesOverviewBtn.TabIndex = 11;
            this.salesOverviewBtn.Text = "Sales Overview";
            this.salesOverviewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesOverviewBtn.UseVisualStyleBackColor = true;
            this.salesOverviewBtn.Click += new System.EventHandler(this.salesOverviewBtn_Click_1);
            // 
            // panelAnalytics
            // 
            this.panelAnalytics.Controls.Add(this.salesChartBtn);
            this.panelAnalytics.Controls.Add(this.salesOverviewBtn);
            this.panelAnalytics.Controls.Add(this.topSellingBtn);
            this.panelAnalytics.Controls.Add(this.analyticsBtn);
            this.panelAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnalytics.Location = new System.Drawing.Point(0, 550);
            this.panelAnalytics.MaximumSize = new System.Drawing.Size(238, 232);
            this.panelAnalytics.MinimumSize = new System.Drawing.Size(238, 58);
            this.panelAnalytics.Name = "panelAnalytics";
            this.panelAnalytics.Size = new System.Drawing.Size(238, 232);
            this.panelAnalytics.TabIndex = 0;
            // 
            // salesChartBtn
            // 
            this.salesChartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesChartBtn.FlatAppearance.BorderSize = 0;
            this.salesChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesChartBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesChartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.salesChartBtn.Location = new System.Drawing.Point(0, 174);
            this.salesChartBtn.Name = "salesChartBtn";
            this.salesChartBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.salesChartBtn.Size = new System.Drawing.Size(238, 58);
            this.salesChartBtn.TabIndex = 12;
            this.salesChartBtn.Text = "Sales Chart";
            this.salesChartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesChartBtn.UseVisualStyleBackColor = true;
            this.salesChartBtn.Click += new System.EventHandler(this.salesChartBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.nameEmployeeLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userTypeLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.employeePhoto, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameEmployeeLbl
            // 
            this.nameEmployeeLbl.AutoSize = true;
            this.nameEmployeeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameEmployeeLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEmployeeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.nameEmployeeLbl.Location = new System.Drawing.Point(3, 90);
            this.nameEmployeeLbl.Name = "nameEmployeeLbl";
            this.nameEmployeeLbl.Size = new System.Drawing.Size(232, 30);
            this.nameEmployeeLbl.TabIndex = 0;
            this.nameEmployeeLbl.Text = "Name";
            this.nameEmployeeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTypeLbl
            // 
            this.userTypeLbl.AutoSize = true;
            this.userTypeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTypeLbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.userTypeLbl.Location = new System.Drawing.Point(3, 120);
            this.userTypeLbl.Name = "userTypeLbl";
            this.userTypeLbl.Size = new System.Drawing.Size(232, 30);
            this.userTypeLbl.TabIndex = 1;
            this.userTypeLbl.Text = "User Type";
            this.userTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeePhoto
            // 
            this.employeePhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePhoto.Location = new System.Drawing.Point(3, 3);
            this.employeePhoto.Name = "employeePhoto";
            this.employeePhoto.Size = new System.Drawing.Size(232, 84);
            this.employeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeePhoto.TabIndex = 2;
            this.employeePhoto.TabStop = false;
            // 
            // IMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1188, 840);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1210, 661);
            this.Name = "IMS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.productsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelAnalytics.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Button prodCategories;
        private System.Windows.Forms.Button allProducts;
        private System.Windows.Forms.Button prodInStock;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelAnalytics;
        private System.Windows.Forms.Button salesChartBtn;
        private System.Windows.Forms.Button salesOverviewBtn;
        private System.Windows.Forms.Button topSellingBtn;
        private System.Windows.Forms.Button analyticsBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label nameEmployeeLbl;
        public System.Windows.Forms.Label userTypeLbl;
        public System.Windows.Forms.PictureBox employeePhoto;
        public System.Windows.Forms.Button employeesBtn;
    }
}