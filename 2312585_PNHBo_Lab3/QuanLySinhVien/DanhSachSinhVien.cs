using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class DanhSachSinhVien
    {
        List<SinhVien> ds = new List<SinhVien>();
        public void Them(SinhVien sv)
        {
            ds.Add(sv);
        }

        public void NhapTuFile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            // Đọc ghi file 
            var line = "";
            while ((line = sr.ReadLine()) != null)
            {
                Them(new SinhVien(line));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MSSV".PadRight(6) + "Họ tên".PadRight(14) + "DTB".PadRight(2) + "  Giới Tính  " + "Lớp ".PadRight(10) + "Xếp Loại \n".PadRight(10));
            foreach(var sv in ds)
            {
                sb.Append(sv + "\n");
            }
            return sb.ToString();
        }

        public float TimDTBCaoNhat()
        {
            return ds.Min(x => x.dTB);
        }

        public DanhSachSinhVien TimDSSVCoDTBCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            float max = TimDTBCaoNhat();
            foreach (var item in ds)
            {
                if(item.dTB == max)
                    kq.Them(item);
            }
            return kq;
        }

        private int DemSoLuongSVTheoGioiTinhvaLop(bool GT, string lop)
        {
            return ds.Count(x => x.gioiTinh == GT && x.Lop == lop);
        }

        public int DemSoLuongSVNam(string lop)
        {
            return DemSoLuongSVTheoGioiTinhvaLop(true, lop);
        }

        public int DemSoLuongSVNu(string lop)
        {
            return DemSoLuongSVTheoGioiTinhvaLop(false, lop);
        }

        public List<string> LayDanhSachLop()
        {
            List<string> kq = new List<string>();
            foreach (var sv in ds)
            {
                if(!kq.Contains(sv.Lop))
                    kq.Add(sv.Lop);
            }
            return kq;
        }

        public enum KieuSapXep
        {
            TangDTB,
            GiamDTB
        }

        void SapXep(KieuSapXep kieu)
        {
            if(kieu == KieuSapXep.TangDTB)
                ds.Sort((sv1, sv2) => sv1.dTB.CompareTo(sv2.dTB));
            if(kieu == KieuSapXep.GiamDTB)
                ds.Sort((sv1, sv2) => -sv1.dTB.CompareTo(sv2.dTB));
        }

        public DanhSachSinhVien SinhVienTheoLop(string lop)
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            foreach (var i in ds)
            {
                if (i.Lop == lop)
                    kq.Them(i);
            }
            return kq;
        }
        public void SapXepTangTheoDTB()
        {
            SapXep(KieuSapXep.TangDTB);
        }

        public void SapXepGiamTheoDTB()
        {
            SapXep(KieuSapXep.GiamDTB);
        }

        public List<string> TimLopCoDTBCaoNhat()
        {
            List<string> lopDiemCao = new List<string>();
            float max = TimDTBCaoNhat();
            foreach (var i in ds)
            {
                if (i.dTB == max && !lopDiemCao.Contains(i.Lop))
                {
                    lopDiemCao.Add(i.Lop);
                } 
            }
            return lopDiemCao;
        }

        public List<string> TimLopKhongCoDTBCaoNhat()
        {
            List<string> lopDiemCao = TimLopCoDTBCaoNhat();
            List<string> lopKoCao = new List<string>();
            foreach(var i in ds)
            {
                if (!lopDiemCao.Contains(i.Lop) && !lopKoCao.Contains(i.Lop))
                {
                    lopKoCao.Add(i.Lop);
                }
            }
            return lopKoCao;
        }

        public void XuatRaLopCoDTBCaoNhat()
        {
            var kq = TimLopCoDTBCaoNhat();
            foreach (var Lop in kq)
            {
                Console.Write(Lop + "  ");
            }
        }

        public void XuatRaLopKoCoDTBCaoNhat()
        {
            var kq = TimLopKhongCoDTBCaoNhat();
            foreach (var Lop in kq)
            {
                Console.Write(Lop+"  ");
            }
        }

        int TimViThuCuaSV(SinhVien sv)
        {
            int vt = 1;
            foreach (var i in ds)
            {
                if (sv.Lop == i.Lop && sv.dTB < i.dTB)
                    vt++;
            }
            return vt;
        }

        public float TongDTBTheoLop(string lop)
        {
            float total = 0;
            foreach (var i in ds)
            {
                if (i.Lop == lop)
                    total += i.dTB;
            }
            return total;
        }
        public List<float> TongDTBCuaCacLop()
        {
            List<float> dsDiem = new List<float>();

            foreach (var i in LayDanhSachLop())
            {
                dsDiem.Add(TongDTBTheoLop(i));
            }
            return dsDiem;
        }
        public string LopCoTongDTBCaoNhat()
        {
            return LayDanhSachLop()[TongDTBCuaCacLop().IndexOf(TongDTBCuaCacLop().Max())];

        }
        public string LopCoTongDTBThapNhat()
        {
            return LayDanhSachLop()[TongDTBCuaCacLop().IndexOf(TongDTBCuaCacLop().Min())];

        }

        public void XuatXepLoaiDSSV(SinhVien sv)
        {
            DanhSachSinhVien dss = new DanhSachSinhVien();
            Console.Write(dss);
            foreach (var i in ds)
            {
                sv.XepLoaiSV(i);
                Console.WriteLine(i);
            }
            
        }


        //public void XepHangSinhVien()
        //{
        //  foreach(var i in ds)
        //    {
        //        if(i.)
        //    }

        //}

        //public List<string> SVGioi(SinhVien sv)
        //{
        //    List<string> svgioi = new List<string>();
        //    foreach (var i in ds)
        //    {
        //        if(sv.xepLoai == "Gioi")
        //        {
        //            svgioi.Add(i.Lop);
        //        }
        //    }
        //    return svgioi;
        //}

        //public void XuatLopCoNhieuSVGioi(SinhVien sv)
        //{
        //    var kq = SVGioi(sv);
        //    foreach (var Lop in kq)
        //    {
        //        Console.Write(Lop + "  ");
        //    }
        //}

        public int DemSoSVTheoHocLuc(string xepLoai)
        {
            int count = 0;
            foreach (var sv in ds)
            {
                if (sv.xepLoai == xepLoai)
                {
                    count++;
                }
            }
            return count;
        }
        public Dictionary<string, int> ThongKeTheoLop(string lop)
        {
            Dictionary<string, int> ex = new Dictionary<string, int>();
            foreach (var sv in ds)
            {
                if (sv.Lop == lop && !ex.ContainsKey(sv.xepLoai))

                    ex.Add(sv.xepLoai, DemSoSVTheoHocLuc(sv.xepLoai));

            }
            return ex;
        }
        public string TimLopCoNhieuSVGioiNhat(string xepLoai)
        {
            int max = 0;
            string LOP = "";
            foreach (var lop in LayDanhSachLop())
            {
                if (ThongKeTheoLop(lop).ContainsKey(xepLoai))
                {
                    if (ThongKeTheoLop(lop)[xepLoai] > max)
                    {
                        max = ThongKeTheoLop(lop)[xepLoai];
                        LOP = lop;
                    }
                }
            }
            return LOP;
        }

        public List<string> TimLopCoNu()
        {
            List<string> lopCoNu = new List<string>();

            foreach (var i in ds)
            {
                if (i.gioiTinh == false && !lopCoNu.Contains(i.Lop))
                    lopCoNu.Add(i.Lop);


            }
            return lopCoNu;
        }
        public List<string> TimLopKhongCoNu()
        {
            List<string> lopCoNu = TimLopCoNu();
            List<string> lopKoCoNu = new List<string>();
            foreach (var i in ds)
            {
                if (!lopCoNu.Contains(i.Lop) && !lopKoCoNu.Contains(i.Lop))
                {
                    lopKoCoNu.Add(i.Lop);
                }
            }
            return lopKoCoNu;
        }
        public List<string> TimLopCoNam()
        {
            List<string> lopCoNam = new List<string>();

            foreach (var i in ds)
            {
                if (i.gioiTinh == true && !lopCoNam.Contains(i.Lop))
                    lopCoNam.Add(i.Lop);


            }
            return lopCoNam;
        }
        public List<string> TimLopKhongCoNam()
        {
            List<string> lopCoNam = TimLopCoNam();
            List<string> lopKoCoNam = new List<string>();
            foreach (var i in ds)
            {
                if (!lopCoNam.Contains(i.Lop) && !lopKoCoNam.Contains(i.Lop))
                {
                    lopKoCoNam.Add(i.Lop);
                }
            }
            return lopKoCoNam;
        }

        public void XuatLop(List<string> list)
        {
            foreach (string i in list)
            {
                Console.Write(i +"  ");
                
            }

        }

        public int DemSoSVTheoLop(string lop)
        {
            int count = 0;
            foreach (var i in ds)
            {
                if (i.Lop == lop)
                    count++;
            }
            return count;
        }

        public Dictionary<string, int> ThongKeSVTheoLop()
        {
            Dictionary<string, int> ds = new Dictionary<string, int>();
            foreach (var lop in LayDanhSachLop())
            {
                ds.Add(lop, DemSoSVTheoLop(lop));

            }
            return ds;

        }

        public void XuatMap(Dictionary<string, int> ds)
        {
            foreach (var i in ds)
            {
                Console.WriteLine(i.Key + ' ' + i.Value);
            }
        }

        public void XoaSinhVienTheoLop(string lopCanXoa)
        {
            ds.RemoveAll(sv => sv.Lop == lopCanXoa);
        }
    }
}