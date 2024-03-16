using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class SinhVien
    {
        // <Properties>
        public string maSV;
        public string hoTen;
        public float dTB;
        public Boolean gioiTinh;
        public string xepLoai;
        // Phương thức public có thể truy cập được bên trong class và bên ngoài class
        private string lop;
        // Phương thức private chỉ có thể truy cập được bên trong class và không được truy cập từ bên ngoài class.

        public string Lop
        {
            get { return lop; } 
            // getter để đọc giá trị của biến lop
            set { lop = value.Trim(); }  
            // setter để gán giá trị cho biến lop
            // Phương thức Trim được sử dụng để loại bỏ khoảng trắng ở đầu và cuối chuỗi.

        }

        // <Summary>
        // Phương thức tạo lập mặc định của lớp sinh viên (constructor method)
        // Không có tham số
        // <Summary>
        public SinhVien()
        {
            // Gán chuỗi 1 cho thuộc tính maSV
            maSV = "1";
            // Gán giá trị chuỗi a cho thuộc tính hoTen
            hoTen = "a";
        }

        // Construstor có tham số của class SinhVien
        public SinhVien(string ma, string ho, float dtb, bool gt, string lop)
        {
            maSV = ma;
            hoTen = ho;
            dTB = dtb;
            gioiTinh = gt;
            this.lop = lop;
            // this là một biến (lop) tham chiếu đặc biệt cho phép truy cập các thuộc tính, phương thức một cách trực tiếp 
        }

        

        // Construstor có tham số khác class SinhVien
        public SinhVien(string line)
        {
            //001,Nguyen Van A, 8.0, Nam, CTK43
            string[] str = line.Split(',');
            //  để chia nhỏ danh sách được phân tách bằng dấu phẩy
            maSV = str[0];
            hoTen = str[1];
            dTB = float.Parse(str[2]);
            gioiTinh = str[3] == "Nam" ? true : false;
            lop = str[4];
           
        }
        public void XepLoaiSV(SinhVien sv)
        {
            if (sv.dTB > 8.5)
                sv.xepLoai = "Gioi";
            else if (sv.dTB > 6.5)
                sv.xepLoai = "Kha";
            else if (sv.dTB > 5)
                sv.xepLoai = "TB";
            else sv.xepLoai = "Yeu";
        }

        //Ghi đè phương thức ToString của lớp Object
        public override string ToString()
        {
            return string.Format("{0, 2} {1, 10} {2, 5} {3, 6} {4, 10} {5, 10}",maSV, hoTen, dTB, gioiTinh == true ? "Nam" : "Nu", lop, xepLoai);
            // Trả về một chuỗi định dạng thông tin của Object SinhVien
        }

       

        

    }
}
