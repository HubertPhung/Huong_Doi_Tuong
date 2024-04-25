using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLiDongVatVaDaKeThua
{
    internal interface IAnimal
    {
        int Age { get; set; }
        string Name { get; set; }


        void Speak();
    }
}
