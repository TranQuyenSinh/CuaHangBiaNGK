using BusinessLayer.DTO;
using BusinessLayer.REPORT;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace BusinessLayer
{
    public class PHIEUNHAP
    {
        Entities db = Entities.CreateEntities();
        public List<PHIEUNHAP_REPORT_DATA> GetReport(string idpn)
        {
            List<PHIEUNHAP_REPORT_DATA> list = (
                from pn in db.tb_PHIEUNHAPHANG
                join ct in db.tb_CHITIET_PHIEUNHAPHANG on pn.IDPN equals ct.IDPN
                join hh in db.tb_HANGHOA on ct.IDHH equals hh.IDHH
                join ncc in db.tb_NHACUNGCAP on pn.IDNCC equals ncc.IDNCC
                join user in db.tb_USER on pn.IDUSER equals user.IDUSER
                join nv in db.tb_NHANVIEN on pn.IDNV equals nv.IDNV into groupNV_PN
                from table in groupNV_PN.DefaultIfEmpty()
                where pn.IDPN == idpn
                select new PHIEUNHAP_REPORT_DATA
                {
                    IDPN = pn.IDPN,
                    HOTENNV = table.HOTEN == null ? "":table.HOTEN,
                    HOTENNCC = ncc.HOTEN,
                    DIACHI = ncc.DIACHI,
                    DIENTHOAI = ncc.SODIENTHOAI,
                    NGAY = pn.NGAY.Value,
                    GHICHU = pn.GHICHU,
                    NGUOILAP = user.TENDAYDU,
                    TONGTIEN = (double)pn.TONGTIEN,
                    PHIVANCHUYEN = (double)pn.PHIVANCHUYEN,
                    // chi tiết
                    TENHH = hh.TENHH,
                    DONVITINH = ct.DONVITINH,
                    DONGIA = (double)ct.DONGIA,
                    SOLUONG = (int)ct.SOLUONG,
                    THANHTIEN = (double)ct.THANHTIEN,
                    GHICHUSP = ct.GHICHU

                }).ToList();
            /*List<PHIEUNHAP_REPORT_DATA> report_list = new List<PHIEUNHAP_REPORT_DATA>();
            PHIEUNHAP_DTO pn_dto = GetItemPN_DTO(idpn);

            foreach (var chitiet in pn_dto.listCTPN_DTO)
            {
                PHIEUNHAP_REPORT_DATA r_item = new PHIEUNHAP_REPORT_DATA();
                r_item.IDPN = pn_dto.IDPN;
                if (pn_dto.IDNV != null)
                {
                    r_item.HOTENNV = db.tb_NHANVIEN.FirstOrDefault(x => x.IDNV == pn_dto.IDNV).HOTEN;
                }
                r_item.HOTENNCC = pn_dto.HOTEN;
                var nhacungcap = db.tb_NHACUNGCAP.FirstOrDefault(x => x.IDNCC == pn_dto.IDNCC);
                r_item.DIACHI = nhacungcap.DIACHI;
                r_item.DIENTHOAI = nhacungcap.SODIENTHOAI;
                r_item.NGAY = pn_dto.NGAY.ToString();
                r_item.GHICHU = pn_dto.GHICHU;
                r_item.NGUOILAP = db.tb_USER.FirstOrDefault(x => x.IDUSER == pn_dto.IDUSER).TENDAYDU;
                r_item.TONGTIEN = double.Parse(pn_dto.TONGTIEN.ToString());
                r_item.PHIVANCHUYEN = double.Parse(pn_dto.PHIVANCHUYEN.ToString());
                // chi tiết
                r_item.TENHH = chitiet.TENHH;
                r_item.DONVITINH = chitiet.DONVITINH;
                r_item.DONGIA = double.Parse(chitiet.DONGIA.ToString());
                r_item.SOLUONG = int.Parse(chitiet.SOLUONG.ToString());
                r_item.THANHTIEN = double.Parse(chitiet.THANHTIEN.ToString());
                r_item.GHICHUSP = chitiet.GHICHU;

                report_list.Add(r_item);
            }*/
            Func.WriteLog($"[Phiếu nhập][PRINT]: [MaPN={idpn}]");
            return list;
        }

        public tb_PHIEUNHAPHANG GetItemPN(string id)
        {
            return db.tb_PHIEUNHAPHANG.FirstOrDefault(x => x.IDPN == id);
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
                dto.IDNV = item.IDNV;
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
                pn.IDNV = pn_dto.IDNV;
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
                Func.WriteLog($"[Phiếu nhập][INSERT]: [MaPN={pn_dto.IDPN}]");
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
                pn.IDNV = pn_dto.IDNV;
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
                Func.WriteLog($"[Phiếu nhập][UPDATE]: [MaPN={pn_dto.IDPN}]");
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
