using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTap
{
    public enum Selector
    {
        Ten,
        TenGiam,
        GiaTien,

    }
    public delegate int SoSanh(IAnPham a, IAnPham b);
    public class DanhSachAnPham : IComparer<IAnPham>
    {
        List<IAnPham> collection = new List<IAnPham>();

        // Indexer
        public IAnPham this[int index]
        {
            get { return collection[index]; }
            set { collection[index] = value; }
        }

        public Selector ThuocTinh { get; set; }
        public void Them(IAnPham anPham)
        {
            collection.Add(anPham);
        }

        public void DocFile(string filename = "dsanpham.txt")
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] s = line.Split(',');
                if (s[0] == "Sach")
                {
                    Them(new Sach(line));
                }
                else if (s[0] == "Tap chi")
                {
                    Them(new TapChi(line));
                }
                else if(s[0] =="Truyen Tranh")
                {
                    Them(new TruyenTranh(line));
                }
            }
            sr.Close();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
        #region TimMax_Min
        // Giá bao nhiêu mới được gọi là lớn nhất
        public float TimGiaTienLonNhat()
        {
            // float max = collection[0].GiaTien;
            float max = 0;
            for (int i = 1; i < collection.Count; i++)
            {
                if (this[i].GiaTien > max)
                    max = this[i].GiaTien;
            }
            return max;
        }

        public float TimGiaTienNhoNhat()
        {
            // float max = collection[0].GiaTien;
            float min = int.MaxValue;
            for (int i = 1; i < collection.Count; i++)
            {
                if (this[i].GiaTien < min)
                    min = this[i].GiaTien;
            }
            return min;
        }

        public DanhSachAnPham TimAnPhamTheoGia(float giaTien)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach (var i in collection)
            {
                if (i.GiaTien == giaTien)
                    kq.Them(i);
            }
            return kq;
        }
        #endregion
        #region SapXep
        // Sap xep 

        public void HoanVi(int a, int b)
        {
            IAnPham temp = this[a];
            this[a] = this[b];
            this[b] = temp;
        }

        public void SapXep()
        {
            //for (int i = 0; i < collection.Count - 1; i++)
            //    for (int j = i + 1; j < collection.Count; j++)
            //        if (Compare(this[i], this[j]) > 0)
            //            HoanVi(i, j);
            collection.Sort(this);
        }

        // Sắp xếp danh sách ấn phẩm tăng dần theo giá tiền (sử dụng IComparer).
        

        public int Compare(IAnPham x, IAnPham y)
        {
            switch (ThuocTinh)
            {
                case Selector.Ten:
                    return x.Ten.CompareTo(y.Ten);
                case Selector.GiaTien:
                    return x.GiaTien.CompareTo(y.GiaTien);
                case Selector.TenGiam:
                    return -x.Ten.CompareTo(y.Ten);
                default:
                    return 0;
            }
        }
        //Sắp xếp danh sách ấn phẩm là TruyenTranh giảm dần theo tên, các ẩn phẩm khác giữ nguyên vị trí(sử dụng delegate).
        public void SapXepTruyenTranhGiamDan(SoSanh ss)
        {
            for(int i =0; i < collection.Count - 1; i++)
            {
                for(int j = i + 1; j < collection.Count; j++)
                {
                    if (ss(this.collection[i], this.collection[j]) > 0 && collection[i] is TruyenTranh && collection[j] is TruyenTranh)
                    {
                        HoanVi(i, j);
                    }
                }
            }
        }

        #endregion
        // Thêm 3 TruyenTranh từ file dsanpham.txt.
        //Tìm truyện tranh của nhà xuất bản X.
        public DanhSachAnPham TimTruyenTranh(string nhaXuatBan)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach(var i in collection)
            {
                if(i is TruyenTranh && i.NhaXuatBan.Equals(nhaXuatBan.ToString(),StringComparison.OrdinalIgnoreCase))
                {
                    kq.Them(i);
                }
            }
            return kq;
        }

        // Tìm tất cả danh sách ẩn phẩm có giá tiền > y.  
        public DanhSachAnPham TimALLAnPhamCoGiaTienLonHonY(float y)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach(var i in collection)
            {
                if(i.GiaTien >  y)
                {
                    kq.Them(i);
                }
            }
            return kq;
        }

    }
}
