using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ThuctapNhom
{
    public partial class FormThemNanhVien : Form
    {
        private void getdata()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            DataTable data1 = new DataTable();
            DataTable data = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from chucvu";
            da.SelectCommand = cm;
            da.Fill(data);
            cmbChucVu.DataSource = data;
            cmbChucVu.DisplayMember = "ten";
            cmbChucVu.ValueMember = "ID";
            cmbChucVu.SelectedValue = "ID";

            cm.CommandText = "select * from PhongBan";
            da.SelectCommand = cm;
            da.Fill(data1);
            cmbTenPhongBan.DataSource = data1;
            cmbTenPhongBan.DisplayMember = "ten";
            cmbTenPhongBan.ValueMember = "ID";
            cmbTenPhongBan.SelectedValue = "ID";

        }
        private bool isEmpty()
        {
            if(txtID.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập mã");
                return true;
            }
            if (txtHoten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên");
                return true;
            }
            if (!rdbNam.Checked && !rdbNu.Checked)
            {
                MessageBox.Show("Bạn chưa chọn giới tính");
                return true;
            }
            if (txtQuequan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập quê quán");
                return true;
            }
            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                return true;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số CMND");
                return true;
            }
            if (txtDienthoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập điện thoại");
                return true;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập email");
                return true;
            }
            if (cmbTenPhongBan.Text.Trim() == "")
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
        public FormThemNanhVien()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
        NhanVien_obj nv;
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (isEmpty()) return;
            nv = new NhanVien_obj();
            //try
            //{
                if (datetimeNgaySinh.Value < DateTime.Today)
                {
                    nv.ngaysinhNV = datetimeNgaySinh.Value;
                    nv.IDNV = txtID.Text;
                    nv.hotenNV = txtHoten.Text;



                    if (rdbNam.Checked == true)
                    {
                        nv.gioitinhNV = true;
                    }
                    else if (rdbNu.Checked == true)
                    {
                        nv.gioitinhNV = false;
                    }
                    nv.quequanNV = txtQuequan.Text;
                    nv.diachiNV = txtDiachi.Text;
                    nv.emailNV = txtEmail.Text;
                    nv.dienthoaiNV = txtDienthoai.Text;
                    nv.soCMNDNV = txtCMND.Text;
                    nv.PB_IDNV = cmbTenPhongBan.SelectedValue.ToString();
                    nv.CV_IDNV = cmbChucVu.SelectedValue.ToString();


                    NhanVienBus bus = new NhanVienBus();
                    int ret;
                    ret = bus.insert(nv);
                    bus.close();
                    if (ret < 0)
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        //this.Hide();
                        //FormNhanVien nv = new FormNhanVien();
                        //nv.Show();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(MessageBox.Show("Bạn có muốn tiếp tục thêm mới?","?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            txtID.Clear();
                            txtHoten.Clear();
                            txtEmail.Clear();
                            txtDienthoai.Clear();
                            txtDiachi.Clear();
                            txtCMND.Clear();
                            txtQuequan.Clear();
                            cmbChucVu.Text = "";
                            cmbTenPhongBan.Text = "";
                            return;
                        }
                        this.Hide();
                        FormNhanVien nv = new FormNhanVien();
                        nv.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai ngày!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtHoten.Clear();
            txtEmail.Clear();
            txtDienthoai.Clear();
            txtDiachi.Clear();
            txtCMND.Clear();
            txtQuequan.Clear();
            cmbChucVu.Text = "";
            cmbTenPhongBan.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormNhanVien nv = new FormNhanVien();
            nv.ShowDialog();
        }

        private void FormThemNanhVien_Load(object sender, EventArgs e)
        {
            getdata();
        }
        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
