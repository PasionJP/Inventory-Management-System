
namespace Login_Form
{
    partial class dateSelectForm
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
            this.todayBtn = new System.Windows.Forms.Button();
            this.yesterdayBtn = new System.Windows.Forms.Button();
            this.last7DaysBtn = new System.Windows.Forms.Button();
            this.last30DaysBtn = new System.Windows.Forms.Button();
            this.thisMonthBtn = new System.Windows.Forms.Button();
            this.lastMonthBtn = new System.Windows.Forms.Button();
            this.customBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.customBtn);
            this.panel1.Controls.Add(this.lastMonthBtn);
            this.panel1.Controls.Add(this.thisMonthBtn);
            this.panel1.Controls.Add(this.last30DaysBtn);
            this.panel1.Controls.Add(this.last7DaysBtn);
            this.panel1.Controls.Add(this.yesterdayBtn);
            this.panel1.Controls.Add(this.todayBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 350);
            this.panel1.TabIndex = 0;
            // 
            // todayBtn
            // 
            this.todayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.todayBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.todayBtn.FlatAppearance.BorderSize = 0;
            this.todayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todayBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.todayBtn.Location = new System.Drawing.Point(0, 0);
            this.todayBtn.MinimumSize = new System.Drawing.Size(324, 50);
            this.todayBtn.Name = "todayBtn";
            this.todayBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.todayBtn.Size = new System.Drawing.Size(324, 50);
            this.todayBtn.TabIndex = 0;
            this.todayBtn.Text = "Today";
            this.todayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.todayBtn.UseVisualStyleBackColor = false;
            this.todayBtn.Click += new System.EventHandler(this.todayBtn_Click);
            // 
            // yesterdayBtn
            // 
            this.yesterdayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.yesterdayBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.yesterdayBtn.FlatAppearance.BorderSize = 0;
            this.yesterdayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesterdayBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesterdayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.yesterdayBtn.Location = new System.Drawing.Point(0, 50);
            this.yesterdayBtn.MinimumSize = new System.Drawing.Size(324, 50);
            this.yesterdayBtn.Name = "yesterdayBtn";
            this.yesterdayBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.yesterdayBtn.Size = new System.Drawing.Size(324, 50);
            this.yesterdayBtn.TabIndex = 1;
            this.yesterdayBtn.Text = "Yesterday";
            this.yesterdayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yesterdayBtn.UseVisualStyleBackColor = false;
            this.yesterdayBtn.Click += new System.EventHandler(this.yesterdayBtn_Click);
            // 
            // last7DaysBtn
            // 
            this.last7DaysBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.last7DaysBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.last7DaysBtn.FlatAppearance.BorderSize = 0;
            this.last7DaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last7DaysBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last7DaysBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.last7DaysBtn.Location = new System.Drawing.Point(0, 100);
            this.last7DaysBtn.MinimumSize = new System.Drawing.Size(324, 50);
            this.last7DaysBtn.Name = "last7DaysBtn";
            this.last7DaysBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.last7DaysBtn.Size = new System.Drawing.Size(324, 50);
            this.last7DaysBtn.TabIndex = 2;
            this.last7DaysBtn.Text = "Last 7 Days";
            this.last7DaysBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.last7DaysBtn.UseVisualStyleBackColor = false;
            this.last7DaysBtn.Click += new System.EventHandler(this.last7DaysBtn_Click);
            // 
            // last30DaysBtn
            // 
            this.last30DaysBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.last30DaysBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.last30DaysBtn.FlatAppearance.BorderSize = 0;
            this.last30DaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last30DaysBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last30DaysBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.last30DaysBtn.Location = new System.Drawing.Point(0, 150);
            this.last30DaysBtn.MinimumSize = new System.Drawing.Size(324, 50);
            this.last30DaysBtn.Name = "last30DaysBtn";
            this.last30DaysBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.last30DaysBtn.Size = new System.Drawing.Size(324, 50);
            this.last30DaysBtn.TabIndex = 3;
            this.last30DaysBtn.Text = "Last 30 Days";
            this.last30DaysBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.last30DaysBtn.UseVisualStyleBackColor = false;
            this.last30DaysBtn.Click += new System.EventHandler(this.last30DaysBtn_Click);
            // 
            // thisMonthBtn
            // 
            this.thisMonthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.thisMonthBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.thisMonthBtn.FlatAppearance.BorderSize = 0;
            this.thisMonthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thisMonthBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisMonthBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.thisMonthBtn.Location = new System.Drawing.Point(0, 200);
            this.thisMonthBtn.MinimumSize = new System.Drawing.Size(324, 50);
            this.thisMonthBtn.Name = "thisMonthBtn";
            this.thisMonthBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.thisMonthBtn.Size = new System.Drawing.Size(324, 50);
            this.thisMonthBtn.TabIndex = 4;
            this.thisMonthBtn.Text = "This Month";
            this.thisMonthBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thisMonthBtn.UseVisualStyleBackColor = false;
            this.thisMonthBtn.Click += new System.EventHandler(this.thisMonthBtn_Click);
            // 
            // lastMonthBtn
            // 
            this.lastMonthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lastMonthBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastMonthBtn.FlatAppearance.BorderSize = 0;
            this.lastMonthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastMonthBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastMonthBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lastMonthBtn.Location = new System.Drawing.Point(0, 250);
            this.lastMonthBtn.MinimumSize = new System.Drawing.Size(324, 50);
            this.lastMonthBtn.Name = "lastMonthBtn";
            this.lastMonthBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lastMonthBtn.Size = new System.Drawing.Size(324, 50);
            this.lastMonthBtn.TabIndex = 5;
            this.lastMonthBtn.Text = "Last Month";
            this.lastMonthBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastMonthBtn.UseVisualStyleBackColor = false;
            this.lastMonthBtn.Click += new System.EventHandler(this.lastMonthBtn_Click);
            // 
            // customBtn
            // 
            this.customBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.customBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customBtn.FlatAppearance.BorderSize = 0;
            this.customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.customBtn.Location = new System.Drawing.Point(0, 300);
            this.customBtn.MinimumSize = new System.Drawing.Size(324, 50);
            this.customBtn.Name = "customBtn";
            this.customBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.customBtn.Size = new System.Drawing.Size(324, 50);
            this.customBtn.TabIndex = 7;
            this.customBtn.Text = "Custom";
            this.customBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customBtn.UseVisualStyleBackColor = false;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 50);
            this.panel2.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.98765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.01234F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 10);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 50);
            this.panel3.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.98765F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.01234F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(70, 10);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(251, 30);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 450);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 50);
            this.panel4.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.submitBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(324, 50);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cancelBtn.Location = new System.Drawing.Point(165, 5);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 5, 5, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(154, 40);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(222)))));
            this.submitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.submitBtn.Location = new System.Drawing.Point(5, 5);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(154, 40);
            this.submitBtn.TabIndex = 19;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // dateSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(324, 500);
            this.MinimumSize = new System.Drawing.Size(324, 350);
            this.Name = "dateSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "dateSelectForm";
            this.Deactivate += new System.EventHandler(this.dateSelectForm_Deactivate);
            this.Load += new System.EventHandler(this.dateSelectForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button todayBtn;
        private System.Windows.Forms.Button customBtn;
        private System.Windows.Forms.Button lastMonthBtn;
        private System.Windows.Forms.Button thisMonthBtn;
        private System.Windows.Forms.Button last30DaysBtn;
        private System.Windows.Forms.Button last7DaysBtn;
        private System.Windows.Forms.Button yesterdayBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}