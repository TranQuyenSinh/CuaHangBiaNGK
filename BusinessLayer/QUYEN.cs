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
            List<QUYEN_DTO> list = (
                from q in db.tb_PHANQUYEN
                where q.IDNHOM == idnhom
                select new QUYEN_DTO
                {
                    ID = q.ID,
                    IDNHOM = q.IDNHOM,
                    FUNC_CODE = q.FUNC_CODE,
                    TENCHUCNANG = q.tb_CHUCNANG.TENCHUCNANG,
                    SHOW = q.SHOW,
                    ADD = q.ADD,
                    UPDATE = q.UPDATE,
                    DELETE = q.DELETE
                }).ToList();
            return list;
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

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
