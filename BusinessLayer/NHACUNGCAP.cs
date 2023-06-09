﻿
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

        #region GetData
        public tb_NHACUNGCAP GetItem(int id)
        {
            return db.tb_NHACUNGCAP.FirstOrDefault(x => x.IDNCC == id);
        }
        public List<tb_NHACUNGCAP> getList()
        {
            return db.tb_NHACUNGCAP.Where(x=>x.DELETED == false).ToList();
        }
      
        #endregion
        #region XuLyData
        public void Add(tb_NHACUNGCAP dt)
        {
            try
            {
                dt.DELETED = false;
                db.tb_NHACUNGCAP.Add(dt);

                string changedLog = Func.FindChanged(db, "Nhà cung cấp");
                if (changedLog != "") Func.WriteLog(changedLog);

                db.SaveChanges();
               
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
                _dt.HOTEN = dt.HOTEN;
                _dt.DIACHI = dt.DIACHI;
                _dt.SODIENTHOAI = dt.SODIENTHOAI;
                _dt.EMAIL = dt.EMAIL;

                string changedLog = Func.FindChanged(db, "Nhà cung cấp");
                if (changedLog != "") Func.WriteLog($"[ID={dt.IDNCC}]"+changedLog);

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
                var dt = db.tb_NHACUNGCAP.FirstOrDefault(x => x.IDNCC == id);
                dt.DELETED = true;
                db.SaveChanges();
                Func.WriteLog($"[Nhà cung cấp][DELETE][ID={id}]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
