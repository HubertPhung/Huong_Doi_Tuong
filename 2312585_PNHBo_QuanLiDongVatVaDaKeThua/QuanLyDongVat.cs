using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2312585_PNHBo_QuanLiDongVatVaDaKeThua
{
    enum LoaiDongVat
    {
        Bird,
        Bat,
        Lion
    }

    enum Fly
    {
        Flyable,
        Unflyable
    }

    enum Sort
    {
        TangName,
        GiamName,
        TangAge,
        GiamAge
    }

    enum CasesToFind
    {
        TimDongVatBietBay,
        TimDongVatBietBayTheoTen,
        TimDongVatBietBayTheoTuoi,
        TimDongVatTaiX,
        TimDongVatNhoTuoiTheoLoai,
        TimDongVatLonTuoiTheoLoai,
        TimDongVatNhieuTuoiNhat,
        TimDongVatNhoTuoiNhat,
        TimDongVatKhongBietBayTheoTen,
        TimDongVatKhongBietBayTheoTuoi,
    }


    internal class QuanLyDongVat
    {
        List<IAnimal> ds = new List<IAnimal>();

        public int SoLuong
        {
            get => ds.Count;
        }

        public void Them(IAnimal animal)
        {
            ds.Add(animal);
        }
        public void DocFile(string tenfile)
        {
            StreamReader sr = new StreamReader(tenfile);
            string s = "";

            while ((s = sr.ReadLine()) != null)
            {
                string[] t = s.Split(',');
                if (t[0] == "Bat")
                {
                    IAnimal bat = new Bat(int.Parse(t[2]), t[1]);
                    ds.Add(bat);
                }

                else if (t[0] == "Lion")
                {
                    IAnimal lion = new Lion(int.Parse(t[2]), t[1]);
                    ds.Add(lion);
                }
                else if (t[0] == "Bird")
                {
                    IAnimal bird = new Bird(int.Parse(t[2]), t[1]);
                    ds.Add(bird);
                }
            }
            sr.Close();
        }

        public override string ToString()
        {
            //StringBuilder sb = new StringBuilder();
            //foreach (IAnimal animal in ds)
            //{
            //    sb.AppendLine(animal.ToString());
            //}
            //return sb.ToString();

            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < ds.Count; i++)
            {
                sb.AppendLine($"{i + 1,-5}{ds[i]}"); // Thêm STT vào chuỗi kết quả
            }
            return sb.ToString();

            //return string.Join("\n", ds.Select(x => x.ToString()).ToArray());
        }

        //public override string ToString()
        //{
        //    return string.Join("\n", ds.Select((animal, index) => $"{index + 1,-5}{animal.ToString()}").ToArray());
        //}

        public void Xuat()
        {
            Console.WriteLine($"{"STT",-5}{"Kind",-10}{"Name",-11}Age");
            Console.WriteLine(this);
        }

        

        // 4.	Đếm số lượng động vật là Bat, Lion, Bird && //5.	Đếm số lượng động vật biết bay, không biết bay

        public int DemSLTheoLoai(Enum loai)
        {
            if (loai is LoaiDongVat)
                switch (loai)
                {
                    case LoaiDongVat.Bird:
                        return ds.Count(x => x is Bird);
                    case LoaiDongVat.Bat:
                        return ds.Count(x => x is Bat);
                    case LoaiDongVat.Lion:
                        return ds.Count(x => x is Lion);
                    default:
                        return 0;
                }
            else if (loai is Fly)
                switch (loai)
                {
                    case Fly.Flyable:
                        //return ds.Count(x => x is IFlyable);
                        return DSDVBietBay().SoLuong;
                    case Fly.Unflyable:
                        return ds.Count(x => !(x is IFlyable));
                }
            return 0;
        }

        


        //6.	Đếm số lượng động vật biết bay, không biết bay theo tên, tuổi

        

        public int DemSLDVBietBayTheoTen(string name)
        {
            return ds.Count(x => x.Name == name && x is IFlyable);
        }

        public int DemSLDVBietBayTheoTuoi(int age)
        {
            return ds.Count(x => x.Age == age && x is IFlyable);
        }

        public int DemSLDVKhongBietBayTheoTen(string name1)
        {
            return ds.Count(x => x.Name == name1 && (!(x is IFlyable)));
        }
        public int DemSLDVKhongBietBayTheoTuoi(int age1)
        {
            return ds.Count(x => x.Age == age1 && (!(x is IFlyable)));
        }

        //8.	Tìm tất cả động vật thuộc loài Bat, Lion, Bird (tương ứng thành 3 phương thức)
        public QuanLyDongVat TimDSDVTheoLoai(LoaiDongVat loai)
        {
            QuanLyDongVat kq = new QuanLyDongVat();
            foreach (var dongVat in ds)
            {
                if (dongVat.GetType().Name == loai.ToString())
                    kq.Them(dongVat);
            }
            return kq;
        }

        //9.	Tìm tất cả động vật có tên ngắn nhất, dài nhất

        public QuanLyDongVat TimALLDVCoTen_Min()
        {
            QuanLyDongVat kq = new QuanLyDongVat();
            int nameMin = ds.Min(x => x.Name.Length);
            foreach (var x in ds)
            {
                if (x.Name.Length == nameMin)
                {
                    kq.Them(x);
                }
            }
            return kq;
        }

        public QuanLyDongVat TimALLDVCoTen_Max()
        {
            QuanLyDongVat kq = new QuanLyDongVat();
            int nameMax = ds.Max(x => x.Name.Length);
            foreach (var x in ds)
            {
                if (x.Name.Length == nameMax)
                {
                    kq.Them(x);
                }
            }
            return kq;
        }

        //10.	Tìm tất cả động vật có tuổi lớn nhất, nhỏ nhất

        public QuanLyDongVat TimALLDVCoTuoi_Max()
        {
            QuanLyDongVat kq = new QuanLyDongVat();
            int ageMax = ds.Max(x => x.Age);
            foreach (var x in ds)
            {
                if (ageMax == x.Age)
                {
                    kq.Them(x);
                }
            }
            return kq;
        }
        public QuanLyDongVat TimALLDVCoTuoi_Min()
        {
            QuanLyDongVat kq = new QuanLyDongVat();
            int ageMin = ds.Min(x => x.Age);
            foreach (var x in ds)
            {
                if (ageMin == x.Age)
                {
                    kq.Them(x);
                }
            }
            return kq;
        }

        //11.	Tìm tất cả động vật có tên ngắn nhất, dài nhất theo loài
        public QuanLyDongVat TimLoai(LoaiDongVat kind)
        {
            QuanLyDongVat kq = new QuanLyDongVat();
            foreach (var i in ds)
            {
                if (kind == LoaiDongVat.Bat)
                {
                    if (i is Bat) kq.Them(i);
                }
                else if (kind == LoaiDongVat.Bird)
                {
                    if (i is Bird) kq.Them(i);
                }      
                else if (kind == LoaiDongVat.Lion)
                {
                    if (i is Lion) kq.Them(i);
                }
                else
                Console.WriteLine("Không có loài động vật này! ");
            }

            return kq;
        }
        public QuanLyDongVat TimDVCoTenDaiNhatTheoLoai(LoaiDongVat kind)
        {

            QuanLyDongVat kq = TimLoai(kind);
            return kq.TimALLDVCoTen_Max();
        }

        public QuanLyDongVat TimDVCoTenNganNhatTheoLoai(LoaiDongVat kind)
        {
            QuanLyDongVat kq = TimLoai(kind);
            return kq.TimALLDVCoTen_Min();
        }

        //12.	Tìm tất cả động vật có tuổi lớn nhất, nhỏ nhất theo loài
        public QuanLyDongVat TimDVCoTuoiLonNhatTheoLoai(LoaiDongVat kind)
        {
            QuanLyDongVat kq = TimLoai(kind);
            return kq.TimALLDVCoTuoi_Max();
        }
        public QuanLyDongVat TimDVCoTuoiNhoNhatTheoLoai(LoaiDongVat kind)
        {
            QuanLyDongVat kq = TimLoai(kind);
            return kq.TimALLDVCoTuoi_Min();
        }

        //13.	Tìm danh sách các động vật biết bay
        public QuanLyDongVat DSDVBietBay()
        {
            QuanLyDongVat kq = new QuanLyDongVat();
            foreach (var x in ds)
            {
                if (x is IFlyable)
                    kq.Them(x);
            }
            return kq;
        }

        //14.	Tìm danh sách các động vật không biết bay
        public QuanLyDongVat DSDVKoBietBay()
        {
            QuanLyDongVat kq = new QuanLyDongVat();
            foreach (var x in ds)
            {
                if (!(x is IFlyable))
                    kq.Them(x);
            }
            return kq;
        }

        //15.	Sắp sếp theo chiều tăng, giảm của tên, tuổi
        public QuanLyDongVat SapXepDVTangTheoTen()
        { 
            return new QuanLyDongVat { ds = ds.OrderBy(x => x.Name).ToList() };
        }
        public QuanLyDongVat SapXepDVGiamTheoTen()
        {
           return new QuanLyDongVat { ds = ds.OrderByDescending(x => x.Name).ToList() };
        }
        public QuanLyDongVat SapXepDVTangTheoTuoi()
        {
            return new QuanLyDongVat { ds = ds.OrderBy(x => x.Age).ToList() };
        }
        public QuanLyDongVat SapXepDVGiamTheoTuoi()
        {
            return new QuanLyDongVat { ds = ds.OrderByDescending(x => x.Age).ToList() };
        }

        //16.	Xóa tất cả động vật theo loài nào đó
        
        public QuanLyDongVat XoaDVGiDo(LoaiDongVat loai)
        {
            if (loai == LoaiDongVat.Lion)
            {
                ds.RemoveAll(x => x is Lion);
            }
            else if (loai == LoaiDongVat.Bat)
            {
                ds.RemoveAll(x => x is Bat);
            }
            else if (loai == LoaiDongVat.Bird)
            {
                ds.RemoveAll(x => x is Bird);
            }
            return this;
        }

        //17.	Xóa tất cả động vật biết bay, không biết bay
        public void XoaAllDongVatBietBay(Fly flyable)
        {
            ds.RemoveAll(x => x is IFlyable);

        }
        public void XoaAllDongVatKhongBietBay(Fly unflyable)
        {
            ds.RemoveAll(x => !(x is IFlyable));

        }
        //18.	Xóa tất cả động vật biết bay theo tên, tuổi
        public void XoaAllDongVatBietBayTheoTen(string name)
        {
            ds.RemoveAll(x => x.Name == name && x is IFlyable);
        }

        public void XoaAllDongVatBietBayTheoTuoi(int age)
        {
            ds.RemoveAll(x => x.Age == age && x is IFlyable);
        }

        //19.	Xóa tất cả động vật không biết bay theo tên, tuổi
        public void XoaAllDongVatKhongBietBayTheoTen(string name)
        {
            ds.RemoveAll(x => x.Name == name && !(x is IFlyable));
        }

        public void XoaAllDongVatKhongBietBayTheoTuoi(int age)
        {
            ds.RemoveAll(x => x.Age == age && !(x is IFlyable));
        }

        //20.	Xóa tất cả động vật có tuổi nhỏ nhất, lớn nhất
        public void XoaAllDongVatCoTuoiNhoNhat()
        {
            int tuoinhonhat = ds.Min(x => x.Age);
            ds.RemoveAll(x => x.Age == tuoinhonhat);
        }
        public void XoaAllDongVatCoTuoiLonNhat()
        {
            int tuoilonnhat = ds.Max(x => x.Age);
            ds.RemoveAll(x => x.Age == tuoilonnhat);
        }

        //21.	Xóa tất cả động vật theo loài có tuổi nhỏ nhất, lớn nhất
        public void XoaAllDongVatCoTuoiLonNhatTheoLoai(LoaiDongVat loai)
        {
            
            if (loai == LoaiDongVat.Lion)
            {
                int age = ds.FindAll(y => y is Lion).Max(y => y.Age);
                ds.RemoveAll(x => x.Age == age && x is Lion);
            }
            else if (loai == LoaiDongVat.Bat)
            {
                int age = ds.FindAll(y => y is Bat).Max(y => y.Age);
                ds.RemoveAll(x => x.Age == age && x is Bat);
            }
            else if (loai == LoaiDongVat.Bird)
            {
                int age = ds.FindAll(y => y is Bird).Max(y => y.Age);
                ds.RemoveAll(x => x.Age == age && x is Bird);
            }
        }
        public void XoaAllDongVatCoTuoiNhoNhatTheoLoai(LoaiDongVat loai)
        {
            if (loai == LoaiDongVat.Lion)
            {
                int age = ds.FindAll(y => y is Lion).Min(y => y.Age);
                ds.RemoveAll(x => x.Age == age && x is Lion);
            }
            else if (loai == LoaiDongVat.Bat)
            {
                int age = ds.FindAll(y => y is Bat).Min(y => y.Age);
                ds.RemoveAll(x => x.Age == age && x is Bat);
            }
            else if (loai == LoaiDongVat.Bird)
            {
                int age = ds.FindAll(y => y is Bird).Min(y => y.Age);
                ds.RemoveAll(x => x.Age == age && x is Bird);
            }
        }

        //23.	Xóa động  vật tại vị trí x
        public void XoaAllDongVatTaiViTriX(int x)
        {
            ds.RemoveAt(x);
        }

        //24.	Tính tổng tuổi của các động vật theo loài
        public int TinhTongTuoiDongVatTheoLoai(LoaiDongVat loai)
        {
            
            int kq = 0;
            if (loai == LoaiDongVat.Lion)
            {
                kq = ds.Where(x => x is Lion).Sum(x => x.Age);
            }
            else if (loai == LoaiDongVat.Bat)
            {
                kq = ds.Where(x => x is Bat).Sum(x => x.Age);
            }
            else if (loai == LoaiDongVat.Bird)
            {
                kq = ds.Where(x => x is Bird).Sum(x => x.Age);
            }
            return kq;
        }

        //25.	Tính tổng tuổi của các động vật biết bay, không biết bay
        public int TinhTongTuoiDongVatBietBay_KoBietBay(Fly fly)
        {
            
            int kq = 0;
            if (Fly.Flyable == fly)
            {
                kq = ds.Where(x => x is IFlyable).Sum(x => x.Age);
            }
            else if(Fly.Unflyable == fly)
            {
                kq = ds.Where(x => !(x is IFlyable)).Sum(x => x.Age);
            }   
            return kq;
        }

        //27.	Hiển thị danh sách theo danh sách chiều tăng giảm của tên, tuổi

        public QuanLyDongVat HienThiDSTangGiamCuaTenTuoi(Enum sort)
        { 
                switch (sort)
                {
                    case Sort.TangName:
                        return SapXepDVTangTheoTen().XuatTheoLoai((LoaiDongVat)sort);
                    case Sort.GiamName:
                        return SapXepDVGiamTheoTen().XuatTheoLoai((LoaiDongVat)sort);
                    case Sort.TangAge:
                        return SapXepDVTangTheoTuoi().XuatTheoLoai((LoaiDongVat)sort);
                    case Sort.GiamAge:
                        return SapXepDVGiamTheoTuoi().XuatTheoLoai((LoaiDongVat)sort);
                }
            return this;
        }

        //public void HienThiDSTang_GiamTen()
        //{
        //    var tangtheoten = ds.OrderBy(x => x.Name);
        //    foreach (var item in tangtheoten)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //public void HienThiDSGiamTen()
        //{
        //    var tangtheoten = ds.OrderByDescending(x => x.Name);
        //    foreach (var item in tangtheoten)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public void HienThiDSGiamTuoi()
        //{
        //    var tangtheoten = ds.OrderByDescending(x => x.Age);
        //    foreach (var item in tangtheoten)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //public void HienThiDSTangTuoi()
        //{
        //    var tangtheoten = ds.OrderBy(x => x.Age);
        //    foreach (var item in tangtheoten)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //28.	Hiển thị danh sách theo nhóm Bat, Lion, Bird
        //public void HienThiDSNhomLion()
        //{
        //    var kq = ds.Where(x => x is Lion);
        //    foreach (var item in kq)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //public void HienThiDSNhomBat()
        //{
        //    var kq = ds.Where(x => x is Bat);
        //    foreach (var item in kq)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //public void HienThiDSNhomBird()
        //{
        //    var kq = ds.Where(x => x is Bird);
        //    foreach (var item in kq)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        public QuanLyDongVat XuatTheoLoai(LoaiDongVat loai)
        {
            //QuanLyDongVat kq = new QuanLyDongVat();
            //foreach (var dongVat in ds)
            //{
            //    if (dongVat.GetType().Name == loai.ToString())
            //    {
            //        kq.Them(dongVat);
            //    }    
            //}
            //Xuat();
            //return kq;
            TimLoai(loai).Xuat();
            return this;
        }

        //29.	Hiển thị danh sách theo nhóm Bat, Lion, Bird, trong mỗi nhóm hiển thị theo chiều tăng, giảm của tên, tuổi.

        public QuanLyDongVat HienThiDSTangGiamCuaTenTuoiTheoLoai(Enum loai, Enum sort)
        {
            if (loai is LoaiDongVat)
            {
                switch (sort)
                {
                    case Sort.TangName:
                        return SapXepDVTangTheoTen().XuatTheoLoai((LoaiDongVat)loai);
                    case Sort.GiamName:
                        return SapXepDVGiamTheoTen().XuatTheoLoai((LoaiDongVat)loai);
                    case Sort.TangAge:
                        return SapXepDVTangTheoTuoi().XuatTheoLoai((LoaiDongVat)loai);
                    case Sort.GiamAge:
                        return SapXepDVGiamTheoTuoi().XuatTheoLoai((LoaiDongVat)loai);
                }
            }
            return this;
        }

            //public void HienThiDSNhomBirdTangTheoTen()
            //{
            //    var ketQua = ds.Where(x => x is Bird).OrderBy(x => x.Name);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //public void HienThiDSNhomBirdGiamTheoTen()
            //{
            //    var ketQua = ds.Where(x => x is Bird).OrderByDescending(x => x.Name);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //public void HienThiDSNhomBirdTangTheoTuoi()
            //{
            //    var ketQua = ds.Where(x => x is Bird).OrderBy(x => x.Age);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //public void HienThiDSNhomBirdGiamTheoTuoi()
            //{
            //    var ketQua = ds.Where(x => x is Bird).OrderByDescending(x => x.Age);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //public void HienThiDSNhomBatTangTheoTen()
            //{
            //    var ketQua = ds.Where(x => x is Bat).OrderBy(x => x.Name);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //public void HienThiDSNhomBatGiamTheoTen()
            //{
            //    var ketQua = ds.Where(x => x is Bat).OrderByDescending(x => x.Name);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //public void HienThiDSNhomBatTangTheoTuoi()
            //{
            //    var ketQua = ds.Where(x => x is Bat).OrderBy(x => x.Age);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //public void HienThiDSNhomBatGiamTheoTuoi()
            //{
            //    var ketQua = ds.Where(x => x is Bat).OrderByDescending(x => x.Age);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //public void HienThiDSNhomLionTangTheoTen()
            //{
            //    var ketQua = ds.Where(x => x is Lion).OrderBy(x => x.Name);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //public void HienThiDSNhomLionGiamTheoTen()
            //{
            //    var ketQua = ds.Where(x => x is Lion).OrderByDescending(x => x.Name);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //public void HienThiDSNhomLionTangTheoTuoi()
            //{
            //    var ketQua = ds.Where(x => x is Lion).OrderBy(x => x.Age);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //public void HienThiDSNhomLionGiamTheoTuoi()
            //{
            //    var ketQua = ds.Where(x => x is Lion).OrderByDescending(x => x.Age);
            //    foreach (var i in ketQua)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


        
        //7.	Tìm động vật có số lượng nhiều nhất, ít nhất.
        public int TimSLDV_Min()
        {
            int min = int.MaxValue;
            foreach (var loai in (LoaiDongVat[])Enum.GetValues(typeof(LoaiDongVat)))
                if (min > DemSLTheoLoai(loai))
                    min = DemSLTheoLoai(loai);
            return min;
        }

        public int TimSLDV_Max()
        {
            int max = 0;
            foreach (var loai in (LoaiDongVat[])Enum.GetValues(typeof(LoaiDongVat)))
                if (max < DemSLTheoLoai(loai))
                    max = DemSLTheoLoai(loai);
            return max;
        }

        public void TimDongVatSL_Min()
        {
            int min = TimSLDV_Min();
            foreach (var loai in (LoaiDongVat[])Enum.GetValues(typeof(LoaiDongVat)))
                if (min == DemSLTheoLoai(loai))
                {
                    Console.WriteLine(loai);
                    Console.WriteLine("Số lượng là " + DemSLTheoLoai(loai));
                }
            
        }
        public void TimDongVatSL_Max()
        {
            int max = TimSLDV_Max();
            foreach (var loai in (LoaiDongVat[])Enum.GetValues(typeof(LoaiDongVat)))
                if (max == DemSLTheoLoai(loai))
                {
                    Console.WriteLine(loai);
                    Console.WriteLine("Số lượng là " + DemSLTheoLoai(loai));
                }
        }



        //30.	Lưu tất cả các câu hiển thị ở trên xuống File
        public void XuatFile(string filename = "data.txt")
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (var dongVat in ds)
            {
                sw.WriteLine($"{(dongVat is Bat ? "Bat" : (dongVat is Lion) ? "Lion" : "Bird")},{dongVat.Name},{dongVat.Age}");
                // sw.WriteLine($"{dongVat.GetType().Name},{dongVat.Name},{dongVat.Age}");
            }
            sw.Close();
        }


        public Predicate<IAnimal> TimTheoYeuCau(CasesToFind cases, object obj)
        {
            int age = 0;
            switch (cases)
            {
                case CasesToFind.TimDongVatBietBay:
                    return x => x is IFlyable;
                case CasesToFind.TimDongVatBietBayTheoTen:
                    return x => x is IFlyable && x.Name == obj.ToString();
                case CasesToFind.TimDongVatBietBayTheoTuoi:
                    //return x => x is IFlyable && x.Age == int.Parse(obj.ToString());
                    return x => x is IFlyable && x.Age == Convert.ToInt32(obj);
                case CasesToFind.TimDongVatTaiX:
                    return x => x == ds[Convert.ToInt32(obj)];
                case CasesToFind.TimDongVatNhoTuoiTheoLoai:
                    if (Convert.ToInt32(obj) == (int)LoaiDongVat.Lion)
                    {
                        age = ds.FindAll(y => y is Lion).Min(y => y.Age);
                        return x => x.Age == age && x is Lion;
                    }
                    else if (Convert.ToInt32(obj) == (int)LoaiDongVat.Bat)
                    {
                        age = ds.FindAll(y => y is Bat).Min(y => y.Age);
                        return x => x.Age == age && x is Bat;
                    }
                    else if (Convert.ToInt32(obj) == (int)LoaiDongVat.Bird)
                    {
                        age = ds.FindAll(y => y is Bird).Min(y => y.Age);
                        return x => x.Age == age && x is Bird;
                    }
                    return null;
                case CasesToFind.TimDongVatLonTuoiTheoLoai:
                    if (Convert.ToInt32(obj) == (int)LoaiDongVat.Lion)
                    {
                        age = ds.FindAll(y => y is Lion).Max(y => y.Age);
                        return x => x.Age == age && x is Lion;
                    }
                    else if (Convert.ToInt32(obj) == (int)LoaiDongVat.Bat)
                    {
                        age = ds.FindAll(y => y is Bat).Max(y => y.Age);
                        return x => x.Age == age && x is Bat;
                    }
                    else if (Convert.ToInt32(obj) == (int)LoaiDongVat.Bird)
                    {
                        age = ds.FindAll(y => y is Bird).Max(y => y.Age);
                        return x => x.Age == age && x is Bird;
                    }
                    return null;
                case CasesToFind.TimDongVatNhieuTuoiNhat:
                    age = ds.Max(x => x.Age);
                    return x => x.Age == age;
                case CasesToFind.TimDongVatNhoTuoiNhat:
                    age = ds.Min(x => x.Age);
                    return x => x.Age == age;
                case CasesToFind.TimDongVatKhongBietBayTheoTen:
                    return x => x.Name == obj.ToString() && !(x is IFlyable);
                case CasesToFind.TimDongVatKhongBietBayTheoTuoi:
                    return x => x.Age == Convert.ToInt32(obj) && !(x is IFlyable);
                    //Tim theo tung loai
            }
            return null;
        }

        public void XoaTheoYeuCau(Predicate<IAnimal> predicate)
        {
            ds.RemoveAll(predicate);
        }

    }
}
