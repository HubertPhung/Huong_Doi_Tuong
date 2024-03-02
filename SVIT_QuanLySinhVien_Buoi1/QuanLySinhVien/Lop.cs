using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Lop
    {
        // Fields
        public List<SinhVien> DanhSachSV { get; set; }

        //Properties
        public string TenLop { get; set; }
        
        public int SiSo
        {
            get {  return DanhSachSV.Count;}
        }
        public Lop()
        {
            DanhSachSV = new List<SinhVien>();
        }

        public Lop(string tenLop)
        {
            TenLop = tenLop;
            DanhSachSV = new List<SinhVien> ();
        }

        public void ThemSV(SinhVien sinhVien)
        {
            DanhSachSV.Add(sinhVien);
        }

        public void NhapDuLieu(string tenTapTin)
        {
            StreamReader sr = new StreamReader(tenTapTin);
            string line;
            while(!string.IsNullOrEmpty(line=sr.ReadLine()))
            {
                string [] Arr =line.Split(';');// Dựa vào ; để tách chuỗi
                ThemSV(new SinhVien(Arr[0],
                    Arr[1],
                    DateTime.ParseExact(Arr[2], "dd/M/yyyy", CultureInfo.InvariantCulture),
                    Arr[3] == "Nam" ? GioiTinh.Nam : GioiTinh.Nu));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Danh sách sinh viên lớp : {TenLop}");
            //foreach (SinhVien sinhVien in DanhSachSV)
            //{
            //    sb.AppendLine( sinhVien.ToString() );
            //}
            for (int i = 0;i <DanhSachSV.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {DanhSachSV[i]}");
            }
            return sb.ToString();
        }
    }
}
