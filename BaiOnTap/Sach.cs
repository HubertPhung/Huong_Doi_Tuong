using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTap
{
    public class Sach : IAnPham
    {
        // Fields
        float giaTien;
        string ten;
        string nhaXuatBan;
        public int SoTrang;

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
        public Sach()
        {

        }
        public Sach(string ten, string nhaXuatBan, float giaTien, int soTrang)
        {
            Ten = ten;
            this.nhaXuatBan = nhaXuatBan;
            this.giaTien = giaTien;
            SoTrang = soTrang;
        }

        // 
        public Sach(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1].Trim();
            this.nhaXuatBan = s[2].Trim();
            SoTrang = int.Parse(s[4].Trim());
            this.giaTien = float.Parse(s[3].Trim());
        }

        // Override
        public override string ToString()
        {
            //return $"{"Sách",-10}{Ten,-20}{NhaXuatBan,-25}{GiaTien,-15}{SoTrang}";
            return string.Format("{0,-10}{1,-20}{2,-25}{3,-15}{4}", "Sách", ten, nhaXuatBan, giaTien, SoTrang);
        }
    }
}
