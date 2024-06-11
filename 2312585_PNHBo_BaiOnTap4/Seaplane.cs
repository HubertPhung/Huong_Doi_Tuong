using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_BaiOnTap4
{
    public class Seaplane : Vehicle, IFloatable, IFlyable
    {

        public int Buom { get; set; }
        public float DoCao { get; set; }
        public int PhanLuc { get; set; }
        public int Canh { get; set; }

        public Seaplane(string loai, string ten, string hang, float tocDo, int nhienLieu, int buom, float doCao, int phanLuc, int canh) : base(loai, ten, hang, tocDo, nhienLieu)
        {

            Buom = buom;
            DoCao = doCao;
            PhanLuc = phanLuc;
            Canh = canh;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Buom,-10} {DoCao,-10} {PhanLuc,-10} {Canh,-10}";
        }

    }
}
