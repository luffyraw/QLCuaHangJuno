
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuDat));
            this.label11 = new System.Windows.Forms.Label();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.panelPrint = new System.Windows.Forms.Panel();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblThoiHanGiaoHang = new System.Windows.Forms.Label();
            this.lblMaPhieuD = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDat)).BeginInit();
            this.panelPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(77, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mã phiếu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(327, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ngày lập:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(77, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Thời hạn giao hàng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(27, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 23);
            this.label14.TabIndex = 23;
            this.label14.Text = "Danh sách sản phẩm:";
            // 
            // dgvSanPhamDat
            // 
            this.dgvSanPhamDat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSanPhamDat.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvSanPhamDat.Location = new System.Drawing.Point(27, 211);
            this.dgvSanPhamDat.Name = "dgvSanPhamDat";
            this.dgvSanPhamDat.RowHeadersVisible = false;
            this.dgvSanPhamDat.RowHeadersWidth = 51;
            this.dgvSanPhamDat.RowTemplate.Height = 29;
            this.dgvSanPhamDat.Size = new System.Drawing.Size(733, 239);
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
            this.label1.Location = new System.Drawing.Point(213, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "CHI TIẾT PHIẾU ĐẶT HÀNG";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(414, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 29);
            this.btnClose.TabIndex = 33;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelPrint
            // 
            this.panelPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPrint.Controls.Add(this.lblNgayLap);
            this.panelPrint.Controls.Add(this.lblThoiHanGiaoHang);
            this.panelPrint.Controls.Add(this.lblMaPhieuD);
            this.panelPrint.Controls.Add(this.dgvSanPhamDat);
            this.panelPrint.Controls.Add(this.label12);
            this.panelPrint.Controls.Add(this.label14);
            this.panelPrint.Controls.Add(this.label1);
            this.panelPrint.Controls.Add(this.label11);
            this.panelPrint.Controls.Add(this.label13);
            this.panelPrint.Location = new System.Drawing.Point(12, 2);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(789, 453);
            this.panelPrint.TabIndex = 34;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgayLap.Location = new System.Drawing.Point(405, 93);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(159, 20);
            this.lblNgayLap.TabIndex = 35;
            this.lblNgayLap.Text = "23-12-2021 19:48:20";
            // 
            // lblThoiHanGiaoHang
            // 
            this.lblThoiHanGiaoHang.AutoSize = true;
            this.lblThoiHanGiaoHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThoiHanGiaoHang.Location = new System.Drawing.Point(230, 129);
            this.lblThoiHanGiaoHang.Name = "lblThoiHanGiaoHang";
            this.lblThoiHanGiaoHang.Size = new System.Drawing.Size(93, 20);
            this.lblThoiHanGiaoHang.TabIndex = 34;
            this.lblThoiHanGiaoHang.Text = "23-12-2021";
            // 
            // lblMaPhieuD
            // 
            this.lblMaPhieuD.AutoSize = true;
            this.lblMaPhieuD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaPhieuD.Location = new System.Drawing.Point(170, 93);
            this.lblMaPhieuD.Name = "lblMaPhieuD";
            this.lblMaPhieuD.Size = new System.Drawing.Size(56, 20);
            this.lblMaPhieuD.TabIndex = 33;
            this.lblMaPhieuD.Text = "PD001";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.Location = new System.Drawing.Point(321, 461);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 29);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmChiTietPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(810, 502);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelPrint);
            this.Controls.Add(this.btnClose);
            this.Name = "frmChiTietPhieuDat";
            this.Text = "frmChiTietPhieuDat";
            this.Load += new System.EventHandler(this.frmChiTietPhieuDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDat)).EndInit();
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvSanPhamDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblThoiHanGiaoHang;
        private System.Windows.Forms.Label lblMaPhieuD;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}