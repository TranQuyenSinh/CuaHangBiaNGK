using BusinessLayer;
using BusinessLayer.DTO;
using DataLayer;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.ExpressApp;
using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BIA_NGK
{
    public partial class frmChiTietPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        CHITIETPHIEUNHAP_DTO _ctpn;
        HANGHOA _hh;
        List<CHITIETPHIEUNHAP_DTO> listChiTietPN;
        HANGHOAFULL_DTO _hh_dto;
        public frmChiTietPhieuNhap(CHITIETPHIEUNHAP_DTO ctpn)
        {
            InitializeComponent();
            _ctpn = ctpn;
        }
        void LoadData()
        {
            var listHangHoa = _hh.getListHangHoa();
            listChiTietPN = frmNhapHang._listSP;
            // Ko hiển thị những hàng hóa nào đã có rồi trong frmNhapHang trừ chính hàng hóa đang chỉnh sửa này (_ctpn)
            listHangHoa.RemoveAll(item => listChiTietPN.Any(x => x.IDHH == item.IDHH && x.IDHH != _ctpn.IDHH));
           
            slkLoaiHH.Properties.DataSource = listHangHoa;
            slkLoaiHH.Properties.DisplayMember = "IDHH";
            slkLoaiHH.Properties.ValueMember = "IDHH";
        }
        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            _hh = new HANGHOA();
            LoadData();
            if (_ctpn.IDHH != null)
            {
                slkLoaiHH.Text = _ctpn.IDHH;
                txtGhiChu.Text = _ctpn.GHICHU;
                cboDVT.Text = _ctpn.DONVITINH;
                txtGiaNhap.Text = _ctpn.DONGIA.ToString();
                txtSoLuong.Text = _ctpn.SOLUONG.ToString();
                txtThanhTien.Text = _ctpn.THANHTIEN.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _ctpn.IDHH = slkLoaiHH.EditValue.ToString();
            _ctpn.TENHH = txtTenHH.Text;
            _ctpn.GHICHU = txtGhiChu.Text;
            _ctpn.DONVITINH = cboDVT.Text;
            _ctpn.QUYDOI = double.Parse(txtQuyDoi.Text);
            _ctpn.DONGIA = double.Parse(txtGiaNhap.Text);
            _ctpn.SOLUONG = int.Parse(txtSoLuong.Text);
            _ctpn.THANHTIEN = double.Parse(txtThanhTien.Text);

            // thêm vào list chi tiết
            if (!listChiTietPN.Contains(_ctpn))
                listChiTietPN.Add(_ctpn);

            frmNhapHang._isSaved = false;
            this.Close();
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void slkLoaiHH_EditValueChanged(object sender, EventArgs e)
        {
            string idhh = slkLoaiHH.EditValue.ToString();
            _hh_dto = _hh.GetItemHangHoaFullDTO(slkLoaiHH.EditValue.ToString());
            txtTenHH.Text = _hh_dto.TENHH;
            txtMoTa.Text = _hh_dto.MOTA;

            cboDVT.DisplayMember = "DONVITINH";
            cboDVT.ValueMember = "IDGIA";
            cboDVT.DataSource = _hh_dto.LISTGIA;
        }

        private void txtSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            double soluong = txtSoLuong.Text == "" ? 0 : double.Parse(txtSoLuong.Text);
            if (soluong != 0)
            {
                txtThanhTien.Text = (double.Parse(txtSoLuong.Text) * double.Parse(txtGiaNhap.Text)).ToString();
            }
            else
            {
                txtSoLuong.Text = "0";
                txtThanhTien.Text = "0";
            }
        }

        private void txtGiaNhap_EditValueChanged(object sender, EventArgs e)
        {
            double dongia = txtGiaNhap.Text == "" ? 0 : double.Parse(txtGiaNhap.Text);
            if (dongia != 0)
            {
                txtThanhTien.Text = (double.Parse(txtSoLuong.Text) * double.Parse(txtGiaNhap.Text)).ToString();
            }
            else
            {
                txtGiaNhap.Text = "0";
                txtThanhTien.Text = "0";
            }
        }

        private void cboDVT_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboDVT.SelectedValue != null)
            {
                tb_GIA gia = (tb_GIA)cboDVT.SelectedItem;
                double tonkho = double.Parse(_hh_dto.TONKHO.ToString());
                double quydoi = double.Parse(gia.QUYDOI.ToString());
                double tonkhoNew = tonkho / quydoi;

                txtQuyDoi.Text = gia.QUYDOI.ToString();
                txtHienTon.Text = tonkhoNew.ToString();
                txtGiaNhap.Text = gia.GIANHAP.ToString();
            }
        }

        private void frmChiTietPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}