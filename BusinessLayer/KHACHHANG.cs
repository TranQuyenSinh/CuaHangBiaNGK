
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KHACHHANG
    {
        Entities db = Entities.CreateEntities();

        #region GetData
        public tb_KHACHHANG GetItem(string id)
        {
            return db.tb_KHACHHANG.Where(x => x.DELETED == false).FirstOrDefault(x => x.IDKH == id);
        }
        public List<tb_KHACHHANG> getList()
        {
            return db.tb_KHACHHANG.Where(x => x.DELETED == false).ToList();
        }
        #endregion

        #region XuLyData
        public void Add(tb_KHACHHANG dt)
        {
            try
            {
                dt.DELETED = false;
                db.tb_KHACHHANG.Add(dt);

                string changedLog = Func.FindChanged(db, "Khách hàng");
                if (changedLog != "") Func.WriteLog(changedLog);
                db.SaveChanges();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(tb_KHACHHANG dt)
        {
            try
            {
                var _dt = db.tb_KHACHHANG.FirstOrDefault(x => x.IDKH == dt.IDKH);
                string oldValue = $"ID:{_dt.IDKH}, Name:{_dt.HOTEN}";
                string newValue = $"ID:{dt.IDKH}, Name:{dt.HOTEN}";
                _dt.HOTEN = dt.HOTEN;
                _dt.NGAYSINH = dt.NGAYSINH;
                _dt.GIOITINH = dt.GIOITINH;
                _dt.DIACHI = dt.DIACHI;
                _dt.SODIENTHOAI = dt.SODIENTHOAI;
                _dt.EMAIL = dt.EMAIL;

                string changedLog = Func.FindChanged(db, "Khách hàng");
                if (changedLog != "") Func.WriteLog($"[ID={dt.IDKH}]"+changedLog);

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(string id)
        {
            try
            {
                var dt = db.tb_KHACHHANG.FirstOrDefault(x => x.IDKH == id);
                dt.DELETED = true;
                db.SaveChanges();
                
                Func.WriteLog($"[Khách hàng][DELETE][ID={id}]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        public string GetMaxID()
        {
            var dt = db.tb_KHACHHANG.OrderByDescending(x => x.IDKH).FirstOrDefault();

            if (dt != null)
            {
                int nextId = int.Parse(dt.IDKH.Substring(2)) + 1;
                return "KH" + nextId.ToString("000");
            }
            return "KH001";
        }
    }
}
