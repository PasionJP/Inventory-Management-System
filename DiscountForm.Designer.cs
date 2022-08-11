
namespace Login_Form
{
    partial class DiscountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.discountAmount = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.discountTB = new System.Windows.Forms.TextBox();
            this.dcAmountTB = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.selectDiscount = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.tableLayoutPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(657, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Discount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.84479F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.15521F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.idLbl, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.price, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.discount, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.discountAmount, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.priceTB, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.discountTB, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dcAmountTB, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.Insert, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.selectDiscount, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(35, 80);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(35, 20, 35, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(639, 266);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apply discount to:";
            // 
            // idLbl
            // 
            this.idLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.idLbl.Location = new System.Drawing.Point(8, 220);
            this.idLbl.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(189, 38);
            this.idLbl.TabIndex = 9;
            this.idLbl.Visible = false;
            this.idLbl.Click += new System.EventHandler(this.idLbl_Click);
            // 
            // price
            // 
            this.price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.price.Location = new System.Drawing.Point(8, 61);
            this.price.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(189, 37);
            this.price.TabIndex = 6;
            this.price.Text = "Price";
            // 
            // discount
            // 
            this.discount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.discount.Location = new System.Drawing.Point(8, 114);
            this.discount.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(189, 37);
            this.discount.TabIndex = 7;
            this.discount.Text = "Discount (%)";
            // 
            // discountAmount
            // 
            this.discountAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountAmount.AutoSize = true;
            this.discountAmount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.discountAmount.Location = new System.Drawing.Point(8, 167);
            this.discountAmount.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.discountAmount.Name = "discountAmount";
            this.discountAmount.Size = new System.Drawing.Size(189, 37);
            this.discountAmount.TabIndex = 8;
            this.discountAmount.Text = "Discount Amount";
            // 
            // priceTB
            // 
            this.priceTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceTB.Enabled = false;
            this.priceTB.Location = new System.Drawing.Point(203, 56);
            this.priceTB.Margin = new System.Windows.Forms.Padding(6, 3, 15, 3);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(421, 26);
            this.priceTB.TabIndex = 1;
            // 
            // discountTB
            // 
            this.discountTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountTB.Location = new System.Drawing.Point(203, 109);
            this.discountTB.Margin = new System.Windows.Forms.Padding(6, 3, 15, 3);
            this.discountTB.Name = "discountTB";
            this.discountTB.Size = new System.Drawing.Size(421, 26);
            this.discountTB.TabIndex = 2;
            this.discountTB.TextChanged += new System.EventHandler(this.discountTB_TextChanged);
            // 
            // dcAmountTB
            // 
            this.dcAmountTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dcAmountTB.Enabled = false;
            this.dcAmountTB.Location = new System.Drawing.Point(203, 162);
            this.dcAmountTB.Margin = new System.Windows.Forms.Padding(6, 3, 15, 3);
            this.dcAmountTB.Name = "dcAmountTB";
            this.dcAmountTB.Size = new System.Drawing.Size(421, 26);
            this.dcAmountTB.TabIndex = 3;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(189)))), ((int)(((byte)(168)))));
            this.Insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Insert.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Insert.Location = new System.Drawing.Point(202, 217);
            this.Insert.Margin = new System.Windows.Forms.Padding(5, 5, 13, 5);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(424, 44);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Confirm";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click_1);
            // 
            // selectDiscount
            // 
            this.selectDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectDiscount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDiscount.FormattingEnabled = true;
            this.selectDiscount.Items.AddRange(new object[] {
            "Selected Item",
            "All Items"});
            this.selectDiscount.Location = new System.Drawing.Point(200, 3);
            this.selectDiscount.Name = "selectDiscount";
            this.selectDiscount.Size = new System.Drawing.Size(436, 31);
            this.selectDiscount.TabIndex = 11;
            this.selectDiscount.SelectedIndexChanged += new System.EventHandler(this.selectDiscount_SelectedIndexChanged);
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(709, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountForm";
            this.Load += new System.EventHandler(this.DiscountForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label discountAmount;
        private System.Windows.Forms.TextBox discountTB;
        private System.Windows.Forms.Button Insert;
        public System.Windows.Forms.Label idLbl;
        public System.Windows.Forms.TextBox priceTB;
        public System.Windows.Forms.TextBox dcAmountTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectDiscount;
    }
}