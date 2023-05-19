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

                string changedLog = Func.FindChanged(db, "Loại hàng hóa");
                if (changedLog != "") Func.WriteLog(changedLog);

                db.SaveChanges(); 
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
                _dt.TENLOAI = dt.TENLOAI;

                string changedLog = Func.FindChanged(db, "Loại hàng hóa");
                if (changedLog != "") Func.WriteLog($"[ID={dt.IDLOAI}]" + changedLog);

                db.SaveChanges();
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
                Func.WriteLog($"[Loại hàng hóa][DELETE][ID={id}]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
