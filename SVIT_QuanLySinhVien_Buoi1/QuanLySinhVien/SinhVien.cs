using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public enum GioiTinh
    {
        Nam = 1,
        Nu = 2,
        Khac = 3
    }
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }

        public GioiTinh GioiTinh { get; set; }


        //Overloaded methods là những cái phương thức cùng tên nhưng mà khác tham số
        public SinhVien()
        {

        }
        public SinhVien(string mSSV, string hoTen, DateTime ngaySinh, GioiTinh gioiTinh)
        {
            MSSV = mSSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
        }

        //Ghi đè phương thức ToString của lớp Object
        public override string ToString()
        {
            //Chuỗi nội suy
            return $"{MSSV}\t{HoTen}\t{NgaySinh.ToString("ddd, dd/MM/yyyy")}\t{GioiTinh}";
            
        }


    }
}
