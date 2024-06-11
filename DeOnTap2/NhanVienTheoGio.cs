using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOnTap2
{
    public class NhanVienTheoGio : INhanVien
    {
        List<string> _dscongviec;
        string _maso;
        int _namsinh;
        string _ten;
        int _tiengio;

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

        public int TienGio
        {
            get { return _tiengio; }
            set { _tiengio = value; }
        }

        public NhanVienTheoGio()
        {

        }

        public NhanVienTheoGio(List<string> dscongviec, string maso, int namsinh, string ten, int tiengio)
        {
            _dscongviec = dscongviec;
            _maso = maso;
            _namsinh = namsinh;
            _ten = ten;
            _tiengio = tiengio;
        }
        //TheoGio;TG44;Tran Lan Huong;1991;Truc van phong;4000
        public NhanVienTheoGio(string line)
        {
            string[] s = line.Split(';');
            this._maso = s[1];
            Ten = s[2].Trim();
            NamSinh = int.Parse(s[3]);
            TienGio = int.Parse(s[5]);
            string[] congviec = s[4].Split(',');
            this._dscongviec = new List<string>();
            for(int i = 0;i < congviec.Length; i++)
            {
                _dscongviec.Add(congviec[i].Trim());
            } 
        }

        public override string ToString()
        {
            string congviec = "";
            foreach(var i in _dscongviec)
            {
                congviec += i.ToString() + ", ";
            }
            return $"{"Theo Gio",-10}{MaSo,-10}{Ten,-20}{NamSinh,-10}{TienGio,-10}{congviec,-20}";
        }

    }
}
