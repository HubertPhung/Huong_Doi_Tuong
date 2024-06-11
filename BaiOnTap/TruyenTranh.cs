using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTap
{
    public class TruyenTranh : IAnPham
    {
        

        float giaTien { get; }
        string nhaXuatBan { get; }
        string ten { get; set; }

        public TruyenTranh(float giaTien, string nhaXuatBan, string ten)
        {
            this.giaTien = giaTien;
            this.nhaXuatBan = nhaXuatBan;
            this.ten = ten;
        }

        public float GiaTien
        {
            get
            {
                return giaTien;
            }
        }
        public string NhaXuatBan
        {
            get
            {
                return nhaXuatBan;
            }
        }
        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public TruyenTranh (String line)
        {
            string[] s = line.Split(',');
            Ten = s[1].Trim();
            this.nhaXuatBan = s[2].Trim();
            this.giaTien = float.Parse(s[3]);

        }

        public override string ToString()
        {
            return $"{"Truyen Tranh",-10}{Ten,-20}{nhaXuatBan,-25}{GiaTien}";
        }

    }
}
