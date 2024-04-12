using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDongVat
{
     internal class Rabbit : Animal
    {
       

        public string Color { get; set; }

        public string Species { get; set; }

        public override void Speak()
        {
            Console.WriteLine("Măm măm");
        }
        public Rabbit()
        {

        }

        public void Eat()
        {
            Console.WriteLine("Carrot... măm măm");
        }

        public Rabbit(string name, int age, string color, string species) : base (name, age)
        {
            Color = color;
            Species = species;
        }

        public Rabbit(string tb) : base(tb)
        {
            string[] s = tb.Split(',');
            Color = s[3];
            Species = s[2];
        }

        public override string ToString() 
        {
            return base.ToString() + String.Format("Species {0}\tColor {1}\t", Species, Color );
        }
    }
}
