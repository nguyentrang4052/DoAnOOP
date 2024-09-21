using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class HopDong
    {
        private long tiendatcoc;
        private PhongTro pt;
        private NguoiChoThue nct;
        private NguoiThue nt;
        private DateTime ngayki;
        private int thoihan;
        private bool ntlamsai;
        private bool nctlamsai;
        public long TienDatCoc
        {
            get { return tiendatcoc; }
            set { tiendatcoc = value;}
        }
        public PhongTro PT
        {
            get { return pt; }
        }
        public NguoiChoThue NCT
        {
            get { return nct; }
        }
        public NguoiThue NT
        {
            get { return nt; }
            set { nt = value;}
        }
        public DateTime NgayKi
        {
            get { return ngayki; }
            set { ngayki = value; }
        }
        public int ThoiHan
        {
            get { return thoihan; }
            set { thoihan = value; }
        }
        public bool NTLamSai
        {
            get { return ntlamsai; }
            set { ntlamsai = value; }
        }
        public bool NCTLamSai
        {
            get { return nctlamsai; }
            set { nctlamsai = value; }
        }
        public HopDong()
        {
        }
        public HopDong(long tiendatcoc, PhongTro pt, NguoiChoThue nct, NguoiThue nt, DateTime ngayki, int thoihan)
        {
            this.tiendatcoc = tiendatcoc;
            this.nct = nct;
            this.pt = pt;
            this.nt = nt;
            try
            {
                if (nt.GioiTinh != pt.GioiTinhNguoiThue && pt.GioiTinhNguoiThue != "Nam va Nu")
                    throw new Exception("Gioi tinh nguoi thue khong phu hop");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            this.ngayki = ngayki;
            this.thoihan = thoihan;
            ntlamsai = false;
            nctlamsai = false;
        }
        public bool KiemTraDongTienTre()
        {
            DateTime NgayTre = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 5);
            if (DateTime.Now > NgayTre)
                return true;
            return false;
        }
        public bool KiemTraHetHan()
        {
            if (DateTime.Now > ngayki.AddYears(thoihan))
                return true;
            return false;
        }
        public void GiaHan(int thoihanmoi)
        {
            thoihan += thoihanmoi;
            Console.WriteLine("Nguoi cho thue tiep tuc giu tien coc");
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Hop dong:");
            Console.Write("Nguoi thue: ");
            nt.XuatThongTin();
            pt.XuatThongTin();
            Console.WriteLine("Thoi gian hop dong: " + ngayki.ToString("dd/MM/yyyy") + " - " + ngayki.AddYears(thoihan).ToString("dd/MM/yyyy"));
        }
    }
}
