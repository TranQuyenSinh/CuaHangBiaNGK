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
            return db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == idHH);
        }
        public List<tb_HANGHOA> getListHangHoa()
        {
            return db.tb_HANGHOA.Where(x => x.DELETED == false).ToList();
        }

        public List<tb_GIA> getListGia(string idHH)
        {
            return db.tb_GIA.Where(x => x.IDHH == idHH).OrderBy(x => x.QUYDOI).ToList();
        }
        public tb_GIA getItemGia(int IDGIA)
        {
            return db.tb_GIA.FirstOrDefault(x => x.IDGIA == IDGIA);
        }
        public List<tb_GIA> getListGia()
        {
            return db.tb_GIA.OrderBy(x => x.QUYDOI).ToList();
        }
        // lưu ý: hàm này lấy luôn những hàng hóa đã bị xóa (DELETED = true)
        public HANGHOAFULL_DTO GetItemHangHoaFullDTO(string idhh)
        {
            HANGHOAFULL_DTO dto = null;
            List<tb_GIA> listGia = db.tb_GIA.Where(x => x.IDHH == idhh).OrderBy(x => x.QUYDOI).ToList();
            var hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == idhh);
            if (hanghoa == null)
                return null;
            var loai = db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == hanghoa.IDLOAI);
            if (listGia != null)
            {
                dto = new HANGHOAFULL_DTO();
                dto.IDHH = idhh;
                dto.TENHH = hanghoa.TENHH;
                dto.MOTA = hanghoa.MOTA;
                dto.IDLOAI = hanghoa.IDLOAI;
                dto.TENLOAI = loai.TENLOAI;
                dto.DINHMUCTON = hanghoa.DINHMUCTON;
                dto.TONKHO = hanghoa.TONKHO;
                dto.LISTGIA = listGia;
            }
            return dto;
        }
        public List<HANGHOA_DTO> getListHangHoaDTO(bool isMinQuyDoi)
        {
            List<tb_HANGHOA> list = this.getListHangHoa();
            List<HANGHOA_DTO> listDTO = new List<HANGHOA_DTO>();

            foreach (var item in list)
            {
                HANGHOA_DTO dto;
                tb_GIA gia;
                // nếu isMinQuyDoi = true thì lấy giá có quy đổi nhỏ nhất
                if (isMinQuyDoi)
                    gia = db.tb_GIA.Where(x => x.IDHH == item.IDHH).OrderBy(x => x.QUYDOI).FirstOrDefault();
                else
                    gia = db.tb_GIA.Where(x => x.IDHH == item.IDHH).OrderByDescending(x => x.QUYDOI).FirstOrDefault();
                var loai = db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == item.IDLOAI);
                if (gia != null)
                {
                    dto = new HANGHOA_DTO();
                    dto.IDHH = item.IDHH;
                    dto.TENHH = item.TENHH;
                    dto.MOTA = item.MOTA;
                    dto.IDLOAI = item.IDLOAI;
                    dto.TENLOAI = loai.TENLOAI;
                    dto.DINHMUCTON = item.DINHMUCTON;
                    dto.TONKHO = item.TONKHO;
                    dto.IDGIA = gia.IDGIA;
                    dto.DONVITINH = gia.DONVITINH;
                    dto.GIANHAP = gia.GIANHAP;
                    dto.GIABANLE = gia.GIABANLE;
                    dto.GIABANSI = gia.GIABANSI;
                    dto.QUYDOI = gia.QUYDOI;

                    listDTO.Add(dto);
                }
            }
            return listDTO;

        }
        public List<HANGHOAFULL_DTO> getListHangHoaFullDTO()
        {
            List<tb_HANGHOA> list = this.getListHangHoa();
            List<HANGHOAFULL_DTO> listDTO = new List<HANGHOAFULL_DTO>();

            foreach (var item in list)
            {
                HANGHOAFULL_DTO dto;
                List<tb_GIA> listGia = db.tb_GIA.Where(x => x.IDHH == item.IDHH).OrderBy(x => x.QUYDOI).ToList();
                var loai = db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == item.IDLOAI);
                if (listGia != null)
                {
                    dto = new HANGHOAFULL_DTO();
                    dto.IDHH = item.IDHH;
                    dto.TENHH = item.TENHH;
                    dto.MOTA = item.MOTA;
                    dto.IDLOAI = item.IDLOAI;
                    dto.TENLOAI = loai.TENLOAI;
                    dto.DINHMUCTON = item.DINHMUCTON;
                    dto.TONKHO = item.TONKHO;
                    dto.LISTGIA = listGia;

                    listDTO.Add(dto);
                }
            }
            return listDTO;
        }
        public List<HANGHOA_DTO> GetListHangHoaDTOSapHet(bool isReverseQuyDoi)
        {
            var list_tb = db.tb_HANGHOA.Where(x => x.TONKHO <= x.DINHMUCTON && x.DELETED == false).ToList();
            List<HANGHOA_DTO> list_dto = new List<HANGHOA_DTO>();
            foreach (tb_HANGHOA hanghoa in list_tb)
            {
                tb_GIA gia;
                if (isReverseQuyDoi)
                {
                    gia = db.tb_GIA.Where(x => x.IDHH == hanghoa.IDHH).OrderByDescending(x => x.QUYDOI).FirstOrDefault();
                }
                else
                    gia = db.tb_GIA.Where(x => x.IDHH == hanghoa.IDHH).OrderBy(x => x.QUYDOI).FirstOrDefault();
                HANGHOA_DTO dto = new HANGHOA_DTO();
                dto.IDHH = hanghoa.IDHH;
                dto.TENHH = hanghoa.TENHH;
                dto.MOTA = hanghoa.MOTA;
                dto.IDLOAI = hanghoa.IDLOAI;
                dto.TENLOAI = db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == hanghoa.IDLOAI).TENLOAI; ;
                dto.DINHMUCTON = hanghoa.DINHMUCTON / gia.QUYDOI;
                dto.TONKHO = hanghoa.TONKHO / gia.QUYDOI;
                dto.IDGIA = gia.IDGIA;
                dto.DONVITINH = gia.DONVITINH;
                dto.QUYDOI = gia.QUYDOI;
                dto.GIANHAP = gia.GIANHAP;
                dto.GIABANLE = gia.GIABANLE;
                dto.GIABANSI = gia.GIABANSI;
                list_dto.Add(dto);
            }
            return list_dto;
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
        public void AddGia(tb_GIA dvt)
        {
            try
            {
                db.tb_GIA.Add(dvt);
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
        public void UpdateTonKho(string idHH, double tonkhoMoi)
        {
            try
            {
                var hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == idHH);
                string oldValue = $"ID:{hanghoa.IDHH}, Name:{hanghoa.TENHH}, Tồn kho: {hanghoa.TONKHO}";
                hanghoa.TONKHO = tonkhoMoi;
                db.SaveChanges();
                Func.Log("UPDATE", "Tồn kho", $"Tồn kho mới: {tonkhoMoi.ToString("###,###,##0.##")}", oldValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateGia(tb_GIA dt)
        {
            try
            {
                var dvt = db.tb_GIA.FirstOrDefault(x => x.IDGIA == dt.IDGIA);

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
