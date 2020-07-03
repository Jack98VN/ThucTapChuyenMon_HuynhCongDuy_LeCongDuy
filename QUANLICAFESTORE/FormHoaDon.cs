using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLICAFESTORE
{
    public partial class FormHoaDon : Form
    {
        private string price,ma;
        public FormHoaDon()
        {
           
            InitializeComponent();
        }
        public FormHoaDon(string m):this()
        {
            price = m;
            lbTongtien.Text = price;
            InitializeComponent();
        }
        public FormHoaDon(string m,string ma) : this()
        {
            price = m;
            ma = ma;
            lbTongtien.Text = price;
            txtidhoadon.Text = ma;
            InitializeComponent();
        }

        private void txtTienkhachdua_TextChanged(object sender, EventArgs e)
        {
           

            //if (txtTienkhachdua.Text !="")
            //{
            //   c=a-b ;

            //}
            
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Quay lại Màn hình chính ?", "Thông báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                FormGiaoDien f1 = new FormGiaoDien();
                this.Hide();
              

            }
        }

        private void gunaPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
