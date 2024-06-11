using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOnTap2
{
    public class NhanVienHopDong : INhanVien
    {
        
        List<string> _dsNguoiThan;
        float _hesoluong;
        string _maso;
        int _namsinh;
        string _ten;

        public float HeSoLuong
        {
            get { return _hesoluong; }
            set { _hesoluong = value;}
        }

        public string MaSo
        {
            get { return _maso; }
           
        }

        public int NamSinh
        {
            get { return _namsinh; }
            set { _namsinh = value; }
        }

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        public List<string> DsNguoiThan
        {
            get { return _dsNguoiThan; }
        }

        public NhanVienHopDong()
        {

        }

        public NhanVienHopDong(List<string> dsNguoiThan, float hesoluong, string maso, int namsinh, string ten, float heSoLuong, int namSinh)
        {
            _dsNguoiThan = dsNguoiThan;
            _hesoluong = hesoluong;
            _maso = maso;
            _namsinh = namsinh;
            this._ten = ten;
            HeSoLuong = heSoLuong;
            NamSinh = namSinh;
        }
        //HopDong;HD10;Nguyen Lan Anh;1998;Nguyen Bao, Le Thi Lan; 3.4 
        public NhanVienHopDong(string line)
        {
            string[] s = line.Split(';');
            this._maso = s[1];
            Ten = s[2].Trim();
            NamSinh = int.Parse(s[3]);
            string[] nguoithan = s[4].Split(',');
            this._dsNguoiThan = new List<string>();
            for(int i = 0; i < nguoithan.Length; i++)
            {
                this._dsNguoiThan.Add(nguoithan[i].Trim());
            }
            HeSoLuong = float.Parse(s[5]);
        }

        public override string ToString()
        {
            string nguoithan = string.Join(", ",_dsNguoiThan);
            return $"{"Hop Dong",-10}{MaSo,-10}{Ten,-20}{NamSinh,-10}{HeSoLuong,-10}{nguoithan,-20}";
        }
    }
}
