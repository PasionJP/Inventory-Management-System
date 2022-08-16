namespace Login_Form
{
    partial class POS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TransactNo = new System.Windows.Forms.Label();
            this.TransactNumLabel = new System.Windows.Forms.Label();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.cashierName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Discountlbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.subTotalLbl = new System.Windows.Forms.Label();
            this.VatLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtotalLblValue = new System.Windows.Forms.Label();
            this.discountLblValue = new System.Windows.Forms.Label();
            this.vatLblValue = new System.Windows.Forms.Label();
            this.vatableLblValue = new System.Windows.Forms.Label();
            this.totalLblValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.VoidButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewTransactButton = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.AdvSearchButton = new System.Windows.Forms.Button();
            this.DiscountButton = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.removeQty = new System.Windows.Forms.DataGridViewImageColumn();
            this.addQty = new System.Windows.Forms.DataGridViewImageColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 111);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.TransactNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TransactNumLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BarcodeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cashierName, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1012, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // TransactNo
            // 
            this.TransactNo.AutoSize = true;
            this.TransactNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.TransactNo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.TransactNo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TransactNo.Location = new System.Drawing.Point(187, 5);
            this.TransactNo.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.TransactNo.Name = "TransactNo";
            this.TransactNo.Size = new System.Drawing.Size(142, 39);
            this.TransactNo.TabIndex = 15;
            this.TransactNo.Text = "000000000000";
            this.TransactNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactNo.Click += new System.EventHandler(this.TransactNo_Click);
            // 
            // TransactNumLabel
            // 
            this.TransactNumLabel.AutoSize = true;
            this.TransactNumLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TransactNumLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TransactNumLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TransactNumLabel.Location = new System.Drawing.Point(20, 5);
            this.TransactNumLabel.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.TransactNumLabel.Name = "TransactNumLabel";
            this.TransactNumLabel.Size = new System.Drawing.Size(126, 39);
            this.TransactNumLabel.TabIndex = 14;
            this.TransactNumLabel.Text = "Transaction No.";
            this.TransactNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarcodeLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BarcodeLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BarcodeLabel.Location = new System.Drawing.Point(20, 54);
            this.BarcodeLabel.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(94, 52);
            this.BarcodeLabel.TabIndex = 13;
            this.BarcodeLabel.Text = "Barcode";
            this.BarcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.searchBox.Location = new System.Drawing.Point(172, 64);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5, 5, 150, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(514, 32);
            this.searchBox.TabIndex = 12;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // cashierName
            // 
            this.cashierName.AutoSize = true;
            this.cashierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashierName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cashierName.Location = new System.Drawing.Point(839, 0);
            this.cashierName.Name = "cashierName";
            this.cashierName.Size = new System.Drawing.Size(170, 49);
            this.cashierName.TabIndex = 16;
            this.cashierName.Text = "cashier";
            this.cashierName.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 111);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 405);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCount,
            this.cartID,
            this.pcode,
            this.ProductName,
            this.PriceCol,
            this.Quantity,
            this.disc,
            this.totl,
            this.removeQty,
            this.addQty,
            this.Remove});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(656, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // itemCount
            // 
            this.itemCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemCount.HeaderText = "#";
            this.itemCount.MinimumWidth = 8;
            this.itemCount.Name = "itemCount";
            this.itemCount.ReadOnly = true;
            this.itemCount.Width = 58;
            // 
            // cartID
            // 
            this.cartID.DataPropertyName = "id";
            this.cartID.HeaderText = "";
            this.cartID.MinimumWidth = 8;
            this.cartID.Name = "cartID";
            this.cartID.ReadOnly = true;
            this.cartID.Visible = false;
            this.cartID.Width = 150;
            // 
            // pcode
            // 
            this.pcode.HeaderText = "pcode";
            this.pcode.MinimumWidth = 8;
            this.pcode.Name = "pcode";
            this.pcode.ReadOnly = true;
            this.pcode.Visible = false;
            this.pcode.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Item";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // PriceCol
            // 
            this.PriceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PriceCol.HeaderText = "Price";
            this.PriceCol.MinimumWidth = 8;
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            this.PriceCol.Width = 91;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle9;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 127;
            // 
            // disc
            // 
            this.disc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.disc.DefaultCellStyle = dataGridViewCellStyle10;
            this.disc.HeaderText = "Discount";
            this.disc.MinimumWidth = 8;
            this.disc.Name = "disc";
            this.disc.ReadOnly = true;
            this.disc.Width = 127;
            // 
            // totl
            // 
            this.totl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totl.DefaultCellStyle = dataGridViewCellStyle11;
            this.totl.HeaderText = "Total";
            this.totl.MinimumWidth = 8;
            this.totl.Name = "totl";
            this.totl.ReadOnly = true;
            this.totl.Width = 91;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(665, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(344, 399);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.Discountlbl, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.TotalLbl, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.subTotalLbl, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.VatLbl, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.subtotalLblValue, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.discountLblValue, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.vatLblValue, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.vatableLblValue, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.totalLblValue, 1, 4);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.MaximumSize = new System.Drawing.Size(1200, 300);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(338, 153);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // Discountlbl
            // 
            this.Discountlbl.AutoSize = true;
            this.Discountlbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Discountlbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discountlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Discountlbl.Location = new System.Drawing.Point(15, 33);
            this.Discountlbl.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.Discountlbl.Name = "Discountlbl";
            this.Discountlbl.Size = new System.Drawing.Size(109, 18);
            this.Discountlbl.TabIndex = 15;
            this.Discountlbl.Text = "DISCOUNT";
            this.Discountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TotalLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TotalLbl.Location = new System.Drawing.Point(15, 117);
            this.TotalLbl.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(108, 31);
            this.TotalLbl.TabIndex = 14;
            this.TotalLbl.Text = "TOTAL";
            this.TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subTotalLbl
            // 
            this.subTotalLbl.AutoSize = true;
            this.subTotalLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.subTotalLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.subTotalLbl.Location = new System.Drawing.Point(15, 5);
            this.subTotalLbl.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.subTotalLbl.Name = "subTotalLbl";
            this.subTotalLbl.Size = new System.Drawing.Size(107, 18);
            this.subTotalLbl.TabIndex = 17;
            this.subTotalLbl.Text = "SUB TOTAL";
            this.subTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VatLbl
            // 
            this.VatLbl.AutoSize = true;
            this.VatLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.VatLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VatLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.VatLbl.Location = new System.Drawing.Point(15, 61);
            this.VatLbl.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.VatLbl.Name = "VatLbl";
            this.VatLbl.Size = new System.Drawing.Size(48, 18);
            this.VatLbl.TabIndex = 16;
            this.VatLbl.Text = "VAT";
            this.VatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "VATABLE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtotalLblValue
            // 
            this.subtotalLblValue.AutoSize = true;
            this.subtotalLblValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.subtotalLblValue.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.subtotalLblValue.Location = new System.Drawing.Point(285, 5);
            this.subtotalLblValue.Margin = new System.Windows.Forms.Padding(5);
            this.subtotalLblValue.Name = "subtotalLblValue";
            this.subtotalLblValue.Size = new System.Drawing.Size(48, 18);
            this.subtotalLblValue.TabIndex = 19;
            this.subtotalLblValue.Text = "0.00";
            this.subtotalLblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discountLblValue
            // 
            this.discountLblValue.AutoSize = true;
            this.discountLblValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.discountLblValue.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.discountLblValue.Location = new System.Drawing.Point(285, 33);
            this.discountLblValue.Margin = new System.Windows.Forms.Padding(5);
            this.discountLblValue.Name = "discountLblValue";
            this.discountLblValue.Size = new System.Drawing.Size(48, 18);
            this.discountLblValue.TabIndex = 20;
            this.discountLblValue.Text = "0.00";
            this.discountLblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vatLblValue
            // 
            this.vatLblValue.AutoSize = true;
            this.vatLblValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.vatLblValue.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatLblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.vatLblValue.Location = new System.Drawing.Point(285, 61);
            this.vatLblValue.Margin = new System.Windows.Forms.Padding(5);
            this.vatLblValue.Name = "vatLblValue";
            this.vatLblValue.Size = new System.Drawing.Size(48, 18);
            this.vatLblValue.TabIndex = 21;
            this.vatLblValue.Text = "0.00";
            this.vatLblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vatableLblValue
            // 
            this.vatableLblValue.AutoSize = true;
            this.vatableLblValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.vatableLblValue.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.vatableLblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.vatableLblValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.vatableLblValue.Location = new System.Drawing.Point(285, 89);
            this.vatableLblValue.Margin = new System.Windows.Forms.Padding(5);
            this.vatableLblValue.Name = "vatableLblValue";
            this.vatableLblValue.Size = new System.Drawing.Size(48, 18);
            this.vatableLblValue.TabIndex = 18;
            this.vatableLblValue.Text = "0.00";
            this.vatableLblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLblValue
            // 
            this.totalLblValue.AutoSize = true;
            this.totalLblValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalLblValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.totalLblValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.totalLblValue.Location = new System.Drawing.Point(275, 117);
            this.totalLblValue.Margin = new System.Windows.Forms.Padding(5);
            this.totalLblValue.Name = "totalLblValue";
            this.totalLblValue.Size = new System.Drawing.Size(58, 31);
            this.totalLblValue.TabIndex = 25;
            this.totalLblValue.Text = "0.00";
            this.totalLblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.VoidButton, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.CancelButton, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.NewTransactButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PaymentButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.AdvSearchButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.DiscountButton, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 162);
            this.tableLayoutPanel4.MaximumSize = new System.Drawing.Size(0, 500);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66944F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(338, 234);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // VoidButton
            // 
            this.VoidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VoidButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(110)))), ((int)(((byte)(174)))));
            this.VoidButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoidButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.VoidButton.Location = new System.Drawing.Point(3, 155);
            this.VoidButton.Name = "VoidButton";
            this.VoidButton.Size = new System.Drawing.Size(332, 32);
            this.VoidButton.TabIndex = 12;
            this.VoidButton.Text = "Void";
            this.VoidButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CancelButton.Location = new System.Drawing.Point(5, 193);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(328, 38);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // NewTransactButton
            // 
            this.NewTransactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTransactButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(198)))), ((int)(((byte)(99)))));
            this.NewTransactButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTransactButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.NewTransactButton.Location = new System.Drawing.Point(5, 3);
            this.NewTransactButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NewTransactButton.Name = "NewTransactButton";
            this.NewTransactButton.Size = new System.Drawing.Size(328, 32);
            this.NewTransactButton.TabIndex = 3;
            this.NewTransactButton.Text = "New Transaction";
            this.NewTransactButton.UseVisualStyleBackColor = false;
            this.NewTransactButton.Click += new System.EventHandler(this.NewTransactButton_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(189)))), ((int)(((byte)(168)))));
            this.PaymentButton.Enabled = false;
            this.PaymentButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PaymentButton.Location = new System.Drawing.Point(5, 41);
            this.PaymentButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(328, 32);
            this.PaymentButton.TabIndex = 4;
            this.PaymentButton.Text = "Payment";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // AdvSearchButton
            // 
            this.AdvSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            this.AdvSearchButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvSearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.AdvSearchButton.Location = new System.Drawing.Point(5, 79);
            this.AdvSearchButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AdvSearchButton.Name = "AdvSearchButton";
            this.AdvSearchButton.Size = new System.Drawing.Size(328, 32);
            this.AdvSearchButton.TabIndex = 5;
            this.AdvSearchButton.Text = "Search Product";
            this.AdvSearchButton.UseVisualStyleBackColor = false;
            this.AdvSearchButton.Click += new System.EventHandler(this.AdvSearchButton_Click);
            // 
            // DiscountButton
            // 
            this.DiscountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(119)))), ((int)(((byte)(223)))));
            this.DiscountButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.DiscountButton.Location = new System.Drawing.Point(5, 117);
            this.DiscountButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DiscountButton.Name = "DiscountButton";
            this.DiscountButton.Size = new System.Drawing.Size(328, 32);
            this.DiscountButton.TabIndex = 6;
            this.DiscountButton.Text = "Discount";
            this.DiscountButton.UseVisualStyleBackColor = false;
            this.DiscountButton.Click += new System.EventHandler(this.DiscountButton_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 8;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Login_Form.Properties.Resources.arrow_right;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 8;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 8;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.Width = 8;
            // 
            // removeQty
            // 
            this.removeQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.removeQty.HeaderText = "";
            this.removeQty.Image = global::Login_Form.Properties.Resources.arrow_left;
            this.removeQty.MinimumWidth = 8;
            this.removeQty.Name = "removeQty";
            this.removeQty.ReadOnly = true;
            this.removeQty.Width = 8;
            // 
            // addQty
            // 
            this.addQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addQty.HeaderText = "";
            this.addQty.Image = global::Login_Form.Properties.Resources.arrow_right;
            this.addQty.MinimumWidth = 8;
            this.addQty.Name = "addQty";
            this.addQty.ReadOnly = true;
            this.addQty.Width = 8;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Remove.HeaderText = "";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Remove.MinimumWidth = 8;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Remove.Width = 8;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1012, 516);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button NewTransactButton;
        private System.Windows.Forms.Button PaymentButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AdvSearchButton;
        private System.Windows.Forms.Button DiscountButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label Discountlbl;
        private System.Windows.Forms.Label VatLbl;
        private System.Windows.Forms.Label subTotalLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TransactNumLabel;
        private System.Windows.Forms.Label BarcodeLabel;
        public System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.Label TransactNo;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label subtotalLblValue;
        public System.Windows.Forms.Label discountLblValue;
        public System.Windows.Forms.Label vatLblValue;
        public System.Windows.Forms.Label vatableLblValue;
        public System.Windows.Forms.Label totalLblValue;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn totl;
        private System.Windows.Forms.DataGridViewImageColumn removeQty;
        private System.Windows.Forms.DataGridViewImageColumn addQty;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.Button VoidButton;
        public System.Windows.Forms.Label cashierName;
    }
}