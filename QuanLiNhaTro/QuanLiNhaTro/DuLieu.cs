using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class DuLieu
    {
        public static DoDac[] DSDoDac()
        {
            DoDac[] DS = { new DoDac("Tu lanh", 500000), new DoDac("May giat", 3000000), new DoDac("Noi com", 100000), new DoDac("Quat", 200000) };
            return DS;
        }
        public static NguoiChoThue[] DSNguoiChoThue()
        {
            NguoiChoThue nct1 = new NguoiChoThue("Vo A", 35, "Ben Tre", "Nam", "kinh doanh", "123456", 45000000);
            NguoiChoThue nct2 = new NguoiChoThue("Vo B", 30, "Da Nang", "Nu", "kinh doanh", "125679", 50000000);
            NguoiChoThue nct3 = new NguoiChoThue("Vo C", 31, "Thanh Pho Ho Chi Minh", "Nu", "kinh doanh", "125728", 10000000);
            NguoiChoThue[] DS = { nct1, nct2, nct3 };
            return DS;
        }
        public static PhongTro[] DanhSachPhong()
        {
            DoDac[] DanhSach = { DSDoDac()[2], DSDoDac()[3] };
            PhongSoCap sc1 = new PhongSoCap(10, "go", DanhSach, 1700000, "Quan 12", "Nu", false, true, true, 2, DSNguoiChoThue()[0], "khong co", 3000, 15000);
            PhongSoCap sc2 = new PhongSoCap(15, "go", DanhSach, 1500000, "Quan 8", "Nu", false, false, true, 3, DSNguoiChoThue()[0], "khong co", 4500, 12000);
            PhongSoCap sc3 = new PhongSoCap(15, "dien may", DanhSach, 1800000, "Binh Thanh", "Nam", true, true, true, 3, DSNguoiChoThue()[1], "khong cho nguoi la o qua dem", 3000, 11500);
            PhongTrungCap tc1 = new PhongTrungCap(25, "dien may", DSDoDac(), 1850000, "Quan 12", "Nu", true, false, true, 4, DSNguoiChoThue()[2], "khong co ", 3200, 14500, 10000);
            PhongTrungCap tc2 = new PhongTrungCap(20, "go", DSDoDac(), 1900000, "Binh Tan", "Nam", false, true, false, 3, DSNguoiChoThue()[0], "giu gin ve sinh chung", 3500, 13000, 60000);
            PhongTrungCap tc3 = new PhongTrungCap(25, "dien may", DSDoDac(), 1900000, "Thu Duc", "Nam", false, false, false, 3, DSNguoiChoThue()[2], "khong co", 3500, 12000, 65000);
            PhongCaoCap cc1 = new PhongCaoCap(30, "dien may", DSDoDac(), 2000000, "Quan 8", "Nam va Nu", false, true, false, 5, DSNguoiChoThue()[0], "khong dan ban khac gioi vao phong", 4000, 15000, 30000, 150000, 50000);
            PhongCaoCap cc2 = new PhongCaoCap(35, "dienmay", DSDoDac(), 2500000, "Binh Thanh", "Nu", true, true, true, 6, DSNguoiChoThue()[1], "khong co", 4500, 12500, 80000, 180000, 60000);
            PhongCaoCap cc3 = new PhongCaoCap(32, "go", DSDoDac(), 2700000, "Quan 7", "Nu", true, false, true, 5 , DSNguoiChoThue()[1], "khong co", 4000, 13000, 85000, 160000, 75000);
            PhongTro[] danhsachphong = { sc1, sc2,sc3, tc1, tc2, tc3,cc1, cc2,cc3 };
            return danhsachphong;
        }
        public static NguoiThue[] DSNguoiThue()
        {
            NguoiThue nt1 = new NguoiThue("Nguyen A", 19, "Tien Giang", "Nu", "sinh vien", "344219", 2000000);
            NguoiThue nt2 = new NguoiThue("Nguyen B", 22, "An Giang", "Nu", "giang vien", "1233745", 3000000);
            NguoiThue nt3 = new NguoiThue("Nguyen C", 18, "Ben Tre", "Nu", "cong nhan", "3135219", 4000000);
            NguoiThue nt4 = new NguoiThue("Nguyen D", 22, "Ca Mau", "Nu", "sinh vien", "123245", 500000);
            NguoiThue nt5 = new NguoiThue("Nguyen E", 33, "Thanh Pho Ho Chi Minh", "Nam", "bac si", "331119", 10000000);
            NguoiThue nt6 = new NguoiThue("Nguyen F", 20, "An Giang", "Nu", "sinh vien", "1234335", 0);
            NguoiThue[] DS = { nt1, nt2, nt3, nt4, nt5, nt6 };
            return DS;
        }
        public static HopDong[] DSHopDong()
        {
            HopDong hd1 = new HopDong(500000, DanhSachPhong()[0], DSNguoiChoThue()[0], DSNguoiThue()[3], new DateTime(2022, 2, 22), 2);
            HopDong hd2 = new HopDong(600000, DanhSachPhong()[1], DSNguoiChoThue()[0], DSNguoiThue()[1], new DateTime(2021, 3, 11), 1);
            HopDong hd3 = new HopDong(200000, DanhSachPhong()[3], DSNguoiChoThue()[0], DSNguoiThue()[4], new DateTime(2022, 11, 11), 2);
            hd3.NTLamSai = true;
            HopDong hd4 = new HopDong(300000, DanhSachPhong()[4], DSNguoiChoThue()[0], DSNguoiThue()[5], new DateTime(2023, 1, 16), 2);
            hd4.NTLamSai = true;
            HopDong[] DS = { hd1, hd2, hd3, hd4 };
            return DS;
        }
    }
}