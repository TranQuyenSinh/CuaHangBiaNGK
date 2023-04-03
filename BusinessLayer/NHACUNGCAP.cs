using BusinessLayer.REPORT;
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
        public List<NHACUNGCAP_REPORT> getDataReportList()
        {
            List<NHACUNGCAP_REPORT> list_rpt = new List<NHACUNGCAP_REPORT>();
            var list = this.getList();
            foreach (var item in list)
            {
                var rptItem = new NHACUNGCAP_REPORT();
                rptItem.IDNCC = item.IDNCC;
                rptItem.HOTEN = item.HOTEN;
                rptItem.DIACHI = item.DIACHI;
                rptItem.SODIENTHOAI = item.SODIENTHOAI;
                rptItem.EMAIL = item.EMAIL;
                rptItem.SOLANGIAODICH = db.tb_PHIEUNHAPHANG.Count(x => x.IDNCC == item.IDNCC);
                list_rpt.Add(rptItem);
            }
            // sắp xếp theo số lần giao dịch giảm dần
            return list_rpt.OrderByDescending(x => x.SOLANGIAODICH).ToList();
        }
        #endregion
        #region XuLyData
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
        #endregion
    }
}
