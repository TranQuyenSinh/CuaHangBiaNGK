using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class LOG_DTO
    {
        public int ID { get; set; }
        public Nullable<int> IDUSER { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> TIME { get; set; }
        public string MESSAGE { get; set; }
    }
}
