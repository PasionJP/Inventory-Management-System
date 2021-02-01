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
            this.ordersDropdown = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.ordersDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.Employees);
            this.panel1.Controls.Add(this.ordersDropdown);
            this.panel1.Controls.Add(this.orders);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 721);
            this.panel1.TabIndex = 0;
            // 
            // Employees
            // 
            this.Employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employees.FlatAppearance.BorderSize = 0;
            this.Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employees.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Employees.Location = new System.Drawing.Point(0, 329);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(238, 58);
            this.Employees.TabIndex = 5;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
            // 
            // ordersDropdown
            // 
            this.ordersDropdown.Controls.Add(this.button9);
            this.ordersDropdown.Controls.Add(this.add);
            this.ordersDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersDropdown.Location = new System.Drawing.Point(0, 210);
            this.ordersDropdown.Name = "ordersDropdown";
            this.ordersDropdown.Size = new System.Drawing.Size(238, 119);
            this.ordersDropdown.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 58);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(235, 59);
            this.button9.TabIndex = 1;
            this.button9.Text = "Manage orders";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(0, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(235, 59);
            this.add.TabIndex = 1;
            this.add.Text = "Add orders";
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button8_Click);
            // 
            // orders
            // 
            this.orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.orders.FlatAppearance.BorderSize = 0;
            this.orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orders.Location = new System.Drawing.Point(0, 155);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(238, 55);
            this.orders.TabIndex = 3;
            this.orders.Text = "Orders";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click_1);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 100);
            this.panel2.TabIndex = 1;
            // 
            // IMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 721);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1027, 561);
            this.Name = "IMS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ordersDropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ordersDropdown;
        private System.Windows.Forms.Button Employees;
    }
}