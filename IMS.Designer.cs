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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelAnalytics = new System.Windows.Forms.Panel();
            this.salesChartBtn = new System.Windows.Forms.Button();
            this.salesOverviewBtn = new System.Windows.Forms.Button();
            this.topSellingBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.prodCategories = new System.Windows.Forms.Button();
            this.allProducts = new System.Windows.Forms.Button();
            this.prodInStock = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.userID = new System.Windows.Forms.Label();
            this.nameEmployeeLbl = new System.Windows.Forms.Label();
            this.userTypeLbl = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.userLogBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTLP = new System.Windows.Forms.TableLayoutPanel();
            this.dateSelectBtn = new System.Windows.Forms.Button();
            this.datePicture = new System.Windows.Forms.PictureBox();
            this.analyticsBtn = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.employeePhoto = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAnalytics.SuspendLayout();
            this.productsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.dateTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(238, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 58);
            this.panel3.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(238, 58);
            this.panelMenu.MinimumSize = new System.Drawing.Size(800, 600);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1120, 827);
            this.panelMenu.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 885);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.46808F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.53191F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 885);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.panelAnalytics);
            this.panel2.Controls.Add(this.employeesBtn);
            this.panel2.Controls.Add(this.productsPanel);
            this.panel2.Controls.Add(this.orders);
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 663);
            this.panel2.TabIndex = 3;
            // 
            // panelAnalytics
            // 
            this.panelAnalytics.Controls.Add(this.userLogBtn);
            this.panelAnalytics.Controls.Add(this.salesChartBtn);
            this.panelAnalytics.Controls.Add(this.salesOverviewBtn);
            this.panelAnalytics.Controls.Add(this.topSellingBtn);
            this.panelAnalytics.Controls.Add(this.analyticsBtn);
            this.panelAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnalytics.Location = new System.Drawing.Point(0, 350);
            this.panelAnalytics.MaximumSize = new System.Drawing.Size(238, 250);
            this.panelAnalytics.MinimumSize = new System.Drawing.Size(238, 50);
            this.panelAnalytics.Name = "panelAnalytics";
            this.panelAnalytics.Size = new System.Drawing.Size(238, 250);
            this.panelAnalytics.TabIndex = 0;
            // 
            // salesChartBtn
            // 
            this.salesChartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesChartBtn.FlatAppearance.BorderSize = 0;
            this.salesChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesChartBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesChartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.salesChartBtn.Location = new System.Drawing.Point(0, 150);
            this.salesChartBtn.Name = "salesChartBtn";
            this.salesChartBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.salesChartBtn.Size = new System.Drawing.Size(238, 50);
            this.salesChartBtn.TabIndex = 12;
            this.salesChartBtn.Text = "Sales Chart";
            this.salesChartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesChartBtn.UseVisualStyleBackColor = true;
            this.salesChartBtn.Click += new System.EventHandler(this.salesChartBtn_Click);
            this.salesChartBtn.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.salesChartBtn.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // salesOverviewBtn
            // 
            this.salesOverviewBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesOverviewBtn.FlatAppearance.BorderSize = 0;
            this.salesOverviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesOverviewBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOverviewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.salesOverviewBtn.Location = new System.Drawing.Point(0, 100);
            this.salesOverviewBtn.Name = "salesOverviewBtn";
            this.salesOverviewBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.salesOverviewBtn.Size = new System.Drawing.Size(238, 50);
            this.salesOverviewBtn.TabIndex = 11;
            this.salesOverviewBtn.Text = "Sales Overview";
            this.salesOverviewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesOverviewBtn.UseVisualStyleBackColor = true;
            this.salesOverviewBtn.Click += new System.EventHandler(this.salesOverviewBtn_Click);
            this.salesOverviewBtn.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.salesOverviewBtn.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // topSellingBtn
            // 
            this.topSellingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.topSellingBtn.FlatAppearance.BorderSize = 0;
            this.topSellingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topSellingBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topSellingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.topSellingBtn.Location = new System.Drawing.Point(0, 50);
            this.topSellingBtn.Name = "topSellingBtn";
            this.topSellingBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.topSellingBtn.Size = new System.Drawing.Size(238, 50);
            this.topSellingBtn.TabIndex = 9;
            this.topSellingBtn.Text = "Top Selling";
            this.topSellingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topSellingBtn.UseVisualStyleBackColor = true;
            this.topSellingBtn.Click += new System.EventHandler(this.topSellingBtn_Click);
            this.topSellingBtn.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.topSellingBtn.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // employeesBtn
            // 
            this.employeesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeesBtn.FlatAppearance.BorderSize = 0;
            this.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.employeesBtn.Location = new System.Drawing.Point(0, 300);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.employeesBtn.Size = new System.Drawing.Size(232, 50);
            this.employeesBtn.TabIndex = 9;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesBtn.UseVisualStyleBackColor = true;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            this.employeesBtn.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.employeesBtn.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.prodCategories);
            this.productsPanel.Controls.Add(this.allProducts);
            this.productsPanel.Controls.Add(this.prodInStock);
            this.productsPanel.Controls.Add(this.Products);
            this.productsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsPanel.Location = new System.Drawing.Point(0, 100);
            this.productsPanel.MaximumSize = new System.Drawing.Size(238, 200);
            this.productsPanel.MinimumSize = new System.Drawing.Size(238, 50);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(238, 200);
            this.productsPanel.TabIndex = 0;
            // 
            // prodCategories
            // 
            this.prodCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.prodCategories.FlatAppearance.BorderSize = 0;
            this.prodCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodCategories.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.prodCategories.Location = new System.Drawing.Point(0, 150);
            this.prodCategories.Name = "prodCategories";
            this.prodCategories.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.prodCategories.Size = new System.Drawing.Size(238, 50);
            this.prodCategories.TabIndex = 10;
            this.prodCategories.Text = "Categories";
            this.prodCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prodCategories.UseVisualStyleBackColor = true;
            this.prodCategories.Click += new System.EventHandler(this.prodCategories_Click);
            this.prodCategories.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.prodCategories.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // allProducts
            // 
            this.allProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.allProducts.FlatAppearance.BorderSize = 0;
            this.allProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allProducts.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.allProducts.Location = new System.Drawing.Point(0, 100);
            this.allProducts.Name = "allProducts";
            this.allProducts.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.allProducts.Size = new System.Drawing.Size(238, 50);
            this.allProducts.TabIndex = 9;
            this.allProducts.Text = "All Products";
            this.allProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allProducts.UseVisualStyleBackColor = true;
            this.allProducts.Click += new System.EventHandler(this.allProducts_Click);
            this.allProducts.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.allProducts.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // prodInStock
            // 
            this.prodInStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.prodInStock.FlatAppearance.BorderSize = 0;
            this.prodInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodInStock.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.prodInStock.Location = new System.Drawing.Point(0, 50);
            this.prodInStock.Name = "prodInStock";
            this.prodInStock.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.prodInStock.Size = new System.Drawing.Size(238, 50);
            this.prodInStock.TabIndex = 8;
            this.prodInStock.Text = "Products Stock";
            this.prodInStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prodInStock.UseVisualStyleBackColor = true;
            this.prodInStock.Click += new System.EventHandler(this.prodInStock_Click);
            this.prodInStock.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.prodInStock.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // orders
            // 
            this.orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.orders.FlatAppearance.BorderSize = 0;
            this.orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.orders.Location = new System.Drawing.Point(0, 50);
            this.orders.Name = "orders";
            this.orders.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.orders.Size = new System.Drawing.Size(232, 50);
            this.orders.TabIndex = 3;
            this.orders.Text = "POS";
            this.orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click_2);
            this.orders.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.orders.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Dashboard.Size = new System.Drawing.Size(232, 50);
            this.Dashboard.TabIndex = 3;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            this.Dashboard.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.MaximumSize = new System.Drawing.Size(232, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 207);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.userID, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.nameEmployeeLbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.userTypeLbl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.employeePhoto, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(232, 207);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userID.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.userID.Location = new System.Drawing.Point(3, 187);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(226, 20);
            this.userID.TabIndex = 3;
            this.userID.Text = "0";
            this.userID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userID.Visible = false;
            // 
            // nameEmployeeLbl
            // 
            this.nameEmployeeLbl.AutoSize = true;
            this.nameEmployeeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameEmployeeLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEmployeeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.nameEmployeeLbl.Location = new System.Drawing.Point(3, 127);
            this.nameEmployeeLbl.Name = "nameEmployeeLbl";
            this.nameEmployeeLbl.Size = new System.Drawing.Size(226, 30);
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
            this.userTypeLbl.Location = new System.Drawing.Point(3, 157);
            this.userTypeLbl.Name = "userTypeLbl";
            this.userTypeLbl.Size = new System.Drawing.Size(226, 30);
            this.userTypeLbl.TabIndex = 1;
            this.userTypeLbl.Text = "User Type";
            this.userTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.logoutBtn.Location = new System.Drawing.Point(0, 600);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.logoutBtn.Size = new System.Drawing.Size(232, 50);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // userLogBtn
            // 
            this.userLogBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userLogBtn.FlatAppearance.BorderSize = 0;
            this.userLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLogBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.userLogBtn.Location = new System.Drawing.Point(0, 200);
            this.userLogBtn.Name = "userLogBtn";
            this.userLogBtn.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.userLogBtn.Size = new System.Drawing.Size(238, 50);
            this.userLogBtn.TabIndex = 13;
            this.userLogBtn.Text = "User Log";
            this.userLogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userLogBtn.UseVisualStyleBackColor = true;
            this.userLogBtn.Click += new System.EventHandler(this.userLogBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dateTLP, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1120, 58);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dateTLP
            // 
            this.dateTLP.ColumnCount = 2;
            this.dateTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dateTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.dateTLP.Controls.Add(this.dateSelectBtn, 1, 0);
            this.dateTLP.Controls.Add(this.datePicture, 0, 0);
            this.dateTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTLP.Location = new System.Drawing.Point(3, 3);
            this.dateTLP.Name = "dateTLP";
            this.dateTLP.RowCount = 1;
            this.dateTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dateTLP.Size = new System.Drawing.Size(324, 52);
            this.dateTLP.TabIndex = 1;
            // 
            // dateSelectBtn
            // 
            this.dateSelectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateSelectBtn.FlatAppearance.BorderSize = 0;
            this.dateSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateSelectBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dateSelectBtn.Image = global::Login_Form.Properties.Resources.collapse_arrow;
            this.dateSelectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateSelectBtn.Location = new System.Drawing.Point(53, 0);
            this.dateSelectBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dateSelectBtn.MinimumSize = new System.Drawing.Size(266, 36);
            this.dateSelectBtn.Name = "dateSelectBtn";
            this.dateSelectBtn.Size = new System.Drawing.Size(271, 52);
            this.dateSelectBtn.TabIndex = 8;
            this.dateSelectBtn.Text = "10/08/9999 - 10/08/9999";
            this.dateSelectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateSelectBtn.UseVisualStyleBackColor = true;
            this.dateSelectBtn.Click += new System.EventHandler(this.dateSelectBtn_Click);
            // 
            // datePicture
            // 
            this.datePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicture.Location = new System.Drawing.Point(3, 3);
            this.datePicture.Name = "datePicture";
            this.datePicture.Size = new System.Drawing.Size(47, 46);
            this.datePicture.TabIndex = 9;
            this.datePicture.TabStop = false;
            this.datePicture.Click += new System.EventHandler(this.datePicture_Click);
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
            this.analyticsBtn.Size = new System.Drawing.Size(238, 50);
            this.analyticsBtn.TabIndex = 6;
            this.analyticsBtn.Text = "Analytics";
            this.analyticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analyticsBtn.UseVisualStyleBackColor = true;
            this.analyticsBtn.Click += new System.EventHandler(this.analyticsBtn_Click_1);
            this.analyticsBtn.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.analyticsBtn.MouseHover += new System.EventHandler(this.mouseHover_Event);
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
            this.Products.Size = new System.Drawing.Size(238, 50);
            this.Products.TabIndex = 7;
            this.Products.Text = "Products";
            this.Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click_1);
            this.Products.MouseLeave += new System.EventHandler(this.mouseLeave_Event);
            this.Products.MouseHover += new System.EventHandler(this.mouseHover_Event);
            // 
            // employeePhoto
            // 
            this.employeePhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePhoto.Location = new System.Drawing.Point(3, 3);
            this.employeePhoto.Name = "employeePhoto";
            this.employeePhoto.Size = new System.Drawing.Size(226, 121);
            this.employeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeePhoto.TabIndex = 2;
            this.employeePhoto.TabStop = false;
            // 
            // IMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1358, 885);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1300, 900);
            this.Name = "IMS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelAnalytics.ResumeLayout(false);
            this.productsPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.dateTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelAnalytics;
        private System.Windows.Forms.Button salesChartBtn;
        private System.Windows.Forms.Button salesOverviewBtn;
        private System.Windows.Forms.Button topSellingBtn;
        private System.Windows.Forms.Button analyticsBtn;
        public System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Button prodCategories;
        private System.Windows.Forms.Button allProducts;
        private System.Windows.Forms.Button prodInStock;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label userID;
        public System.Windows.Forms.Label nameEmployeeLbl;
        public System.Windows.Forms.Label userTypeLbl;
        public System.Windows.Forms.PictureBox employeePhoto;
        public System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button userLogBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel dateTLP;
        private System.Windows.Forms.Button dateSelectBtn;
        private System.Windows.Forms.PictureBox datePicture;
    }
}