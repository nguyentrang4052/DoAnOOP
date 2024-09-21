using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class Menu
    {
        static bool dathue;
        public static void BatDau()
        {
            int luachon = -1;
            while (luachon != 0)
            {
                Console.Clear();
                luachon = ChonVaiTro();
                switch (luachon)
                {
                    case 1:
                        {
                            ChonThaoTacNT();
                            break;
                        }
                    case 2:
                        {
                            ChonThaoTacNCT();
                            break;
                        }
                }
            }
        }
        private static int ChonVaiTro()
        {
            Console.WriteLine("--------------------------------------------------");
            TienIch.InNhieuChuoi(new string[] { "Ket thuc", "Nguoi thue", "Nguoi cho thue" });
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Ban la ai: ");
            return int.Parse(Console.ReadLine());
        }
        private static void ChonThaoTacNT()
        {
            int luachon = -1;
            HopDong hd = new HopDong();
            NguoiThue nt = DuLieu.DSNguoiThue()[0];
            while (luachon != 0)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                if (dathue)
                    TienIch.InNhieuChuoi(new string[] { "Ket thuc", "Tim phong va thue phong", "Gia han hop dong", "Tra phong", "Review nguoi cho thue" });
                else
                    TienIch.InNhieuChuoi(new string[] { "Ket thuc", "Tim phong va thue phong" });
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Ban can gi: ");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        {
                            PhongTro[] DS = TimPhong(nt, DuLieu.DanhSachPhong());
                            if (DS.Length == 0)
                            {
                                Console.ReadKey();
                                break;
                            }
                            PhongTro pt = ChonPhong(DS);
                            hd = LamHopDong(nt, pt);
                            break;
                        }
                    case 2:
                        {
                            GiaHanHopDong(nt, hd);
                            break;
                        }
                    case 3:
                        {
                            TraPhong(nt, hd);
                            break;
                        }
                    case 4:
                        {
                            ReviewNCT(nt, hd);
                            break;
                        }
                }
            }   
        }
        private static PhongTro[] TimPhong(NguoiThue nt, PhongTro[] DS)
        {
            Console.Write("Nhap dia chi phong: ");
            string diachi = TienIch.VietHoaChuDau(Console.ReadLine());
            Console.Write("Nhap gia phong toi thieu mong muon: ");
            long giatoithieu = long.Parse(Console.ReadLine());
            Console.Write("Nhap gia phong toi da mong muon: ");
            long giatoida = long.Parse(Console.ReadLine());
            Console.Write("Nhap so luong nguoi o: ");
            int soluongnguoio = int.Parse(Console.ReadLine());
            return PhongTro.TimPhong(diachi, giatoithieu, giatoida, soluongnguoio, DS, nt.GioiTinh);
        }
        private static PhongTro ChonPhong(PhongTro[] DS)
        {
            int dem = 0;
            Console.WriteLine("--------------------------------------------------");
            foreach (var p in DS)
            {
                Console.Write(dem + ".");
                p.XuatThongTin();
                dem++;
            }
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Chon phong muon thue: ");
            int luachon = int.Parse(Console.ReadLine());
            return DS[luachon];
        }
        private static HopDong LamHopDong(NguoiThue nt, PhongTro pt)
        {
            HopDong hd = new HopDong(pt.GiaCa, pt, pt.NCT, nt, DateTime.Now, 1);
            hd.XuatThongTin();
            Console.ReadKey();
            dathue = true;
            return hd;
        }
        private static void GiaHanHopDong(NguoiThue nt, HopDong hd)
        {
            Console.Write("Nhap so nam muon gia han: ");
            int thoihan = int.Parse(Console.ReadLine());
            hd.GiaHan(thoihan);
            hd.XuatThongTin();
            Console.ReadKey();
        }
        private static void TraPhong(NguoiThue nt, HopDong hd)
        {
            Console.WriteLine("--------------------------------------------------");
            TienIch.InNhieuChuoi(new string[] { "Ket thuc", "Truong hop tim duoc nguoi thay", "Truong hop khong tim duoc nguoi thay" });
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Ban tra phong theo truong hop nao: ");
            int luachon = int.Parse(Console.ReadLine());
            switch (luachon)
            {
                case 1:
                    {
                        NguoiThue ntt = ChonNguoiThay(DuLieu.DSNguoiThue());
                        nt.TraPhong(ntt, hd);
                        hd.XuatThongTin();
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        nt.TraPhong(hd);
                        Console.ReadKey();
                        break;
                    }
            }
            dathue = false;
        }
        private static NguoiThue ChonNguoiThay(NguoiThue[] DSThayThe)
        {
            int dem = 0;
            Console.WriteLine("--------------------------------------------------");
            foreach (var nt in DSThayThe)
            {
                Console.Write(dem + ".");
                nt.XuatThongTin();
                dem++;
            }
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Chon nguoi thay the: ");
            int luachon = int.Parse(Console.ReadLine());
            return DSThayThe[luachon];
        }
        private static void ReviewNCT(NguoiThue nt, HopDong hd)
        {
            Console.Write("Nguoi thue nhap noi dung: ");
            string noidung = Console.ReadLine();
            nt.ReviewNCT(noidung, hd);
            Console.ReadKey();
        }
        private static void ChonThaoTacNCT()
        {
            NguoiChoThue nct = DuLieu.DSNguoiChoThue()[0];
            int luachon = -1;
            while (luachon != 0)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                TienIch.InNhieuChuoi(new string[] { "Ket thuc", "Lam giay tam tru cho nguoi thue", "Tinh tien phong tro trong 1 thang", "Lay lai nha", "Report nguoi thue" });
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Ban can gi: ");
                luachon = int.Parse(Console.ReadLine());
                HopDong hd = ChonHopDong(DuLieu.DSHopDong());
                switch (luachon)
                {
                    case 1:
                        {
                            LamTamTru(hd.NT);
                            break;
                        }
                    case 2:
                        {
                            TinhTienPhong(hd.PT);
                            break;
                        }
                    case 3:
                        {
                            LayPhong(nct, hd);
                            break;
                        }
                    case 4:
                        {
                            ReportNT(nct, hd);
                            break;
                        }
                }
            }
        }
        private static HopDong ChonHopDong(HopDong[] DS)
        {
            int dem = 0;
            Console.WriteLine("--------------------------------------------------");
            foreach (var hd in DS)
            {
                Console.Write(dem + ".");
                hd.XuatThongTin();
                if (hd.NTLamSai == true)
                    Console.WriteLine("Nguoi thue da lam sai");
                if (hd.NCTLamSai == true)
                    Console.WriteLine("Nguoi cho thue da lam sai");
                if (hd.KiemTraHetHan() == true)
                    Console.WriteLine("Hop dong nay da het han");
                dem++;
            }
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Chon hop dong ban muon thao tac: ");
            int luachon = int.Parse(Console.ReadLine());
            return DS[luachon];
        }
        private static void LamTamTru(NguoiThue nt)
        {
            GiayTamTru gtt = new GiayTamTru(nt, DuLieu.DanhSachPhong()[3].DiaChi);
            gtt.XuatThongTin();
            Console.ReadKey();
        }
        private static void TinhTienPhong(PhongTro pt)
        {
            Console.Write("Nhap vao so ki dien nguoi thue da su dung: ");
            int sokidien = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so khoi muoc nguoi thue da su dung: ");
            int sokinuoc = int.Parse(Console.ReadLine());
            Console.WriteLine("Tien tro trong 1 thang la: " + pt.TienTro(sokidien, sokinuoc) + "VND");
            Console.ReadKey();
        }
        private static void LayPhong(NguoiChoThue nct, HopDong hd)
        {
            nct.LayNhaLai(DateTime.Now, hd);
            Console.ReadKey();
        }
        private static void ReportNT(NguoiChoThue nct, HopDong hd)
        {
            Console.Write("Nguoi cho thue nhap noi dung: ");
            string noidung = Console.ReadLine();
            nct.ReportNT(noidung, hd);
            Console.ReadKey();
        }
    }
}
