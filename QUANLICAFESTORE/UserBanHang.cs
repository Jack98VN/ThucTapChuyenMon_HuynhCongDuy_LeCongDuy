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
using Guna.UI.WinForms;

namespace QUANLICAFESTORE
{
    public partial class UserBanHang : UserControl
    {


        string conString = @"Data Source=LAPTOP-PCEQUR9I\SQLEXPRESS;Initial Catalog=CAFE1;Integrated Security=True";
        public UserBanHang()
        {
            InitializeComponent();
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
        SqlConnection conn;
        public void loadDl()
        {

            string query = "select  *from ChitietHoaDon_new ";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;

        }

        private void UserBanHang_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=LAPTOP-PCEQUR9I\SQLEXPRESS;Initial Catalog=CAFE1;Integrated Security=True";
            conn = new SqlConnection(conString);
            conn.Open();
            loadDl();
        }

        private void dtgvBanhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                txtStt.Text = dtgvBanhang.CurrentRow.Cells["stt"].Value.ToString();
                txtIDhd.Text = dtgvBanhang.CurrentRow.Cells["idhoadon"].Value.ToString();
                cbsoban.Text = dtgvBanhang.CurrentRow.Cells["soban"].Value.ToString();
                cbNuocuong.Text = dtgvBanhang.CurrentRow.Cells["thongtinnuocuong"].Value.ToString();
                txtGhichu.Text = dtgvBanhang.CurrentRow.Cells["ghichu"].Value.ToString();
                lbl_ThanhTien.Text = dtgvBanhang.CurrentRow.Cells["thanhtien"].Value.ToString();
            }
        }


        public void Hienthi()
        {
            string sqlSELECT = "select *from ChitietHoaDon_new ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgvBanhang.DataSource = dt;
        }
        //Them
        private void btThem_Click(object sender, EventArgs e)
        {
            /*string query = "INSERT INTO ChitietHoaDon_new values ('"+txtIDhd.Text+"','"+cbsoban.Text+"',"+
                "N'"+cbNuocuong.Text +"','"+ numericsoluong.Value+"','"+lbl_ThanhTien.Text+"',N'"+ txtGhichu.Text+"')";
            DataTable data = ketNoi(query);
            loadDl();*/

            string sqlINSERT = "INSERT INTO ChitietHoaDon_new values(@idhoadon,@soban,@thongtinnuocuong,@soluong,@ghichu)";
            SqlCommand cmd = new SqlCommand(sqlINSERT,conn);

            cmd.Parameters.AddWithValue("idhoadon", txtIDhd.Text);
            cmd.Parameters.AddWithValue("soban", cbsoban.GetItemText(this.cbsoban.SelectedItem));
            cmd.Parameters.AddWithValue("thongtinnuocuong", txtIDhd.Text);
            cmd.Parameters.AddWithValue("soluong", txtSoluong.Text);
            cmd.Parameters.AddWithValue("ghichu", txtGhichu.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công!");
            Hienthi();
        }

        private void numericsoluong_ValueChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string query = "select dongia from NUOCUONG where tennuocuong =N'" + cbNuocuong.Text + "'";
            dataTable = ketNoi(query);
            string gia_chuoi = dataTable.Rows[0][0].ToString();
            gia_chuoi = gia_chuoi.Replace(",", "");
            int gia = int.Parse(gia_chuoi);
            lbl_ThanhTien.Text = (gia * numericsoluong.Value / 10000) + " VNĐ";
        }

        private void btBan1_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan1.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDl();
        }

        private void lb_Tongtien_Click(object sender, EventArgs e)
        {
            /*string query = "select sum(thanhtien) from ChitietHoaDon_new where soban ='1'";
            DataTable data = ketNoi(query);
            string price1 = data.Rows[0][0].ToString();
            lb_Tongtien.Text = price1;*/
        }

        private void btBan11_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan11.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btBan10_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan10.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btBan9_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan9.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btBan8_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan8.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btBan7_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan7.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btBan6_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan6.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btBan5_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan5.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btBan4_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan4.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btBan3_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan3.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;

        }

        private void btBan2_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan2.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btBan12_Click(object sender, EventArgs e)
        {
            string query = "select  *from ChitietHoaDon_new where soban like '%" + btBan12.Text + "%'";
            DataTable data = ketNoi(query);
            dtgvBanhang.DataSource = data;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            string query = "delete ChitietHoaDon_new where stt= '"+txtStt.Text+"'  ";
            DataTable data = ketNoi(query);
            loadDl();
            
        }

        private void lb_Tongtien_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void lb_Tongtien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTongtien_Click(object sender, EventArgs e)
        {
            

            /*string query = "select sum(thanhtien) from ChitietHoaDon_new where soban ='1'";
            DataTable data = ketNoi(query);
            string price1 = data.Rows[0][0].ToString();
            lb_Tongtien.Text = price1 +"VNĐ";*/

            DataTable dataTable = new DataTable();
            string query = "select sum(thanhtien) from ChitietHoaDon_new where soban ='1'";
            DataTable data = ketNoi(query);
            string price1 = data.Rows[0][0].ToString();
            price1 = price1.Replace(",", "");
            int gia = int.Parse(price1);
            lb_Tongtien.Text = (gia ) / 10000 + "VNĐ";

            
        }

        private void btChitiet_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon(lb_Tongtien.Text,txtIDhd.Text);
            //this.Hide();
           
            hd.Show();
        }

        private void gunaPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
