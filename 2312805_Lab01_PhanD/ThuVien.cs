using static System.Math;
using static System.Console;
using System;

namespace _2312805_lab1_PhanD
{
    public class ThuVien
    {
        const int MAX = 100;
        static int[] a = new int[MAX];
        public static int n;

        #region Nhap_Xuat
        public void NhapMang()
        {
            for (int i = 0; i < n; i++)
            {
                Write("a[{0}]= ", i);
                a[i] = Convert.ToInt32(ReadLine());
            }
        }
        public void NhapTuDong()
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rd.Next(-100, 100) % 100;
        }
        public void XuatMang()
        {
            for (int i = 0; i < n; i++)
                Write("{0}\t", a[i]);
        }
        #endregion

        #region Sap_Tang
        public void SapTang()
        {
            bool dk;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    dk = a[i] > a[j];
                    if (dk)
                        HoanVi(ref a[i], ref a[j]);
                }
        }
        void HoanVi(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        #endregion

        #region PTu_Lon_Nhat
        public int PTuLonNhat()
        {
            int x = a[0];
            for (int i = 1; i < n; i++)
                if (x < a[i])
                    x = a[i];
            return x;
        }
        #endregion

        #region So_Lan_Xuat_Hien
        public int SoLanXuatHien(int y)
        {
            int x = 0;
            for (int i = 0; i < n; i++)
                if (a[i] == y)
                    x++;
            return x;
        }
        #endregion region

        #region Thay_The
        public int Tim(int y)
        {
            for (int i = 0; i < n; i++)
                if (a[i] == y)
                    return i;
            return -1;
        }
        public void ThayThe(int y, int z)
        {
            int x = Tim(y);
            do
            {
                a[x] = z;
                x = Tim(y);
            } while (x != -1);
        }
        #endregion

        #region Dao_Nguoc_Mang
        public void DaoNguoc()
        {
            int[] b = new int[MAX];
            int c = 0;
            for (int i = n - 1; i >= 0; i--)
                b[c++] = a[i];
            for (int i = 0; i < n; i++)
                a[i] = b[i];
        }
        #endregion

        #region Xoa
        public int TimPTu(int x)
        {
            for (int i = 0; i < n; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        void Xoa1(int vitri)
        {
            for (; vitri < n - 1; vitri++)
                a[vitri] = a[vitri + 1];
            n--;
        }
        public void Xoa(int x)
        {
            int a = TimPTu(x);
            while (a != -1)
            {
                if (TimPTu(x) != -1)
                    Xoa1(a);
                a = TimPTu(x);
            }
        }
        #endregion

        #region So_Am_Lon_Nhat
        public int SoAmDau()
        {
            for (int i = 0; i < n; i++)
                if (a[i] < 0)
                    return i;
            return 0;
        }
        public int SoAm()
        {
            int y = SoAmDau();
            bool dk;
            int x = a[y];
            for (int i = y + 1; i < n; i++)
            {
                dk = (a[i] < 0 && x < a[i]);
                if (dk)
                    x = a[i];
            }
            return x;
        }
        #endregion

        #region So_Nguyen_To
        bool KiemTra(int n)
        {
            int m = 0, i = 0;
            bool kq;
            if (n < 2)
                kq = false;
            else
            {
                m = (int)Sqrt((double)n);
                i = 2;
                kq = true;

                // Duyệt qua từng giá trị i từ 2 -> m để kiểm tra
                // n có chia hết cho i không? Nếu có, gán kq = 0;
                while (i <= m && kq)
                {
                    if (n % i == 0)
                        kq = false;
                    i++;
                }
            }
            return kq;
        }
        public int SoNguyenTo()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                if (KiemTra(a[i]))
                    sum += a[i];
            return sum;
        }
        #endregion

        #region Sap_Tang_2
        public void SapTang_2()
        {
            bool dk;
            for (int i = 0; i < n - 1; i++)
                for (int j = i; j < n; j++)
                {
                    dk = (a[i] < 0 && a[j] < 0 && a[i] < a[j])
                        || (a[i] > 0 && a[j] < 0)
                        || (a[i] < 0 && a[j] == 0)
                        || (a[i] > 0 && a[j] == 0)
                        || (a[i] > 0 && a[j] > 0 && a[i] > a[j]);
                    if (dk)
                        HoanVi(ref a[i], ref a[j]);
                }
        }
        #endregion

        #region Chen
        public void Chen(int vitri)
        {
            n++;
            for (int i = n - 1; i >= vitri; i--)
                a[i] = a[i - 1];
            Write("\nNhập giá trị a[{0}] = ", vitri);
            a[vitri] = Convert.ToInt32(ReadLine());
        }
        #endregion

        #region O_Hoac_1
        public int TonTai0Hoac1()
        {
            bool x = false, y = false;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == 0)
                    x = true;
                if (a[i] == 1)
                    y = true;
            }
            if (x && y)
                return 1;
            else
                return 0;
        }
        #endregion
    }

}