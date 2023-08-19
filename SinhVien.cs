using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaolopThayThanh
{
    public class SinhVien
    {
        #region các biến lớp 
        //Khai báo biến lớp         
        private string tenSV;
        private int maSV;
        private string diaChi;
        private string gioiTinh;
        private int soDienThoai;
        #endregion
        #region Các con trucstor
        // Khai báo constructor 
        //(Gán giá trị mặc định cho đối tượng)

        public SinhVien()
        {
            this.tenSV = "tên gì đó";
            this.maSV = 113;
            this.diaChi = " ở đâu đó";
            this.gioiTinh = "Nam, Nữ";
            this.soDienThoai = 082;
        }
        public SinhVien(string tenSV, int maSV, string diaChi, string gioiTinh, int soDienThoai)
        {
            this.tenSV = tenSV;
            this.maSV = maSV;
            this.diaChi = diaChi;
        }
        #endregion
        #region các properties
        //Khai báo Properties để có thể truy xuất sửa đổi dữ liệu:
        public string TenSV
        {
            get { return tenSV; }//get để đọc giá trị            
            set { tenSV = value; } //set giá trị
        }
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }            
        }        
        public string DiaChi
        {
            set { diaChi = value; }
            get { return diaChi; }        
        }
        public string GioiTinh
        {
            set { gioiTinh = value; }
            get { return gioiTinh; }
        }
        public int SoDienThoai
        {
            set { soDienThoai = value; }
            get { return soDienThoai; }
        }
        #endregion
        #region các phương thức
        //Phương thức Tostring
        public override string ToString()
        {
            return this.maSV + "\t" + this.tenSV + "\t" + this.diaChi;

            
        }
        #endregion


    }
}
