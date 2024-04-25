using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLiDongVatVaDaKeThua
{
    internal class Lion : IAnimal
    {
        public Lion(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public void Speak()
        {
            Console.WriteLine("Roar.....");
        }

        public Lion()
        {
   
        }
        public Lion(string t)
        {
            string[] s = t.Split(',');
            Age = int.Parse(s[2]);
            Name = s[1];
        }

        public override string ToString()
        {
            return string.Format($"Kind :{"Lion"}\nName : {Name}\nAge : {Age}");
        }
    }
}
