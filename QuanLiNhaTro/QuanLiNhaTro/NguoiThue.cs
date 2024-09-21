using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class NguoiThue : ConNguoi
    {
        public NguoiThue(string ten, int tuoi, string quequan, string gioitinh, string nghenghiep, string cmnd, long tien)
           : base(ten, tuoi, quequan, gioitinh, nghenghiep, cmnd, tien)
        {
        }  
        public void TraPhong(HopDong hd)
        {
            if (hd.KiemTraHetHan() == true || hd.NCTLamSai == true)
            {
                tien += hd.TienDatCoc;
                hd.NCT.Tien -= hd.TienDatCoc;
                Console.WriteLine("Nhan lai " + hd.TienDatCoc + "VND tien coc");
                hd.NTLamSai = true;
            }
            else
                Console.WriteLine("Phai den hop dong nen mat tien coc " + hd.TienDatCoc + "VND");
            long tienboithuong = hd.PT.TienBoiThuong();
            tien -= tienboithuong;
            hd.NCT.Tien += tienboithuong;
            if (tienboithuong > 0)
                Console.WriteLine("Boi thuong hu hai do dac " + tienboithuong + "VND");
        }
        public void TraPhong(NguoiThue nguoithay, HopDong hd)
        {
            tien += hd.TienDatCoc;
            nguoithay.Tien -= hd.TienDatCoc;
            Console.WriteLine("Nhan lai " + hd.TienDatCoc + "VND tien coc");
            long tienboithuong = hd.PT.TienBoiThuong();
            tien -= tienboithuong;
            hd.NCT.Tien += tienboithuong;
            if (tienboithuong > 0)
                Console.WriteLine("Boi thuong hu hai do dac " + tienboithuong + "VND");
            hd.NT = nguoithay;
        }
        public void ReviewNCT(string noidung, HopDong hd)
        {
            if (hd.NCTLamSai == true)
                Console.WriteLine(noidung);
            else
                Console.WriteLine("Nguoi cho thue khong lam gi sai");
        }
    }
}
