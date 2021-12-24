
namespace QLCuaHangJuno
{
    partial class frmChiTietSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChiTietSP = new System.Windows.Forms.DataGridView();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.txtKieuDang = new System.Windows.Forms.TextBox();
            this.txtChatLieu = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtLoaiSp = new System.Windows.Forms.TextBox();
            this.txtBaoHanh = new System.Windows.Forms.TextBox();
            this.txtTraHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietSP
            // 
            this.dgvChiTietSP.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mau,
            this.KichCo,
            this.SoLuongCon});
            this.dgvChiTietSP.Location = new System.Drawing.Point(369, 76);
            this.dgvChiTietSP.Name = "dgvChiTietSP";
            this.dgvChiTietSP.RowHeadersWidth = 51;
            this.dgvChiTietSP.RowTemplate.Height = 29;
            this.dgvChiTietSP.Size = new System.Drawing.Size(439, 210);
            this.dgvChiTietSP.TabIndex = 0;
            // 
            // Mau
            // 
            this.Mau.DataPropertyName = "Mau";
            this.Mau.HeaderText = "Màu";
            this.Mau.MinimumWidth = 6;
            this.Mau.Name = "Mau";
            this.Mau.Width = 125;
            // 
            // KichCo
            // 
            this.KichCo.DataPropertyName = "KichCo";
            this.KichCo.HeaderText = "Kích cỡ";
            this.KichCo.MinimumWidth = 6;
            this.KichCo.Name = "KichCo";
            this.KichCo.Width = 125;
            // 
            // SoLuongCon
            // 
            this.SoLuongCon.DataPropertyName = "SoLuongCon";
            this.SoLuongCon.HeaderText = "Số lượng còn";
            this.SoLuongCon.MinimumWidth = 6;
            this.SoLuongCon.Name = "SoLuongCon";
            this.SoLuongCon.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtMaSp
            // 
            this.txtMaSp.Enabled = false;
            this.txtMaSp.Location = new System.Drawing.Point(185, 76);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(150, 27);
            this.txtMaSp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kiểu dáng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chất liệu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Loại sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(36, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bảo hành:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(36, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Trả hàng:";
            // 
            // txtTenSp
            // 
            this.txtTenSp.Enabled = false;
            this.txtTenSp.Location = new System.Drawing.Point(185, 119);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(150, 27);
            this.txtTenSp.TabIndex = 10;
            // 
            // txtKieuDang
            // 
            this.txtKieuDang.Enabled = false;
            this.txtKieuDang.Location = new System.Drawing.Point(185, 161);
            this.txtKieuDang.Name = "txtKieuDang";
            this.txtKieuDang.Size = new System.Drawing.Size(150, 27);
            this.txtKieuDang.TabIndex = 11;
            // 
            // txtChatLieu
            // 
            this.txtChatLieu.Enabled = false;
            this.txtChatLieu.Location = new System.Drawing.Point(185, 201);
            this.txtChatLieu.Name = "txtChatLieu";
            this.txtChatLieu.Size = new System.Drawing.Size(150, 27);
            this.txtChatLieu.TabIndex = 12;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(185, 242);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(150, 27);
            this.txtDonGia.TabIndex = 13;
            // 
            // txtLoaiSp
            // 
            this.txtLoaiSp.Enabled = false;
            this.txtLoaiSp.Location = new System.Drawing.Point(185, 280);
            this.txtLoaiSp.Name = "txtLoaiSp";
            this.txtLoaiSp.Size = new System.Drawing.Size(150, 27);
            this.txtLoaiSp.TabIndex = 14;
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.Enabled = false;
            this.txtBaoHanh.Location = new System.Drawing.Point(185, 321);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(150, 27);
            this.txtBaoHanh.TabIndex = 15;
            // 
            // txtTraHang
            // 
            this.txtTraHang.Enabled = false;
            this.txtTraHang.Location = new System.Drawing.Point(185, 365);
            this.txtTraHang.Name = "txtTraHang";
            this.txtTraHang.Size = new System.Drawing.Size(150, 27);
            this.txtTraHang.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(271, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 37);
            this.label9.TabIndex = 17;
            this.label9.Text = "CHI TIẾT SẢN PHẨM";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(335, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 460);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTraHang);
            this.Controls.Add(this.txtBaoHanh);
            this.Controls.Add(this.txtLoaiSp);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtChatLieu);
            this.Controls.Add(this.txtKieuDang);
            this.Controls.Add(this.txtTenSp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChiTietSP);
            this.Name = "frmChiTietSanPham";
            this.Text = "frmChiTietSanPham";
            this.Load += new System.EventHandler(this.frmChiTietSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.TextBox txtKieuDang;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtLoaiSp;
        private System.Windows.Forms.TextBox txtBaoHanh;
        private System.Windows.Forms.TextBox txtTraHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCon;
        private System.Windows.Forms.Button btnClose;
    }
}