using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class DoDac
    {
        private string ten;
        private long giatri;
        private bool tinhtrang;
        public bool TinhTrang
        {
            get { return tinhtrang; }
        }
        public long GiaTri
        {
            get { return giatri; }
        }
        public DoDac(string ten, int giatri)
        {
            this.ten = ten;
            this.giatri = giatri;
            tinhtrang = true;
        }
        public void XuatThongTin()
        {
            Console.Write(ten + ", " + giatri + "VND, tinh trang: ");
            if (tinhtrang)
                Console.WriteLine("binh thuong");
            else
                Console.WriteLine("hu hong");
        }
    }
}
