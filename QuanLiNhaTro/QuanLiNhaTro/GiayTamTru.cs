using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    internal class GiayTamTru
    {
        private ConNguoi nguoitamtru;
        private string noitamtru;
        public GiayTamTru(ConNguoi nguoitamtru, string noitamtru)
        {
            this.nguoitamtru = nguoitamtru;
            this.noitamtru = noitamtru;
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Giay tam tru:");
            Console.Write("Nguoi tam tru: ");
            nguoitamtru.XuatThongTin();
            Console.WriteLine("Dia chi noi tam tru: " + noitamtru);
        }
    }
}
