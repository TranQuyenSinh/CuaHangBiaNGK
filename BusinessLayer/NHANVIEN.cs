using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BusinessLayer
{

    public class NHANVIEN
    {
        Entities db = Entities.CreateEntities();


        public tb_NHANVIEN GetItem(string idnv)
        {
            return db.tb_NHANVIEN.Where(x => x.DELETED == false).FirstOrDefault(x => x.IDNV == idnv);
        }

        public List<tb_NHANVIEN> getList()
        {
            return db.tb_NHANVIEN.Where(x => x.DELETED == false).ToList();
        }

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
