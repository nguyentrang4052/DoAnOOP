using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class PhongCaoCap : PhongTro
    {
        private long tienbaove;
        private long tienmang;
        private long tienvesinh;
        public PhongCaoCap (long dientich, string noithat, DoDac[] danhsachdodac, long giaca, string diachi, string gioitinhnguoithue, bool nuoichomeo, bool loidirieng, bool giogiactudo, int soluong, NguoiChoThue nct, string yeucaurieng, long tiendien, long tiennuoc, long tienbaove, long tienmang, long tienvesinh) 
            : base(dientich, noithat, danhsachdodac, giaca, diachi, gioitinhnguoithue, nuoichomeo, loidirieng, giogiactudo, soluong, nct, yeucaurieng, tiendien, tiennuoc)
        {
            this.tienbaove = tienbaove;
            this.tienmang = tienmang;
            this.tienvesinh = tienvesinh;
        }
        public override long ChiPhiKhac()
        {
            return tienbaove + tienmang + tienvesinh;
        }
        public override long UuDai()
        {
            if (KiemTraUuDai() == true)
                return (long)(giaca * 0.2);
            return 0;
        }
    }
}
