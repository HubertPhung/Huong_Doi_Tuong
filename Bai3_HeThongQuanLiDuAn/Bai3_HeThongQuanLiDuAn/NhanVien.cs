using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_HeThongQuanLiDuAn
{
    /// <summary>
    /// Nhân viên
    /// </summary>
    internal class NhanVien
    {
        // fields
        private string Ho;
        private string Ten;
        private string MaSo;
        private string DiaChi;
        private float Luong;
        private string GioiTinh;
        private DateTime NgaySinh;

        //properties

        // Constructor (Khởi tạo)

        // Phương thức khởi tạo (mặc định) không có tham số
        public NhanVien()
        {
            
        }

        // Phương thức khởi tạo có tham số
        public NhanVien(string ho, string ten, string maSo, string diaChi, float luong, string gioiTinh, DateTime ngaySinh)
        {
            Ho = ho;
            Ten = ten;
            MaSo = maSo;
            DiaChi = diaChi;
            Luong = luong;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }
    }
}
