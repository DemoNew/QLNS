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
            cl.HeaderText = "Mã";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
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
            cl.DataPropertyName = "quequan";
            cl.HeaderText = "Quê quán";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "diachi";
            cl.HeaderText = "Địa chỉ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "socmnd";
            cl.HeaderText = "Số CMND";
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
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "phongban";
            cl.HeaderText = "Phòng";
            dgv.Columns.Add(cl);
            
        }
        private bool isEmpty()
        {
            if (txthoten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên");
                return true;
            }
            if (!rdbnam.Checked && !rdbnu.Checked)
            {
                MessageBox.Show("Bạn chưa chọn giới tính");
                return true;
            }
            if (txtquequan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập quê quán");
                return true;
            }
            if (txtdiachi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                return true;
            }
            if (txtsoCMND.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số CMND");
                return true;
            }
            if (txtdienthoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập điện thoại");
                return true;
            }
            if (txtemail.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập email");
                return true;
            }
            if (cmbPhongBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng ban");
                return true;
            }
            if (cmbChucVu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn chức vụ");
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
            FormThemNanhVien them = new FormThemNanhVien();
            this.Hide();
            them.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain m = new FormMain();
            m.Show();
        }

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào");
                return;
            }
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txtemail.Enabled = true;
            txthoten.Enabled = true;
            txtquequan.Enabled = true;
            txtsoCMND.Enabled = true;
            dtpngaysinh.Enabled = true;
            cmbChucVu.Enabled = true;
            cmbPhongBan.Enabled = true;
            btnthemnv.Enabled = false;
            btnsuanv.Enabled = false;
            btnxoanv.Enabled = false;
            btCapNhat.Enabled = true;
            btnHuy.Enabled = true;
            dvgnhanvien.Enabled = false;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (isEmpty()) return;
            NhanVien_obj nv = new NhanVien_obj();
            nv.IDNV = txtID.Text;
            nv.hotenNV = txthoten.Text;
            nv.ngaysinhNV = dtpngaysinh.Value;
            nv.emailNV = txtemail.Text;
            nv.dienthoaiNV = txtdienthoai.Text;
            nv.quequanNV = txtquequan.Text;
            nv.diachiNV = txtdiachi.Text;
            nv.soCMNDNV = txtsoCMND.Text;
            nv.CV_IDNV = cmbChucVu.SelectedValue.ToString();
            nv.PB_IDNV = cmbPhongBan.SelectedValue.ToString();

            NhanVienBus bus = new NhanVienBus();
            int ret;
            ret = bus.update(nv);
            bus.close();
            if (ret < 0)
            {
                MessageBox.Show("Không sửa được dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào");
                return;
            }           
            try
            {
                connect();
                SqlCommand command = new SqlCommand("SP_DELETE_NHANVIEN", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", txtID.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
                getdata();
                disconect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dvgnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gt = this.dvgnhanvien.CurrentRow.Cells[2].Value.ToString().Trim();
            if (gt == "Nam")
            {
                rdbnam.Checked = true;

            }
            else if (gt == "Nữ")
            {
                rdbnu.Checked = true;

            }
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dvgnhanvien.DataSource, "ID");
            txthoten.DataBindings.Clear();
            txthoten.DataBindings.Add("Text", dvgnhanvien.DataSource, "hoten");
            dtpngaysinh.DataBindings.Clear();
            dtpngaysinh.DataBindings.Add("Text", dvgnhanvien.DataSource, "ngaysinh");
            txtquequan.DataBindings.Clear();
            txtquequan.DataBindings.Add("Text", dvgnhanvien.DataSource, "quequan");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dvgnhanvien.DataSource, "diachi");
            txtsoCMND.DataBindings.Clear();
            txtsoCMND.DataBindings.Add("Text", dvgnhanvien.DataSource, "soCMND");
            txtemail.DataBindings.Clear();
            txtemail.DataBindings.Add("Text", dvgnhanvien.DataSource, "email");
            txtdienthoai.DataBindings.Clear();
            txtdienthoai.DataBindings.Add("Text", dvgnhanvien.DataSource, "dienthoai");
            cmbChucVu.DataBindings.Clear();
            cmbChucVu.DataBindings.Add("Text",dvgnhanvien.DataSource,"chucvu");
            cmbPhongBan.DataBindings.Clear();
            cmbPhongBan.DataBindings.Add("Text", dvgnhanvien.DataSource, "phongban");
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                connect();
                getdata();
                disconect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
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
