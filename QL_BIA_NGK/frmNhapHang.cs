using BusinessLayer;
using BusinessLayer.DTO;
using DataLayer;
using DevExpress.Utils;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }
        NHACUNGCAP _ncc;
        PHIEUNHAP _pn;
        HANGHOA _hh;
        public static List<CHITIETPHIEUNHAP_DTO> _listSP;
        bool _isAdd;
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            _ncc = new NHACUNGCAP();
            _pn = new PHIEUNHAP();
            _hh = new HANGHOA();
            _isAdd = true;
            _listSP = new List<CHITIETPHIEUNHAP_DTO>();

            ShowHideButton();
            ResetForm();
            LoadCboNCC();
            LoadData();

            dtTuNgay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtDenNgay.EditValue = DateTime.Now.AddHours(1);

        }
        void ShowHideButton()
        {
            // permission
            btnThem.Enabled = Func.checkPermission("NHAPHANG", "ADD");
            btnThemSP.Enabled = Func.checkPermission("NHAPHANG", "ADD");
            btnSuaSP.Enabled = Func.checkPermission("NHAPHANG", "UPDATE");
            btnXoaSP.Enabled = Func.checkPermission("NHAPHANG", "DELETE");
            btnLuu.Enabled = Func.checkPermission("NHAPHANG", "ADD") && Func.checkPermission("NHAPHANG", "UPDATE");
            btnIn.Enabled = Func.checkPermission("NHAPHANG", "PRINT");
        }
        void LoadData()
        {
            gvDanhSach.OptionsBehavior.Editable = false;

            // khúc này bug, phải copy 1 list mới rồi ms gán vào datasource, éo biết sao luôn dkm
            List<CHITIETPHIEUNHAP_DTO> newList = new List<CHITIETPHIEUNHAP_DTO>();
            newList.AddRange(_listSP);
            gcDanhSach.DataSource = newList;
        }
        void ResetForm()
        {
            _isAdd = true;
            slkNCC2.SelectedText = "";
            dtNgayLap.EditValue = DateTime.Now;
            txtNguoiLap.Text = Func.FULLNAMEUSER;
            txtMaPhieu.Text = _pn.GetMaxID();
            txtPhiVanChuyen.Text = "0";
            _listSP.Clear();
        }
        void LoadCboNCC()
        {
            // cbo nhà cung cấp
            var listNCC = _ncc.getList();
            slkNCC1.Properties.DataSource = listNCC;
            slkNCC2.Properties.DataSource = listNCC;
            slkNCC1.Properties.DisplayMember = "HOTEN";
            slkNCC2.Properties.DisplayMember = "HOTEN";
            slkNCC1.Properties.ValueMember = "IDNCC";
            slkNCC2.Properties.ValueMember = "IDNCC";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetForm();
            LoadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_listSP.Count <= 0)
            {
                Func.ShowMessage("Bạn chưa thêm hàng hóa nào, không thể lưu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (slkNCC2.EditValue == null)
            {
                Func.ShowMessage("Bạn chưa thêm nhà cung cấp, không thể lưu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_isAdd) 
            {
                PHIEUNHAP_DTO pn_dto = new PHIEUNHAP_DTO();
                pn_dto.IDPN = txtMaPhieu.Text;
                pn_dto.IDNCC = int.Parse(slkNCC2.EditValue.ToString());
                pn_dto.IDUSER = Func.IDUSER;
                pn_dto.NGAY = DateTime.Parse(dtNgayLap.EditValue.ToString());
                pn_dto.PHIVANCHUYEN = double.Parse(txtPhiVanChuyen.Text);
                pn_dto.GHICHU = txtGhiChu.Text;
                pn_dto.TONGTIEN = double.Parse(txtTongTienSauPhi.Text);
                pn_dto.listCTPN_DTO = _listSP;
                _pn.Add(pn_dto);
                Func.ShowMessage("Thêm phiếu nhập hàng thành công!");
                _isAdd = false;
            }
            else
            {

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(slkNCC2.EditValue.ToString());
            tb_NHACUNGCAP ncc = _ncc.GetItem(id);
            txtHoTen.Text = ncc.HOTEN;
            txtDiaChi.Text = ncc.DIACHI;
            txtDienThoai.Text = ncc.SODIENTHOAI;
        }
        
        void AddData()
        {
            if (Func.checkPermission("NHAPHANG", "ADD"))
            {
                CHITIETPHIEUNHAP_DTO ctpn = new CHITIETPHIEUNHAP_DTO();
                ctpn.IDPN = txtMaPhieu.Text;
                frmChiTietPhieuNhap frm = new frmChiTietPhieuNhap(ctpn);
                frm.ShowDialog();
                LoadData();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void UpdateData()
        {
            if (Func.checkPermission("NHAPHANG", "UPDATE"))
            {
                var index = gvDanhSach.GetFocusedDataSourceRowIndex();
                if (index >= 0)
                {
                    frmChiTietPhieuNhap frm = new frmChiTietPhieuNhap(_listSP[index]);
                    frm.ShowDialog();
                    LoadData();
                }
                else
                {
                    Func.ShowMessage("Bạn chưa chọn hàng hóa nào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void DeleteData()
        {
            if (Func.checkPermission("NHAPHANG", "DELETE"))
            {
                var row = (CHITIETPHIEUNHAP_DTO)gvDanhSach.GetFocusedRow();
                if (row != null)
                {
                    _listSP.Remove(row);
                }
                LoadData();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmChiTietNhaCungCap frm = new frmChiTietNhaCungCap();
            frm.ShowDialog();
            LoadData();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void gvDanhSach_DoubleClick_1(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void txtTongCong_TextChanged(object sender, EventArgs e)
        {
            double tongTien = txtTongCong.Text == "" ? 0 : double.Parse(txtTongCong.Text);
            if (tongTien != 0)
            {
                txtTongTienSauPhi.Text = (double.Parse(txtTongCong.Text) + double.Parse(txtPhiVanChuyen.Text)).ToString();
            }
            else
            {
                txtTongTienSauPhi.Text = txtPhiVanChuyen.Text;
            }
        }

        private void txtPhiVanChuyen_TextChanged(object sender, EventArgs e)
        {
            double phiVanChuyen = txtPhiVanChuyen.Text == "" ? 0 : double.Parse(txtPhiVanChuyen.Text);
            if (phiVanChuyen != 0)
            {
                txtTongTienSauPhi.Text = (double.Parse(txtTongCong.Text) + double.Parse(txtPhiVanChuyen.Text)).ToString();
            }
            else
            {
                txtTongTienSauPhi.Text = txtTongCong.Text;
            }
        }

        private void gvDanhSach_DataSourceChanged(object sender, EventArgs e)
        {
            double tongTien = 0;
            foreach (var item in _listSP)
            {
                tongTien += double.Parse(item.THANHTIEN.ToString());
            }
            txtTongCong.Text = tongTien.ToString();
        }
    }
}