using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class PhongTrungCap : PhongTro
    {
        private long tiengoixe;
        public PhongTrungCap(long dientich, string noithat, DoDac[] danhsachdodac, long giaca, string diachi, string gioitinhnguoithue, bool nuoichomeo, bool loidirieng, bool giogiactudo, int soluong, NguoiChoThue nct, string yeucaurieng, long tiendien, long tiennuoc, long tiengoixe)
            : base(dientich, noithat, danhsachdodac, giaca, diachi, gioitinhnguoithue, nuoichomeo, loidirieng, giogiactudo, soluong, nct, yeucaurieng, tiendien, tiennuoc)
        {
            this.tiengoixe = tiengoixe;
        }
        public virtual long ChiPhiKhac()
        {
            return tiengoixe;
        }
        public override long UuDai()
        {
            if (KiemTraUuDai() == true)
                return (long)(giaca * 0.1);
            return 0;
        }
    }
}
