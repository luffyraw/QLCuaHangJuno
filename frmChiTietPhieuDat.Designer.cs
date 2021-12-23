
namespace QLCuaHangJuno
{
    partial class frmChiTietPhieuDat
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaPhieuD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvSanPhamDat = new System.Windows.Forms.DataGridView();
            this.MaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoiHanGiaoHang = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDat)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(73, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mã phiếu:";
            // 
            // txtMaPhieuD
            // 
            this.txtMaPhieuD.Location = new System.Drawing.Point(166, 71);
            this.txtMaPhieuD.Name = "txtMaPhieuD";
            this.txtMaPhieuD.Size = new System.Drawing.Size(94, 27);
            this.txtMaPhieuD.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(323, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ngày lập:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(73, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Thời hạn giao hàng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(23, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 23);
            this.label14.TabIndex = 23;
            this.label14.Text = "Danh sách sản phẩm:";
            // 
            // dgvSanPhamDat
            // 
            this.dgvSanPhamDat.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPhamDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPhamDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSp,
            this.TenSp,
            this.Mau,
            this.KichCo,
            this.SoLuongDat});
            this.dgvSanPhamDat.Location = new System.Drawing.Point(23, 194);
            this.dgvSanPhamDat.Name = "dgvSanPhamDat";
            this.dgvSanPhamDat.RowHeadersVisible = false;
            this.dgvSanPhamDat.RowHeadersWidth = 51;
            this.dgvSanPhamDat.RowTemplate.Height = 29;
            this.dgvSanPhamDat.Size = new System.Drawing.Size(733, 115);
            this.dgvSanPhamDat.TabIndex = 25;
            // 
            // MaSp
            // 
            this.MaSp.DataPropertyName = "MaSp";
            this.MaSp.HeaderText = "Mã sản phẩm";
            this.MaSp.MinimumWidth = 6;
            this.MaSp.Name = "MaSp";
            this.MaSp.Width = 149;
            // 
            // TenSp
            // 
            this.TenSp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenSp.DataPropertyName = "TenSp";
            this.TenSp.HeaderText = "Tên sản phẩm";
            this.TenSp.MinimumWidth = 6;
            this.TenSp.Name = "TenSp";
            this.TenSp.Width = 135;
            // 
            // Mau
            // 
            this.Mau.DataPropertyName = "Mau";
            this.Mau.HeaderText = "Màu sắc";
            this.Mau.MinimumWidth = 6;
            this.Mau.Name = "Mau";
            this.Mau.Width = 149;
            // 
            // KichCo
            // 
            this.KichCo.DataPropertyName = "KichCo";
            this.KichCo.HeaderText = "Kích cỡ";
            this.KichCo.MinimumWidth = 6;
            this.KichCo.Name = "KichCo";
            this.KichCo.Width = 148;
            // 
            // SoLuongDat
            // 
            this.SoLuongDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongDat.DataPropertyName = "SoLuongDat";
            this.SoLuongDat.HeaderText = "Số lượng đặt";
            this.SoLuongDat.MinimumWidth = 6;
            this.SoLuongDat.Name = "SoLuongDat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "CHI TIẾT PHIẾU ĐẶT HÀNG";
            // 
            // txtThoiHanGiaoHang
            // 
            this.txtThoiHanGiaoHang.Location = new System.Drawing.Point(219, 109);
            this.txtThoiHanGiaoHang.Name = "txtThoiHanGiaoHang";
            this.txtThoiHanGiaoHang.Size = new System.Drawing.Size(183, 27);
            this.txtThoiHanGiaoHang.TabIndex = 31;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(401, 71);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(213, 27);
            this.txtNgayLap.TabIndex = 32;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(322, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 29);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmChiTietPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.txtThoiHanGiaoHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvSanPhamDat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMaPhieuD);
            this.Controls.Add(this.label12);
            this.Name = "frmChiTietPhieuDat";
            this.Text = "frmChiTietPhieuDat";
            this.Load += new System.EventHandler(this.frmChiTietPhieuDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaPhieuD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvSanPhamDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThoiHanGiaoHang;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDat;
        private System.Windows.Forms.Button btnClose;
    }
}