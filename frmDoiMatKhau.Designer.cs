
namespace QLCuaHangJuno
{
    partial class frmDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMkCu = new System.Windows.Forms.TextBox();
            this.txtMkMoi = new System.Windows.Forms.TextBox();
            this.txtReMkMoi = new System.Windows.Forms.TextBox();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(199, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu hiện tại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(219, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(167, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtMkCu
            // 
            this.txtMkCu.Location = new System.Drawing.Point(330, 145);
            this.txtMkCu.Name = "txtMkCu";
            this.txtMkCu.PasswordChar = '*';
            this.txtMkCu.Size = new System.Drawing.Size(183, 23);
            this.txtMkCu.TabIndex = 1;
            // 
            // txtMkMoi
            // 
            this.txtMkMoi.Location = new System.Drawing.Point(330, 186);
            this.txtMkMoi.Name = "txtMkMoi";
            this.txtMkMoi.PasswordChar = '*';
            this.txtMkMoi.Size = new System.Drawing.Size(183, 23);
            this.txtMkMoi.TabIndex = 3;
            // 
            // txtReMkMoi
            // 
            this.txtReMkMoi.Location = new System.Drawing.Point(330, 228);
            this.txtReMkMoi.Name = "txtReMkMoi";
            this.txtReMkMoi.PasswordChar = '*';
            this.txtReMkMoi.Size = new System.Drawing.Size(183, 23);
            this.txtReMkMoi.TabIndex = 5;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCapNhat.Location = new System.Drawing.Point(256, 313);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 28);
            this.btCapNhat.TabIndex = 6;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHuy.Location = new System.Drawing.Point(382, 313);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 28);
            this.btHuy.TabIndex = 7;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.txtReMkMoi);
            this.Controls.Add(this.txtMkMoi);
            this.Controls.Add(this.txtMkCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMkCu;
        private System.Windows.Forms.TextBox txtMkMoi;
        private System.Windows.Forms.TextBox txtReMkMoi;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btHuy;
    }
}