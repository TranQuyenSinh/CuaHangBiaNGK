using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class HANGHOA_DTO
    {
        public string IDHH { get; set; }
        public string TENHH { get; set; }
        public string MOTA { get; set; }
        public Nullable<int> IDLOAI { get; set; }
        public string TENLOAI { get; set; }
        public Nullable<double> DINHMUCTON { get; set; }
        public Nullable<double> TONKHO { get; set; }
        public int IDDVT { get; set; }
        public string DONVITINH { get; set; }
        public Nullable<double> QUYDOI { get; set; }
        public Nullable<double> GIANHAP { get; set; }
        public Nullable<double> GIABANLE { get; set; }
        public Nullable<double> GIABANSI { get; set; }
    }
}
