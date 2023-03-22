using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class QUYEN
    {
        Entities db = Entities.CreateEntities();

        public List<QUYEN_DTO> getList(int idnhom)
        {
            List<tb_PHANQUYEN> list = db.tb_PHANQUYEN.Where(x=>x.IDNHOM == idnhom).ToList();
            List<QUYEN_DTO> listDTO = new List<QUYEN_DTO>();
            QUYEN_DTO dto;

            foreach (var item in list)
            {
                dto = new QUYEN_DTO();
                dto.ID = item.ID;
                dto.IDNHOM = item.IDNHOM;
                dto.FUNC_CODE = item.FUNC_CODE;
                dto.TENCHUCNANG = db.tb_CHUCNANG.FirstOrDefault(x => x.FUNC_CODE == item.FUNC_CODE).TENCHUCNANG;
                dto.SHOW = item.SHOW;
                dto.ADD = item.ADD;
                dto.UPDATE = item.UPDATE;
                dto.DELETE = item.DELETE;
                dto.PRINT = item.PRINT;
                listDTO.Add(dto);
            }
            return listDTO;
        }

        public void Update(QUYEN_DTO dt)
        {
            try
            {
                var _dt = db.tb_PHANQUYEN.FirstOrDefault(x => x.ID == dt.ID);
                
                _dt.SHOW = dt.SHOW;
                _dt.ADD = dt.ADD;
                _dt.UPDATE = dt.UPDATE;
                _dt.DELETE = dt.DELETE;
                _dt.PRINT = dt.PRINT;

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
