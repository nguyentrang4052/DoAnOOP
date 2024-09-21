using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class TienIch
    {
        public static string VietHoaChuDau(string ten)
        {
            string[] tam = ten.Split(' ');
            ten = "";
            foreach (var tu in tam)
                ten += tu.Substring(0, 1).ToUpper() + tu.Substring(1).ToLower() + " ";
            ten = ten.Substring(0, ten.Length - 1);
            return ten;
        }
        public static void InNhieuChuoi(string[] dschuoi)
        {
            int d = 0;
            foreach (var chuoi in dschuoi)
            {
                Console.WriteLine(d + "." + chuoi);
                d++;
            }
        }
    }
}
