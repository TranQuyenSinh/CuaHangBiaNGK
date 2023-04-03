using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.REPORT
{
    public class DS_NHANVIEN_REPORT
    {
        public string IDNV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public string DIACHI { get; set; }
        public string SODIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public Nullable<bool> DELETED { get; set; }
    }
}
