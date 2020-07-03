namespace QUANLICAFESTORE
{
    partial class FormGiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoDien));
            this.panelTrai = new System.Windows.Forms.Panel();
            this.btnTinhnang = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lbNhom = new System.Windows.Forms.Label();
            this.btnThongtinHethong = new Guna.UI.WinForms.GunaButton();
            this.btnTongquat = new Guna.UI.WinForms.GunaButton();
            this.panelTinhNang = new System.Windows.Forms.Panel();
            this.btnBanhang = new Guna.UI.WinForms.GunaButton();
            this.btnTaikhoan = new Guna.UI.WinForms.GunaButton();
            this.btnHoadon = new Guna.UI.WinForms.GunaButton();
            this.btnPaint = new Guna.UI.WinForms.GunaButton();
            this.btnDangXuat = new Guna.UI.WinForms.GunaButton();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.lbWelcome = new Guna.UI.WinForms.GunaLabel();
            this.userBanHang2 = new QUANLICAFESTORE.UserBanHang();
            this.userBanHang1 = new QUANLICAFESTORE.UserBanHang();
            this.userTaiKhoan1 = new QUANLICAFESTORE.UserTaiKhoan();
            this.panelTrai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panelTinhNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrai
            // 
            this.panelTrai.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelTrai.Controls.Add(this.btnTinhnang);
            this.panelTrai.Controls.Add(this.gunaPictureBox1);
            this.panelTrai.Controls.Add(this.lbNhom);
            this.panelTrai.Controls.Add(this.btnThongtinHethong);
            this.panelTrai.Controls.Add(this.btnTongquat);
            this.panelTrai.Controls.Add(this.panelTinhNang);
            this.panelTrai.Controls.Add(this.btnDangXuat);
            this.panelTrai.Location = new System.Drawing.Point(3, -1);
            this.panelTrai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTrai.Name = "panelTrai";
            this.panelTrai.Size = new System.Drawing.Size(267, 588);
            this.panelTrai.TabIndex = 0;
            // 
            // btnTinhnang
            // 
            this.btnTinhnang.AnimationHoverSpeed = 0.07F;
            this.btnTinhnang.AnimationSpeed = 0.03F;
            this.btnTinhnang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTinhnang.BorderColor = System.Drawing.Color.Black;
            this.btnTinhnang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTinhnang.FocusedColor = System.Drawing.Color.Empty;
            this.btnTinhnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTinhnang.ForeColor = System.Drawing.Color.Black;
            this.btnTinhnang.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhnang.Image")));
            this.btnTinhnang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTinhnang.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTinhnang.Location = new System.Drawing.Point(11, 229);
            this.btnTinhnang.Name = "btnTinhnang";
            this.btnTinhnang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTinhnang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTinhnang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTinhnang.OnHoverImage = null;
            this.btnTinhnang.OnPressedColor = System.Drawing.Color.Black;
            this.btnTinhnang.Size = new System.Drawing.Size(200, 42);
            this.btnTinhnang.TabIndex = 16;
            this.btnTinhnang.Text = "Tính Năng";
            this.btnTinhnang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTinhnang.Click += new System.EventHandler(this.btnTinhnang_Click_1);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(11, 28);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(55, 40);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 18;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lbNhom
            // 
            this.lbNhom.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhom.ForeColor = System.Drawing.Color.Red;
            this.lbNhom.Location = new System.Drawing.Point(72, 41);
            this.lbNhom.Name = "lbNhom";
            this.lbNhom.Size = new System.Drawing.Size(133, 27);
            this.lbNhom.TabIndex = 17;
            this.lbNhom.Text = "Nhóm Đôi";
            // 
            // btnThongtinHethong
            // 
            this.btnThongtinHethong.AnimationHoverSpeed = 0.07F;
            this.btnThongtinHethong.AnimationSpeed = 0.03F;
            this.btnThongtinHethong.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongtinHethong.BorderColor = System.Drawing.Color.Black;
            this.btnThongtinHethong.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThongtinHethong.FocusedColor = System.Drawing.Color.Empty;
            this.btnThongtinHethong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongtinHethong.ForeColor = System.Drawing.Color.Black;
            this.btnThongtinHethong.Image = ((System.Drawing.Image)(resources.GetObject("btnThongtinHethong.Image")));
            this.btnThongtinHethong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThongtinHethong.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThongtinHethong.Location = new System.Drawing.Point(51, 145);
            this.btnThongtinHethong.Name = "btnThongtinHethong";
            this.btnThongtinHethong.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThongtinHethong.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThongtinHethong.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThongtinHethong.OnHoverImage = null;
            this.btnThongtinHethong.OnPressedColor = System.Drawing.Color.Black;
            this.btnThongtinHethong.Size = new System.Drawing.Size(160, 42);
            this.btnThongtinHethong.TabIndex = 15;
            this.btnThongtinHethong.Text = "Thông tin";
            this.btnThongtinHethong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThongtinHethong.Click += new System.EventHandler(this.btnThongtinHethong_Click);
            // 
            // btnTongquat
            // 
            this.btnTongquat.AnimationHoverSpeed = 0.07F;
            this.btnTongquat.AnimationSpeed = 0.03F;
            this.btnTongquat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTongquat.BorderColor = System.Drawing.Color.Black;
            this.btnTongquat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTongquat.FocusedColor = System.Drawing.Color.Empty;
            this.btnTongquat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTongquat.ForeColor = System.Drawing.Color.Black;
            this.btnTongquat.Image = ((System.Drawing.Image)(resources.GetObject("btnTongquat.Image")));
            this.btnTongquat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTongquat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTongquat.Location = new System.Drawing.Point(11, 97);
            this.btnTongquat.Name = "btnTongquat";
            this.btnTongquat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTongquat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTongquat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTongquat.OnHoverImage = null;
            this.btnTongquat.OnPressedColor = System.Drawing.Color.Black;
            this.btnTongquat.Size = new System.Drawing.Size(200, 42);
            this.btnTongquat.TabIndex = 14;
            this.btnTongquat.Text = "Tổng Quát";
            this.btnTongquat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTinhNang
            // 
            this.panelTinhNang.Controls.Add(this.btnBanhang);
            this.panelTinhNang.Controls.Add(this.btnTaikhoan);
            this.panelTinhNang.Controls.Add(this.btnHoadon);
            this.panelTinhNang.Controls.Add(this.btnPaint);
            this.panelTinhNang.Location = new System.Drawing.Point(3, 278);
            this.panelTinhNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTinhNang.Name = "panelTinhNang";
            this.panelTinhNang.Size = new System.Drawing.Size(264, 217);
            this.panelTinhNang.TabIndex = 13;
            // 
            // btnBanhang
            // 
            this.btnBanhang.AnimationHoverSpeed = 0.07F;
            this.btnBanhang.AnimationSpeed = 0.03F;
            this.btnBanhang.BaseColor = System.Drawing.Color.Blue;
            this.btnBanhang.BorderColor = System.Drawing.Color.Black;
            this.btnBanhang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBanhang.FocusedColor = System.Drawing.Color.Empty;
            this.btnBanhang.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnBanhang.ForeColor = System.Drawing.Color.Black;
            this.btnBanhang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanhang.Image")));
            this.btnBanhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBanhang.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBanhang.Location = new System.Drawing.Point(48, 51);
            this.btnBanhang.Name = "btnBanhang";
            this.btnBanhang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBanhang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBanhang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBanhang.OnHoverImage = null;
            this.btnBanhang.OnPressedColor = System.Drawing.Color.Black;
            this.btnBanhang.Size = new System.Drawing.Size(160, 42);
            this.btnBanhang.TabIndex = 10;
            this.btnBanhang.Text = "Bán Hàng";
            this.btnBanhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBanhang.Click += new System.EventHandler(this.btnBanhang_Click);
            // 
            // btnTaikhoan
            // 
            this.btnTaikhoan.AnimationHoverSpeed = 0.07F;
            this.btnTaikhoan.AnimationSpeed = 0.03F;
            this.btnTaikhoan.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnTaikhoan.BorderColor = System.Drawing.Color.Black;
            this.btnTaikhoan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTaikhoan.FocusedColor = System.Drawing.Color.Empty;
            this.btnTaikhoan.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnTaikhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaikhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaikhoan.Image")));
            this.btnTaikhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTaikhoan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTaikhoan.Location = new System.Drawing.Point(48, 3);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTaikhoan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTaikhoan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTaikhoan.OnHoverImage = null;
            this.btnTaikhoan.OnPressedColor = System.Drawing.Color.Black;
            this.btnTaikhoan.Size = new System.Drawing.Size(160, 42);
            this.btnTaikhoan.TabIndex = 9;
            this.btnTaikhoan.Text = "Tài Khoản";
            this.btnTaikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTaikhoan.Click += new System.EventHandler(this.btnTaikhoan_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.AnimationHoverSpeed = 0.07F;
            this.btnHoadon.AnimationSpeed = 0.03F;
            this.btnHoadon.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnHoadon.BorderColor = System.Drawing.Color.Black;
            this.btnHoadon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHoadon.FocusedColor = System.Drawing.Color.Empty;
            this.btnHoadon.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnHoadon.ForeColor = System.Drawing.Color.Black;
            this.btnHoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoadon.Image")));
            this.btnHoadon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHoadon.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHoadon.Location = new System.Drawing.Point(48, 99);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnHoadon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHoadon.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHoadon.OnHoverImage = null;
            this.btnHoadon.OnPressedColor = System.Drawing.Color.Black;
            this.btnHoadon.Size = new System.Drawing.Size(160, 42);
            this.btnHoadon.TabIndex = 11;
            this.btnHoadon.Text = "Hóa Đơn";
            this.btnHoadon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.AnimationHoverSpeed = 0.07F;
            this.btnPaint.AnimationSpeed = 0.03F;
            this.btnPaint.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnPaint.BorderColor = System.Drawing.Color.Black;
            this.btnPaint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPaint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPaint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaint.ForeColor = System.Drawing.Color.Black;
            this.btnPaint.Image = ((System.Drawing.Image)(resources.GetObject("btnPaint.Image")));
            this.btnPaint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPaint.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPaint.Location = new System.Drawing.Point(47, 146);
            this.btnPaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPaint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPaint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPaint.OnHoverImage = null;
            this.btnPaint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPaint.Size = new System.Drawing.Size(160, 42);
            this.btnPaint.TabIndex = 8;
            this.btnPaint.Text = "Phần mềm Vẽ";
            this.btnPaint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AnimationHoverSpeed = 0.07F;
            this.btnDangXuat.AnimationSpeed = 0.03F;
            this.btnDangXuat.BaseColor = System.Drawing.Color.Red;
            this.btnDangXuat.BorderColor = System.Drawing.Color.Black;
            this.btnDangXuat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDangXuat.FocusedColor = System.Drawing.Color.Empty;
            this.btnDangXuat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDangXuat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDangXuat.Location = new System.Drawing.Point(11, 500);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDangXuat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDangXuat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDangXuat.OnHoverImage = null;
            this.btnDangXuat.OnPressedColor = System.Drawing.Color.Black;
            this.btnDangXuat.Size = new System.Drawing.Size(200, 42);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BaseColor = System.Drawing.Color.Red;
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThoat.Location = new System.Drawing.Point(1399, 40);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(125, 42);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(616, 58);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(438, 55);
            this.lbWelcome.TabIndex = 9;
            this.lbWelcome.Text = "Welcome To Relax Coffee ";
            // 
            // userBanHang2
            // 
            this.userBanHang2.Location = new System.Drawing.Point(312, 96);
            this.userBanHang2.Name = "userBanHang2";
            this.userBanHang2.Size = new System.Drawing.Size(1231, 600);
            this.userBanHang2.TabIndex = 14;
            this.userBanHang2.Load += new System.EventHandler(this.userBanHang2_Load);
            // 
            // userBanHang1
            // 
            this.userBanHang1.Location = new System.Drawing.Point(622, 313);
            this.userBanHang1.Name = "userBanHang1";
            this.userBanHang1.Size = new System.Drawing.Size(138, 15);
            this.userBanHang1.TabIndex = 13;
            // 
            // userTaiKhoan1
            // 
            this.userTaiKhoan1.BackColor = System.Drawing.Color.Bisque;
            this.userTaiKhoan1.Location = new System.Drawing.Point(0, 0);
            this.userTaiKhoan1.Name = "userTaiKhoan1";
            this.userTaiKhoan1.Size = new System.Drawing.Size(905, 501);
            this.userTaiKhoan1.TabIndex = 0;
            // 
            // FormGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.userBanHang2);
            this.Controls.Add(this.userBanHang1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.panelTrai);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGiaoDien";
            this.Text = "Giao Diện";
            this.Load += new System.EventHandler(this.FormGiaoDien_Load);
            this.panelTrai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panelTinhNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTrai;
        private Guna.UI.WinForms.GunaButton btnPaint;
        private Guna.UI.WinForms.GunaButton btnDangXuat;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private System.Windows.Forms.Panel panelTinhNang;
        private Guna.UI.WinForms.GunaButton btnTinhnang;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label lbNhom;
        private Guna.UI.WinForms.GunaButton btnThongtinHethong;
        private Guna.UI.WinForms.GunaButton btnTongquat;
        private Guna.UI.WinForms.GunaButton btnBanhang;
        private Guna.UI.WinForms.GunaButton btnTaikhoan;
        private Guna.UI.WinForms.GunaButton btnHoadon;
        private Guna.UI.WinForms.GunaLabel lbWelcome;
        private UserTaiKhoan userTaiKhoan1;
        private UserBanHang userBanHang1;
        private UserBanHang userBanHang2;
    }
}