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
        public override void Speak()
        {
            Console.WriteLine( "blub blub");
        }

        public void Eat()
        {
            Console.WriteLine("Cá con ");
        }

    }
}
