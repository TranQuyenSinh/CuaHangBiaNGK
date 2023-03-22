using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer
{
    public class HANGHOA
    {
        Entities db = Entities.CreateEntities();
        public tb_HANGHOA getItemHangHoa(string idHH)
        {
            return db.tb_HANGHOA.FirstOrDefault(x => x.DELETED == false && x.IDHH == idHH);
        }

        public List<tb_DONVITINH> getListDonViTinh(string idHH)
        {
            return db.tb_DONVITINH.Where(x => x.IDHH == idHH).OrderBy(x => x.QUYDOI).ToList();
        }
        public tb_DONVITINH getItemDonViTinh(int iddvt)
        {
            return db.tb_DONVITINH.FirstOrDefault(x => x.IDDVT == iddvt);
        }
        public List<tb_DONVITINH> getListDonViTinh()
        {
            return db.tb_DONVITINH.OrderBy(x => x.QUYDOI).ToList();
        }
        public HANGHOA_DTO GetItemHangHoaDTO(string id)
        {
            HANGHOA_DTO dto = null;
            var dvtGoc = db.tb_DONVITINH.FirstOrDefault(x => x.QUYDOI == 1 && x.IDHH == id);
            var hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.DELETED == false && x.IDHH == dvtGoc.IDHH);
            if (hanghoa == null)
                return null;
            var loai = db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == hanghoa.IDLOAI);
            if (dvtGoc != null)
            {
                dto = new HANGHOA_DTO();
                dto.IDHH = dvtGoc.IDHH;
                dto.TENHH = hanghoa.TENHH;
                dto.MOTA = hanghoa.MOTA;
                dto.IDLOAI = hanghoa.IDLOAI;
                dto.TENLOAI = loai.TENLOAI;
                dto.DINHMUCTON = hanghoa.DINHMUCTON;
                dto.TONKHO = hanghoa.TONKHO;
                dto.IDDVT = dvtGoc.IDDVT;
                dto.DONVITINH = dvtGoc.DONVITINH;
                dto.QUYDOI = dvtGoc.QUYDOI;
                dto.GIANHAP = dvtGoc.GIANHAP;
                dto.GIABANLE = dvtGoc.GIABANLE;
                dto.GIABANSI = dvtGoc.GIABANSI;
            }
            return dto;
        }

        public List<HANGHOA_DTO> getListHangHoaDTO()
        {
           /* Random rd = new Random();
            foreach (var hh in db.tb_HANGHOA.ToList())
            {
                hh.TONKHO = rd.Next(1, 100);
            }
            db.SaveChanges();*/
            List<tb_DONVITINH> list = db.tb_DONVITINH.Where(x => x.QUYDOI == 1).ToList();
            List<HANGHOA_DTO> listDTO = new List<HANGHOA_DTO>();

            foreach (var item in list)
            {
                var dto = GetItemHangHoaDTO(item.IDHH);
                if (dto != null)
                    listDTO.Add(dto);
            }
            return listDTO;
        }

        
        public void AddHangHoa(tb_HANGHOA hanghoa)
        {
            try
            {
                db = Entities.CreateEntities();
                hanghoa.DELETED = false;
                db.tb_HANGHOA.Add(hanghoa);
                db.SaveChanges();
                Func.Log("ADD", "Hàng hóa", $"ID:{hanghoa.IDHH}, Name:{hanghoa.TENHH}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddDonViTinh(tb_DONVITINH dvt)
        {
            try
            {
                db.tb_DONVITINH.Add(dvt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateHangHoa(tb_HANGHOA dt)
        {
            try
            {
                var hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == dt.IDHH);
                string oldValue = "";
                string newValue = $"ID:{dt.IDHH}, Name:{dt.TENHH}";
                hanghoa.TENHH = dt.TENHH;
                hanghoa.MOTA = dt.MOTA;
                hanghoa.IDLOAI = dt.IDLOAI;
                hanghoa.DINHMUCTON = dt.DINHMUCTON;
                hanghoa.TONKHO = dt.TONKHO;

                db.SaveChanges();
                Func.Log("UPDATE", "Hàng hóa", newValue, oldValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateDonViTinh(tb_DONVITINH dt)
        {
            try
            {
                var dvt = db.tb_DONVITINH.FirstOrDefault(x => x.IDDVT == dt.IDDVT);

                dvt.DONVITINH = dt.DONVITINH;
                dvt.QUYDOI = dt.QUYDOI;
                dvt.GIANHAP = dt.GIANHAP;
                dvt.GIABANLE = dt.GIABANLE;
                dvt.GIABANSI = dt.GIABANSI;

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
                var dt = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == id);
                dt.DELETED = true;
                db.SaveChanges();
                Func.Log("DELETE", "Hàng hóa", $"ID:{dt.IDHH}, Name:{dt.TENHH}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
