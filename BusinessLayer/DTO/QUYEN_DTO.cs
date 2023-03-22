using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class QUYEN_DTO
    {
        public int ID { get; set; }
        public Nullable<int> IDNHOM { get; set; }
        public string FUNC_CODE { get; set; }
        public string TENCHUCNANG { get; set; }
        public Nullable<bool> SHOW { get; set; }
        public Nullable<bool> ADD { get; set; }
        public Nullable<bool> UPDATE { get; set; }
        public Nullable<bool> DELETE { get; set; }
        public Nullable<bool> PRINT { get; set; }
    }
}
