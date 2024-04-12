using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDongVat
{
    internal class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        

        public virtual void  Speak()
        {
            Console.WriteLine("Thú đang kêu....");
        }

        public  Animal()
        {

        }
    
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
           
        }

        public Animal(string tb)
        {
            string[] s = tb.Split(',');
            Name = s[0];
            Age = int.Parse(s[1]);
            
        }

        public override string ToString()
        {
            return String.Format("Name {0} \tAge {1}\t", Name, Age);
        }

    }
}
