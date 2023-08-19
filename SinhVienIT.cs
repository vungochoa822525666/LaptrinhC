using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaolopThayThanh
{
    public class SinhVienIT:SinhVien
    {
        //khai bổ sung
        public float diemLTW { get; set; }
        public float diemMMT { get; set; }
        public float diemTinHVP { get; set; }
        
        // hàm tạo truyền dữ liệu vào
        public SinhVienIT(float diemLTW, float diemMMT, float diemTinHVP)
        {
            this.diemLTW=diemLTW;
            this.diemMMT = diemMMT;
            this.diemTinHVP = diemTinHVP;
        }
       
     }
    }

