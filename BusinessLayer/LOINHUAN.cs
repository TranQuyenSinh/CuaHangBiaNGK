using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOINHUAN
    {
        Entities db = new Entities();
        public List<LOINHUAN_KH_DTO> getListLoiNhuanKH(DateTime tuNgay, DateTime denNgay)
        {
			string query = @"select 
								kh.HOTEN,
								hh.TENHH, 
								gia.DONVITINH, 
								SUM(ctpb.SOLUONG) as SLBAN,
								gia.GIANHAP,
								ctpb.DONGIA,
								SUM(ctpb.SOLUONG*(ctpb.DONGIA - gia.GIANHAP)) as LOINHUAN
							from tb_HANGHOA hh, tb_GIA gia, tb_CHITIET_PHIEUBANHANG ctpb, tb_PHIEUBANHANG pb, tb_LOAIHANGHOA loai, tb_KHACHHANG kh
							where pb.IDKH = kh.IDKH and
								  pb.NGAY > Convert(date, @p0) and 
								  pb.NGAY < Convert(date, @p1) and
								  hh.IDHH = gia.IDHH and 
								  ctpb.IDHH = hh.IDHH and 
								  pb.IDPB = ctpb.IDPB and
								  ctpb.DONVITINH = gia.DONVITINH and 
								  loai.IDLOAI = hh.IDLOAI
							group by kh.HOTEN, hh.TENHH, gia.DONVITINH, gia.GIANHAP, ctpb.DONGIA 
							order by kh.HOTEN, SUM(ctpb.SOLUONG*(ctpb.DONGIA - gia.GIANHAP)) desc";
            return db.Database.SqlQuery<LOINHUAN_KH_DTO>(query, tuNgay, denNgay).ToList();
        }
        public List<LOINHUAN_SP_DTO> getListLoiNhuanSP(DateTime tuNgay, DateTime denNgay)
        {
            string query = @"select loai.TENLOAI, 
									hh.IDHH, 
									hh.TENHH, 
									gia.DONVITINH, 
									SUM(ctpb.SOLUONG) as SLBAN,
									gia.GIANHAP,
									ctpb.DONGIA,
									SUM(ctpb.SOLUONG*(ctpb.DONGIA - gia.GIANHAP)) as LOINHUAN
							from tb_HANGHOA hh, tb_GIA gia, tb_CHITIET_PHIEUBANHANG ctpb, tb_PHIEUBANHANG pb, tb_LOAIHANGHOA loai
							where pb.NGAY > Convert(smalldatetime, @p0) and 
								  pb.NGAY < Convert(date, @p1) and
								  hh.IDHH = gia.IDHH and 
								  ctpb.IDHH = hh.IDHH and 
								  pb.IDPB = ctpb.IDPB and
								  ctpb.DONVITINH = gia.DONVITINH and 
								  loai.IDLOAI = hh.IDLOAI
							group by loai.TENLOAI,hh.IDHH,  hh.TENHH, gia.DONVITINH, gia.GIANHAP, ctpb.DONGIA 
							order by hh.TENHH, SUM(ctpb.SOLUONG*(ctpb.DONGIA - gia.GIANHAP)) desc";
            return db.Database.SqlQuery<LOINHUAN_SP_DTO>(query, tuNgay, denNgay).ToList();
        }
    }
}
