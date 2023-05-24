using BusinessLayer.DTO;
using BusinessLayer.REPORT;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class PHIEUBAN
    {
        Entities db = Entities.CreateEntities();
        public List<PHIEUBAN_REPORT_DATA> GetReport(string idpb)
        {
            List<PHIEUBAN_REPORT_DATA> list = (
                from pb in db.tb_PHIEUBANHANG
                join ct in db.tb_CHITIET_PHIEUBANHANG on pb.IDPB equals ct.IDPB
                join user in db.tb_USER on pb.IDUSER equals user.IDUSER
                join hh in db.tb_HANGHOA on ct.IDHH equals hh.IDHH
                join kh in db.tb_KHACHHANG on pb.IDKH equals kh.IDKH
                join nv in db.tb_NHANVIEN on pb.IDNV equals nv.IDNV into group_NV_PB
                where pb.IDPB == idpb
                from table in group_NV_PB.DefaultIfEmpty()
                select new PHIEUBAN_REPORT_DATA
                {
                    IDPB = pb.IDPB,
                    HOTENNV = table.HOTEN == null ? "" : table.HOTEN,
                    HOTENKH = kh.HOTEN,
                    DIACHI = kh.DIACHI,
                    DIENTHOAI = kh.SODIENTHOAI,
                    NGAY = pb.NGAY.Value,
                    GHICHU = pb.GHICHU,
                    NGUOILAP = user.TENDAYDU,
                    LOAIGIA = pb.GIASI == true ? "Giá sỉ" : "Giá lẻ",
                    TONGTIEN = (double)pb.TONGTIEN,
                    PHIVANCHUYEN = (double)pb.PHIVANCHUYEN,
                    // chi tiết
                    TENHH = hh.TENHH,
                    DONVITINH = ct.DONVITINH,
                    DONGIA = (double)ct.DONGIA,
                    SOLUONG = (int)ct.SOLUONG,
                    THANHTIEN = (double)ct.THANHTIEN,
                    GHICHUSP = ct.GHICHU,
                }
                ).ToList();


            /*List<PHIEUBAN_REPORT_DATA> report_list = new List<PHIEUBAN_REPORT_DATA>();
            PHIEUBAN_DTO pb_dto = GetItemPB_DTO(idpb);
            foreach (var chitiet in pb_dto.listCTPB_DTO)
            {
                PHIEUBAN_REPORT_DATA r_item = new PHIEUBAN_REPORT_DATA();
                r_item.IDPB = pb_dto.IDPB;
                if (pb_dto.IDNV != null)
                {
                    r_item.HOTENNV = db.tb_NHANVIEN.FirstOrDefault(x => x.IDNV == pb_dto.IDNV).HOTEN;
                }
                r_item.HOTENKH = pb_dto.HOTEN;
                var khachhang = db.tb_KHACHHANG.FirstOrDefault(x => x.IDKH == pb_dto.IDKH);
                r_item.DIACHI = khachhang.DIACHI;
                r_item.DIENTHOAI = khachhang.SODIENTHOAI;
                r_item.NGAY = pb_dto.NGAY.ToString();
                r_item.GHICHU = pb_dto.GHICHU;
                r_item.NGUOILAP = db.tb_USER.FirstOrDefault(x => x.IDUSER == pb_dto.IDUSER).TENDAYDU;
                r_item.LOAIGIA = pb_dto.GIASI == true ? "Giá sỉ" : "Giá lẻ";
                r_item.TONGTIEN = double.Parse(pb_dto.TONGTIEN.ToString());
                r_item.PHIVANCHUYEN = double.Parse(pb_dto.PHIVANCHUYEN.ToString());
                // chi tiết
                r_item.TENHH = chitiet.TENHH;
                r_item.DONVITINH = chitiet.DONVITINH;
                r_item.DONGIA = double.Parse(chitiet.DONGIA.ToString());
                r_item.SOLUONG = int.Parse(chitiet.SOLUONG.ToString());
                r_item.THANHTIEN = double.Parse(chitiet.THANHTIEN.ToString());
                r_item.GHICHUSP = chitiet.GHICHU;

                report_list.Add(r_item);
            }*/
            Func.WriteLog($"[Bán hàng][PRINT][IDPB={idpb}]");
            return list;
        }

        public tb_PHIEUBANHANG GetItemPB(string id)
        {
            return db.tb_PHIEUBANHANG.FirstOrDefault(x => x.IDPB == id);
        }
        public PHIEUBAN_DTO GetItemPB_DTO(string id)
        {
            var pb = db.tb_PHIEUBANHANG.FirstOrDefault(x => x.IDPB == id);
            PHIEUBAN_DTO pb_dto = new PHIEUBAN_DTO();

            pb_dto.IDPB = pb.IDPB;
            pb_dto.IDUSER = int.Parse(pb.IDUSER.ToString());
            pb_dto.IDKH = pb.IDKH;
            pb_dto.HOTEN = db.tb_KHACHHANG.FirstOrDefault(x => x.IDKH == pb.IDKH).HOTEN;
            pb_dto.GHICHU = pb.GHICHU;
            pb_dto.NGAY = pb.NGAY;
            pb_dto.IDNV = pb.IDNV;
            if (pb.IDNV != null)
            {
                pb_dto.IDNV = pb.IDNV;
                pb_dto.HOTENNV = db.tb_NHANVIEN.FirstOrDefault(x => x.IDNV == pb.IDNV).HOTEN;
            }
            pb_dto.PHIVANCHUYEN = pb.PHIVANCHUYEN;
            pb_dto.TONGTIEN = pb.TONGTIEN;
            pb_dto.GIASI = pb.GIASI;
            pb_dto.listCTPB_DTO = this.getListCTPB_DTO(pb.IDPB);

            return pb_dto;
        }
        public List<PHIEUBAN_DTO> GetListPB_DTO(DateTime tuNgay, DateTime denNgay, string idkh = "")
        {
            List<tb_PHIEUBANHANG> list_tb;
            if (idkh == "")
                list_tb = db.tb_PHIEUBANHANG.Where(x => x.NGAY >= tuNgay && x.NGAY <= denNgay).ToList();
            else
                list_tb = db.tb_PHIEUBANHANG.Where(x => x.NGAY >= tuNgay && x.NGAY <= denNgay && x.IDKH == idkh).ToList();
            List<PHIEUBAN_DTO> list_dto = new List<PHIEUBAN_DTO>();
            foreach (var item in list_tb)
            {
                PHIEUBAN_DTO pb_dto = new PHIEUBAN_DTO();
                pb_dto.IDPB = item.IDPB;
                pb_dto.IDUSER = int.Parse(item.IDUSER.ToString());
                pb_dto.IDKH = item.IDKH;
                pb_dto.HOTEN = db.tb_KHACHHANG.FirstOrDefault(x => x.IDKH == item.IDKH).HOTEN;
                pb_dto.GHICHU = item.GHICHU;
                pb_dto.NGAY = item.NGAY;
                if (item.IDNV != null)
                {
                    pb_dto.IDNV = item.IDNV;
                    pb_dto.HOTENNV = db.tb_NHANVIEN.FirstOrDefault(x => x.IDNV == item.IDNV).HOTEN;
                }
                pb_dto.PHIVANCHUYEN = item.PHIVANCHUYEN;
                pb_dto.TONGTIEN = item.TONGTIEN;
                pb_dto.GIASI = item.GIASI;
                pb_dto.listCTPB_DTO = this.getListCTPB_DTO(item.IDPB);
                list_dto.Add(pb_dto);
            }
            return list_dto;
        }
        public List<tb_CHITIET_PHIEUBANHANG> getListCTPB(string idpb)
        {
            return db.tb_CHITIET_PHIEUBANHANG.Where(x => x.IDPB == idpb).ToList();
        }
        public List<CHITIETPHIEUBAN_DTO> getListCTPB_DTO(string idpb)
        {
            List<CHITIETPHIEUBAN_DTO> list =
                (from ctpb in db.tb_CHITIET_PHIEUBANHANG
                 join hh in db.tb_HANGHOA on ctpb.IDHH equals hh.IDHH
                 where ctpb.IDPB == idpb
                 select new CHITIETPHIEUBAN_DTO
                 {
                     IDCTPB = ctpb.IDCTPB,
                     IDPB = ctpb.IDPB,
                     IDHH = hh.IDHH,
                     TENHH = hh.TENHH,
                     DONVITINH = ctpb.DONVITINH,
                     DONGIA = ctpb.DONGIA,
                     QUYDOI = (double)ctpb.QUYDOI,
                     SOLUONG = ctpb.SOLUONG,
                     THANHTIEN = ctpb.THANHTIEN,
                     GHICHU = ctpb.GHICHU,
                 }).ToList();
            return list;
        }

        public void Add(PHIEUBAN_DTO pb_dto)
        {
            try
            {
                tb_PHIEUBANHANG pb = new tb_PHIEUBANHANG();
                pb.IDPB = pb_dto.IDPB;
                pb.IDKH = pb_dto.IDKH;
                pb.GHICHU = pb_dto.GHICHU;
                pb.NGAY = pb_dto.NGAY;
                pb.PHIVANCHUYEN = pb_dto.PHIVANCHUYEN;
                pb.TONGTIEN = pb_dto.TONGTIEN;
                pb.IDUSER = pb_dto.IDUSER;
                pb.IDNV = pb_dto.IDNV;
                pb.GIASI = pb_dto.GIASI;
                db.tb_PHIEUBANHANG.Add(pb);
                foreach (var item in pb_dto.listCTPB_DTO)
                {
                    tb_CHITIET_PHIEUBANHANG ctpb = new tb_CHITIET_PHIEUBANHANG();
                    ctpb.IDHH = item.IDHH;
                    ctpb.IDPB = item.IDPB;
                    ctpb.DONGIA = item.DONGIA;
                    ctpb.DONVITINH = item.DONVITINH;
                    ctpb.SOLUONG = item.SOLUONG;
                    ctpb.THANHTIEN = item.THANHTIEN;
                    ctpb.QUYDOI = item.QUYDOI;
                    ctpb.GHICHU = item.GHICHU;
                    db.tb_CHITIET_PHIEUBANHANG.Add(ctpb);

                    // cập nhật số lượng hàng hóa trong kho
                    tb_HANGHOA hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == item.IDHH);
                    hanghoa.TONKHO -= item.SOLUONG * item.QUYDOI;
                }
                db.SaveChanges();
                Func.WriteLog($"[Bán hàng][INSERT][IDPB={pb_dto.IDPB}]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(PHIEUBAN_DTO pb_dto)
        {
            try
            {
                tb_PHIEUBANHANG pb = db.tb_PHIEUBANHANG.FirstOrDefault(x => x.IDPB == pb_dto.IDPB);
                pb.IDPB = pb_dto.IDPB;
                pb.IDKH = pb_dto.IDKH;
                pb.GHICHU = pb_dto.GHICHU;
                pb.NGAY = pb_dto.NGAY;
                pb.PHIVANCHUYEN = pb_dto.PHIVANCHUYEN;
                pb.IDNV = pb_dto.IDNV;
                pb.TONGTIEN = pb_dto.TONGTIEN;
                pb.IDUSER = pb_dto.IDUSER;
                pb.GIASI = pb_dto.GIASI;
                // list ctpb trong database trước khi update
                var list_ctpb_in_database = this.getListCTPB(pb.IDPB);
                // tạo 1 list coppy
                List<tb_CHITIET_PHIEUBANHANG> listCTPN_deleted = new List<tb_CHITIET_PHIEUBANHANG>();
                listCTPN_deleted.AddRange(list_ctpb_in_database);
                // lấy list những ctpb bị delete khi update bằng cách
                // list cũ - list mới (theo idctpb) => list những item bị xóa
                listCTPN_deleted.RemoveAll(item => pb_dto.listCTPB_DTO.Any(x => x.IDCTPB == item.IDCTPB));

                // xử lý những item bị xóa
                // trừ lại tồn kho
                // xóa ctpb khỏi database
                foreach (var item_deleted in listCTPN_deleted)
                {
                    tb_HANGHOA hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == item_deleted.IDHH);
                    hanghoa.TONKHO += item_deleted.SOLUONG * item_deleted.QUYDOI;
                    db.tb_CHITIET_PHIEUBANHANG.Remove(item_deleted);
                }

                // cập nhật những item trong list mới
                foreach (var item in pb_dto.listCTPB_DTO)
                {
                    bool isNew = false;
                    double soluongban_cu = 0;
                    tb_CHITIET_PHIEUBANHANG ctpb = db.tb_CHITIET_PHIEUBANHANG.FirstOrDefault(x => x.IDCTPB == item.IDCTPB);
                    // trường hợp thêm mới ctpb
                    // chi tiết pb này sẽ ko tồn tại sẵn trong db nên sẽ ra null
                    // nên cần add vào thay vì update chi tiết pb
                    if (ctpb == null)
                    {
                        ctpb = new tb_CHITIET_PHIEUBANHANG();
                        isNew = true;
                    }
                    else
                    {
                        soluongban_cu = double.Parse((ctpb.SOLUONG * ctpb.QUYDOI).ToString());
                    }
                    ctpb.IDHH = item.IDHH;
                    ctpb.IDPB = item.IDPB;
                    ctpb.DONGIA = item.DONGIA;
                    ctpb.DONVITINH = item.DONVITINH;
                    ctpb.QUYDOI = item.QUYDOI;
                    ctpb.SOLUONG = item.SOLUONG;
                    ctpb.THANHTIEN = item.THANHTIEN;
                    ctpb.GHICHU = item.GHICHU;
                    // cập nhật số lượng hàng hóa trong kho
                    // sửa số lượng hàng hóa thì phải tính lại tồn kho
                    tb_HANGHOA hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == item.IDHH);
                    hanghoa.TONKHO = hanghoa.TONKHO + soluongban_cu - (item.SOLUONG * item.QUYDOI);

                    if (isNew)
                        db.tb_CHITIET_PHIEUBANHANG.Add(ctpb);
                }

                db.SaveChanges();
                Func.WriteLog($"[Bán hàng][UPDATE][IDPB={pb_dto.IDPB}]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string idpb)
        {
            try
            {   
                // phục hồi lại tồn kho
                var list_chitiet = db.tb_CHITIET_PHIEUBANHANG.Where(x => x.IDPB == idpb);
                foreach (var chitiet in list_chitiet)
                {
                    var hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == chitiet.IDHH);
                    hanghoa.TONKHO += chitiet.SOLUONG * chitiet.QUYDOI;
                }

                // Xóa chi tiết phiếu bán
                db.tb_CHITIET_PHIEUBANHANG.RemoveRange(list_chitiet);

                // xóa pb
                var phieuban = db.tb_PHIEUBANHANG.FirstOrDefault(x => x.IDPB == idpb);
                db.tb_PHIEUBANHANG.Remove(phieuban);

                db.SaveChanges();
                Func.WriteLog($"[Bán hàng][DELETE][IDPB={idpb}]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetMaxID()
        {
            var dt = db.tb_PHIEUBANHANG.OrderByDescending(x => x.IDPB).FirstOrDefault();

            if (dt != null)
            {
                int nextId = int.Parse(dt.IDPB.Substring(2)) + 1;
                return "PB" + nextId.ToString("00000");
            }
            return "PB00001";
        }
    }
}
