using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAIHANGHOA
    {
        Entities db = Entities.CreateEntities();
        public tb_LOAIHANGHOA GetItem(int id)
        {
            return db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == id);
        }

        public List<tb_LOAIHANGHOA> getList()
        {
            return db.tb_LOAIHANGHOA.ToList();
        }

        public void Add(tb_LOAIHANGHOA dt)
        {
            try
            {
                db.tb_LOAIHANGHOA.Add(dt);
                db.SaveChanges();
                Func.Log("ADD", "Loại hàng hóa",$"ID:{dt.IDLOAI}, Name:{dt.TENLOAI}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(tb_LOAIHANGHOA dt)
        {
            try
            {
                var _dt = db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == dt.IDLOAI);
                string oldValue = $"ID:{_dt.IDLOAI}, Name:{_dt.TENLOAI}";
                string newValue =  $"ID:{dt.IDLOAI}, Name:{dt.TENLOAI}";
                _dt.TENLOAI = dt.TENLOAI;
                
                db.SaveChanges();
                Func.Log("UPDATE", "Loại hàng hóa", newValue, oldValue);
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
                var dt = db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == id);
                db.tb_LOAIHANGHOA.Remove(dt);
                db.SaveChanges();
                Func.Log("DELETE", "Loại hàng hóa", $"ID:{dt.IDLOAI}, Name:{dt.TENLOAI}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
