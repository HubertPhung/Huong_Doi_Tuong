using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLiDongVatVaDaKeThua
{
    internal class QuanLyDongVat
    {
        List<IAnimal> ds = new List<IAnimal>();


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

           
        }
        public void Xuat()
        {
            foreach (IAnimal animal in ds)
            {
                Console.WriteLine(animal);
                Console.WriteLine();
            }
        }

        // 4.	Đếm số lượng động vật là Bat, Lion, Bird
        public int DemSLBat()
        {
            return ds.Count(x => x is Bat);
        }

        public int DemSLLion()
        {
            return ds.Count(x => x is Lion);    
        }

        public int DemSLBird()
        {
            return ds.Count(x => x is Bird);
        }

        //5.	Đếm số lượng động vật biết bay, không biết bay
        public int DemSLDongVatBietBay()
        {
            return ds.Count(x => x is IFlyable);
        }

        public int DemSLDongVatKhongBietBay()
        {
            return ds.Count(x => !(x is IFlyable));
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
            return ds.Count(x => x.Name == name1  && !(x is IFlyable));
        }
        public int DemSLDVKhongBietBayTheoTuoi( int age1)
        {
            return ds.Count(x => x.Age == age1 && !(x is IFlyable));
        }
        //7.	Tìm động vật có số lượng nhiều nhất, ít nhất.
        public void TimDongVatMAX()
        {

        }

        //8.	Tìm tất cả động vật thuộc loài Bat, Lion, Bird (tương ứng thành 3 phương thức)
        public List<IAnimal> TimALLDVThuocBat()
        {
            List<IAnimal> kq = new List<IAnimal> ();
            foreach (var x in ds)
            {
                if(x is Bat)
                    kq.Add(x);
            }
            return kq;
        }

        public List<IAnimal> TimALLDVThuocLion()
        {
            List<IAnimal> kq = new List<IAnimal> ();
            foreach (var x in ds)
            {
                if (x is Lion)
                    kq.Add(x);
            }
            return kq;
        }

        public List<IAnimal> TimALLDVThuocBird()
        {
            List<IAnimal> kq = new List<IAnimal>();
            foreach (var x in ds)
            {
                if (x is Bird)
                    kq.Add(x) ;
            }
            return kq;
        }

        //9.	Tìm tất cả động vật có tên ngắn nhất, dài nhất

        public List<IAnimal> TimALLDVCoTenNganNhat()
        {
            List<IAnimal> kq = new List<IAnimal> () ;
            int namengannhat = ds.Max(x => x.Name.Length);
            foreach(var x in ds)
            {
                if(x.Name.Length ==  namengannhat)
                {
                    kq.Add(x);
                }
            }
            return kq;
        }

        public List<IAnimal> TimALLDVCoTenDaiNhat()
        {
            List<IAnimal> kq = new List<IAnimal>();
            int namedainhat = ds.Min(x => x.Name.Length);
            foreach (var x in ds)
            {
                if (x.Name.Length == namedainhat)
                {
                    kq.Add(x);
                }
            }
            return kq;
        }

        //10.	Tìm tất cả động vật có tuổi lớn nhất, nhỏ nhất

        public List<IAnimal> TimALLDVCoTuoiMAX()
        {
            List<IAnimal> kq = new List<IAnimal> ();
            int ageMax = ds.Max (x => x.Age);
            foreach(var x in ds)
            {
                if(ageMax == x.Age)
                {
                    kq.Add(x);
                }
            }
            return kq;
        }
        public List<IAnimal> TimALLDVCoTuoiMIN()
        {
            List<IAnimal> kq = new List<IAnimal>();
            int ageMin = ds.Min(x => x.Age);
            foreach (var x in ds)
            {
                if (ageMin == x.Age)
                {
                    kq.Add(x);
                }
            }
            return kq;
        }

        //11.	Tìm tất cả động vật có tên ngắn nhất, dài nhất theo loài
        public QuanLyDongVat TimLoai(string kind)
        {
            QuanLyDongVat kq = null;
            foreach (var i in ds)
            {
                if (kind == "Bat")
                    if (i is Bat) kq.Them(i);
                else if (kind == "Bird")
                    if (i is Bird) kq.Them(i);
                else if (kind == "Lion")
                    if (i is Lion) kq.Them(i);
            }
            return kq;
        }
        public List<IAnimal> TimDVCoTenDaiNhatTheoLoai(string kind1)
        {

            QuanLyDongVat kq = TimLoai(kind1);
            return kq.TimALLDVCoTenDaiNhat();
        }

        public List<IAnimal> TimDVCoTenNganNhatTheoLoai(string kind)
        {
            QuanLyDongVat kq = TimLoai(kind);
            return kq.TimALLDVCoTenNganNhat();
        }

        //12.	Tìm tất cả động vật có tuổi lớn nhất, nhỏ nhất theo loài
        public List<IAnimal> TimDVCoTuoiDaiNhatTheoLoai(string kind)
        {
            QuanLyDongVat kq = TimLoai(kind);
            return kq.TimALLDVCoTuoiMIN();
        }
        public List<IAnimal> TimDVCoTuoiNganNhatTheoLoai(string kind)
        {
            QuanLyDongVat kq = TimLoai(kind);
            return kq.TimALLDVCoTuoiMIN();
        }

        //13.	Tìm danh sách các động vật biết bay
        public List<IAnimal> TimAllDongVatBietBay()
        {
            List<IAnimal> kq = null;
            foreach (var i in ds)
                if (i is IFlyable)
                    kq.Add(i);
            return kq;
        }


        //14.	Tìm danh sách các động vật không biết bay
        public List<IAnimal> TimAllDongVatKoBietBay()
        {
            List<IAnimal> kq = null;
            foreach (var i in ds)
                if (!(i is IFlyable))
                    kq.Add(i);
            return kq;
        }

        //15.	Sắp sếp theo chiều tăng, giảm của tên, tuổi
       
        public List<IAnimal> SapXepTangTheoTenTuoi(string name)
        {
            List<IAnimal> kq = new List<IAnimal>();
            
            return kq;
           
        }

        public void SapSepDVTangTheoTen()
        {
            var tangtheoten = ds.OrderBy(x => x.Name);
            foreach (var i in tangtheoten)
            {
                Console.WriteLine(i);
            }
        }
        public void SapSepDVGiamTheoTen()
        {
            var giamtheoten = ds.OrderByDescending(x => x.Name);
            foreach (var i in giamtheoten)
            {
                Console.WriteLine(i);
            }
        }
        public void SapSepDVTangTheoTuoi()
        {
            var tang = ds.OrderBy(x => x.Age);
            foreach (var i in tang)
            {
                Console.WriteLine(i);
            }
        }
        public void SapSepDVGiamTheoTuoi()
        {
            var giam = ds.OrderByDescending(x => x.Age);
            foreach (var i in giam)
            {
                Console.WriteLine(i);
            }
        }

        public void XoaDVGiDo(string loai)
        {
            if (loai == "Lion")
            {
                ds.RemoveAll(x => x is Lion);
            }
            else if (loai == "Bat")
            {
                ds.RemoveAll(x => x is Bat);
            }
            else if (loai == "Bird")
            {
                ds.RemoveAll(x => x is Bird);
            }
        }
        public void XoaAllDongVatBietBay()
        {
            ds.RemoveAll(x => x is IFlyable);

        }
        public void XoaAllDongVatKhongBietBay()
        {
            ds.RemoveAll(x => !(x is IFlyable));

        }
        public void XoaAllDongVatCoTuoiNhoNhat()
        {
            int tuoingannhat = ds.Min(x => x.Age);
            ds.RemoveAll(x => x.Equals(tuoingannhat));
        }
        public void XoaAllDongVatCoTuoiLonNhat()
        {
            int lonnhat =ds.Max(x => x.Age);
            ds.RemoveAll(x => x.Equals(lonnhat));
        }

        public void XoaAllDongVatCoTuoiLonNhatTheoLoai(string loai)
        {
            int lonnhat = ds.Max(x => x.Age);
            if (loai == "Lion")
            {
                ds.RemoveAll(x => x.Equals(lonnhat));
            }
            else if (loai == "Bat")
            {
                ds.RemoveAll(x => x.Equals(lonnhat));
            }
            else if (loai == "Bird")
            {
                ds.RemoveAll(x => x.Equals(lonnhat));
            }
        }
        public void XoaAllDongVatCoTuoiNhoNhatTheoLoai(string loai)
        {
            int lonnhat = ds.Min(x => x.Age);
            if (loai == "Lion")
            {
                ds.RemoveAll(x => x.Equals(lonnhat));
            }
            else if (loai == "Bat")
            {
                ds.RemoveAll(x => x.Equals(lonnhat));
            }
            else if (loai == "Bird")
            {
                ds.RemoveAll(x => x.Equals(lonnhat));
            }
        }

        public void XoaAllDongVatTaiViTriX()
        {
            Console.WriteLine("Nhap vao vi tri can xoa");
            int vitri = int.Parse(Console.ReadLine());
            ds.RemoveAt(vitri);
        }
        public int TinhTongTuoiDongVatTheoLoai()
        {
            Console.Write("Nhap vao loai can tinh tong: ");
            string loai = Console.ReadLine();
            int kq = 0;
            if (loai == "Lion")
            {
                kq = ds.Where(x => x is Lion).Sum(x => x.Age);
            }
            else if (loai == "Bat")
            {
                kq = ds.Where(x => x is Bat).Sum(x => x.Age);
            }
            else if (loai == "Bird")
            {
                kq = ds.Where(x => x is Bird).Sum(x => x.Age);
            }
            return kq;
        }
        public int TinhTongTuoiDongVatBietBay()
        {
            Console.Write("Nhap vao loai can tinh tong: ");
            string loai = Console.ReadLine();
            int kq = 0;
            if (loai == "Lion" || loai == "Bird" || loai == "Bat")
            {
                kq = ds.Where(x => x is IFlyable).Sum(x => x.Age);
            }
            return kq;
        }


        //27.	Hiển thị danh sách theo danh sách chiều tăng giảm của tên, tuổi

        public void HienThiDSTangTen()
        {
            var tangtheoten = ds.OrderBy(x => x.Name);
            foreach (var item in tangtheoten)
            {
                Console.WriteLine(item);
            }
        }
        public void HienThiDSGiamTen()
        {
            var tangtheoten = ds.OrderByDescending(x => x.Name);
            foreach (var item in tangtheoten)
            {
                Console.WriteLine(item);
            }
        }

        public void HienThiDSGiamTuoi()
        {
            var tangtheoten = ds.OrderByDescending(x => x.Age);
            foreach (var item in tangtheoten)
            {
                Console.WriteLine(item);
            }
        }
        public void HienThiDSTangTuoi()
        {
            var tangtheoten = ds.OrderBy(x => x.Age);
            foreach (var item in tangtheoten)
            {
                Console.WriteLine(item);
            }
        }

        public void HienThiDSNhomLion()
        {
            var kq = ds.Where(x => x is Lion);
            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }
        }
        public void HienThiDSNhomBat()
        {
            var kq = ds.Where(x => x is Bat);
            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }
        }
        public void HienThiDSNhomBird()
        {
            var kq = ds.Where(x => x is Bird);
            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }
        }

        public void HienThiDSNhomBirdTangTheoTen()
        {
            var ketQua = ds.Where(x => x is Bird).OrderBy(x => x.Name);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }
        public void HienThiDSNhomBirdGiamTheoTen()
        {
            var ketQua = ds.Where(x => x is Bird).OrderByDescending(x => x.Name);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

        public void HienThiDSNhomBirdTangTheoTuoi()
        {
            var ketQua = ds.Where(x => x is Bird).OrderBy(x => x.Age);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }
        public void HienThiDSNhomBirdGiamTheoTuoi()
        {
            var ketQua = ds.Where(x => x is Bird).OrderByDescending(x => x.Age);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

        public void HienThiDSNhomBatTangTheoTen()
        {
            var ketQua = ds.Where(x => x is Bat).OrderBy(x => x.Name);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

        public void HienThiDSNhomBatGiamTheoTen()
        {
            var ketQua = ds.Where(x => x is Bat).OrderByDescending(x => x.Name);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

        public void HienThiDSNhomBatTangTheoTuoi()
        {
            var ketQua = ds.Where(x => x is Bat).OrderBy(x => x.Age);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

        public void HienThiDSNhomBatGiamTheoTuoi()
        {
            var ketQua = ds.Where(x => x is Bat).OrderByDescending(x => x.Age);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

        public void HienThiDSNhomLionTangTheoTen()
        {
            var ketQua = ds.Where(x => x is Lion).OrderBy(x => x.Name);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

        public void HienThiDSNhomLionGiamTheoTen()
        {
            var ketQua = ds.Where(x => x is Lion).OrderByDescending(x => x.Name);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

        public void HienThiDSNhomLionTangTheoTuoi()
        {
            var ketQua = ds.Where(x => x is Lion).OrderBy(x => x.Age);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

        public void HienThiDSNhomLionGiamTheoTuoi()
        {
            var ketQua = ds.Where(x => x is Lion).OrderByDescending(x => x.Age);
            foreach (var i in ketQua)
            {
                Console.WriteLine(i);
            }
        }

    }
}
