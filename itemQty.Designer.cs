namespace Login_Form
{
    partial class itemQty
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
            this.itmQtyTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itmQtyTB
            // 
            this.itmQtyTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itmQtyTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itmQtyTB.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmQtyTB.Location = new System.Drawing.Point(0, 0);
            this.itmQtyTB.Name = "itmQtyTB";
            this.itmQtyTB.Size = new System.Drawing.Size(354, 66);
            this.itmQtyTB.TabIndex = 0;
            this.itmQtyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itmQtyTB.TextChanged += new System.EventHandler(this.itmQtyTB_TextChanged);
            this.itmQtyTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itmQtyTB_KeyPress);
            // 
            // itemQty
            // 
            this.ClientSize = new System.Drawing.Size(354, 65);
            this.Controls.Add(this.itmQtyTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "itemQty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemQtyTB;
        private System.Windows.Forms.TextBox itmQtyTB;
    }
}