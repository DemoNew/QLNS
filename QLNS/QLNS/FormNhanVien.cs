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
    public partial class FormNhanVien : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblNHANVIEN");
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
            command.CommandText = "sp_TIMKIEM_NHANVIEN";
            command.Parameters.Add(new SqlParameter("@id", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@hoten", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@phong", txtTimKiem.Text));
            da.SelectCommand = command;
            da.Fill(dt);
            dvgnhanvien.DataSource = dt;
        }
        private void getdata2()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            DataTable dtChucVu = new DataTable();
            DataTable dtPhong = new DataTable();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from CHUCVU";
            da.SelectCommand = command;
            da.Fill(dtChucVu);
            cmbChucVu.DataSource = dtChucVu;
            cmbChucVu.DisplayMember = "ten";
            cmbChucVu.ValueMember = "ID";
            cmbChucVu.SelectedValue = "ID";

            command.CommandText = "select * from PHONGBAN";
            da.SelectCommand = command;
            da.Fill(dtPhong);
            cmbPhongBan.DataSource = dtPhong;
            cmbPhongBan.DisplayMember = "ten";
            cmbPhongBan.ValueMember = "ID";
            cmbPhongBan.SelectedValue = "ID";
        }
        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "id";
            cl.HeaderText = "M�";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "hoten";
            cl.HeaderText = "H? t�n";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "ngaysinh";
            cl.HeaderText = "Ng�y sinh";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "gioitinh";
            cl.HeaderText = "Gi?i t�nh";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "quequan";
            cl.HeaderText = "Qu� qu�n";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "diachi";
            cl.HeaderText = "??a ch?";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "socmnd";
            cl.HeaderText = "S? CMND";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "dienthoai";
            cl.HeaderText = "?i?n tho?i";
            dgv.Columns.Add(cl);
            
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "email";
            cl.HeaderText = "Email";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "chucvu";
            cl.HeaderText = "Ch?c v?";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "phongban";
            cl.HeaderText = "Ph�ng";
            dgv.Columns.Add(cl);
            
        }
        private bool isEmpty()
        {
            if (txthoten.Text.Trim() == "")
            {
                MessageBox.Show("B?n ch?a nh?p h? t�n");
                return true;
            }
            if (!rdbnam.Checked && !rdbnu.Checked)
            {
                MessageBox.Show("B?n ch?a ch?n gi?i t�nh");
                return true;
            }
            if (txtquequan.Text.Trim() == "")
            {
                MessageBox.Show("B?n ch?a nh?p qu� qu�n");
                return true;
            }
            if (txtdiachi.Text.Trim() == "")
            {
                MessageBox.Show("B?n ch?a nh?p ??a ch?");
                return true;
            }
            if (txtsoCMND.Text.Trim() == "")
            {
                MessageBox.Show("B?n ch?a nh?p s? CMND");
                return true;
            }
            if (txtdienthoai.Text.Trim() == "")
            {
                MessageBox.Show("B?n ch?a nh?p ?i?n tho?i");
                return true;
            }
            if (txtemail.Text.Trim() == "")
            {
                MessageBox.Show("B?n ch?a nh?p email");
                return true;
            }
            if (cmbPhongBan.Text.Trim() == "")
            {
                MessageBox.Show("B?n ch?a ch?n ph�ng ban");
                return true;
            }
            if (cmbChucVu.Text.Trim() == "")
            {
                MessageBox.Show("B?n ch?a ch?n ch?c v?");
                return true;
            }
            return false;
        }

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {

            if (FormLogin.quyen == false)
            {
                btnthemnv.Enabled = false;
                btnsuanv.Enabled = false;
                btnxoanv.Enabled = false;
            }
            else
            {
                btnthemnv.Enabled = true;
                btnsuanv.Enabled = true;
                btnxoanv.Enabled = true;
            }
            connect();
            initGrid(dvgnhanvien);
            getdata();
            getdata2();
            //binding();
            disconect();

        }

        //private void binding()
        //{
        //    txtID.DataBindings.Clear();
        //    txtID.DataBindings.Add("Text", dvgnhanvien.DataSource, "ID");
        //    txthoten.DataBindings.Clear();
        //    txthoten.DataBindings.Add("Text", dvgnhanvien.DataSource, "hoten");
        //    dtpngaysinh.DataBindings.Clear();
        //    dtpngaysinh.DataBindings.Add("Text", dvgnhanvien.DataSource, "ngaysinh");
        //    txtquequan.DataBindings.Clear();
        //    txtquequan.DataBindings.Add("Text", dvgnhanvien.DataSource, "quequan");
        //    txtdiachi.DataBindings.Clear();
        //    txtdiachi.DataBindings.Add("Text", dvgnhanvien.DataSource, "diachi");
        //    txtsoCMND.DataBindings.Clear();
        //    txtsoCMND.DataBindings.Add("Text", dvgnhanvien.DataSource, "soCMND");
        //    txtemail.DataBindings.Clear();
        //    txtemail.DataBindings.Add("Text", dvgnhanvien.DataSource, "email");
        //    txtdienthoai.DataBindings.Clear();
        //    txtdienthoai.DataBindings.Add("Text", dvgnhanvien.DataSource, "dienthoai");
        //}
        private void btnthem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
           this.Hide();
            FormMain m = new FormMain();
            m.Show();
        }

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("B?n ch?a ch?n b?n ghi n�o");
                return;
            }           
            try
            {
                connect();
                SqlCommand command = new SqlCommand("SP_DELETE_NHANVIEN", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", txtID.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("X�a th�nh c�ng !", "Th�ng b�o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
                getdata();
                disconect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("X�a d? li?u kh�ng th�nh c�ng", "Th�ng b�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dvgnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           txtdiachi.Enabled = false;
            txtdienthoai.Enabled = false;
            txtemail.Enabled = false;
            txthoten.Enabled = false;
            txtquequan.Enabled = false;
            txtsoCMND.Enabled = false;
            dtpngaysinh.Enabled = false;
            cmbChucVu.Enabled = false;
            cmbPhongBan.Enabled = false;
            btnthemnv.Enabled = true;
            btnsuanv.Enabled = true;
            btnxoanv.Enabled = true;
            btCapNhat.Enabled = false;
            btnHuy.Enabled = false;
            dvgnhanvien.Enabled = true;
            dt.Clear();
            connect();
            getdata();
            disconect();

        }
    }
}
