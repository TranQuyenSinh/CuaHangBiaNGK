using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class PHIEUBAN_DTO
    {
        public string IDPB { get; set; }
        public int IDUSER { get; set; }
        public string IDKH { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<double> PHIVANCHUYEN { get; set; }
        public Nullable<double> TONGTIEN { get; set; }
        public string GHICHU { get; set; }
        public Nullable<bool> GIASI { get; set; }
        public string IDNV { get; set; }
        public string HOTENNV { get; set; }
        public List<CHITIETPHIEUBAN_DTO> listCTPB_DTO { get; set; }
    }
}
