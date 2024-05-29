using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyTreTraiCay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyChe ds = new QuanLyChe();
            ds.DocFile("TextFile1.txt");
            ds.Xuat();
            Console.ReadKey();
        }
    }
}
