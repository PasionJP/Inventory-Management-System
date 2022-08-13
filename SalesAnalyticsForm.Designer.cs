
namespace Login_Form
{
    partial class SalesAnalyticsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOverviewDataGridView = new System.Windows.Forms.DataGridView();
            this.totalSalesOverview = new System.Windows.Forms.Label();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.filterLbl = new System.Windows.Forms.Label();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesOverviewDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(922, 54);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(916, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Overview";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.salesOverviewDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(928, 515);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 91;
            // 
            // disc
            // 
            this.disc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.disc.DataPropertyName = "disc";
            this.disc.HeaderText = "Discount";
            this.disc.MinimumWidth = 8;
            this.disc.Name = "disc";
            this.disc.ReadOnly = true;
            this.disc.Width = 127;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.DataPropertyName = "qty";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qty.DefaultCellStyle = dataGridViewCellStyle13;
            this.qty.HeaderText = "Quantity";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 127;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 91;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // pcode
            // 
            this.pcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pcode.DataPropertyName = "pcode";
            this.pcode.HeaderText = "Item Code";
            this.pcode.MinimumWidth = 8;
            this.pcode.Name = "pcode";
            this.pcode.ReadOnly = true;
            this.pcode.Width = 150;
            // 
            // transactionNumber
            // 
            this.transactionNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.transactionNumber.DataPropertyName = "transno";
            this.transactionNumber.HeaderText = "Transaction No.";
            this.transactionNumber.MinimumWidth = 8;
            this.transactionNumber.Name = "transactionNumber";
            this.transactionNumber.ReadOnly = true;
            this.transactionNumber.Width = 193;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 63;
            // 
            // i
            // 
            this.i.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.i.DataPropertyName = "i";
            this.i.HeaderText = "";
            this.i.MinimumWidth = 8;
            this.i.Name = "i";
            this.i.ReadOnly = true;
            this.i.Width = 27;
            // 
            // salesOverviewDataGridView
            // 
            this.salesOverviewDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            this.salesOverviewDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.salesOverviewDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.salesOverviewDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.salesOverviewDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesOverviewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.salesOverviewDataGridView.ColumnHeadersHeight = 30;
            this.salesOverviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salesOverviewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.id,
            this.transactionNumber,
            this.pcode,
            this.productName,
            this.price,
            this.qty,
            this.disc,
            this.Total});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesOverviewDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.salesOverviewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesOverviewDataGridView.EnableHeadersVisualStyles = false;
            this.salesOverviewDataGridView.Location = new System.Drawing.Point(3, 103);
            this.salesOverviewDataGridView.Name = "salesOverviewDataGridView";
            this.salesOverviewDataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesOverviewDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.salesOverviewDataGridView.RowHeadersVisible = false;
            this.salesOverviewDataGridView.RowHeadersWidth = 62;
            this.salesOverviewDataGridView.RowTemplate.Height = 28;
            this.salesOverviewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesOverviewDataGridView.Size = new System.Drawing.Size(922, 409);
            this.salesOverviewDataGridView.TabIndex = 5;
            this.salesOverviewDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.soldItemsDataGridView_CellContentClick);
            // 
            // totalSalesOverview
            // 
            this.totalSalesOverview.AutoSize = true;
            this.totalSalesOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalSalesOverview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.totalSalesOverview.Location = new System.Drawing.Point(725, 0);
            this.totalSalesOverview.Name = "totalSalesOverview";
            this.totalSalesOverview.Size = new System.Drawing.Size(194, 34);
            this.totalSalesOverview.TabIndex = 19;
            this.totalSalesOverview.Text = "0.00";
            this.totalSalesOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datePicker1
            // 
            this.datePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.datePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.datePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.datePicker1.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.datePicker1.CustomFormat = "MM/dd/yyyy";
            this.datePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(114, 3);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(159, 30);
            this.datePicker1.TabIndex = 15;
            this.datePicker1.Value = new System.DateTime(2022, 8, 12, 21, 26, 51, 0);
            this.datePicker1.ValueChanged += new System.EventHandler(this.datePicker1_ValueChanged);
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.filterLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.filterLbl.Location = new System.Drawing.Point(20, 3);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(82, 28);
            this.filterLbl.TabIndex = 14;
            this.filterLbl.Text = "Filter By";
            this.filterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePicker2
            // 
            this.datePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.datePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.datePicker2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.datePicker2.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.datePicker2.CustomFormat = "MM/dd/yyyy";
            this.datePicker2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Location = new System.Drawing.Point(279, 3);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(159, 30);
            this.datePicker2.TabIndex = 18;
            this.datePicker2.Value = new System.DateTime(2022, 8, 12, 21, 26, 51, 0);
            this.datePicker2.ValueChanged += new System.EventHandler(this.datePicker2_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.datePicker2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.filterLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.datePicker1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalSalesOverview, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(922, 34);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // SalesAnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(928, 515);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesAnalyticsForm";
            this.Text = "SalesAnalyticsForm";
            this.Load += new System.EventHandler(this.SalesAnalyticsForm_Load);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesOverviewDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView salesOverviewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.Label totalSalesOverview;
    }
}