using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_BaiOnTap2
{
    public enum Selector
    {
        Ho,
        Ten,
        NhanVienID,
        Phong,
        Luong
    }

    public enum Sort
    {
        Tang,
        Giam
    }
    public class DanhSachNhanVien : IComparer<INhanVien>
    {
        public List<INhanVien> collection = new List<INhanVien>();
        public Selector ThuocTinh {  get; set; }

        public INhanVien this[int index]
        {
            get { return collection[index]; }
            set { collection[index] = value; }
        }
        public void Them(INhanVien nhanVien)
        {
            collection.Add(nhanVien);
        }

        public void Xoa(INhanVien nhanVien)
        {
            collection.Remove(nhanVien);
        }

        public void DocFile()
        {
            StreamReader sr = new StreamReader("data.txt");
            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] s = line.Split(',');
                string ho = s[0];
                string ten = s[1];
                int nhanVienID = int.Parse(s[2]);
                string phong = s[3];
                double luong = double.Parse(s[4]);
                INhanVien temp = new QuanLy(ten, ho,nhanVienID,phong,luong);
                Them(temp);
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(new string('-',40));
            Console.WriteLine($"{"Họ",-6} {"Tên",-8} {"ID",-5} {"Phòng",-10} {"Lương $",-10}");
            Console.WriteLine(new string('-', 40));
            foreach (var i in collection)
            {
                sb.AppendLine(i.ToString());
            }
            return sb.ToString();
        }

        public void Xuat()
        {
            Console.WriteLine(this);
        }

        //	Phương thức nhập thủ công
        public void NhapThuCong()
        {
            Console.Write("Nhập số Nhân Viên cần nhập : ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n ; i++)
            {
                Console.Write("Nhập Họ :");
                string ho = Console.ReadLine();

                Console.Write("Nhập Tên :");
                string ten = Console.ReadLine();

                Console.Write("Nhập ID :");
                int nhanVienID = int.Parse(Console.ReadLine());

                Console.Write("Nhập Phòng :");
                string phong = Console.ReadLine();

                Console.Write("Nhập Lương : ");
                double luong = double.Parse(Console.ReadLine());

                INhanVien nhanVien = new QuanLy(ten,ho,nhanVienID,phong,luong);
                Them(nhanVien);
            }

        }
        // Tim kiem

        public DanhSachNhanVien TimKiem(object x)
        {
            DanhSachNhanVien kq = new DanhSachNhanVien();
            foreach(var obj in collection)
            {
                switch (ThuocTinh)
                {
                    case Selector.Ho:
                        if ((obj as QuanLy).Ho.Equals(x.ToString(), StringComparison.OrdinalIgnoreCase))
                            kq.Them(obj);
                        break;
                    case Selector.Ten:
                        if ((obj as QuanLy).Ten.Equals(x.ToString(), StringComparison.OrdinalIgnoreCase))
                            kq.Them(obj);
                        break;
                    case Selector.NhanVienID:
                        if (obj.NhanVienID.Equals((int)x))
                            kq.Them(obj);
                        break;
                    case Selector.Phong:
                        if (obj.Phong.Equals(x.ToString(), StringComparison.OrdinalIgnoreCase))
                            kq.Them(obj);
                        break;
                    case Selector.Luong:
                        if (obj.Luong.Equals((double)x))
                            kq.Them(obj);
                        break;
                }
            }
            return kq;
        }

        // Sap Xep
        public void HoanVi(int a , int b)
        {
            INhanVien temp = collection[a];
            collection[a] = collection[b];
            collection[b] = temp;

        }

        public void SapXep(Sort sort)
        {
            int n = collection.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (Compare(this[i], this[j]) > 0 && sort == Sort.Tang)
                    {
                        HoanVi(i, j);
                    }
                    else if (Compare(this[i], this[j]) < 0 && sort == Sort.Giam)
                    {
                        HoanVi(i, j);
                    }
                }
            }
        }

        public int Compare(INhanVien x, INhanVien y)
        {
            switch (ThuocTinh)
            {
                case Selector.Ho:
                    return (x as QuanLy).Ho.CompareTo((y as QuanLy).Ho);
                case Selector.Ten:
                    return (x as QuanLy).Ten.CompareTo((y as QuanLy).Ten);
                case Selector.NhanVienID:
                    return (x as QuanLy).NhanVienID.CompareTo((y as QuanLy).NhanVienID);
                case Selector.Phong:
                    return (x as QuanLy).Phong.CompareTo((y as QuanLy).Phong);
                case Selector.Luong:
                    return (x as QuanLy).Luong.CompareTo((y as QuanLy).Luong);
                default:
                    return 0;
            }
        }

        //  Cap Nhat
        public void CapNhat(int vt, Object thongTinMoi)
        {
            INhanVien nv = this[vt];
            switch (ThuocTinh)
            {
                case Selector.Ho:
                    (nv as QuanLy).Ho = thongTinMoi.ToString();
                    break;
                case Selector.Ten:
                    (nv as QuanLy).Ten = thongTinMoi.ToString();
                    break;
                case Selector.NhanVienID:
                    nv.NhanVienID = (int)thongTinMoi;
                    break;
                case Selector.Phong:
                    nv.Phong = thongTinMoi.ToString();
                    break;
                case Selector.Luong:
                    nv.Luong = (double)thongTinMoi;
                    break;
            }
        }

        // Xoa
        public void XoaTheoThuocTinh(object x)
        {
            var ds = TimKiem(x);
            foreach(var d in ds.collection)
            {
                Xoa(d);
            }
        }

        // 5. Thêm tính năng lọc nhân viên theo phòng ban và hiển thị danh sách nhân viên thuộc phòng ban cụ thể.
        //6. Viết phương thức để lọc và hiển thị danh sách các nhân viên thuộc một phòng ban xác định.
        public DanhSachNhanVien LocNhanVienTheoPhong(string phong)
        {
            DanhSachNhanVien kq = new DanhSachNhanVien(); 
            foreach (var i in collection)
            {
                if (i.Phong == phong)
                {
                    kq.Them(i);
                }
            }
            return kq;
        }

        // 13.	Thêm tính năng tính toán và hiển thị tổng số lương của tất cả nhân viên.
        //14.	Viết phương thức để tính toán và hiển thị tổng số lương của tất cả nhân viên trong danh sách.
        public double TongLuongALLNhanVien()
        {
            double sum = 0;
            foreach (var i in collection)
            {
                sum += i.Luong;
            }
            return sum;
        }

        //15.	Viết phương thức sắp xếp danh sách nhân viên theo tên và hiển thị danh sách sau khi sắp xếp.
        //16.	Phương thức này sẽ sắp xếp danh sách nhân viên theo tên (tăng dần hoặc giảm dần) và hiển thị kết quả.
        //17.	Từ các thuộc tính của các lớp mới bổ sung, xây dựng các phương thức tương ứng như tìm kiếm, sắp xếp, cập nhật, thêm, xóa, sửa…

    }
}
