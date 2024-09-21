using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class NguoiChoThue : ConNguoi
    {
        public NguoiChoThue(string ten, int tuoi, string quequan, string gioitinh, string nghenghiep, string cmnd, long tien)
           : base(ten, tuoi, quequan, gioitinh, nghenghiep, cmnd, tien)
        {
        }      
        public void LayNhaLai(DateTime ngaylay, HopDong hd)
        {
            if (hd.KiemTraHetHan() == false && hd.NTLamSai == false)
            {
                tien -= hd.TienDatCoc * 2;
                hd.NT.Tien += hd.TienDatCoc * 2;
                Console.WriteLine("Phai tra " + hd.TienDatCoc + "VND tien coc va den them " + hd.TienDatCoc + "VND");
                hd.NCTLamSai = true;
            }
            else
            {
                tien -= hd.TienDatCoc;
                hd.NT.Tien += hd.TienDatCoc;
                Console.WriteLine("Tra lai cho nguoi thue " + hd.TienDatCoc + "VND tien coc");
            }
            long tienboithuong = hd.PT.TienBoiThuong();
            tien += tienboithuong;
            hd.NT.Tien -= tienboithuong;
            if (tienboithuong > 0)
                Console.WriteLine("Nguoi thue boi thuong hu hai do dac " + tienboithuong + "VND");
        }
        public void ReportNT(string noidung, HopDong hd)
        {
            if (hd.NTLamSai == true)
                Console.WriteLine(noidung);
            else
                Console.WriteLine("Nguoi thue khong lam gi sai");
        } 
    }
}
