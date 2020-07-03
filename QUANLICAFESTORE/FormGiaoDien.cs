using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLICAFESTORE
{
    public partial class FormGiaoDien : Form
    {
        //private int price;
        public FormGiaoDien()
        {
            InitializeComponent();
            customizeDesign();
        }
        
        private void customizeDesign()
        {

            panelTinhNang.Visible = false;

        }
        public class YourCustomException : Exception
        {
            public YourCustomException() : base() { } //constructor

            public override string StackTrace
            {
                get { return "Message instead stacktrace"; }
            }
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelTinhNang.Visible = true)
                panelTinhNang.Visible = false;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn Đăng Xuất khỏi hệ thống không  ?", "Thông báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                FormDangNhap f1 = new FormDangNhap();
                this.Hide();
                f1.ShowDialog();
                this.Show();
            }
        }
            
        private void btnTinhnang_Click(object sender, EventArgs e)
        {
            showSubmenu(panelTinhNang);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn Thoát không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            
            DemoPaint paint = new DemoPaint();
            this.Hide();
            paint.ShowDialog();
            this.Show();
        }

        private void FormGiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhnang_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelTinhNang);
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            FormTaiKhoan formTaiKhoan = new FormTaiKhoan();
            //this.Hide();
            formTaiKhoan.ShowDialog();
            //this.Show();
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            userBanHang1.BringToFront();
        }

        private void userBanHang2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            FormHoaDon f2 = new FormHoaDon();
           
            f2.Show();
        }

        private void btnThongtinHethong_Click(object sender, EventArgs e)
        {
            FormThongTin f1 = new FormThongTin();
            //this.Hide();
            f1.ShowDialog();
        }
    }
}
