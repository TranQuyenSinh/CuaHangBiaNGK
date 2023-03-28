using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class PHIEUNHAP
    {
        Entities db = Entities.CreateEntities();

        public tb_PHIEUNHAPHANG GetItemPN(string id)
        {
            return db.tb_PHIEUNHAPHANG.FirstOrDefault(x => x.IDPN == id);
        }
        public PHIEUNHAP_DTO GetItemPN_DTO(string id)
        {

            var pn = db.tb_PHIEUNHAPHANG.FirstOrDefault(x => x.IDPN == id);
            PHIEUNHAP_DTO pn_dto = new PHIEUNHAP_DTO();

            pn_dto.IDPN = pn.IDPN;
            pn_dto.IDUSER = int.Parse(pn.IDUSER.ToString());
            pn_dto.IDNCC = pn.IDNCC;
            pn_dto.HOTEN = db.tb_NHACUNGCAP.FirstOrDefault(x => x.IDNCC == pn.IDNCC).HOTEN;
            pn_dto.GHICHU = pn.GHICHU;
            pn_dto.NGAY = pn.NGAY;
            pn_dto.PHIVANCHUYEN = pn.PHIVANCHUYEN;
            pn_dto.TONGTIEN = pn.TONGTIEN;
            pn_dto.listCTPN_DTO = this.getListCTPN_DTO(pn.IDPN);

            return pn_dto;
        }
        public List<PHIEUNHAP_DTO> GetListPN_DTO(DateTime tuNgay, DateTime denNgay, int idncc = -1)
        {
            List<tb_PHIEUNHAPHANG> list;
            if (idncc == -1)
                list = db.tb_PHIEUNHAPHANG.Where(x => x.NGAY >= tuNgay && x.NGAY <= denNgay).ToList();
            else
                list = db.tb_PHIEUNHAPHANG.Where(x => x.NGAY >= tuNgay && x.NGAY <= denNgay && x.IDNCC == idncc).ToList();
            List<PHIEUNHAP_DTO> list_dto = new List<PHIEUNHAP_DTO>();
            foreach (var item in list)
            {
                PHIEUNHAP_DTO dto = new PHIEUNHAP_DTO();
                dto.IDPN = item.IDPN;
                dto.IDUSER = int.Parse(item.IDUSER.ToString());
                dto.IDNCC = item.IDNCC;
                dto.HOTEN = db.tb_NHACUNGCAP.FirstOrDefault(x => x.IDNCC == item.IDNCC).HOTEN;
                dto.GHICHU = item.GHICHU;
                dto.NGAY = item.NGAY;
                dto.PHIVANCHUYEN = item.PHIVANCHUYEN;
                dto.TONGTIEN = item.TONGTIEN;
                dto.listCTPN_DTO = this.getListCTPN_DTO(item.IDPN);
                list_dto.Add(dto);
            }
            return list_dto;
        }
        public List<tb_CHITIET_PHIEUNHAPHANG> getListCTPN(string idpn)
        {
            return db.tb_CHITIET_PHIEUNHAPHANG.Where(x => x.IDPN == idpn).ToList();
        }
        public List<CHITIETPHIEUNHAP_DTO> getListCTPN_DTO(string idpn)
        {
            List<CHITIETPHIEUNHAP_DTO> list_dto = new List<CHITIETPHIEUNHAP_DTO>();
            List<tb_CHITIET_PHIEUNHAPHANG> list_tb = db.tb_CHITIET_PHIEUNHAPHANG.Where(x => x.IDPN == idpn).ToList();
            foreach (var item in list_tb)
            {
                CHITIETPHIEUNHAP_DTO pn_dto = new CHITIETPHIEUNHAP_DTO();
                pn_dto.IDCTPN = item.IDCTPN;
                pn_dto.IDPN = item.IDPN;
                pn_dto.IDHH = item.IDHH;
                pn_dto.TENHH = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == item.IDHH).TENHH;
                pn_dto.DONVITINH = item.DONVITINH;
                pn_dto.DONGIA = item.DONGIA;
                pn_dto.QUYDOI = double.Parse(item.QUYDOI.ToString());
                pn_dto.SOLUONG = item.SOLUONG;
                pn_dto.THANHTIEN = item.THANHTIEN;
                pn_dto.GHICHU = item.GHICHU;
                list_dto.Add(pn_dto);
            }
            return list_dto;
        }
        
        public void Add(PHIEUNHAP_DTO pn_dto)
        {
            try
            {
                tb_PHIEUNHAPHANG pn = new tb_PHIEUNHAPHANG();
                pn.IDPN = pn_dto.IDPN;
                pn.IDNCC = pn_dto.IDNCC;
                pn.GHICHU = pn_dto.GHICHU;
                pn.NGAY = pn_dto.NGAY;
                pn.PHIVANCHUYEN = pn_dto.PHIVANCHUYEN;
                pn.TONGTIEN = pn_dto.TONGTIEN;
                pn.IDUSER = pn_dto.IDUSER;
                db.tb_PHIEUNHAPHANG.Add(pn);
                foreach (var item in pn_dto.listCTPN_DTO)
                {
                    tb_CHITIET_PHIEUNHAPHANG ctpn = new tb_CHITIET_PHIEUNHAPHANG();
                    ctpn.IDHH = item.IDHH;
                    ctpn.IDPN = item.IDPN;
                    ctpn.DONGIA = item.DONGIA;
                    ctpn.DONVITINH = item.DONVITINH;
                    ctpn.SOLUONG = item.SOLUONG;
                    ctpn.THANHTIEN = item.THANHTIEN;
                    ctpn.QUYDOI = item.QUYDOI;
                    ctpn.GHICHU = item.GHICHU;
                    db.tb_CHITIET_PHIEUNHAPHANG.Add(ctpn);

                    // cập nhật số lượng hàng hóa trong kho
                    tb_HANGHOA hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == item.IDHH);
                    hanghoa.TONKHO += item.SOLUONG * item.QUYDOI;
                }
                db.SaveChanges();
                Func.Log("ADD", "Nhập hàng", $"ID:{pn_dto.IDPN}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(PHIEUNHAP_DTO pn_dto)
        {
            try
            {
                tb_PHIEUNHAPHANG pn = db.tb_PHIEUNHAPHANG.FirstOrDefault(x => x.IDPN == pn_dto.IDPN);
                pn.IDPN = pn_dto.IDPN;
                pn.IDNCC = pn_dto.IDNCC;
                pn.GHICHU = pn_dto.GHICHU;
                pn.NGAY = pn_dto.NGAY;
                pn.PHIVANCHUYEN = pn_dto.PHIVANCHUYEN;
                pn.TONGTIEN = pn_dto.TONGTIEN;
                pn.IDUSER = pn_dto.IDUSER;
                // list ctpn trong database trước khi update
                var list_ctpn_in_database = this.getListCTPN(pn.IDPN);
                // tạo 1 list coppy
                List<tb_CHITIET_PHIEUNHAPHANG> listCTPN_deleted = new List<tb_CHITIET_PHIEUNHAPHANG>();
                listCTPN_deleted.AddRange(list_ctpn_in_database);
                // lấy list những ctpn bị delete khi update bằng cách
                // list cũ - list mới (theo idctpn) => list những item bị xóa
                listCTPN_deleted.RemoveAll(item => pn_dto.listCTPN_DTO.Any(x => x.IDCTPN == item.IDCTPN));

                // xử lý những item bị xóa
                // trừ lại tồn kho
                // xóa ctpn khỏi database
                foreach (var item_deleted in listCTPN_deleted)
                {
                    tb_HANGHOA hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == item_deleted.IDHH);
                    hanghoa.TONKHO -= item_deleted.SOLUONG * item_deleted.QUYDOI;
                    db.tb_CHITIET_PHIEUNHAPHANG.Remove(item_deleted);
                }

                // cập nhật những item trong list mới
                foreach (var item in pn_dto.listCTPN_DTO)
                {
                    bool isNew = false;
                    double tonkho_cu = 0;
                    tb_CHITIET_PHIEUNHAPHANG ctpn = db.tb_CHITIET_PHIEUNHAPHANG.FirstOrDefault(x => x.IDCTPN == item.IDCTPN);
                    // trường hợp thêm mới ctpn
                    // chi tiết pn này sẽ ko tồn tại sẵn trong db nên sẽ ra null
                    // nên cần add vào thay vì update chi tiết pn
                    if (ctpn == null)
                    {
                        ctpn = new tb_CHITIET_PHIEUNHAPHANG();
                        isNew = true;
                    }
                    else
                    {
                        tonkho_cu = double.Parse((ctpn.SOLUONG * ctpn.QUYDOI).ToString());
                    }
                    ctpn.IDHH = item.IDHH;
                    ctpn.IDPN = item.IDPN;
                    ctpn.DONGIA = item.DONGIA;
                    ctpn.DONVITINH = item.DONVITINH;
                    ctpn.QUYDOI = item.QUYDOI;
                    ctpn.SOLUONG = item.SOLUONG;
                    ctpn.THANHTIEN = item.THANHTIEN;
                    ctpn.GHICHU = item.GHICHU;
                    // cập nhật số lượng hàng hóa trong kho
                    // sửa số lượng hàng hóa thì phải tính lại tồn kho, không thể cứ cộng lên được
                    // done
                    tb_HANGHOA hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == item.IDHH);
                    hanghoa.TONKHO = hanghoa.TONKHO - tonkho_cu + (item.SOLUONG * item.QUYDOI);

                    if (isNew)
                        db.tb_CHITIET_PHIEUNHAPHANG.Add(ctpn);
                }

                db.SaveChanges();
                Func.Log("UPDATE", "Nhập hàng", $"ID:{pn_dto.IDPN}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetMaxID()
        {
            var dt = db.tb_PHIEUNHAPHANG.OrderByDescending(x => x.IDPN).FirstOrDefault();

            if (dt != null)
            {
                int nextId = int.Parse(dt.IDPN.Substring(2)) + 1;
                return "PN" + nextId.ToString("00000");
            }
            return "PN00001";
        }
    }
}
