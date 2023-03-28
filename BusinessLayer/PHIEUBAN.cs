using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PHIEUBAN
    {
        Entities db = Entities.CreateEntities();

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
            List<CHITIETPHIEUBAN_DTO> list_dto = new List<CHITIETPHIEUBAN_DTO>();
            List<tb_CHITIET_PHIEUBANHANG> list_tb = db.tb_CHITIET_PHIEUBANHANG.Where(x => x.IDPB == idpb).ToList();
            foreach (var item in list_tb)
            {
                CHITIETPHIEUBAN_DTO pb_dto = new CHITIETPHIEUBAN_DTO();
                pb_dto.IDCTPB = item.IDCTPB;
                pb_dto.IDPB = item.IDPB;
                pb_dto.IDHH = item.IDHH;
                pb_dto.TENHH = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == item.IDHH).TENHH;
                pb_dto.DONVITINH = item.DONVITINH;
                pb_dto.DONGIA = item.DONGIA;
                pb_dto.QUYDOI = double.Parse(item.QUYDOI.ToString());
                pb_dto.SOLUONG = item.SOLUONG;
                pb_dto.THANHTIEN = item.THANHTIEN;
                pb_dto.GHICHU = item.GHICHU;
                list_dto.Add(pb_dto);
            }
            return list_dto;
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
                Func.Log("ADD", "Bán hàng", $"ID:{pb_dto.IDPB}");
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
                    double tonkho_cu = 0;
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
                        tonkho_cu = double.Parse((ctpb.SOLUONG * ctpb.QUYDOI).ToString());
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
                    hanghoa.TONKHO = hanghoa.TONKHO + tonkho_cu - (item.SOLUONG * item.QUYDOI);

                    if (isNew)
                        db.tb_CHITIET_PHIEUBANHANG.Add(ctpb);
                }

                db.SaveChanges();
                Func.Log("UPDATE", "Bán hàng", $"ID:{pb_dto.IDPB}");
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
