using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace QUANLICAFESTORE
{
    public partial class FormDangNhap : Form
    {
        string strConnection = @"";
        SqlConnection conn;
        SqlCommand command;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnection);
                conn.Open();
                string sql = "Select Count(*) from [CAFE1].[dbo].[Account] Where UserName =@account and PassWord=@pwd";
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@account", txtUsername.Text));
                command.Parameters.Add(new SqlParameter("@pwd", txtPassword.Text));

                int x = (int)command.ExecuteScalar();

                if (x == 1)
                {
                    // Login Success
                    MessageBox.Show("Đăng nhập Thành công!", "Thông Báo");
                    lbIncorrect.Text = "";
                    txtUsername.Focus();

                    //Open new Form
                    this.Hide();
                    FormGiaoDien f1 = new FormGiaoDien();
                    f1.Show();

                }
                else
                {
                    //Login failed
                    lbIncorrect.Text = "Thông tin bị Trống hoặc Không chính xác !";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkboxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
