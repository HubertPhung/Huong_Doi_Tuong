using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyTreTraiCay
{
    public class QuanLyChe
    {
        List<Che> ds = new List<Che>();

        public void Them(Che x)
        {
            ds.Add(x);
        }

        public void DocFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line = " ";

            while ((line = sr.ReadLine()) != null)
            {
                string[] t = line.Split(',');
                if (t[0] == "Chè Thái")
                {
                    Che chethai = new CheThai(t[1], float.Parse(t[2]));
                    ds.Add(chethai);
                }
                else if (t[0] == "Chè Đậu Xanh")
                {
                    Che chedauxanh = new CheDauXanh(t[1], float.Parse(t[2]));
                    ds.Add(chedauxanh);
                }
            }
            sr.Close();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine($"{"LOẠI CHÈ",-16}{"NGUYÊN LIỆU",-50}{"CÂN NẶNG (KG) "}");
            for (var i = 0; i < ds.Count; i++)
            {
                sb.AppendLine(ds[i].ToString());
            }
            return sb.ToString();
        }

        public void Xuat()
        {
            Console.WriteLine(this);
        }
    }
}
