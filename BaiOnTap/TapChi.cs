using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTap
{
    public class TapChi : IAnPham
    {
        // Fields
        float giaTien;
        string ten;
        string nhaXuatBan;
        public string DiaChi;

        // Properties
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

        // Constructors
        public TapChi()
        {

        }
        public TapChi(string ten, string nhaXuatBan, float giaTien, string diaChi)
        {
            Ten = ten;
            this.nhaXuatBan = nhaXuatBan;
            this.giaTien = giaTien;
            DiaChi = diaChi;
        }

        public TapChi(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1].Trim();
            this.nhaXuatBan = s[2].Trim();
            this.giaTien = int.Parse(s[3].Trim());
            DiaChi = s[4].Trim();
        }

        public override string ToString()
        {
            //return $"{"Tạp Chí",-10}{Ten,-20}{NhaXuatBan,-25}{GiaTien,-15}{DiaChi}";
            return string.Format("{0,-10}{1,-20}{2,-25}{3,-15}{4}", "Tạp chí", ten, nhaXuatBan, giaTien, DiaChi);
        }
    }
}
