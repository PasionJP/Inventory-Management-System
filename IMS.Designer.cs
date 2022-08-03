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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Employees = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.Suppliers = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Employees);
            this.panel1.Controls.Add(this.Sales);
            this.panel1.Controls.Add(this.Suppliers);
            this.panel1.Controls.Add(this.Products);
            this.panel1.Controls.Add(this.orders);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 610);
            this.panel1.TabIndex = 0;
            // 
            // Employees
            // 
            this.Employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employees.FlatAppearance.BorderSize = 0;
            this.Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Employees.Location = new System.Drawing.Point(0, 434);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(238, 58);
            this.Employees.TabIndex = 9;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
            this.Employees.Click += new System.EventHandler(this.button6_Click);
            // 
            // Sales
            // 
            this.Sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sales.FlatAppearance.BorderSize = 0;
            this.Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Sales.Location = new System.Drawing.Point(0, 376);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(238, 58);
            this.Sales.TabIndex = 5;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.button3_Click);
            // 
            // Suppliers
            // 
            this.Suppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.Suppliers.FlatAppearance.BorderSize = 0;
            this.Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suppliers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Suppliers.Location = new System.Drawing.Point(0, 318);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(238, 58);
            this.Suppliers.TabIndex = 5;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.Products.FlatAppearance.BorderSize = 0;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Products.Location = new System.Drawing.Point(0, 260);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(238, 58);
            this.Products.TabIndex = 5;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Employees_Click);
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
            this.orders.Size = new System.Drawing.Size(238, 55);
            this.orders.TabIndex = 3;
            this.orders.Text = "POS";
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
            this.Dashboard.Size = new System.Drawing.Size(238, 55);
            this.Dashboard.TabIndex = 3;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
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
            this.panelMenu.Size = new System.Drawing.Size(950, 562);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // IMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1188, 610);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Sales;
        private System.Windows.Forms.Button Suppliers;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Employees;
    }
}