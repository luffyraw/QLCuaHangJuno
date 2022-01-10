
namespace QLCuaHangJuno
{
    partial class ThongKeNhanVien
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel9 = new System.Windows.Forms.Panel();
            this.lb_Nv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel9.Controls.Add(this.lb_Nv);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.cb_thang);
            this.panel9.Controls.Add(this.cb_year);
            this.panel9.Controls.Add(this.listView1);
            this.panel9.Controls.Add(this.btn_tim);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(31, 44);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1277, 677);
            this.panel9.TabIndex = 1;
            // 
            // lb_Nv
            // 
            this.lb_Nv.AutoSize = true;
            this.lb_Nv.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_Nv.Location = new System.Drawing.Point(32, 327);
            this.lb_Nv.Name = "lb_Nv";
            this.lb_Nv.Size = new System.Drawing.Size(186, 38);
            this.lb_Nv.TabIndex = 7;
            this.lb_Nv.Text = "Số nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1009, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Báo cáo hoạt động nhân viên tháng 1 năm 2022";
            // 
            // cb_thang
            // 
            this.cb_thang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_thang.Location = new System.Drawing.Point(167, 144);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(201, 39);
            this.cb_thang.TabIndex = 6;
            this.cb_thang.Text = "2022";
            // 
            // cb_year
            // 
            this.cb_year.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cb_year.Location = new System.Drawing.Point(167, 206);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(201, 39);
            this.cb_year.TabIndex = 6;
            this.cb_year.Text = "2022";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader13,
            this.columnHeader14});
            this.listView1.Enabled = false;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(423, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(810, 535);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Số hóa đơn";
            this.columnHeader13.Width = 200;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Số sản phẩm";
            this.columnHeader14.Width = 200;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tim.Location = new System.Drawing.Point(267, 264);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(101, 40);
            this.btn_tim.TabIndex = 2;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tháng";
            // 
            // ThongKeNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 753);
            this.Controls.Add(this.panel9);
            this.Name = "ThongKeNhanVien";
            this.Text = "ThongKeNhanVien";
            this.Load += new System.EventHandler(this.ThongKeNhanVien_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lb_Nv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}