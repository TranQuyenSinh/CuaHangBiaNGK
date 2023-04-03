using BusinessLayer.REPORT;
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
        public List<KHACHHANG_REPORT> getDataReportList()
        {
            List<KHACHHANG_REPORT> list_rpt = new List<KHACHHANG_REPORT>();
            var list = this.getList();
            foreach (var item in list)
            {
                var rptItem = new KHACHHANG_REPORT();
                rptItem.IDKH = item.IDKH;
                rptItem.HOTEN = item.HOTEN;
                rptItem.NGAYSINH = DateTime.Parse(item.NGAYSINH.ToString());
                rptItem.DIACHI = item.DIACHI;
                rptItem.SODIENTHOAI = item.SODIENTHOAI;
                rptItem.EMAIL = item.EMAIL;
                if (item.GIOITINH.Value == true)
                {
                    rptItem.GIOITINH = "Nam";
                }
                else
                {
                    rptItem.GIOITINH = "Nữ";
                }
                rptItem.SOLANGIAODICH = db.tb_PHIEUBANHANG.Count(x => x.IDKH == item.IDKH);
                list_rpt.Add(rptItem);
            }
            // sắp xếp theo số lần giao dịch giảm dần
            return list_rpt.OrderByDescending(x => x.SOLANGIAODICH).ToList();
        }
        #endregion

        #region XuLyData
        public void Add(tb_KHACHHANG dt)
        {
            try
            {
                dt.DELETED = false;
                db.tb_KHACHHANG.Add(dt);
                db.SaveChanges();
                Func.Log("ADD", "Khách hàng", $"ID:{dt.IDKH}, Name:{dt.HOTEN}");
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

                db.SaveChanges();
                Func.Log("UPDATE", "Khách hàng", newValue, oldValue);
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
                Func.Log("DELETE", "Khách hàng", $"ID:{dt.IDKH}, Name:{dt.HOTEN}");
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
