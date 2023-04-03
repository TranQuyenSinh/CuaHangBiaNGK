using BusinessLayer.DTO;
using BusinessLayer.REPORT;
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
        public List<NHANVIEN_REPORT> getDataReportList()
        {
            List<NHANVIEN_REPORT> list_rpt = new List<NHANVIEN_REPORT>();
            var list = this.getList();
            foreach (var item in list)
            {
                var rptItem = new NHANVIEN_REPORT();
                rptItem.IDNV = item.IDNV;
                rptItem.HOTEN = item.HOTEN;
                rptItem.NGAYSINH = DateTime.Parse(item.NGAYSINH.ToString());
                rptItem.DIACHI = item.DIACHI;
                rptItem.SODIENTHOAI = item.SODIENTHOAI;
                rptItem.EMAIL = item.EMAIL;
                if(item.GIOITINH.Value == true)
                {
                    rptItem.GIOITINH = "Nam";
                }
                else
                {
                    rptItem.GIOITINH = "Nữ";
                }
                list_rpt.Add(rptItem);
            }
            return list_rpt;
        }
        #endregion

        #region XuLyData
        public void Add(tb_NHANVIEN dt)
        {
            try
            {
                dt.DELETED = false;
                db.tb_NHANVIEN.Add(dt);
                db.SaveChanges();
                Func.Log("ADD", "Nhân viên", $"ID:{dt.IDNV}, Name:{dt.HOTEN}");
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

                db.SaveChanges();
                Func.Log("UPDATE", "Nhân viên", newValue, oldValue);
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
                db.SaveChanges();
                Func.Log("DELETE", "Nhân viên", $"ID:{dt.IDNV}, Name:{dt.HOTEN}");
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
