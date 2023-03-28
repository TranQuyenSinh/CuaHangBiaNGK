using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHACUNGCAP
    {
        Entities db = Entities.CreateEntities();

        public tb_NHACUNGCAP GetItem(int id)
        {
            return db.tb_NHACUNGCAP.FirstOrDefault(x => x.IDNCC == id);
        }

        public List<tb_NHACUNGCAP> getList()
        {
            return db.tb_NHACUNGCAP.Where(x=>x.DELETED == false).ToList();
        }

        public void Add(tb_NHACUNGCAP dt)
        {
            try
            {
                dt.DELETED = false;
                db.tb_NHACUNGCAP.Add(dt);
                db.SaveChanges();
                Func.Log("ADD", "Nhà cung cấp", $"ID:{dt.IDNCC}, Name:{dt.HOTEN}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(tb_NHACUNGCAP dt)
        {
            try
            {
                var _dt = db.tb_NHACUNGCAP.FirstOrDefault(x => x.IDNCC == dt.IDNCC);
                string oldValue = $"ID:{_dt.IDNCC}, Name:{_dt.HOTEN}";
                string newValue = $"ID:{dt.IDNCC}, Name:{dt.HOTEN}";
                _dt.HOTEN = dt.HOTEN;
                _dt.DIACHI = dt.DIACHI;
                _dt.SODIENTHOAI = dt.SODIENTHOAI;
                _dt.EMAIL = dt.EMAIL;

                db.SaveChanges();
                Func.Log("UPDATE", "Nhà cung cấp", newValue, oldValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var dt = db.tb_NHACUNGCAP.FirstOrDefault(x => x.IDNCC == id);
                dt.DELETED = true;
                db.SaveChanges();
                Func.Log("DELETE", "Nhà cung cấp", $"ID:{dt.IDNCC}, Name:{dt.HOTEN}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
