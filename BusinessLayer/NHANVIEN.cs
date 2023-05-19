using BusinessLayer.DTO;

using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BusinessLayer
{

    public class NHANVIEN
    {
        Entities db = Entities.CreateEntities();

        #region GetData
        public tb_NHANVIEN GetItem(string idnv)
        {
            return db.tb_NHANVIEN.Where(x => x.DELETED == false).FirstOrDefault(x => x.IDNV == idnv);
        }
        public List<tb_NHANVIEN> getList()
        {
            return db.tb_NHANVIEN.Where(x => x.DELETED == false).ToList();
        }
       
        #endregion

        #region XuLyData
        public void Add(tb_NHANVIEN dt)
        {
            try
            {
                dt.DELETED = false;
                db.tb_NHANVIEN.Add(dt);

                string changedLog = Func.FindChanged(db, "Nhân viên");
                if (changedLog != "") Func.WriteLog(changedLog);

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(tb_NHANVIEN dt)
        {
            try
            {
                var _dt = db.tb_NHANVIEN.Where(x => x.DELETED == false).FirstOrDefault(x => x.IDNV == dt.IDNV);
                string oldValue = $"ID:{_dt.IDNV}, Name:{_dt.HOTEN}";
                string newValue = $"ID:{dt.IDNV}, Name:{dt.HOTEN}";
                _dt.HOTEN = dt.HOTEN;
                _dt.NGAYSINH = dt.NGAYSINH;
                _dt.GIOITINH = dt.GIOITINH;
                _dt.SODIENTHOAI = dt.SODIENTHOAI;
                _dt.DIACHI = dt.DIACHI;
                _dt.EMAIL = dt.EMAIL;

                string changedLog = Func.FindChanged(db, "Nhân viên");
                if (changedLog != "") Func.WriteLog($"[ID={dt.IDNV}]" + changedLog);

                db.SaveChanges();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(string idnv)
        {
            try
            {
                var dt = db.tb_NHANVIEN.FirstOrDefault(x => x.IDNV == idnv);
                dt.DELETED = true;

                Func.WriteLog($"[Nhân viên][DELETE][ID={idnv}]");

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        public string GetMaxID()
        {
            var dt = db.tb_NHANVIEN.OrderByDescending(x => x.IDNV).FirstOrDefault();

            if (dt != null)
            {
                int nextId = int.Parse(dt.IDNV.Substring(2)) + 1;
                return "NV" + nextId.ToString("000");
            }
            return "NV001";
        }
    }
}
