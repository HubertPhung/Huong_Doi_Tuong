using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DeOnTap2
{
    public enum Sort
    {
        TangNamSinh,
        GiamNamSinh,
    }
    public class DanhSachNhanVien : IComparer<INhanVien>
    {
        List<INhanVien> dsnhanvien = new List<INhanVien>();
        public Sort KieuSapXep {  get; set; }
        public INhanVien this[int index]
        {
            get { return dsnhanvien[index]; }
            set { dsnhanvien[index] = value; }
        }

        public DanhSachNhanVien()
        {
            dsnhanvien = new List<INhanVien>();
        }

        public void Them(INhanVien tailieu)
        {
            dsnhanvien.Add(tailieu);
        }

        public void NhapTuFile(string filename = "dsnhanvien.txt")
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] s = line.Split(';');
                if (s[0] == "HopDong")
                {
                    Them(new NhanVienHopDong(line));
                }
                else if (s[0] == "TheoGio")
                {
                    Them(new NhanVienTheoGio(line));
                }
            }
            sr.Close();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var i in dsnhanvien)
            {
                sb.AppendLine(i.ToString());
            }
            return sb.ToString();
        }

        public void Xuat()
        {
            Console.WriteLine(this);
        }

        //Tìm những nhân viên lớn tuổi nhất. 
        public int TimNhanVienTuoi_Max()
        {
            int max = int.MaxValue;
            for(int i = 0; i < dsnhanvien.Count; i++)
            {
                if(this[i].NamSinh < max)
                    max = this[i].NamSinh;
            }
            return max;
        }

        public DanhSachNhanVien TimTuoiNhanVien(int tuoi)
        {
            DanhSachNhanVien kq = new DanhSachNhanVien();
            foreach (var i in dsnhanvien)
            {
                if(i.NamSinh == tuoi)
                {
                    kq.Them(i);
                }
            }
            return kq;
        }


        //Sắp xếp danh sách nhân viên tăng theo năm sinh. 
        public void HoanVi(int a , int b)
        {
            INhanVien temp = this[a];
            this[a] = this[b];
            this[b] = temp;
        }
        public int Compare(INhanVien x, INhanVien y)
        {
            if(KieuSapXep == Sort.TangNamSinh)
            {
                return x.NamSinh.CompareTo(y.NamSinh);
            }   
            return 0;
        }

        public void SapXep()
        {
            for(int i = 0; i< dsnhanvien.Count - 1; i++)
            {
                for(int j = i +1; j <  dsnhanvien.Count; j++)
                {
                    if (Compare(this[i], this[j]) > 0)
                    {
                        HoanVi(i, j);
                    }
                }
            }
        }

        //Xóa nhân viên theo tên (tenNV) cho trước. 
        public DanhSachNhanVien TimTen(string ten)
        {
            DanhSachNhanVien kq = new DanhSachNhanVien();
            foreach(var i in dsnhanvien)
            {
                if (i.Ten.Equals(ten, StringComparison.OrdinalIgnoreCase))
                {
                    kq.Them(i);
                }
            }
            return kq;
        }

        public void XoaTheoTen(string ten)
        {
            var dscanxoas = TimTen(ten);

            foreach (var i in dscanxoas.dsnhanvien)
            {
                dsnhanvien.Remove(i);
            }
        }

        //Tìm những tên nhân viên có người thân làm cùng. 
        //Liệt kê danh sách năm sinh và số nhân viên tương ứng.
        public Dictionary<int, List<string>> DanhSachNamVaSoNhanVien()
        {
            Dictionary<int, List<string>> namsinhsonhanvien = new Dictionary<int, List<string>>();
            foreach(var i in dsnhanvien)
            {
                if (!namsinhsonhanvien.ContainsKey(i.NamSinh))
                {
                    namsinhsonhanvien[i.NamSinh] = new List<string>();
                }
                namsinhsonhanvien[i.NamSinh].Add(i.MaSo);
            }
            return namsinhsonhanvien;
        }


    }
}
