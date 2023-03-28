using BusinessLayer.DTO;
using BusinessLayer;
using DataLayer;
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
    public partial class frmChiTietPhieuBan : DevExpress.XtraEditors.XtraForm
    {
        CHITIETPHIEUBAN_DTO _ctpb;
        HANGHOA _hh;
        List<CHITIETPHIEUBAN_DTO> listChiTietPB;
        HANGHOAFULL_DTO _hh_dto;
        bool _isGiaSi;
        public frmChiTietPhieuBan(CHITIETPHIEUBAN_DTO ctpb, bool isGiaSi)
        {
            InitializeComponent();
            _ctpb = ctpb;
            _isGiaSi = isGiaSi;
        }
        private void frmChiTietPhieuBan_Load(object sender, EventArgs e)
        {
            _hh = new HANGHOA();
            LoadData();
            if (_ctpb.IDHH != null)
            {
                slkLoaiHH.Text = _ctpb.IDHH;
                txtGhiChu.Text = _ctpb.GHICHU;
                cboDVT.Text = _ctpb.DONVITINH;
                txtGiaBan.Text = _ctpb.DONGIA.ToString();
                txtSoLuong.Text = _ctpb.SOLUONG.ToString();
                txtThanhTien.Text = _ctpb.THANHTIEN.ToString();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            _ctpb.IDHH = slkLoaiHH.EditValue.ToString();
            _ctpb.TENHH = txtTenHH.Text;
            _ctpb.GHICHU = txtGhiChu.Text;
            _ctpb.DONVITINH = cboDVT.Text;
            _ctpb.QUYDOI = double.Parse(txtQuyDoi.Text);
            _ctpb.DONGIA = double.Parse(txtGiaBan.Text);
            _ctpb.SOLUONG = int.Parse(txtSoLuong.Text);
            _ctpb.THANHTIEN = double.Parse(txtThanhTien.Text);

            // thêm vào list chi tiết
            if (!listChiTietPB.Contains(_ctpb))
                listChiTietPB.Add(_ctpb);

            frmBanHang._isSaved = false;
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
                txtThanhTien.Text = (double.Parse(txtSoLuong.Text) * double.Parse(txtGiaBan.Text)).ToString();
            }
            else
            {
                txtSoLuong.Text = "0";
                txtThanhTien.Text = "0";
            }
        }
        private void txtGiaNhap_EditValueChanged(object sender, EventArgs e)
        {
            double dongia = txtGiaBan.Text == "" ? 0 : double.Parse(txtGiaBan.Text);
            if (dongia != 0)
            {
                txtThanhTien.Text = (double.Parse(txtSoLuong.Text) * double.Parse(txtGiaBan.Text)).ToString();
            }
            else
            {
                txtGiaBan.Text = "0";
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
                txtGiaBan.Text = _isGiaSi == true ? gia.GIABANSI.ToString() : gia.GIABANLE.ToString();
            }
        }
        private void frmChiTietPhieuBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        void LoadData()
        {
            var listHangHoa = _hh.getListHangHoa();
            listChiTietPB = frmBanHang._listSP;
            // Ko hiển thị những hàng hóa nào đã có rồi trong frmBanHang trừ chính hàng hóa đang chỉnh sửa này (_ctpb)
            listHangHoa.RemoveAll(item => listChiTietPB.Any(x => x.IDHH == item.IDHH && x.IDHH != _ctpb.IDHH));

            slkLoaiHH.Properties.DataSource = listHangHoa;
            slkLoaiHH.Properties.DisplayMember = "IDHH";
            slkLoaiHH.Properties.ValueMember = "IDHH";
        }
    }
}