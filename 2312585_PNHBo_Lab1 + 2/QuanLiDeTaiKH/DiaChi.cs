using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDeTaiKH
{
    internal class DiaChi
    {
        public string SoNha;
        public string Duong;
        public string Quan;
        public string ThanhPho;

        public DiaChi(string soNha, string duong, string quan, string thanhPho)
        {
            SoNha = soNha;
            Duong = duong;
            Quan = quan;
            ThanhPho = thanhPho;
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Dia chi: {SoNha} {Duong}, Quan {Quan}, Thanh pho {ThanhPho}");
        }
    }
}
