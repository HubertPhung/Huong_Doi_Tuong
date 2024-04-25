using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLiDongVatVaDaKeThua
{
    internal class Bat : IAnimal, IFlyable
    {
        public int Age { get; set; }
        public string Name { get; set; }    
        public Bat()
        {

        }

        public Bat(string t)
        {
            string[] s = t.Split(',');
            Age = int.Parse(s[2]);
            Name = s[1];
        }

        public Bat(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void Speak()
        {
            Console.WriteLine("Ex ex.....");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        public override string ToString()
        {
            return string.Format($"Kind :{"Bat"}\nName : {Name}\nAge : {Age}");
        }
    }
}
