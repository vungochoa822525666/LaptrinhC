using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaolopThayThanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            SinhVien teo = new SinhVien();
            teo.TenSV = "Nguyễn Văn Tèo";//teo ở bên trái dấu =tự động gọi cái set bên Sinhvieen.Cs(teo ở bên phải = tự động lấy cái get
            //string s = teo.TenSV 
            //teo.MaSV = 113;
            //teo.DiaChi = "Thanh oai, Hà Nội";
            Console.WriteLine("Mã Sinh viên là: " + teo.MaSV);
            Console.WriteLine("Tên sinh viên là: " + teo.TenSV);
            Console.WriteLine("Địa chỉ sinh viên là: " + teo.DiaChi);
            //Console.WriteLine(teo.TenSV);
            //Console.WriteLine(teo.MaSV);
            //Console.WriteLine(teo.GioiTinh);
            //Console.WriteLine(teo.DiaChi);
           // Console.WriteLine(teo.SoDienThoai);
           // Console.ReadKey();
        }
    }
}
