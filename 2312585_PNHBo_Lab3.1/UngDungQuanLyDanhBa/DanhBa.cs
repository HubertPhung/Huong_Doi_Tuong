using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UngDungQuanLyDanhBa
{
    
    internal class DanhBa
    {
        //Khởi tạo danh sách collection chứa các đối tượng ThueBao
        List<ThueBao> collection = new List<ThueBao>();


        public void TieuDe()
        {
            Console.WriteLine("CMND".PadRight(11) + "Ho Ten".PadRight(21) + "Ngay Sinh".PadRight(16) + "Gioi Tinh  " + "SDT ".PadRight(20) + "Dia Chi ".PadRight(10));
        }

        public void Nhap(int n)
        {
            ThueBao thueBao = new ThueBao();
            thueBao.Nhap(n);
            collection.Add(thueBao);
            
        } 
        public void Xuat()
        {
            TieuDe();
            // Duyệt qua tất cả các đối tượng trong danh sách collection
            foreach (var item in collection)
            {
                // Gọi hàm xuất của đối tượng ThueBao
                item.Xuat();
            }
        }

        public void Them(ThueBao n)
        {
            // Thêm đối tượng ThueBao mới vào danh sách 
            collection.Add(n);
        }

        public void NhapTuFile(string tenFile)
        {
            // Đọc dữ liệu từ một file
            // Tạo một
            StreamReader sr = new StreamReader(tenFile);
            string s = "";

            while ((s = sr.ReadLine()) != null)
            {
                ThueBao n = new ThueBao(s);
                collection.Add(n);
            }
        }

        public List<string> TimDSCacThanhPho()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                if(!kq.Contains(item.ThanhPho))
                {
                    kq.Add(item.ThanhPho);
                }
            }
            return kq;
        }

        public int DemSoThueBaoTheoTP(string tp)
        {
            int dem = 0;
            foreach (var item in collection)
            {
                if (item.ThanhPho == tp)
                    dem++;
            }
            return dem;
        }
       
        public List<string> TimTPCoNhieuThueBaoNhat()
        {
            List<string> kq = new List<string>();
            List<string> dstp = TimDSCacThanhPho();
            int max = int.MinValue;
            foreach (var item in dstp)
            {
                if (max < DemSoThueBaoTheoTP(item))
                    max = DemSoThueBaoTheoTP(item);
            }
            //Console.WriteLine(" Max = " + max);
            foreach(var tp in dstp)
            {
                if(DemSoThueBaoTheoTP(tp) == max)
                    kq.Add((tp)); 
            }
            return kq;
        }

        //public List<string> TimSoDT(string x)
        //{
        //    List<string> kq = new List<string>();
        //    foreach (var item in collection)
        //    {
        //        if (item.soDT == x)
        //            kq.Add(item.ThanhPho);
        //    }
        //    return kq;
        //}

        //public List<string> TimAllTPCoSoThueBaoX(string x)
        //{
        //    List<string> kq = new List<string>();
        //    List<string> dstp = TimDSCacThanhPho();
        //    foreach(var item in dstp)
        //    {
        //        if (TimSoDT(x).Count > 0)
        //            kq.Add(item);
        //    }
        //    return kq;
        //}

        public List<string> TimAllTPCoSoThueBaoX(string x)
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                if (item.soDT == x)
                    kq.Add(item.ThanhPho);
            }
            return kq;
        }

        public List<string> TimTPCoItThueBaoNhat()
        {
            List<string> kq = new List<string>();
            List<string> dstp = TimDSCacThanhPho();
            int min = int.MaxValue;
            foreach (var item in dstp)
            {
                if (min > DemSoThueBaoTheoTP(item))
                    min = DemSoThueBaoTheoTP(item);
            }
            
            foreach (var tp in dstp)
            {
                if (DemSoThueBaoTheoTP(tp) == min)
                    kq.Add((tp));
            }
            return kq;
        }


        // sellection Sort



        bool CompareRecordsTang(ThueBao record1, ThueBao record2)
        {
            // So sánh theo tên
            int nameComparison = string.Compare(record1.hoTen, record2.hoTen, StringComparison.OrdinalIgnoreCase);
            // StringComparison.OrdinalIgnoreCase giúp so sánh chuỗi mà không cần phân biệt chữ hoa và chữ thường.
            if (nameComparison != 0)
                return nameComparison < 0;

            // Nếu tên giống nhau, so sánh theo số điện thoại
            return string.Compare(record1.soDT, record2.soDT, StringComparison.OrdinalIgnoreCase) < 0;
        }

        public void SapXepTangTheoHoTenDienThoai()
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (CompareRecordsTang(collection[i], collection[j]))
                    {
                        // Hoán vị hai bản ghi
                        ThueBao temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;

                    }
                }
            }
        }

        bool CompareRecordsGiam(ThueBao record1, ThueBao record2)
        {
            // So sánh theo tên
            int nameComparison = string.Compare(record1.hoTen, record2.hoTen, StringComparison.OrdinalIgnoreCase);
            // StringComparison.OrdinalIgnoreCase giúp so sánh chuỗi mà không cần phân biệt chữ hoa và chữ thường.
            if (nameComparison != 0)
                return nameComparison > 0;

            // Nếu tên giống nhau, so sánh theo số điện thoại
            return string.Compare(record1.soDT, record2.soDT, StringComparison.OrdinalIgnoreCase) > 0;
        }

        public void SapXepGiamTheoHoTenDienThoai()
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (CompareRecordsGiam(collection[i], collection[j]))
                    {
                        // Hoán vị hai bản ghi
                        ThueBao temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;

                    }
                }
            }
        }
        //6.	Hiển thị danh sách các thành phố theo chiều tăng, giảm của số lượng thuê bao.
        
        //public struct ThongKe
        //{
        //    string tenTP;
        //    int soLuong;

        //    public ThongKe(string tenTP, int soLuong)
        //    {
        //        this.TenTP = tenTP;
        //        this.SoLuong = soLuong;
        //    }

        //    public string TenTP { get => tenTP; set => tenTP = value; }
        //    public int SoLuong { get => soLuong; set => soLuong = value; }
        //}
        //List<ThongKe> thongKes = new List<ThongKe>();

       
        public List<string> XuatTBTheoTP()
        {
            Console.WriteLine("Thanh Pho".PadLeft(1) + "So Luong".PadLeft(10));
            List<string> list = new List<string>();
            List<string> dstp = TimDSCacThanhPho();
            foreach (var item in dstp)
            {
                Console.WriteLine($"{item,-13} {DemSoThueBaoTheoTP(item)}");
                list.Add(item);
            }
            return list;
            
        }

       



        //7.	Hiển thị danh bạ theo chiều tăng, giảm của các trường trong thuê bao.
        //bool soSanhTangTheoHoTen(ThueBao records1, ThueBao records2)
        //{
        //    return string.Compare(records1.hoTen, records2.hoTen) < 0; 
        //}

        //bool soSanhGiamTheoHoTen(ThueBao records1, ThueBao records2)
        //{
        //    return string.Compare(records1.hoTen, records2.hoTen) > 0;
        //}
        public void SapXepHoTenTang()
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[i].hoTen.CompareTo(collection[j].hoTen) < 0)
                    {
                        ThueBao temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;
                    }
                        
                }
            }
        }
    }
}
