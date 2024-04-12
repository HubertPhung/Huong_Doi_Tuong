using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyDanhBa
{
   
    enum GioiTinh
    {
        Nam ,
        Nu 
    }
    internal class ThueBao
    {
        List<DanhBa> db = new List<DanhBa>();

        string diaChi { get; set; }
        GioiTinh gioiTinh { get; set; }
        public string hoTen { get; set; }
        DateTime ngaySinh { get; set; }
        public string soDT { get; set; }
        string soCMND { get; set; }
        
       

        public ThueBao()
        {

        }
        public ThueBao(string diaChi, GioiTinh gioiTinh, string hoTen, DateTime ngaySinh, string soDT, string soCMND)
        {
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.soDT = soDT;
            this.soCMND = soCMND;
        }

        public ThueBao(string tb)
        {
            string[] s = tb.Split(',');
            soCMND = s[0];
            hoTen = s[1];
            ngaySinh = DateTime.Parse(s[2]);
            gioiTinh = (GioiTinh)(s[3] == "Nam" ? 1:0);
            soDT = s[4];
            diaChi = s[5];
        }

        

        public void Nhap(int n)
        {
           
                Console.Write("Nhap so CMND : ");
                soCMND = Console.ReadLine();

                Console.Write("Nhap ho va ten : ");
                hoTen = Console.ReadLine();

                Console.Write("Nhap Ngay/Thang/Nam sinh (dd/MM/yyyy): ");
                ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Nhap giai tinh (Nam/Nu): ");
                gioiTinh = Enum.Parse<GioiTinh>(Console.ReadLine());

                Console.Write("SDT : ");
                soDT = Console.ReadLine();

                Console.Write("Nhap dia chi : ");
                diaChi = Console.ReadLine();
                Console.WriteLine();

        }



        public void Xuat()
        {
            Console.WriteLine($"{soCMND,-10} {hoTen,-20} {ngaySinh.ToString("dd/MM/yyyy"),-15} {gioiTinh,-10} {soDT,-15} {diaChi}");

        }

        

        public string ThanhPho
        {
            get
            {
                int vt = diaChi.LastIndexOf('-');
                return diaChi.Substring(vt + 1, diaChi.Length - vt - 1);
            }
        }

       
   
    }
   

}
