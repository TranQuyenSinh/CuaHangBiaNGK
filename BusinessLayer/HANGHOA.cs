using BusinessLayer.DTO;
using BusinessLayer.REPORT;
using DataLayer;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
        public List<HANGHOA_REPORT_DATA> GetReport()
        {
            List<HANGHOA_REPORT_DATA> list = (
                from hh in db.tb_HANGHOA
                where hh.DELETED == false
                select new HANGHOA_REPORT_DATA
                {
                    IDHH = hh.IDHH,
                    TENHH = hh.TENHH,
                    MOTA = hh.MOTA,
                    MAVACH = hh.MaVach
                }).ToList();
            Func.WriteLog("[Hàng hóa][PRINT]");
            return list;
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
                dto.MaVach = hanghoa.MaVach;
                dto.LISTGIA = listGia;
            }
            return dto;
        }
        // hàm dùng để tìm hàng hóa khi nhập vào phiếu nhập, bán bằng barcode
        public HANGHOAFULL_DTO GetItemHangHoaFullDTOByBarcode(string barcode)
        {
            HANGHOAFULL_DTO returnitem =
                (from hh in db.tb_HANGHOA
                 where hh.MaVach == barcode
                 select new HANGHOAFULL_DTO
                 {
                     IDHH = hh.IDHH,
                     TENHH = hh.TENHH,
                     MOTA = hh.MOTA,
                     IDLOAI = hh.IDLOAI,
                     TENLOAI = hh.tb_LOAIHANGHOA.TENLOAI,
                     DINHMUCTON = hh.DINHMUCTON,
                     TONKHO = hh.TONKHO,
                     MaVach = hh.MaVach,
                     LISTGIA = (
                        from gia in hh.tb_GIA
                        orderby gia.QUYDOI
                        select gia
                     ).ToList()
                 }).FirstOrDefault();

           /* HANGHOAFULL_DTO dto = null;
            var hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.MaVach == barcode);
            if (hanghoa == null)
                return null;
            List<tb_GIA> listGia = db.tb_GIA.Where(x => x.IDHH == hanghoa.IDHH).OrderBy(x => x.QUYDOI).ToList();
            var loai = db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == hanghoa.IDLOAI);
            if (listGia != null)
            {
                dto = new HANGHOAFULL_DTO();
                dto.IDHH = hanghoa.IDHH;
                dto.TENHH = hanghoa.TENHH;
                dto.MOTA = hanghoa.MOTA;
                dto.IDLOAI = hanghoa.IDLOAI;
                dto.TENLOAI = loai.TENLOAI;
                dto.DINHMUCTON = hanghoa.DINHMUCTON;
                dto.TONKHO = hanghoa.TONKHO;
                dto.MaVach = hanghoa.MaVach;
                dto.LISTGIA = listGia;
            }*/
            return returnitem;
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
                    dto.MaVach = item.MaVach;
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
       
        public List<HANGTON_REPORT_DATA> GetReportData_HangTonSapHet()
        {
            var hanghoas = db.tb_HANGHOA.Where(x => x.TONKHO <= x.DINHMUCTON && x.DELETED == false).ToList();
            List<HANGTON_REPORT_DATA> list = new List<HANGTON_REPORT_DATA>();
            foreach (tb_HANGHOA hanghoa in hanghoas)
            {
                // lấy đơn vị nhỏ nhất (chai, lon)
                tb_GIA gia = db.tb_GIA.Where(x => x.IDHH == hanghoa.IDHH).OrderBy(x => x.QUYDOI).FirstOrDefault();
                HANGTON_REPORT_DATA rpt_item = new HANGTON_REPORT_DATA();
                rpt_item.IDHH = hanghoa.IDHH;
                rpt_item.TENHH = hanghoa.TENHH;
                rpt_item.TENLOAI = db.tb_LOAIHANGHOA.FirstOrDefault(x => x.IDLOAI == hanghoa.IDLOAI).TENLOAI; 
                rpt_item.TONKHO = double.Parse(hanghoa.TONKHO.ToString());
                rpt_item.DONVITINH = gia.DONVITINH;
                rpt_item.DINHMUCTON = double.Parse(hanghoa.DINHMUCTON.ToString());
                rpt_item.GIANHAP = double.Parse(gia.GIANHAP.ToString());
                list.Add(rpt_item);
            }
            return list;
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
                dto.MaVach = hanghoa.MaVach;
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
        public bool isExistsIDHH(string idhh)
        {
            return db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == idhh) != null;
        }
        public void AddHangHoa(tb_HANGHOA hanghoa)
        {
            try
            {
                db = Entities.CreateEntities();
                hanghoa.DELETED = false;
                db.tb_HANGHOA.Add(hanghoa);

                string changedLog = Func.FindChanged(db, "Hàng hóa");
                if (changedLog != "") Func.WriteLog(changedLog);

                db.SaveChanges();
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
                hanghoa.TENHH = dt.TENHH;
                hanghoa.MOTA = dt.MOTA;
                hanghoa.MaVach = dt.MaVach;
                hanghoa.IDLOAI = dt.IDLOAI;
                hanghoa.DINHMUCTON = dt.DINHMUCTON;
                hanghoa.TONKHO = dt.TONKHO;

                string changedLog = Func.FindChanged(db, "Hàng hóa");
                if (changedLog != "") Func.WriteLog($"[ID={dt.IDHH}]" + changedLog);
                db.SaveChanges();
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
                hanghoa.TONKHO = tonkhoMoi;

                string changedLog = Func.FindChanged(db, "Tồn kho");
                if (changedLog != "") Func.WriteLog($"[ID={idHH}]"+changedLog);
                db.SaveChanges();
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

                string changedLog = Func.FindChanged(db, "Hàng hóa");
                if (changedLog != "") Func.WriteLog($"[ID={dt.IDHH}]" + changedLog);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteHangHoa(string id)
        {
            try
            {
                var dt = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == id);
                dt.DELETED = true;
                
                Func.WriteLog($"[Hàng hóa][DELETE][ID={id}]");
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
