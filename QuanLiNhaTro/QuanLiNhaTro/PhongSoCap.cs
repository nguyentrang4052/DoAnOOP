using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class PhongSoCap : PhongTro
    {
        public PhongSoCap(long dientich, string noithat, DoDac[] danhsachdodac, long giaca, string diachi, string gioitinhnguoithue, bool nuoichomeo, bool loidirieng, bool giogiactudo, int soluong, NguoiChoThue nct, string yeucaurieng, long tiendien, long tiennuoc)
            : base(dientich, noithat, danhsachdodac, giaca, diachi, gioitinhnguoithue, nuoichomeo, loidirieng, giogiactudo, soluong, nct, yeucaurieng, tiendien, tiennuoc)
        {
        }
    }
}
