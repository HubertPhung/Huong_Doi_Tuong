using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDongVat
{
    internal class CatFish : Animal
    {
      
        public string Breed {  get; set; }
        public string Color { get; set; }
        public override void Speak()
        {
            Console.WriteLine( "blub blub");
        }

        public void Eat()
        {
            Console.WriteLine("Cá con ");
        }

        public CatFish()
        {
            
        }

        public CatFish(string name, int age, string breed, string color) : base(name, age)
        {
            Breed = breed;
            Color = color;
        }

        public CatFish(string tb) : base(tb)
        {
            string[] s = tb.Split(',');
            Color = s[3];
            Breed = s[2];
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Breed {0}\tColor {1}\t", Breed, Color);
        }
    }
}
