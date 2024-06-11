using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachAnPham
{
    public enum Selector
    {
        Nam,
        NhaXuatBan,
        TuaDe,
        ISBN,
        TacGia,
        So,
        Tap
    }
    public class DanhSachAnPham : IComparer<AnPham>
    {
        public List<AnPham> collection = new List<AnPham>();
        public Selector ThuocTinh {  get; set; }
        public AnPham this[int index]
        {
            get { return collection[index]; }
            set { collection[index] = value; }
        }

        public void Them(AnPham anPham)
        {
            collection.Add(anPham);
        }
        public void Xoa(AnPham anPham)
        {
            collection.Remove(anPham);
        }

        public void DocFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            AnPham anPham = null;
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] t = s.Split(',');
                string type = t[0];
                int nam = int.Parse(t[1]);
                string nhaXuatBan = t[2];
                string tuaDe = t[3];
                
                if (t[0] == "Sach")
                {
                    string iSBN = t[4];
                    string tacGia = t[5];
                    anPham = new Sach(iSBN, tacGia, nam, nhaXuatBan, tuaDe);
                }
                else if (t[0] == "Tap Chi")
                {
                    int so = int.Parse(t[4]);
                    int tap = int.Parse(t[5]);
                    anPham = new TapChi(so, tap, nam, nhaXuatBan, tuaDe);
                }
                Them(anPham);
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('-', 100));
            sb.AppendLine($"|{"Nam",-4} | {"NhaXuatBan",-12} | {"TuaDe",-19} | {"ISBN",-16} | {"TacGia",-14} |{"So",-5} |{"Tap",-5}");
            sb.AppendLine(new string('-', 100));
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

       

        // Tim kiem
        public DanhSachAnPham TimKiem(object x)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach (var obj in collection)
            {
                switch (ThuocTinh)
                {
                    case Selector.Nam:
                        if (obj.Nam.Equals((int)x))
                        {
                            kq.Them(obj);
                        }

                        break;
                    case Selector.NhaXuatBan:
                        if (obj.NhaXuatBan.Equals(x.ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            kq.Them(obj);
                        }
                        break;
                    case Selector.TuaDe:
                        if (obj.TuaDe.Equals(x.ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            kq.Them(obj);
                        }
                        break;
                    case Selector.ISBN:
                        if((obj as Sach).ISBN.Equals(x.ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            kq.Them(obj);
                        }
                        break;
                    case Selector.TacGia:
                        if((obj as Sach).TacGia.Equals(x.ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            kq.Them(obj);
                        }
                        break;
                    case Selector.So:
                        if((obj as TapChi).So.Equals((int)x))
                        {
                            kq.Them(obj);
                        }
                        break;
                    case Selector.Tap:
                        if ((obj as TapChi).Tap.Equals((int)x))
                        {
                            kq.Them(obj);
                        }
                        break;
                }
            }
            return kq;
        }

        // Sap Xep
        public void HoanVi(int a , int b)
        {
            AnPham temp = collection[a];
            collection[a] = collection[b];
            collection[b] = temp;
        }

        public void SapXepTang()
        {
            for(int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (Compare(this[i], this[j]) > 0)
                    {
                        HoanVi(i, j);
                    }
                }
            }
                
        }

        public void SapXepGiam()
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (Compare(this[i], this[j]) < 0)
                    {
                        HoanVi(i, j);
                    }
                }
            }

        }

        public int Compare(AnPham x, AnPham y)
        {
            switch (ThuocTinh)
            {
                case Selector.Nam:
                    return x.Nam.CompareTo(y.Nam);
                case Selector.NhaXuatBan:
                    return x.NhaXuatBan.CompareTo(y.NhaXuatBan);
                case Selector.TuaDe:
                    return x.TuaDe.CompareTo(y.TuaDe);
                case Selector.ISBN:
                    return (x as Sach).TuaDe.CompareTo((y as Sach).TuaDe);
                case Selector.TacGia:
                    return (x as Sach).TacGia.CompareTo((y as Sach).TacGia);
                case Selector.So:
                    return (x as TapChi).So.CompareTo((y as TapChi).So);
                case Selector.Tap:
                    return (x as TapChi).Tap.CompareTo((y as TapChi).Tap);
                default:
                    return 0;
            }
        }

        // Cap Nhat
        public void CapNhat(int vt, object thongTinMoi)
        {
            AnPham anPham = this[vt];
            switch (ThuocTinh)
            {
                case Selector.Nam:
                    anPham.Nam = (int)thongTinMoi;
                    break;
                case Selector.NhaXuatBan:
                    anPham.NhaXuatBan = thongTinMoi.ToString();
                    break;
                case Selector.TuaDe:
                    anPham.TuaDe = thongTinMoi.ToString();
                    break;
                case Selector.ISBN:
                    (anPham as Sach).ISBN = thongTinMoi.ToString();
                    break;
                case Selector.TacGia:
                    (anPham as Sach).TacGia = thongTinMoi.ToString();
                    break;
                case Selector.So:
                    (anPham as TapChi).So = (int)thongTinMoi;
                    break;
                case Selector.Tap:
                    (anPham as TapChi).Tap = (int)thongTinMoi;
                    break;
                default:
                    break;
            }
        }

        // Xoa 
        public void XoaTheoThuocTinh(object x)
        {
            var ds = TimKiem(x);
            foreach (var i in ds.collection)
            {
               Xoa(i);
            }
        }

       
    }
}
