using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDongVat
{
    internal class ListAnimal
    {
        List<Animal> ds = new List<Animal>();
        
        public void Them(Animal n)
        {
            // Thêm đối tượng ThueBao mới vào danh sách 
            ds.Add(n);
        }

        public void NhapTuFile(string tenFile)
        {
            // Đọc dữ liệu từ một file
            // Tạo một
            StreamReader sr = new StreamReader(tenFile);
            string s = "";
            
            while ((s = sr.ReadLine()) != null)
            {
                if(s.Contains("CatFish"))
                {
                    Animal catfish = new CatFish(s);
                    ds.Add(catfish);
                }

                else if(s.Contains("Rabbit"))
                {
                    Animal rabbit = new Rabbit(s);
                    ds.Add(rabbit);
                }
            }
        }

        public void Xuat()
        {
            foreach (Animal n in ds)
            {
                Console.WriteLine(n);
               
            }
        }
    }
}
