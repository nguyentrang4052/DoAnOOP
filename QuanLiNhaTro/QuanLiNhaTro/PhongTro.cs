using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class PhongTro
    {
        private long dientich;
        protected long giaca;
        private string diachi;
        private string gioitinhnguoithue;
        private string noithat;
        private DoDac[] danhsachdodac;
        private int soluongnguoio;
        private bool loidirieng;
        private bool giogiactudo;
        private bool nuoichomeo;
        private string yeucaurieng;
        NguoiChoThue nct;
        private long tiendien;
        private long tiennuoc;
        public long GiaCa
        {
            get { return giaca; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string GioiTinhNguoiThue
        {
            get { return gioitinhnguoithue; }
        }
        public DoDac[] DanhSachDoDac
        {
            get { return danhsachdodac; }
            set { danhsachdodac = value; }
        }
        public NguoiChoThue NCT
        {
            get { return nct; }
            set {  nct = value; }
        }
        public long TienDien
        {
            get { return tiendien; }
        }
        public long TienNuoc
        {
            get { return tiennuoc; }
        }
        public int SoLuongNguoiO
        {
            get { return soluongnguoio; }
            set { soluongnguoio = value; }
        }
        public PhongTro(long dientich, string noithat, DoDac[] danhsachdodac, long giaca, string diachi, string gioitinhnguoithue, bool nuoichomeo,
            bool loidirieng, bool giogiactudo, int soluongnguoio, NguoiChoThue nct, string yeucaurieng, long tiendien, long tiennuoc)
        {
            this.dientich = dientich;
            this.noithat = noithat;
            this.danhsachdodac = danhsachdodac;
            this.giaca = giaca;
            this.diachi = TienIch.VietHoaChuDau(diachi);
            this.gioitinhnguoithue = gioitinhnguoithue;
            this.nuoichomeo = nuoichomeo;
            this.loidirieng = loidirieng;
            this.giogiactudo = giogiactudo;
            this.soluongnguoio = soluongnguoio;
            this.nct = nct;
            this.yeucaurieng = yeucaurieng;
            this.tiendien = tiendien;
            this.tiennuoc = tiennuoc;
        }
        public long TienTro(int sokidien, int sokinuoc)
        {
            return giaca + tiendien * sokidien + tiennuoc * sokinuoc + ChiPhiKhac() - UuDai();
        }
        public virtual long ChiPhiKhac()
        {
            return 0;
        }
        public void CapNhatTinhTrangPhong(DoDac[] danhsachdodac)
        {
            DanhSachDoDac = danhsachdodac;
        }
        public long TienBoiThuong()
        {
            long tien = 0;
            foreach (var d in DanhSachDoDac)
                if (d.TinhTrang == false)
                    tien += d.GiaTri;
            return tien;
        }
        public bool KiemTraUuDai()
        {
            DateTime ngaydongtien = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
            DateTime ngayle = new DateTime(DateTime.Now.Year + 1, 1, 1);
            if (DateTime.Compare(ngaydongtien.AddDays(2), ngayle) >= 0)
                return true;
            return false;
        }
        public virtual long UuDai()
        {
            return 0;
        }
        public void XuatThongTin()
        {
            Console.Write("Nguoi cho thue: ");
            nct.XuatThongTin();
            Console.WriteLine("Dien tich phong tro: " + dientich + "m2");
            Console.WriteLine("Noi that phong tro: " + noithat);
            Console.WriteLine("Phong cho " + gioitinhnguoithue + " thue, co gia: " + giaca + "VND 1 thang, o " + diachi + ", duoc o " + soluongnguoio + " nguoi");
            Console.WriteLine("Do dac co san: ");
            if (danhsachdodac.Length == 0)
                Console.WriteLine("khong co");
            else
                foreach (var d in danhsachdodac)
                    d.XuatThongTin();
            Console.WriteLine("Yeu cau rieng: " + yeucaurieng);
            if (nuoichomeo == true)
                Console.WriteLine("Duoc nuoi cho meo");
            else
                Console.WriteLine("Khong duoc nuoi cho meo");
            if (loidirieng == true)
                Console.WriteLine("Phong co loi di rieng");
            else
                Console.WriteLine("Phong khong co loi di rieng");
            if (giogiactudo == true)
                Console.WriteLine("Gio giac tu do");
            else
                Console.WriteLine("Gio giac gioi han" );
        }
        public static PhongTro[] TimPhong(string vitri, long giatoithieu, long giatoida, int soluongnguoio, PhongTro[] DanhSachPhong, string gioitinh)
        {
            List<PhongTro> phongtimduoc = new List<PhongTro>();
            bool timduoc = false;
            foreach (PhongTro p in DanhSachPhong)
                if (vitri == p.DiaChi && p.GiaCa >= giatoithieu && p.GiaCa <= giatoida && p.SoLuongNguoiO >= soluongnguoio && (p.GioiTinhNguoiThue == "Nam va Nu" || p.GioiTinhNguoiThue == gioitinh))
                {
                    phongtimduoc.Add(p);
                    timduoc = true;
                }
            if (timduoc == false)
                Console.WriteLine("Khong tim duoc phong thich hop");
            return phongtimduoc.ToArray();
        }
    }
}
