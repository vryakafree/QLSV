using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ThanhVien
    {
        private int _MSSV;
        private string _TEN_SV;
        private string _LOP_SV;
        private int _ID_NGANH;
        private int _ID_KHOA;

        /* ======== GETTER/SETTER ======== */
        public int MSSV { get; set; }
        public string TEN_SV { get; set; }
        public string LOP_SV { get; set; }
        public int ID_NGANH { get; set; }
        public int ID_KHOA { get; set; }


        /* === Constructor === */
        public DTO_ThanhVien()
        {

        }

        public DTO_ThanhVien(int mssv, string hoten, string lop, int nganh, int khoa)
        {
            this.MSSV = mssv;
            this.TEN_SV = hoten;
            this.LOP_SV = lop;
            this.ID_NGANH = nganh;
            this.ID_KHOA = khoa;
        }
    }
}
