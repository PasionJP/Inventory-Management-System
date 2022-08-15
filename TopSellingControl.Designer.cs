
namespace Login_Form
{
    partial class TopSellingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.prodPriceLbl = new System.Windows.Forms.Label();
            this.prodNameLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.unitsSoldLbl = new System.Windows.Forms.Label();
            this.soldLbl = new System.Windows.Forms.Label();
            this.productPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productPhoto, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.prodPriceLbl, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.prodNameLbl, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(78, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 74);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // prodPriceLbl
            // 
            this.prodPriceLbl.AutoSize = true;
            this.prodPriceLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodPriceLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.prodPriceLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prodPriceLbl.Location = new System.Drawing.Point(3, 37);
            this.prodPriceLbl.Name = "prodPriceLbl";
            this.prodPriceLbl.Size = new System.Drawing.Size(138, 37);
            this.prodPriceLbl.TabIndex = 1;
            this.prodPriceLbl.Text = "₱0.00";
            // 
            // prodNameLbl
            // 
            this.prodNameLbl.AutoSize = true;
            this.prodNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodNameLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.prodNameLbl.Location = new System.Drawing.Point(3, 0);
            this.prodNameLbl.Name = "prodNameLbl";
            this.prodNameLbl.Size = new System.Drawing.Size(138, 37);
            this.prodNameLbl.TabIndex = 2;
            this.prodNameLbl.Text = "product";
            this.prodNameLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.prodNameLbl.Click += new System.EventHandler(this.prodNameLbl_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.unitsSoldLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.soldLbl, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(228, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(69, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // unitsSoldLbl
            // 
            this.unitsSoldLbl.AutoSize = true;
            this.unitsSoldLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsSoldLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsSoldLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.unitsSoldLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.unitsSoldLbl.Location = new System.Drawing.Point(3, 0);
            this.unitsSoldLbl.Name = "unitsSoldLbl";
            this.unitsSoldLbl.Size = new System.Drawing.Size(63, 37);
            this.unitsSoldLbl.TabIndex = 3;
            this.unitsSoldLbl.Text = "0";
            this.unitsSoldLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // soldLbl
            // 
            this.soldLbl.AutoSize = true;
            this.soldLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soldLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.soldLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.soldLbl.Location = new System.Drawing.Point(3, 37);
            this.soldLbl.Name = "soldLbl";
            this.soldLbl.Size = new System.Drawing.Size(63, 37);
            this.soldLbl.TabIndex = 0;
            this.soldLbl.Text = "Sold";
            this.soldLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // productPhoto
            // 
            this.productPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPhoto.Location = new System.Drawing.Point(3, 3);
            this.productPhoto.Name = "productPhoto";
            this.productPhoto.Size = new System.Drawing.Size(69, 74);
            this.productPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPhoto.TabIndex = 2;
            this.productPhoto.TabStop = false;
            // 
            // TopSellingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TopSellingControl";
            this.Size = new System.Drawing.Size(300, 80);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label prodPriceLbl;
        private System.Windows.Forms.Label prodNameLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label unitsSoldLbl;
        private System.Windows.Forms.Label soldLbl;
        public System.Windows.Forms.PictureBox productPhoto;
    }
}
