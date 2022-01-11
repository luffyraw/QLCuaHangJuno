
namespace QLCuaHangJuno
{
    partial class frmXemPhieuBaoHanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.dgvBaoHanh = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labe11 = new System.Windows.Forms.Label();
            this.btXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu bảo hành: ";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(190, 173);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(143, 23);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // dgvBaoHanh
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoHanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoHanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.NgayLap,
            this.MaNV,
            this.MaHD,
            this.NgayTra});
            this.dgvBaoHanh.Location = new System.Drawing.Point(12, 224);
            this.dgvBaoHanh.Name = "dgvBaoHanh";
            this.dgvBaoHanh.RowTemplate.Height = 25;
            this.dgvBaoHanh.Size = new System.Drawing.Size(583, 117);
            this.dgvBaoHanh.TabIndex = 2;
            this.dgvBaoHanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoHanh_CellContentClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 90;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLapPhieu";
            this.NgayLap.HeaderText = "Ngày lập phiếu";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 120;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNv";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 110;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHd";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbNgayTra);
            this.panel1.Controls.Add(this.lbMaHD);
            this.panel1.Controls.Add(this.lbMaNV);
            this.panel1.Controls.Add(this.lbNgayLap);
            this.panel1.Controls.Add(this.lbMaPhieu);
            this.panel1.Controls.Add(this.dgvSanPham);
            this.panel1.Controls.Add(this.labe11);
            this.panel1.Location = new System.Drawing.Point(619, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 442);
            this.panel1.TabIndex = 3;
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNgayTra.Location = new System.Drawing.Point(395, 144);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(57, 15);
            this.lbNgayTra.TabIndex = 5;
            this.lbNgayTra.Text = "Ngày trả:";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaHD.Location = new System.Drawing.Point(124, 188);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(76, 15);
            this.lbMaHD.TabIndex = 5;
            this.lbMaHD.Text = "Mã hóa đơn:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaNV.Location = new System.Drawing.Point(395, 104);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(84, 15);
            this.lbMaNV.TabIndex = 5;
            this.lbMaNV.Text = "Mã nhân viên:";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNgayLap.Location = new System.Drawing.Point(124, 144);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(91, 15);
            this.lbNgayLap.TabIndex = 5;
            this.lbNgayLap.Text = "Ngày lập phiếu:";
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.AutoSize = true;
            this.lbMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaPhieu.Location = new System.Drawing.Point(124, 104);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(61, 15);
            this.lbMaPhieu.TabIndex = 5;
            this.lbMaPhieu.Text = "Mã phiếu:";
            // 
            // dgvSanPham
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSanPham.Location = new System.Drawing.Point(43, 250);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowTemplate.Height = 25;
            this.dgvSanPham.Size = new System.Drawing.Size(603, 150);
            this.dgvSanPham.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSpCt";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Loi";
            this.Column3.HeaderText = "Lỗi";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ChiTietLoi";
            this.Column4.HeaderText = "Chi tiết lỗi";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // labe11
            // 
            this.labe11.AutoSize = true;
            this.labe11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labe11.Location = new System.Drawing.Point(229, 41);
            this.labe11.Name = "labe11";
            this.labe11.Size = new System.Drawing.Size(215, 37);
            this.labe11.TabIndex = 3;
            this.labe11.Text = "Phiếu bảo hành";
            // 
            // btXem
            // 
            this.btXem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXem.Location = new System.Drawing.Point(339, 167);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(75, 32);
            this.btXem.TabIndex = 2;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách phiếu bảo hành";
            // 
            // frmXemPhieuBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBaoHanh);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.label1);
            this.Name = "frmXemPhieuBaoHanh";
            this.Text = "frmXemPhieuBaoHanh";
            this.Load += new System.EventHandler(this.frmXemPhieuBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.DataGridView dgvBaoHanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbMaPhieu;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label labe11;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.Label label2;
    }
}