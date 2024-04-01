using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungQuanLyDanhBa
{
    internal class DanhBa
    {
        //Khởi tạo danh sách collection chứa các đối tượng ThueBao
        List<ThueBao> collection = new List<ThueBao>();

        public void Xuat()
        {
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

    }
}
