using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DA_QuanLy
{
    public class DAL_ThanhVien : DBConnect
    {
        public DataTable GetThanhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM THANHVIEN", _conn);
            DataTable dtThanhvien = new DataTable(); 
            da.Fill(dtThanhvien);
            return dtThanhvien; 
            
        }

        public DataTable LoadKhoa()
        {
            DataTable dt = new DataTable();
            _conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * From KHOA", _conn);
                da.Fill(dt);
                _conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }
        }

        public DataTable LoadNganh()
        {
            DataTable dt = new DataTable();
            _conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * From NGANH", _conn);
                da.Fill(dt);
                _conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }
        }

        public DataTable TimSinhVien(string sv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM THANHVIEN WHERE MSSV LIKE N'%" + sv + "%' OR TEN_SV LIKE N'%" + sv + "%' OR LOP_SV LIKE N'%" + sv + "%' OR ID_NGANH LIKE N'%" + sv + "%' OR ID_KHOA LIKE N'%" + sv + "%'", _conn);
            _conn.Open();
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            _conn.Close();
            return dtThanhvien;
        }

        public bool ThemThanhVien(DTO_ThanhVien sv)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO THANHVIEN(MSSV, TEN_SV, LOP_SV, ID_NGANH, ID_KHOA) VALUES ('{0}','{1}','{2}','{3}','{4}')", sv.MSSV, sv.TEN_SV, sv.LOP_SV, sv.ID_KHOA, sv.ID_NGANH);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool SuaThanhVien(DTO_ThanhVien sv)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE THANHVIEN SET TEN_SV = '{1}', LOP_SV = '{2}', ID_NGANH = '{3}', ID_KHOA = '{4}' WHERE MSSV = '{0}'", sv.TEN_SV, sv.LOP_SV, sv.ID_NGANH, sv.ID_KHOA, sv.MSSV);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool XoaThanhVien(DTO_ThanhVien sv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM THANHVIEN WHERE MSSV = '{0}'", sv.MSSV);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        

    }
}
