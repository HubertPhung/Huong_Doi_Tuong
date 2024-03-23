using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyDanhBa
{
    internal class DanhBa
    {
        List<ThueBao> collection = new List<ThueBao>();

        public void Xuat()
        {
            foreach (var item in collection)
            {
                item.Xuat();
            }
        }

        public void Them(ThueBao n)
        {
            collection.Add(n);
        }

        public void NhapTuFile(string tenFile)
        {
            
            StreamReader sr = new StreamReader(tenFile);
            string s = "";

            while ((s = sr.ReadLine()) != null)
            {
                ThueBao n = new ThueBao(s);
                collection.Add(n);
            }
        }

        public List<string> TimDSCacThanhPho()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                if(!kq.Contains(item.ThanhPho))
                {
                    kq.Add(item.ThanhPho);
                }
            }
            return kq;
        }

       

    }
}
