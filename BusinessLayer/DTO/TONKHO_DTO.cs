using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class TONKHO_DTO
    {
        public string IDHH { get; set; }
        public string TENHH { get; set; }
        public Nullable<int> IDLOAI { get; set; }
        public string TENLOAI { get; set; }
        public Nullable<int> DINHMUCTON { get; set; }
        public Nullable<int> TONKHO { get; set; }
        public int IDDVT { get; set; }
        public string DONVITINH { get; set; }
        public Nullable<int> QUYDOI { get; set; }
        public Nullable<double> GIANHAP { get; set; }
        public Nullable<double> GIABANLE { get; set; }
        public Nullable<double> GIABANSI { get; set; }
    }
}
