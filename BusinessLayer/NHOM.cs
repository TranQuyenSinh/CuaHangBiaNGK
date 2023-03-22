using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHOM
    {
        Entities db = Entities.CreateEntities();

        public List<tb_NHOM> getList()
        {
            db = Entities.CreateEntities();
            return db.tb_NHOM.ToList();
        }
        public tb_NHOM getItem(int idnhom)
        {
            return db.tb_NHOM.FirstOrDefault(x => x.IDNHOM == idnhom);
        }

        public void Add(tb_NHOM dt)
        {
            try
            {
                db.tb_NHOM.Add(dt);
                db.SaveChanges();
                Func.Log("ADD", "Nhóm", $"ID:{dt.IDNHOM}, Name:{dt.TENNHOM}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(tb_NHOM dt)
        {
            try
            {
                var _dt = db.tb_NHOM.FirstOrDefault(x => x.IDNHOM == dt.IDNHOM);
                string oldValue = $"ID:{_dt.IDNHOM}, Name:{_dt.TENNHOM}";
                string newValue = $"ID:{dt.IDNHOM}, Name:{dt.TENNHOM}";
                _dt.TENNHOM = dt.TENNHOM;

                db.SaveChanges(); 
                Func.Log("UPDATE", "Nhóm", newValue, oldValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int idnhom)
        {
            try
            {
                db.tb_PHANQUYEN.RemoveRange(db.tb_PHANQUYEN.Where(x => x.IDNHOM == idnhom));
                var dt = db.tb_NHOM.FirstOrDefault(x => x.IDNHOM == idnhom);
                db.tb_NHOM.Remove(dt);
                db.SaveChanges();
                Func.Log("DELETE", "Nhóm", $"ID:{dt.IDNHOM}, Name:{dt.TENNHOM}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
