using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class LOG
    {
        Entities db = Entities.CreateEntities();
        public List<LOG_DTO> getList(DateTime tuNgay, DateTime denNgay)
        {
            List<tb_LOG> list = db.tb_LOG.Where(x=>x.TIME>=tuNgay && x.TIME<=denNgay).OrderByDescending(x => x.ID).ToList();
            List<LOG_DTO> listDTO = new List<LOG_DTO>();
            foreach(var item in list)
            {
                LOG_DTO dto = new LOG_DTO();
                dto.ID = item.ID;
                dto.IDUSER = item.IDUSER;
                dto.HOTEN = db.tb_USER.FirstOrDefault(x => x.IDUSER == item.IDUSER).TENDAYDU;
                dto.TIME = item.TIME;
                dto.MESSAGE = item.MESSAGE;
                listDTO.Add(dto);
            }
            return listDTO;
        }
    }
}
