using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class PHIEUNHAP_DTO
    {
        public string IDPN { get; set; }
        public int IDUSER { get; set; }
        public Nullable<int> IDNCC { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<double> PHIVANCHUYEN { get; set; }
        public string GHICHU { get; set; }
        public Nullable<double> TONGTIEN { get; set; }
        public List<CHITIETPHIEUNHAP_DTO> listCTPN_DTO { get; set; }
    }
}
