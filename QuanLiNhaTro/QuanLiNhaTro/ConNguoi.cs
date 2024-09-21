using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class ConNguoi
    {
        private string ten;
        private int tuoi;
        private string quequan;
        private string gioitinh;
        protected string nghenghiep;
        private string cmnd;
        protected long tien;
        public string GioiTinh
        {
            get { return gioitinh; }
        }
        public long Tien
        {
            get { return tien; }
            set { tien = value; }
        }
        public ConNguoi(string ten, int tuoi, string quequan, string gioitinh, string nghenghiep, string cmnd, long tien) 
        {
            this.ten = TienIch.VietHoaChuDau(ten);
            this.tuoi = tuoi;
            this.quequan = TienIch.VietHoaChuDau(quequan);
            this.gioitinh = gioitinh;
            this.nghenghiep = nghenghiep;
            this.cmnd = cmnd;
            this.tien = tien;
        }
        public void XuatThongTin()
        {
            Console.WriteLine(ten + ", " + tuoi + " tuoi, o " + quequan + ", lam " + nghenghiep + ", so CMND " + cmnd);
        }
    }
}
