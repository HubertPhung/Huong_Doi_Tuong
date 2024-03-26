using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyDanhBa
{
   
    enum GioiTinh
    {
        Nam,
        Nu
    }
    internal class ThueBao
    {
        List<DanhBa> db = new List<DanhBa>();

        string diaChi;
        GioiTinh gioiTinh;
        string hoTen;
        DateTime ngaySinh;
        string soDT;
        string soCMND;
        
       

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



        public void Xuat()
        {
            Console.WriteLine("{0, 1} {1, 10} {2, 15} {3, 10} {4, 10} {5, 10}", soCMND, hoTen, ngaySinh.ToString("dd/MM/yyyy"), gioiTinh, soDT, diaChi);
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
