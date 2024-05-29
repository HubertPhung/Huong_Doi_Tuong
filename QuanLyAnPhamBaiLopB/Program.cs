using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312805_TNNY_Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu mn = new Menu();
            mn.ChayChuongTrinh();
            //DanhSachAnPham ds = new DanhSachAnPham();
            //ds.NhapTuFile();
            //Console.WriteLine(ds);
            //ds.SapXepTheoTen();
            //Console.WriteLine(" An pham co gia cao nhat " + ds.TimAnPhamCoGiaCaoNhat());
            //Console.WriteLine("Sap xep tang theo ten \n" + ds);
            //ds.SapXepTheoGia();
            //Console.WriteLine("Sap xep tang theo gia\n" + ds);
            //ds.SapXep(SoSanhGiamGia);
            //Console.WriteLine("Sap xep giam theo gia\n" + ds);
            //Console.ReadKey();
        }
        //static int SoSanhGiamGia(object a, object b)
        //{
        //    IAnPham ap1 = (IAnPham)a;
        //    IAnPham ap2 = (IAnPham)b;
        //    return -ap1.GiaTien.CompareTo(ap2.GiaTien);
        //}
    }
}
