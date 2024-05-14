using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2312585_PNHBo_Lab7_TinhKeThuaVaDaKeThua
{
    enum LoaiPhuongTien
    {
        Car,
        Motorcycle,
        CarAndMotorcycle,
        CarOrMotorcycle
    }
    enum LoaiDieuKien
    {
        Ten,
        SoChoNgoi,
        TocDo,
        TenvaSoChoNgoi,
        TenvaTocDo,
        SoChoNgoivaTocDo,
        TenvaSoChoNgoivaTocDo
    }
    enum LoaiSoSanh
    {
        LonNhat,
        NhoNhat,
        DaiNhat,
        NganNhat
    }
    enum TimKiemMaxMin
    {
        Max,
        Min
    }
    
    

    internal class DanhSachPhuongTien
    {
        List<IVehicle> collection = new List<IVehicle>();

        public void Them(IVehicle vehicle)
        {
            collection.Add(vehicle);
        }

        public void NhapTuFile(string tenFile)
        {
            StreamReader sr = new StreamReader(tenFile);
            string s = "".Trim();

            while ((s = sr.ReadLine()) != null)
            {
                string[] t = s.Split(',');
                if (t[0] == "Car")
                {
                    IVehicle car = new Car(t[1], int.Parse(t[2]), int.Parse(t[3]));
                    collection.Add(car);
                }
                else if (t[0] == "Motorcycle")
                {
                    IVehicle motorcycle = new Motorcycle(t[1], int.Parse(t[2]));
                    collection.Add(motorcycle);
                }

            }
            sr.Close();
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (var i = 0; i < collection.Count; i++)
        //    {
        //        sb.AppendLine($"{collection[i]}");
        //    }
        //    return sb.ToString();
        //}

        public void Xuat()
        {
            Console.WriteLine($"{"Loại",-11}{"Tên Hãng",-17}{"Tốc Độ",-11}Chỗ Ngồi");

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        // Tìm kiếm
        public int TimKiemMin_Max(TimKiemMaxMin timKiem, LoaiDieuKien loaidk)
        {
            if (loaidk is LoaiDieuKien.Ten)
            {
                switch (timKiem)
                {
                    case TimKiemMaxMin.Max:
                        return collection.Max(x => x.Ten.Length);
                    case TimKiemMaxMin.Min:
                        return collection.Min(x => x.Ten.Length);
                }
            }
            else if (loaidk is LoaiDieuKien.SoChoNgoi)
            {
                switch(timKiem)
                {
                    case TimKiemMaxMin.Max:
                        return collection.Max(x => (x is Car) ? ((Car)x).SoChoNgoi : 0);
                    case TimKiemMaxMin.Min:
                        return collection.Min(x => (x is Car) ? ((Car)x).SoChoNgoi : 0);
                }
            }
            else if (loaidk is LoaiDieuKien.TocDo)
            {
                switch (timKiem)
                {
                    case TimKiemMaxMin.Max:
                        return collection.Max(x => x.TocDo);
                    case TimKiemMaxMin.Min:
                        return collection.Min(x => x.TocDo);
                }
            }
            return 0;
        }

        //public int TimTenDaiNhat()
        //{
        //    return collection.Max(x => x.Ten.Length);
        //}
        //public int TimTenNganNhat()
        //{
        //    return collection.Min(x => x.Ten.Length);
        //}
        //public int TimChoNgoiLonNhat()
        //{
        //    return collection.Max(x => ((Car)x).SoChoNgoi);
        //}
        //public int TimChoNgoiNhoNhat()
        //{
        //    return collection.Min(x => ((Car)x).SoChoNgoi);
        //}
        //public int TimTocDoNhoNhat()
        //{
        //    return collection.Min(x => x.TocDo);
        //}
        //public int TimTocDoLonNhat()
        //{
        //    return collection.Max(x => x.TocDo);
        //}

        //6.	Đếm số lượng theo loại kết hợp
        public int DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien loai)
        {
            int kq = 0;
            if (loai == LoaiPhuongTien.Car)
            {
                kq = collection.Count(x => x is Car);
            }
            else if (loai == LoaiPhuongTien.Motorcycle)
            {
                kq = collection.Count(x => x is Motorcycle);
            }
            else if (loai == LoaiPhuongTien.CarAndMotorcycle)
            {
                kq = collection.Count(x => x is Car && x is Motorcycle);
            }
            else if (loai == LoaiPhuongTien.CarOrMotorcycle)
            {
                kq = collection.Count(x => x is Car || x is Motorcycle);
            }
            return kq;
        }

        // Loai dieu kien
        public int DemSoLuongTheoTen(string ten)
        {
            int kq = 0;
            return kq = collection.Count(x => x.Ten == ten);
        }

        public int DemSoLuongTheoChoNgoi(int choNgoi)
        {
            int kq = 0;
            return kq = collection.Count(x =>
            {
                if (x is Car) return ((Car)x).SoChoNgoi == choNgoi;
                return false;
            });
        }

        public int DemSoLuongTheoTocDo(int tocdo)
        {
            int kq = 0;
            return kq = collection.Count(x => x.TocDo == tocdo);
        }

        public int DemSoLuongTheoTenVaSoChoNgoi(string ten, int choNgoi)
        {
            int kq = 0;
            return kq = collection.Count(x =>
            {
                if (x is Car) return x.Ten == ten && ((Car)x).SoChoNgoi == choNgoi;
                return false;
            });
        }

        public int DemSoLuongTheoTenVaTocDo(string ten, int tocdo)
        {
            int kq = 0;
            return kq = collection.Count(x => x.Ten == ten && x.TocDo == tocdo);
        }

        public int DemSoLuongTheoSoChoNgoiVaTocDo(int choNgoi, int tocdo)
        {
            int kq = 0;
            return kq = collection.Count(x => x is Car && x.TocDo == tocdo && ((Car)x).SoChoNgoi == choNgoi);
        }

        public int DemSoLuongTheoTenVaSoChoNgoivaTocDo(string ten, int tocdo, int choNgoi)
        {
            int kq = 0;
            return kq = collection.Count(x => x is Car && x.Ten == ten && x.TocDo == tocdo && ((Car)x).SoChoNgoi == choNgoi);
        }

        // Loại So Sánh

        
        public int DemSoLuongTenDaiNhat()
        {
            int kq = 0;        
            return  kq = collection.Count(x => x.Ten.Length == TimKiemMin_Max(TimKiemMaxMin.Max,LoaiDieuKien.Ten));
        }

        public int DemSoLuongTenNganNhat()
        {
            int kq = 0;
            return kq = collection.Count(x => x.Ten.Length == TimKiemMin_Max(TimKiemMaxMin.Min,LoaiDieuKien.Ten));
        }

        
        public int DemSoLuongChoNgoiLonNhat()
        {
            int kq = 0;
            return kq = collection.Count(x => x is Car && ((Car)x).SoChoNgoi == TimKiemMin_Max(TimKiemMaxMin.Max,LoaiDieuKien.SoChoNgoi));
        }
        public int DemSoLuongChoNgoiNhoNhat()
        { 
            return collection.Count(x => x is Car && ((Car)x).SoChoNgoi == TimKiemMin_Max(TimKiemMaxMin.Min,LoaiDieuKien.SoChoNgoi));
        }

        public int DemSoLuongTocDoNhoNhat()
        {
            return collection.Count(x => x.TocDo == TimKiemMin_Max(TimKiemMaxMin.Min,LoaiDieuKien.TocDo));
        }

        public int DemSoLuongTocDoLonNhat()
        {
            return collection.Count(x => x.TocDo == TimKiemMin_Max(TimKiemMaxMin.Max, LoaiDieuKien.TocDo));
        }

        // Kết Hợp : Loại Phương Tiện và Loại Điều Kiện
        // Kết Hợp : Loại Phương Tiện và Loại So Sánh
        // Kết Hợp : Loại Phương Tiện , Loại So Sánh, Loại Điều Kiện


        //7.	Tìm tất cả phương tiện theo loại kết hợp
        // Loại Phương Tiện
        public DanhSachPhuongTien TimDSPhuongTien(LoaiPhuongTien loai)
        {
            DanhSachPhuongTien kq = new DanhSachPhuongTien();
            foreach (var x in collection)
            {
                if (loai == LoaiPhuongTien.Car)
                {
                    if (x is Car) kq.Them(x); continue;
                }
                if (loai == LoaiPhuongTien.Motorcycle)
                {
                    if (x is Motorcycle) kq.Them(x); continue;
                }
                if (loai == LoaiPhuongTien.CarAndMotorcycle)
                {
                    if (x is Car && x is Motorcycle) kq.Them(x); continue;
                } 
                if (loai == LoaiPhuongTien.CarOrMotorcycle)
                    if (x is Car || x is Motorcycle) kq.Them(x); continue;
            }
            return kq;
        }

        // Loại Điều Kiện
        public DanhSachPhuongTien TimDSDieuKien(LoaiDieuKien loai, string ten, int soChoNgoi, int tocDo)
        {
            DanhSachPhuongTien kq = new DanhSachPhuongTien();
            foreach(var x in collection)
            {
                switch (loai)
                {
                    case LoaiDieuKien.Ten:
                        if (x.Ten == ten) kq.Them(x); continue;
                    case LoaiDieuKien.SoChoNgoi:
                        if (x is Car && ((Car)x).SoChoNgoi == soChoNgoi) kq.Them(x); continue;
                    case LoaiDieuKien.TocDo:
                        if (x.TocDo == tocDo) kq.Them(x); continue;
                    case LoaiDieuKien.TenvaSoChoNgoi:
                        if (x.Ten == ten && (x is Car && ((Car)x).SoChoNgoi == soChoNgoi)) kq.Them(x); continue;
                    case LoaiDieuKien.TenvaTocDo:
                        if (x.Ten == ten && x.TocDo == tocDo) kq.Them(x); continue;
                    case LoaiDieuKien.SoChoNgoivaTocDo:
                        if ((x is Car && ((Car)x).SoChoNgoi == soChoNgoi) && x.TocDo == tocDo) kq.Them(x); continue;
                    case LoaiDieuKien.TenvaSoChoNgoivaTocDo:
                        if (x.Ten == ten && x.TocDo == tocDo && (x is Car && ((Car)x).SoChoNgoi == soChoNgoi)) kq.Them(x); continue;
                }
                //if(loai == LoaiDieuKien.Ten)
                //{
                //    if (x.Ten == ten) kq.Them(x); continue;
                //}
                //if(loai == LoaiDieuKien.SoChoNgoi)
                //{
                //    if(x is Car && ((Car)x).SoChoNgoi == soChoNgoi) kq.Them(x);  continue;
                //}
                //if (loai == LoaiDieuKien.TocDo)
                //{
                //    if (x.TocDo == tocDo) kq.Them(x); continue;
                //}
                //if (loai == LoaiDieuKien.TenvaSoChoNgoi)
                //{
                //    if (x.Ten == ten && (x is Car && ((Car)x).SoChoNgoi == soChoNgoi)) kq.Them(x); continue;
                //}
                //if(loai == LoaiDieuKien.TenvaTocDo)
                //{
                //    if (x.Ten == ten && x.TocDo == tocDo) kq.Them(x); continue;
                //}
                //if(loai == LoaiDieuKien.SoChoNgoivaTocDo)
                //{
                //    if ((x is Car && ((Car)x).SoChoNgoi == soChoNgoi) && x.TocDo == tocDo) kq.Them(x); continue;
                //}
                //if(loai == LoaiDieuKien.TenvaSoChoNgoivaTocDo)
                //{
                //    if (x.Ten == ten && x.TocDo == tocDo && (x is Car && ((Car)x).SoChoNgoi == soChoNgoi )) kq.Them(x); continue;
                //}
            }
            return kq;
        }

        // Loại So Sánh

        public DanhSachPhuongTien TimDSSoSanh(LoaiSoSanh loaiss, LoaiDieuKien loaidk)
        {
            DanhSachPhuongTien kq = new DanhSachPhuongTien();
            foreach(var x in collection)
            {
                if(loaidk is LoaiDieuKien.Ten)
                {
                    int min = TimKiemMin_Max(TimKiemMaxMin.Min, loaidk);
                    int max = TimKiemMin_Max(TimKiemMaxMin.Max, loaidk);
                    if (min == x.Ten.Length && loaiss is LoaiSoSanh.NganNhat)
                    {
                        kq.Them(x); continue;
                    }
                    if (max == x.Ten.Length && loaiss is LoaiSoSanh.DaiNhat)
                    {
                        kq.Them(x); continue;
                    }
                }
                else if(loaidk is LoaiDieuKien.SoChoNgoi)
                {
                    int min = TimKiemMin_Max(TimKiemMaxMin.Min, loaidk);
                    int max = TimKiemMin_Max(TimKiemMaxMin.Max, loaidk);
                    if (x.TocDo == min && loaiss is LoaiSoSanh.NhoNhat)
                    {
                        kq.Them(x); continue;
                    }
                    if (x.TocDo == max && loaiss is LoaiSoSanh.LonNhat)
                    {
                        kq.Them(x); continue;
                    }
                }
                else if(loaidk is LoaiDieuKien.TocDo)
                {
                    int min = TimKiemMin_Max(TimKiemMaxMin.Min, loaidk);
                    int max = TimKiemMin_Max(TimKiemMaxMin.Max, loaidk);
                    if (x.TocDo == min && loaiss is LoaiSoSanh.NhoNhat)
                    {
                        kq.Them(x); continue;
                    }
                    if (x.TocDo == max && loaiss is LoaiSoSanh.LonNhat)
                    {
                        kq.Them(x); continue;
                    }
                }
            }
            return kq;
        }

        //public DanhSachPhuongTien TimDSTenMin_Max(LoaiSoSanh loai)
        //{
        //    int min = TimTenNganNhat();
        //    int max = TimTenDaiNhat();
        //    DanhSachPhuongTien kq = new DanhSachPhuongTien();
        //    foreach (var x in collection)
        //    {
        //        if (min == x.Ten.Length && loai is LoaiSoSanh.NganNhat)
        //        {
        //                kq.Them(x); continue;
        //        }
        //        if (max == x.Ten.Length && loai is LoaiSoSanh.DaiNhat)
        //        {
        //            kq.Them(x); continue;
        //        }
        //    }
        //    return kq;
        //}

        //public DanhSachPhuongTien TimDSChoNgoiMin_Max(LoaiSoSanh loai)
        //{
        //    int min = TimChoNgoiNhoNhat();
        //    int max = TimChoNgoiLonNhat();
        //    DanhSachPhuongTien kq = new DanhSachPhuongTien();
        //    foreach(var x in collection)
        //    {
        //        if(x is Car && ((Car)x).SoChoNgoi == min && loai is LoaiSoSanh.NhoNhat)
        //        {
        //            kq.Them(x); continue;
        //        }
        //        if (x is Car && ((Car)x).SoChoNgoi == max && loai is LoaiSoSanh.LonNhat)
        //        {
        //            kq.Them(x); continue;
        //        }
        //    }
        //    return kq;
        //}

        //public DanhSachPhuongTien TimDSTocDoMin_Max(LoaiSoSanh loai)
        //{
        //    int min = TimTocDoNhoNhat();
        //    int max = TimTocDoLonNhat();
        //    DanhSachPhuongTien kq = new DanhSachPhuongTien();
        //    foreach(var x in collection)
        //    {
        //        if(x.TocDo == min && loai is LoaiSoSanh.NhoNhat)
        //        {
        //            kq.Them(x); continue;
        //        }
        //        if (x.TocDo == max && loai is LoaiSoSanh.LonNhat)
        //        {
        //            kq.Them(x); continue;
        //        }
        //    }
        //    return kq;
        //}


        // Kết Hợp : Loại Phương Tiện và Loại Điều Kiện
        // Kết Hợp : Loại Phương Tiện và Loại So Sánh
        // Kết Hợp : Loại Phương Tiện , Loại So Sánh, Loại Điều Kiện

        //8.	Tìm phương tiện theo loại phương tiện và có giá trị lớn nhất, nhỏ nhất loại điều kiện
        public DanhSachPhuongTien TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien loaipt,LoaiDieuKien loaidk, TimKiemMaxMin timKiem)
        {
            DanhSachPhuongTien kq = new DanhSachPhuongTien();
            if(loaipt is LoaiPhuongTien.Car)
            {
                foreach (var x in collection)
                {
                    if (x is Car && TimKiemMin_Max(timKiem, LoaiDieuKien.Ten) == x.Ten.Length)
                    {
                        kq.Them(x); continue;
                    }
                    if(x is Car && TimKiemMin_Max(timKiem,LoaiDieuKien.SoChoNgoi) == ((Car)x).SoChoNgoi)
                    {
                        kq.Them(x); continue;
                    }
                    if(x is Car && TimKiemMin_Max(timKiem,LoaiDieuKien.TocDo) == x.TocDo)
                    {
                        kq.Them(x); continue;
                    }
                }
            }
            else if (loaipt is LoaiPhuongTien.Motorcycle)
            {
                foreach (var x in collection)
                {
                    if (x is Motorcycle && TimKiemMin_Max(timKiem, LoaiDieuKien.Ten) == x.Ten.Length)
                    {
                        kq.Them(x); continue;
                    } 
                    if (x is Motorcycle && TimKiemMin_Max(timKiem, LoaiDieuKien.TocDo) == x.TocDo)
                    {
                        kq.Them(x); continue;
                    }
                }
            }
            else if (loaipt is LoaiPhuongTien.CarAndMotorcycle)
            {
                foreach (var x in collection)
                {
                    if ((x is Car && x is Motorcycle) && TimKiemMin_Max(timKiem, LoaiDieuKien.Ten) == x.Ten.Length)
                    {
                        kq.Them(x); continue;
                    }
                    if ((x is Car && x is Motorcycle) && TimKiemMin_Max(timKiem, LoaiDieuKien.SoChoNgoi) == ((Car)x).SoChoNgoi)
                    {
                        kq.Them(x); continue;
                    }
                    if ((x is Car && x is Motorcycle) && TimKiemMin_Max(timKiem, LoaiDieuKien.TocDo) == x.TocDo)
                    {
                        kq.Them(x); continue;
                    }
                }
            }
            else if (loaipt is LoaiPhuongTien.CarOrMotorcycle)
            {
                foreach (var x in collection)
                {
                    if ((x is Car || x is Motorcycle) && TimKiemMin_Max(timKiem, LoaiDieuKien.Ten) == x.Ten.Length)
                    {
                        kq.Them(x); continue;
                    }
                    if ((x is Car || x is Motorcycle) && TimKiemMin_Max(timKiem, LoaiDieuKien.SoChoNgoi) == ((Car)x).SoChoNgoi)
                    {
                        kq.Them(x); continue;
                    }
                    if ((x is Car || x is Motorcycle) && TimKiemMin_Max(timKiem, LoaiDieuKien.TocDo) == x.TocDo)
                    {
                        kq.Them(x); continue;
                    }
                }
            }
            return kq;
        }

        

        //9.	Tìm các Car có số chỗ ngồi cao nhất và Motocycle có tốc độ thấp nhất

    }
}
