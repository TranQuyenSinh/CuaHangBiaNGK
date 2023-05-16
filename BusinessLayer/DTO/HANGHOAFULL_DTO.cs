using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class HANGHOAFULL_DTO
    {
        public string IDHH { get; set; }
        public string TENHH { get; set; }
        public string MOTA { get; set; }
        public Nullable<int> IDLOAI { get; set; }
        public string TENLOAI { get; set; }
        public Nullable<double> DINHMUCTON { get; set; }
        public Nullable<double> TONKHO { get; set; }
        public string MaVach { get; set; }
        public List<tb_GIA> LISTGIA { get; set; }
    }
}
