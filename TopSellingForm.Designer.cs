
namespace Login_Form
{
    partial class TopSellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.AdvSearchButton = new System.Windows.Forms.Button();
            this.filterLbl = new System.Windows.Forms.Label();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sortSelect = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.soldItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldItemsDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.datePicker2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AdvSearchButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.filterLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.datePicker1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sortSelect, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(759, 54);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // datePicker2
            // 
            this.datePicker2.CustomFormat = "MM/dd/yyyy";
            this.datePicker2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Location = new System.Drawing.Point(279, 3);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(159, 30);
            this.datePicker2.TabIndex = 18;
            this.datePicker2.Value = new System.DateTime(2022, 8, 12, 21, 26, 51, 0);
            // 
            // AdvSearchButton
            // 
            this.AdvSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            this.AdvSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvSearchButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvSearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.AdvSearchButton.Location = new System.Drawing.Point(609, 3);
            this.AdvSearchButton.MaximumSize = new System.Drawing.Size(145, 34);
            this.AdvSearchButton.Name = "AdvSearchButton";
            this.AdvSearchButton.Size = new System.Drawing.Size(144, 34);
            this.AdvSearchButton.TabIndex = 17;
            this.AdvSearchButton.Text = "Load Data";
            this.AdvSearchButton.UseVisualStyleBackColor = false;
            this.AdvSearchButton.Click += new System.EventHandler(this.AdvSearchButton_Click);
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
            this.filterLbl.Size = new System.Drawing.Size(82, 48);
            this.filterLbl.TabIndex = 14;
            this.filterLbl.Text = "Filter By";
            this.filterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "MM/dd/yyyy";
            this.datePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(114, 3);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(159, 30);
            this.datePicker1.TabIndex = 15;
            this.datePicker1.Value = new System.DateTime(2022, 8, 12, 21, 26, 51, 0);
            // 
            // sortSelect
            // 
            this.sortSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortSelect.FormattingEnabled = true;
            this.sortSelect.Items.AddRange(new object[] {
            "Sort by Quantity",
            "Sort by Sales Total"});
            this.sortSelect.Location = new System.Drawing.Point(444, 3);
            this.sortSelect.Name = "sortSelect";
            this.sortSelect.Size = new System.Drawing.Size(150, 28);
            this.sortSelect.TabIndex = 19;
            this.sortSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sortSelect_KeyPress);
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
            this.tableLayoutPanel9.Size = new System.Drawing.Size(759, 54);
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
            this.label1.Size = new System.Drawing.Size(753, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Top Selling Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // soldItemsDataGridView
            // 
            this.soldItemsDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            this.soldItemsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.soldItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.soldItemsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.soldItemsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.soldItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.soldItemsDataGridView.ColumnHeadersHeight = 30;
            this.soldItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.soldItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pcode,
            this.productName,
            this.qty,
            this.Total});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.soldItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.soldItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soldItemsDataGridView.EnableHeadersVisualStyles = false;
            this.soldItemsDataGridView.Location = new System.Drawing.Point(3, 123);
            this.soldItemsDataGridView.Name = "soldItemsDataGridView";
            this.soldItemsDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.soldItemsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.soldItemsDataGridView.RowHeadersVisible = false;
            this.soldItemsDataGridView.RowHeadersWidth = 62;
            this.soldItemsDataGridView.RowTemplate.Height = 28;
            this.soldItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.soldItemsDataGridView.Size = new System.Drawing.Size(759, 297);
            this.soldItemsDataGridView.TabIndex = 5;
            this.soldItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "i";
            this.id.HeaderText = "";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 27;
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
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.DataPropertyName = "qty";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.qty.HeaderText = "Quantity";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 127;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total Sales";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 147;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.soldItemsDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 423);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TopSellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(765, 423);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(765, 423);
            this.Name = "TopSellingForm";
            this.Text = "SoldItemsForm";
            this.Load += new System.EventHandler(this.SoldItemsForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldItemsDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Button AdvSearchButton;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.ComboBox sortSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView soldItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}