using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class PhanSo
    {
        public int tu;
        public int mau;
        public PhanSo() {
            mau = 1;
        }
        public PhanSo(int t, int m)
        {
            tu = t;
            mau = m;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap tu : ");
            tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau : ");
            mau = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($" {tu} / {mau}");
        }
        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau + b.tu * a.mau;
            kq.mau = a.mau * b.mau;
            return kq;
        }

        public PhanSo Tru(PhanSo a)
        {
            PhanSo kq = new PhanSo();
            kq.tu = this.tu * a.mau - a.tu * this.mau;
            kq.mau = a.mau * this.mau;
            return kq;
        }

        public PhanSo Nhan(PhanSo a)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * this.tu;
            kq.mau = a.mau * this.mau;
            return kq;
        }
        public PhanSo Chia(PhanSo a)
        {
            PhanSo kq = new PhanSo();
            kq.tu = this.tu * a.mau;
            kq.mau = this.mau * a.tu;
            return kq;
        }
        public int UCLN()
        {
            int x = this.tu;
            int y = this.mau;

            while (x!=y)
            {
                if (x > y) x -= y;
                else y -= x;

            }
            return x;
        }

        public PhanSo ToiGian()
        {
            PhanSo kq = new PhanSo();
            int ucln = this.UCLN();
            kq.tu = this.tu / ucln;
            kq.mau = this.mau / ucln;
            return kq;
        }

        public static PhanSo operator + (PhanSo a, PhanSo b)
        {
            return a.Cong(a, b);
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return a.Tru(b);
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return a.Nhan(b);
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            return a.Chia(b);
        }
        
        public static PhanSo operator %(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau % (b.tu * a.mau);
            kq.mau = a.mau * b.mau;
            return kq;
        
        }
    }
}
