using QuanLyAnPhamBaiLopB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312805_TNNY_Lab6
{
    delegate int SoSanh(object a, object b);
    enum KieuSapXep
    {
        TangTheoTen,
        TangTheoGia,
        GiamTheoNam
    }
    class DanhSachAnPham : List<IAnPham>, IComparer<IAnPham>
    {
        KieuSapXep kieu = KieuSapXep.TangTheoTen;
        public List<IAnPham> collection = new List<IAnPham>();
        float minGia => collection.Min(ap => ap.GiaTien);
        float maxGia => collection.Max(ap => ap.GiaTien);

        #region Đọc_danh_sách_ấn_phẩm_từ_file
        public void NhapTuFile()
        {
            string path = @"Data.txt";
            StreamReader sr = new StreamReader(path);
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                string[] s = str.Split(',');
                if (s[0] == "Sach")
                    Them(new Sach(str));
                if (s[0] == "Bao")
                    Them(new Bao(str));
                if (s[0] == "Tap chi")
                    Them(new TapChi(str));
            }
        }
        public void Them(IAnPham ap)
        {
            collection.Add(ap);
        }
        #endregion

        #region Tìm_ấn_phẩm_có_giá_lớn_nhất
        public DanhSachAnPham TimAnPhamCoGiaCaoNhat()
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            kq.collection = collection.FindAll(x => x.GiaTien == maxGia);
            return kq;
        }
        #endregion

        #region Tìm_danh_sách_ấn_phẩm_thuộc_nhà_xuất_bản_x
        public DanhSachAnPham DSAPTheoNXB(string nxb)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach (IAnPham ap in collection)
                if (ap.NhaXuatBan.CompareTo(nxb) == 0)
                    kq.Them(ap);
            return kq;
        }
        #endregion

        #region Hiển_thị_các_ấn_phấm_theo_giá
        public DanhSachAnPham TimAnPhamTheoGiaTien(float x)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            kq.collection = collection.FindAll(a => a.GiaTien == x);
            return kq;
        }
        #endregion

        #region Tính_tổng_giá_tiền_của_danh_sách_ấn_phẩm
        public float TongGiaDSAP()
        {
            float sum = 0;
            foreach (IAnPham ap in collection)
                sum += ap.GiaTien;
            return sum;
        }
        #endregion

        #region Sắp_xếp_danh_sách_ấn_phẩm_giảm_theo_tên_giảm_theo_giá
        public int Compare(IAnPham x, IAnPham y)
        {
            if (kieu == KieuSapXep.TangTheoTen)
                return x.Ten.CompareTo(y.Ten);
            return x.GiaTien.CompareTo(y.GiaTien);
        }
        public void SapXepTangTheoGia()
        {
            kieu = KieuSapXep.TangTheoGia;
            collection.Sort((x1, x2) => Compare(x1, x2));
        }
        #endregion

        #region Sắp_xếp_danh_sách_ấn_phẩm_tăng_theo_tên_tăng_theo_giá
        public void SapXepGiamTheoGia()
        {
            kieu = KieuSapXep.TangTheoGia;
            collection.Sort((x1, x2) => -Compare(x1, x2));
        }
        #endregion

        #region Tìm_các_ấn_phẩm_có_giá_thấp_nhất
        public DanhSachAnPham DSAPGiaThapNhat()
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            kq.collection = collection.FindAll(x => x.GiaTien == minGia);
            return kq;
        }
        #endregion

        #region Xóa_tất_cả_ấn_phẩm_có_giá_thấp_nhất
        public void XoaAPGiaThapNhat()
        {
            collection.RemoveAll(x => x.GiaTien == minGia);
        }
        #endregion

        #region Chèn_ấn_phẩm_vào_danh_sách_ấn_phẩm_trước_vị_trí_i
        public void Chen(int i)
        {
            string loai;
            Console.Write("Nhập thể loại ấn phẩm: ");
            loai = Console.ReadLine();
            switch (loai)
            {
                case "Bao":
                    Bao b = new Bao();
                    b.Nhap(b);
                    collection.Insert(i, b);
                    break;

                case "Tap chi":
                    TapChi tc = new TapChi();
                    tc.Nhap(tc);
                    collection.Insert(i, tc);
                    break;

                case "Sach":
                    Sach s = new Sach();
                    s.Nhap(s);
                    collection.Insert(i, s);
                    break;

                default:
                    Console.WriteLine("Thể loại ấn phẩm không hợp lệ");
                    break;
            }
        }
        #endregion
        public void SapXepTheoTen()
        {
            kieu = KieuSapXep.TangTheoTen;
            collection.Sort(this);
        }
        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < this.collection.Count - 1; i++)
                for (int j = i + 1; j < this.collection.Count; j++)
                    if (ss(this.collection[i], this.collection[j]) == 1)
                    {
                        IAnPham a = this.collection[i];
                        this.collection[i] = this.collection[j];
                        this.collection[j] = a;
                    }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in collection)
            {
                sb.Append(item + "\n");
            }
            return sb.ToString();
        }
    }
}
