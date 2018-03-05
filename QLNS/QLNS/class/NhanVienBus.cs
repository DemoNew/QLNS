using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ThuctapNhom
{
    class NhanVienBus
    {

        public connection doIt = null;
        public int insert(NhanVien_obj nv)
        {
            int ret = 0;
            //gv = new GiaoVienObj();
            string sql = @"insert into NHANVIEN(ID, hoten , ngaysinh , gioitinh , quequan , diachi , soCMND , dienthoai , email ,CV_ID ,PB_ID)
                                         values(@ID,@hoten,@ngaysinh , @gioitinh , @quequan,@diachi,@soCMND , @dienthoai ,@email,@CV_ID ,@PB_ID)";
            List<SqlParameter> li = new List<SqlParameter>();
            SqlParameter a;
            a = new SqlParameter("ID", SqlDbType.VarChar);
            a.Value = nv.IDNV;
            li.Add(a);
            a = new SqlParameter("hoten", SqlDbType.NVarChar);
            a.Value = nv.hotenNV;
            li.Add(a);
            a = new SqlParameter("ngaysinh", SqlDbType.Date);
            a.Value = nv.ngaysinhNV;
            li.Add(a);
            a = new SqlParameter("gioitinh", SqlDbType.Bit);
            a.Value = nv.gioitinhNV;
            li.Add(a);
            a = new SqlParameter("quequan", SqlDbType.NVarChar);
            a.Value = nv.quequanNV;
            li.Add(a);
            a = new SqlParameter("diachi", SqlDbType.NVarChar);
            a.Value = nv.diachiNV;
            li.Add(a);
            a = new SqlParameter("soCMND", SqlDbType.VarChar);
            a.Value = nv.soCMNDNV;
            li.Add(a);
            a = new SqlParameter("dienthoai", SqlDbType.VarChar);
            a.Value = nv.dienthoaiNV;
            li.Add(a);
            a = new SqlParameter("email", SqlDbType.NVarChar);
            a.Value = nv.emailNV;
            li.Add(a);
            a = new SqlParameter("CV_ID", SqlDbType.VarChar);
            a.Value = nv.CV_IDNV;
            li.Add(a);
            a = new SqlParameter("PB_ID", SqlDbType.NVarChar);
            a.Value = nv.PB_IDNV;
            li.Add(a);




            if (doIt == null)
            {
                doIt = new connection();
            }
            if (doIt.isOpen() < 0)
            {
                ret = doIt.connect();
            }
            if (ret < 0)
            {
                return -2;
            }
            ret = doIt.doSql(sql, li.ToArray());
            return ret;
        }
        public int update(NhanVien_obj nv)
        {
            int ret = 0;// kiem tra , neu tra ve 0 thi thuc hien dc , nho hon 0 thi ko thuc hien dc
            string sql = @"update NHANVIEN
                        set quequan=@quequan,
                        hoten=@hoten,
                        ngaysinh=@ngaysinh,
	                    diachi=@diachi,
	                    soCMND=@soCMND,
	                    dienthoai=@dienthoai,
	                    email=@email,
	                    CV_ID=@CV_ID,
	                    PB_ID=@PB_ID
                        where ID=@ID";
            List<SqlParameter> li = new List<SqlParameter>();
            SqlParameter a;
            a = new SqlParameter("ID", SqlDbType.VarChar);
            a.Value = nv.IDNV;
            li.Add(a);
            a = new SqlParameter("CV_ID", SqlDbType.VarChar);
            a.Value = nv.CV_IDNV;
            li.Add(a);
            a = new SqlParameter("PB_ID", SqlDbType.VarChar);
            a.Value = nv.PB_IDNV;
            li.Add(a);
            a = new SqlParameter("hoten", SqlDbType.NVarChar);
            a.Value = nv.hotenNV;
            li.Add(a);
            a = new SqlParameter("ngaysinh", SqlDbType.Date);
            a.Value = nv.ngaysinhNV;
            li.Add(a);
            a = new SqlParameter("diachi", SqlDbType.VarChar);
            a.Value = nv.diachiNV;
            li.Add(a);
            a = new SqlParameter("email", SqlDbType.VarChar);
            a.Value = nv.emailNV;
            li.Add(a);
            a = new SqlParameter("dienthoai", SqlDbType.VarChar);
            a.Value = nv.dienthoaiNV;
            li.Add(a);
            a = new SqlParameter("soCMND", SqlDbType.VarChar);
            a.Value = nv.soCMNDNV;
            li.Add(a);

            a = new SqlParameter("quequan", SqlDbType.VarChar);
            a.Value = nv.quequanNV;
            li.Add(a);



            if (doIt == null)
            {
                doIt = new connection();
            }
            if (doIt.isOpen() < 0)
            {
                ret = doIt.connect();
            }

            if (ret < 0)
            {
                return -1;
            }
            ret = doIt.doSql(sql, li.ToArray());
            return ret;
        }
        
        public void close()
        {
            if (doIt == null)
            {
                return;
            }
            if (doIt.isOpen() < 0)
            {
                return;
            }
            doIt.close();
        }
       
    }

}
