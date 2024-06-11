using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections;

namespace _2312585_PNHBo_Lab7_TinhKeThuaVaDaKeThua
{

    public class DanhSachKhachHang
    {
        List<KhachHang> dskh = new List<KhachHang>();

        public void Them(KhachHang kh)
        {
            dskh.Add(kh);
        }

        public void DocFile(DanhSachPhuongTien dspt)
        {
            StreamReader sr = new StreamReader("dskh.txt");
            string line;
            KhachHang kh = null;
            while ((line = sr.ReadLine()) != null)
            {
                string[] t = line.Split(';');
                kh = new KhachHang(t[0], t[1], t[2], dspt.TimDSDieuKien(LoaiDieuKien.ChuSoHuu, null, 0, 0, chusohuu: t[0]));
                dskh.Add(kh);
            }
            sr.Close();
        }
        public void Xuat()
        {
            int stt = 0;
            if (dskh.Count == 0)
            {
                Console.WriteLine("Không có dữ liệu. ");
            }
            else
            {
                foreach (var i in dskh)
                {
                    Console.WriteLine($"===\nSTT: {++stt}");
                    Console.Write(i);
                    i.dspt.Xuat();
                }
            }

        }


        #region  2.Xuất danh sách khách hàng theo mẫu trên ra màn hình và file theo chiều tăng giảm của số lượng phương tiện sở hữu.
        public DanhSachKhachHang SapTangDSKH()
        {
            dskh = dskh.OrderBy(x => x.dspt.SoLuongPT()).ToList();
            return this;
        }
        public DanhSachKhachHang SapGiamDSKH()
        {
            dskh = dskh.OrderByDescending(x => x.dspt.SoLuongPT()).ToList();
            return this;
        }
        #endregion

        #region 3. Xuất danh sách khách hàng theo mẫu trên ra màn hình và file theo từng loại phương tiện, loại điều kiện, loại so sánh, loại kết hợp.
        public DanhSachKhachHang TimDSKHCar()
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.Car) != 0).ToList() };
        }

        public DanhSachKhachHang TimDSKHMotorcycle()
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.Motorcycle) != 0).ToList() };
        }

        public DanhSachKhachHang TimDSKHTheoTen(string ten)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.HoTen.Contains(ten)).ToList() };
        }

        public DanhSachKhachHang TimDSKHTheoCCCD(string cccd)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.SoCCCD.Contains(cccd)).ToList() };
        }

        #endregion

        #region 4. Tìm danh sách khách hàng sở hữu nhiều, ít nhất theo từng loại phương tiện, loại điều kiện, loại so sánh, loại kết hợp.
        public DanhSachKhachHang TimDSKHSoHuuNhieuNhatTheoPT(LoaiPhuongTien loai)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoLoaiPhuongTien(loai) == dskh.Max(y => y.dspt.DemSoLuongTheoLoaiPhuongTien(loai))).ToList() };
        }

        public DanhSachKhachHang TimDSKHSoHuuItNhatTheoPT(LoaiPhuongTien loai)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoLoaiPhuongTien(loai) == dskh.Min(y => y.dspt.DemSoLuongTheoLoaiPhuongTien(loai))).ToList() };
        }

        public DanhSachKhachHang TimDSKHSoHuuNhieuNhatTheoTenHang(string ten)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoTen(ten) == dskh.Max(y => y.dspt.DemSoLuongTheoTen(ten))).ToList() };
        }

        public DanhSachKhachHang TimDSKHSoHuuItNhatTheoTenHang(string ten)
        {
            var minSoLuong = dskh.Where(x => x.dspt.DemSoLuongTheoTen(ten) != 0).Min(y => y.dspt.DemSoLuongTheoTen(ten));
            var danhSachKhachHang = new DanhSachKhachHang
            {
                dskh = dskh.Where(x => x.dspt.DemSoLuongTheoTen(ten) == minSoLuong && x.dspt.DemSoLuongTheoTen(ten) != 0).ToList()
            };
            return danhSachKhachHang;
        }
        #endregion
        #region 5.	Tìm khách hàng không sở hữu loại phương tiện nào.
        public DanhSachKhachHang TimDSKHKoCoPT()
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.SoLuongPT() == 0).ToList() };
        }
        #endregion

        #region 7.	Tìm thành phố có nhiều, ít loại phương tiện nhất
        public Dictionary<string, int[]> DSPhuongTienThanhPho()
        {
            Dictionary<string, int[]> kq = new Dictionary<string, int[]>();
            foreach (var i in dskh)
            {
                if (!kq.ContainsKey(i.ThanhPho))
                {
                    kq[i.ThanhPho] = new int[2];
                }
                int[] vehicleCounts = kq[i.ThanhPho];
                int carCount = i.dspt.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.Car);
                vehicleCounts[0] += carCount;
                vehicleCounts[1] += i.dspt.SoLuongPT() - carCount;
            }
            return kq;
        }

        public void XuatDSThanhPho(Dictionary<string, int[]> tp)
        {
            Console.WriteLine($"{"Tên Thành Phố",-24}{"Car",-8}{"Motorcycle"}");
            if (tp.Count == 0)
            {
                Console.WriteLine("Không có dữ liệu.");
            }
            else
            {
                foreach (var i in tp)
                {
                    Console.WriteLine(i.Key + "\t\t" + i.Value[0] + "\t" + i.Value[1]);
                }
            }
        }

        public Dictionary<string, int[]> TimTpCoNhieuLoaiCarNhat()
        {
            var dsPhuongTienThanhPho = DSPhuongTienThanhPho();
            int maxSoLuongCar = dsPhuongTienThanhPho.Max(x => x.Value[0]);
            var kq = dsPhuongTienThanhPho
                .Where(x => x.Value[0] == maxSoLuongCar)
                .ToDictionary(x => x.Key, x => x.Value);
            return kq;
        }


        public Dictionary<string, int[]> TimTpCoItLoaiCarNhat()
        {
            var kq = DSPhuongTienThanhPho()
                .Where(x => x.Value[0] == DSPhuongTienThanhPho().Min(y => y.Value[0]))
                .ToDictionary(x => x.Key, x => x.Value);
            return kq;
        }

        public Dictionary<string, int[]> TimTpCoNhieuLoaiMotorcycleNhat()
        {
            var kq = DSPhuongTienThanhPho()
                .Where(x => x.Value[1] == DSPhuongTienThanhPho().Max(y => y.Value[1]))
                .ToDictionary(x => x.Key, x => x.Value);
            return kq;
        }
        public Dictionary<string, int[]> TimTpCoItLoaiMotorcycleNhat()
        {
            var kq = DSPhuongTienThanhPho()
                .Where(x => x.Value[1] == DSPhuongTienThanhPho().Min(y => y.Value[1]))
                .ToDictionary(x => x.Key, x => x.Value);
            return kq;
        }

        public Dictionary<string, int[]> TimTpCoNhieuLoaiCarAndMotocycleNhat()
        {
            var dsPhuongTienThanhPho = DSPhuongTienThanhPho();
            var tongPhuongTienTheoThanhPho = dsPhuongTienThanhPho
                .Select(x => new
                {
                    ThanhPho = x.Key,
                    TongPhuongTien = x.Value[0] + x.Value[1]
                }).ToList();

            int maxTongPhuongTien = tongPhuongTienTheoThanhPho.Max(x => x.TongPhuongTien);

            var kq = tongPhuongTienTheoThanhPho
                .Where(x => x.TongPhuongTien == maxTongPhuongTien)
                .ToDictionary(x => x.ThanhPho, x => new int[] { dsPhuongTienThanhPho[x.ThanhPho][0], dsPhuongTienThanhPho[x.ThanhPho][1] });
            return kq;
        }

        public Dictionary<string, int[]> TimTpCoItLoaiCarAndMotocycleNhat()
        {
            var dsPhuongTienThanhPho = DSPhuongTienThanhPho();
            var tongPhuongTienTheoThanhPho = dsPhuongTienThanhPho
                .Select(x => new
                {
                    ThanhPho = x.Key,
                    TongPhuongTien = x.Value[0] + x.Value[1]
                });
            int minTongPhuongTien = tongPhuongTienTheoThanhPho.Min(x => x.TongPhuongTien);
            var kq = tongPhuongTienTheoThanhPho
                .Where(x => x.TongPhuongTien == minTongPhuongTien)
                .ToDictionary(x => x.ThanhPho, x => new int[] { dsPhuongTienThanhPho[x.ThanhPho][0], dsPhuongTienThanhPho[x.ThanhPho][1] });
            return kq;
        }

        #endregion

        #region 8.	Tìm tỉnh có nhiều, ít loại phương tiện nhất
        public Dictionary<string, int[]> DSPhuongTienTinh()
        {
            Dictionary<string, int[]> kq = new Dictionary<string, int[]>();
            foreach (var i in dskh)
            {
                if (!kq.ContainsKey(i.Tinh))
                {
                    kq[i.Tinh] = new int[2];
                }
                int[] vehicleCounts = kq[i.Tinh];
                int carCount = i.dspt.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.Car);
                vehicleCounts[0] += carCount;
                vehicleCounts[1] += i.dspt.SoLuongPT() - carCount;
            }
            return kq;
        }

        public void XuatDSTinh(Dictionary<string, int[]> tinh)
        {
            Console.WriteLine($"{"Tên Tỉnh",-16}{"Car",-8}{"Motorcycle"}");
            if (tinh.Count == 0)
            {
                Console.WriteLine("Không có dữ liệu.");
            }
            else
            {
                foreach (var i in tinh)
                {
                    Console.WriteLine(i.Key + "\t" + i.Value[0] + "\t" + i.Value[1]);
                }
            }
        }
        public Dictionary<string, int[]> TimTinhCoNhieuCarNhat()
        {
            var dsptTinh = DSPhuongTienTinh();
            var kq = dsptTinh
                .Where(x => x.Value[0] == dsptTinh.Max(y => y.Value[0]))
                .ToDictionary(x => x.Key, x => x.Value);
            return kq;
        }

        public Dictionary<string,int[]> TimTinhCoItCarNhat()
        {
            var kq = DSPhuongTienTinh()
                .Where(x => x.Value[0] == DSPhuongTienTinh().Min(y => y.Value[0]))
                .ToDictionary(x => x.Key,x => x.Value); 
            return kq;
        }

        public Dictionary<string, int[]> TimTinhCoNhieuMotorcycleNhat()
        {
            var kq = DSPhuongTienTinh()
                .Where(x => x.Value[1] == DSPhuongTienTinh().Max(y => y.Value[1]))
                .ToDictionary(x => x.Key, x => x.Value);
            return kq;
        }

        public Dictionary<string, int[]> TimTinhCoItMotorcycleNhat()
        {
            var kq = DSPhuongTienTinh()
                .Where(x => x.Value[1] == DSPhuongTienTinh().Min(y => y.Value[1]))
                .ToDictionary(x => x.Key, x => x.Value);
            return kq;
        }

        public Dictionary<string, int[]> TimTinhCoNhieuCarAndMotorcyleNhat()
        {
            var dsPhuongTienThanhPho = DSPhuongTienTinh();
            var tongptCarandMotorycle = DSPhuongTienTinh()
                .Select(x => new
                { 
                      ThanhPho = x.Key,
                      TongPT = x.Value[0] + x.Value[1], 
                });
            int maxTongPT = tongptCarandMotorycle.Max(x => x.TongPT);
            var kq = tongptCarandMotorycle
                .Where(x => x.TongPT == maxTongPT)
                .ToDictionary(x => x.ThanhPho, x => new int[] { dsPhuongTienThanhPho[x.ThanhPho][0], dsPhuongTienThanhPho[x.ThanhPho][1] });
            return kq;
        }

        public Dictionary<string, int[]> TimTinhCoItCarAndMotorcyleNhat()
        {
            var dsPhuongTienThanhPho = DSPhuongTienTinh();
            var tongptCarandMotorycle = DSPhuongTienTinh()
                .Select(x => new
                {
                    ThanhPho = x.Key,
                    TongPT = x.Value[0] + x.Value[1],
                });
            int minTongPT = tongptCarandMotorycle.Min(x => x.TongPT);
            var kq = tongptCarandMotorycle
                .Where(x => x.TongPT == minTongPT)
                .ToDictionary(x => x.ThanhPho, x => new int[] { dsPhuongTienThanhPho[x.ThanhPho][0], dsPhuongTienThanhPho[x.ThanhPho][1] });
            return kq;
        }
        #endregion

        #region 9.	Tìm tỉnh, thành phố không có phương tiện theo từng loại phương tiện, loại điều kiện, loại so sánh, loại kết hợp.
        // Loại Phương Tiện
        public string TimTinhKhongCoCar()
        {
            var kq = DSPhuongTienTinh()
                .Where(x => x.Value[0] == 0)
                .Select(x => x.Key );
            return string.Join(", ", kq);
        }
        public string TimTinhKhongCoMotorcycle()
        {
            var dsPhuongTienTheoTinh = DSPhuongTienTinh();
            var kq = dsPhuongTienTheoTinh
                .Where(x => x.Value[1] == 0)
                .Select(x => x.Key);
            return string.Join(", ", kq);
        }
        public string TimTinhKhongCoCarAndMotorcycle()
        {
            var dsPhuongTienTheoTinh = DSPhuongTienTinh();
            var tongPhuongTien = dsPhuongTienTheoTinh.Sum(x => x.Value[0] + x.Value[1]);
            var kq = dsPhuongTienTheoTinh
                .Where(x => tongPhuongTien == 0)
                .Select(x => x.Key);
            return string.Join(", ", kq);
        }

        public string TimThanhPhoKhongCoCar()
        {
            var dsPhuongTienTheoThanhPho = DSPhuongTienThanhPho();
            var kq = dsPhuongTienTheoThanhPho
                .Where(x => x.Value[0] == 0)
                .Select(x => x.Key);
            return string.Join(", ", kq);
        }
        public string TimThanhPhoKhongCoMotorcycle()
        {
            var dsPhuongTienTheoThanhPho = DSPhuongTienThanhPho();
            var kq = dsPhuongTienTheoThanhPho
                .Where(x => x.Value[1] == 0)
                .Select(x => x.Key);
            return string.Join(", ", kq);
        }

        public string TimThanhPhoKhongCoCarAndMotorcycle()
        {
            var dsPhuongTienTheoThanhPho = DSPhuongTienThanhPho();
            var kq = dsPhuongTienTheoThanhPho
                .Where(x => x.Value[0] + x.Value[1] == 0)
                .Select(x => x.Key);
            return string.Join(", ", kq);
        }
        // Loại Điều Kiện
        public Dictionary<string, int[]> TimTheoTenTinh(string tentinh)
        {
            var dsTinh = DSPhuongTienTinh();
            var kq = dsTinh
                .Where(x => x.Key.Equals(tentinh, StringComparison.OrdinalIgnoreCase))
                .ToDictionary(x => x.Key, x => x.Value);

            if (kq.Count == 0)
            {
                // Trả về từ điển trống nếu không tìm thấy tỉnh
                return new Dictionary<string, int[]>();
            }

            return kq;
        }
        #endregion
    }
}
