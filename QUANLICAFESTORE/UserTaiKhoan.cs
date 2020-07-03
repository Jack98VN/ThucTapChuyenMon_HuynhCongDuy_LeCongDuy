using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace QUANLICAFESTORE
{
    
    public partial class UserTaiKhoan : UserControl

    {
        string conString = @"Data Source=LAPTOP-PCEQUR9I\SQLEXPRESS;Initial Catalog=CAFE1;Integrated Security=True";
       
        public UserTaiKhoan()
        {
            InitializeComponent();
        }
        
        private void UserTaiKhoan_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLCafe"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            Hienthi();

        }
        public DataTable ketNoi(string query)
        {
            DataTable data = new DataTable();
            SqlConnection sql = new SqlConnection(conString);
            sql.Open();
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            sql.Close();
            return data;

        }
        public void loadDl()
        {

            string query = "select *from ChitietTaikhoan ";
            DataTable data = ketNoi(query);
            dtgvTaikhoan.DataSource = data;

        }
        public void Hienthi()
        {
            string sqlSELECT = "select *from ChitietTaiKhoan ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgvTaikhoan.DataSource = dt;
        }
        //CellClick
        private void dtgvTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                txtID.Text = dtgvTaikhoan.Rows[row].Cells["IDTK"].Value.ToString();
                txtTK.Text = dtgvTaikhoan.Rows[row].Cells["UserName"].Value.ToString();
                txtPwd.Text = dtgvTaikhoan.Rows[row].Cells["PassWord"].Value.ToString();
                txtTenhienthi.Text = dtgvTaikhoan.Rows[row].Cells["DisplayName"].Value.ToString();
                cbVitri.Text = dtgvTaikhoan.Rows[row].Cells["Vitri"].Value.ToString();
            }
        }

       
        SqlConnection conn;
        //Them 
        private void btThem_Click(object sender, EventArgs e)
        {

            if (txtTK.Text == "" || txtPwd.Text == "" || txtTenhienthi.Text == "" || cbVitri.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                string sqlINSERT = "INSERT INTO ChitietTaiKhoan values(@UserName,@PassWord,@DisplayName,@Vitri)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("UserName", txtTK.Text);
                cmd.Parameters.AddWithValue("PassWord", txtPwd.Text);
                cmd.Parameters.AddWithValue("DisplayName", txtTenhienthi.Text);
                cmd.Parameters.AddWithValue("Vitri", cbVitri.GetItemText(this.cbVitri.SelectedItem));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công!");
                Hienthi();
            }
        }


        //Sua
        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Nhập ID cần sửa vào ô bên dưới :", "Thông báo");
            }
            else
            {
                string sqlEdit = "UPDATE ChitietTaiKhoan SET UserName='" + txtTK.Text + "',PassWord='" + txtPwd.Text + "',DisplayName='" + txtTenhienthi.Text + "'," +
                "Vitri='" + cbVitri.Text + "' WHERE IDTK='" + txtID.Text + "'";

                DataTable data = ketNoi(sqlEdit);
                loadDl();
                MessageBox.Show("Đã sửa thông tin thành công !", "Thông báo");
            }
        }

        //Xoa 
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Chọn dòng cần xóa :", "Thông báo");
            }
            else
            {
                string sqlDelete = "Delete ChitietTaiKhoan  WHERE IDTK='" + txtID.Text + "'";
                DataTable data = ketNoi(sqlDelete);
                loadDl();
                MessageBox.Show("Đã Xóa Thành Công !", "Thông Báo:");
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTK.Text = "";
            txtTenhienthi.Text = "";
            txtPwd.Text = "";
            cbVitri.Text = "";
        }
    }
}
