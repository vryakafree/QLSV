using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DA_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_ThanhVien
    {
        DAL_ThanhVien dalThanhVien = new DAL_ThanhVien();

        public DataTable GetThanhVien()
        {
            return dalThanhVien.GetThanhVien(); //gọi bảng bên DAL qua GUI
        }

        public DataTable LoadKhoa()
        {
            return dalThanhVien.LoadKhoa(); //gọi khoa bên DAL qua GUI
        }

        public DataTable LoadNganh()
        {
            return dalThanhVien.LoadNganh(); //gọi ngành bên DAL qua GUI
        }

        public DataTable TimSinhVien(string sv)
        {
            return dalThanhVien.TimSinhVien(sv);
        }

        public bool ThemThanhVien(DTO_ThanhVien sv)
        {
            return dalThanhVien.ThemThanhVien(sv); //gọi chức năng qua GUI
        }

        public bool SuaThanhVien(DTO_ThanhVien sv)
        {
            return dalThanhVien.SuaThanhVien(sv); //gọi chức năng qua GUI
        }

        public bool XoaThanhVien(DTO_ThanhVien sv)
        {
            return dalThanhVien.XoaThanhVien(sv); //gọi chức năng qua GUI
        }
    }
}
