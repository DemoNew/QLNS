using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThuctapNhom
{
    public partial class FormThongTinPhongBan : Form
    {
        public String mapb;
        public FormThongTinPhongBan()
        {
            InitializeComponent();
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(globalParameter.str);
                conn.Open();
                String a = @"select * from phongban where ID = '" + mapb + "'";

                SqlCommand cm = new SqlCommand(a, conn);
                SqlDataReader r = cm.ExecuteReader();
                if (r.Read())
                {
                    txtsoluongnv.Text = r["soluongNV"].ToString();                 
                    txtEmail.Text = r["email"].ToString();
                    txtdienthoai.Text = r["dienthoai"].ToString();
                    lbltenphongban.Text = r["ten"].ToString();
                }
                connect();
                initGrid(dvgphongban);
                getdata();
                disconect();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi!");
                
                FormPhongBan pb = new FormPhongBan();
                pb.Show();
                this.Close();

            }
        }
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblPHONGBAN");
        private SqlDataAdapter da = new SqlDataAdapter();
        public void connect()
        {
            String conStr = globalParameter.str;
            try
            {

                conn = new SqlConnection(conStr);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi");
            }
        }
        public void disconect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public void getdata()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_HIENTHI_NHANVIEN";
            command.Parameters.Add(new SqlParameter("@mapb", mapb));
            da.SelectCommand = command;
            da.Fill(dt);
            dvgphongban.DataSource = dt;
        }
        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "hoten";
            cl.HeaderText = "Họ tên";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "ngaysinh";
            cl.HeaderText = "Ngày sinh";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "gioitinh";
            cl.HeaderText = "Giới tính";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "dienthoai";
            cl.HeaderText = "Điện thoại";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "email";
            cl.HeaderText = "Email";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "chucvu";
            cl.HeaderText = "Chức vụ";
            dgv.Columns.Add(cl);
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain m = new FormMain();
            m.Show();
        }
    }
}
