using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_BaiOnTap3
{
    public class ThanhPho : IThanhPho
    {
        public string MaTP { get; set; }
        public string TenTP { get; set; }

        public ThanhPho(string maTP, string tenTP)
        {
            MaTP = maTP;
            TenTP = tenTP;
        }

        public override string ToString()
        {
            return $"MaTP: {MaTP}, TenTP: {TenTP}";
        }
    }

}
