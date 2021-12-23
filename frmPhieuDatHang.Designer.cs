
namespace QLCuaHangJuno
{
    partial class frmPhieuDatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhieuDat = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiHanGiaoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSearchMaPh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChiTietPh = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuDat
            // 
            this.dgvPhieuDat.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.NgayDat,
            this.ThoiHanGiaoHang});
            this.dgvPhieuDat.Location = new System.Drawing.Point(29, 143);
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.RowHeadersWidth = 51;
            this.dgvPhieuDat.RowTemplate.Height = 29;
            this.dgvPhieuDat.Size = new System.Drawing.Size(516, 235);
            this.dgvPhieuDat.TabIndex = 0;
            this.dgvPhieuDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDat_CellClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieuDat";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaPhieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaPhieu.HeaderText = "Mã phiếu đặt";
            this.MaPhieu.MinimumWidth = 6;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 130;
            // 
            // NgayDat
            // 
            this.NgayDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayDat.DataPropertyName = "NgayDat";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NgayDat.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.Width = 94;
            // 
            // ThoiHanGiaoHang
            // 
            this.ThoiHanGiaoHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiHanGiaoHang.DataPropertyName = "ThoiHanGiaoHang";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThoiHanGiaoHang.DefaultCellStyle = dataGridViewCellStyle4;
            this.ThoiHanGiaoHang.HeaderText = "Thời hạn giao hàng";
            this.ThoiHanGiaoHang.MinimumWidth = 6;
            this.ThoiHanGiaoHang.Name = "ThoiHanGiaoHang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(164, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHIẾU ĐẶT HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtSearchMaPh);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(36, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 63);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo mã";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTim.Location = new System.Drawing.Point(150, 24);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(51, 29);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSearchMaPh
            // 
            this.txtSearchMaPh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchMaPh.Location = new System.Drawing.Point(6, 26);
            this.txtSearchMaPh.Name = "txtSearchMaPh";
            this.txtSearchMaPh.Size = new System.Drawing.Size(138, 27);
            this.txtSearchMaPh.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(112, 400);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChiTietPh
            // 
            this.btnChiTietPh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiTietPh.Location = new System.Drawing.Point(246, 400);
            this.btnChiTietPh.Name = "btnChiTietPh";
            this.btnChiTietPh.Size = new System.Drawing.Size(94, 29);
            this.btnChiTietPh.TabIndex = 13;
            this.btnChiTietPh.Text = "Chi Tiết";
            this.btnChiTietPh.UseVisualStyleBackColor = true;
            this.btnChiTietPh.Click += new System.EventHandler(this.btnChiTietPh_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReload.Location = new System.Drawing.Point(368, 400);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(94, 29);
            this.btnReload.TabIndex = 14;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmPhieuDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 462);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnChiTietPh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhieuDat);
            this.Name = "frmPhieuDatHang";
            this.Text = "frmPhieuDatHang";
            this.Load += new System.EventHandler(this.frmPhieuDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSearchMaPh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChiTietPh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiHanGiaoHang;
        private System.Windows.Forms.Button btnReload;
    }
}