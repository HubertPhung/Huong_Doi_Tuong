using System.Text;
using static System.Console;

namespace _2312805_lab1_PhanD
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ChayChuongTrinh();
        }
        static void ChayChuongTrinh()
        {
            Menu mn = new Menu();
            int chon;
            do
            {
                Clear();
                mn.XuatMenu();
                chon = (int)mn.ChonMenu();
                mn.XuLyMenu((Menu.MenuCT)chon);
                if (chon < ((int)Menu.MenuCT.Thoat) || ((int)Menu.MenuCT.SapTang) < chon)
                    break;
            } while (chon != 0);
        }
    }
}