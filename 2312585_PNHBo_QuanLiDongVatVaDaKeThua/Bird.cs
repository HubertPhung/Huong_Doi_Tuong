using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLiDongVatVaDaKeThua
{
    internal class Bird : IAnimal, IFlyable
    {
        public Bird(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public Bird() { }

        public Bird(string t)
        {
            string[] s = t.Split(',');
            Age = int.Parse(s[2]);
            Name = s[1];
        }
        public void Speak()
        {
            Console.WriteLine("Tweet.....");
        }
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        public override string ToString()
        {
            return string.Format($"Kind :{"Bird"}\nName : {Name}\nAge : {Age}");
        }
    }
}
