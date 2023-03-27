using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PHIEUNHAP
    {
        Entities db = Entities.CreateEntities();

        public tb_PHIEUNHAPHANG GetItem(string id)
        {
            return db.tb_PHIEUNHAPHANG.FirstOrDefault(x => x.IDPN == id);
        }
        public List<CHITIETPHIEUNHAP_DTO> getListChiTietDTO(string idpn)
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
                    hanghoa.TONKHO += item.SOLUONG*item.QUYDOI;
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
                
                foreach (var item in pn_dto.listCTPN_DTO)
                {
                    tb_CHITIET_PHIEUNHAPHANG ctpn = db.tb_CHITIET_PHIEUNHAPHANG.FirstOrDefault(x => x.IDCTPN == item.IDCTPN);
                    ctpn.IDHH = item.IDHH;
                    ctpn.IDPN = item.IDPN;
                    ctpn.DONGIA = item.DONGIA;
                    ctpn.DONVITINH = item.DONVITINH;
                    ctpn.SOLUONG = item.SOLUONG;
                    ctpn.THANHTIEN = item.THANHTIEN;
                    ctpn.GHICHU = item.GHICHU;

                    // cập nhật số lượng hàng hóa trong kho
                    tb_HANGHOA hanghoa = db.tb_HANGHOA.FirstOrDefault(x => x.IDHH == item.IDHH);
                    hanghoa.TONKHO += item.SOLUONG;
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
