using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class CHITIETPHIEUBAN_DTO
    {
        public int IDCTPB { get; set; }
        public string IDPB { get; set; }
        public string IDHH { get; set; }
        public string TENHH { get; set; }
        public string DONVITINH { get; set; }
        public double QUYDOI { get; set; }
        public Nullable<double> DONGIA { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<double> THANHTIEN { get; set; }
        public string GHICHU { get; set; }
    }
}
