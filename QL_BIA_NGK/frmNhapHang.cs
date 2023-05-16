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
using DevExpress.XtraReports.UI;
using QL_BIA_NGK.Reports;
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
        public frmNhapHang(List<string> listIDHH)
        {
            InitializeComponent();
            _listIDHH = listIDHH;
        }
        #region KhaiBaoBien
        NHACUNGCAP _ncc;
        PHIEUNHAP _pn;
        HANGHOA _hh;
        USER _user;
        NHANVIEN _nv;
        List<string> _listIDHH;
        public static List<CHITIETPHIEUNHAP_DTO> _listSP;
        public static bool _isSaved;
        bool _isAdd;
        #endregion

        #region Sự kiện click
        // click button
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            _ncc = new NHACUNGCAP();
            _pn = new PHIEUNHAP();
            _hh = new HANGHOA();
            _user = new USER();
            _nv = new NHANVIEN();
            _isAdd = true;
            _isSaved = true;
            _listSP = new List<CHITIETPHIEUNHAP_DTO>();

            dtTuNgay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtDenNgay.EditValue = DateTime.Now.AddHours(1);

            ShowHideButton();
            ResetForm();
            LoadCboNCC();
            LoadData();
            LoadListPN();
            LoadCboNhanVien();
            if (_listIDHH != null)
            {
                InitPNFromListIDHH();
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetForm();
            LoadData();
            slkNCC2.Focus();
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            LoadCboNCC();
            LoadListPN();
            LoadCboNhanVien();
        }
        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var focusValue = gvDanhSachPhieu.GetFocusedRowCellValue("IDPN");
            if (focusValue != null)
            {
                string id = focusValue.ToString();
                rptPhieuNhapHang rpt = new rptPhieuNhapHang(_pn.GetReport(id));
                rpt.ShowPreview();
            }
            else
                Func.ShowMessage("Bạn chưa chọn phiếu bán hàng nào để in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnCamera_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCamera frm = new frmCamera();
            frm.captureEvent += FrmCamera_captureEvent;
            frm.Show();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            if (Func.checkPermission("NHACUNGCAP", "ADD"))
            {
                frmChiTietNhaCungCap frm = new frmChiTietNhaCungCap();
                frm.ShowDialog();
                LoadData();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadListPN();
        }
        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        // double click gridview
        private void gvDanhSach_DoubleClick_1(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void gvDanhSachPhieu_DoubleClick(object sender, EventArgs e)
        {
            ShowPhieuNhap();
        }
        // value changed
        private void txtTongCong_TextChanged(object sender, EventArgs e)
        {
            double tongTien = txtTongCong.Text == "" ? 0 : double.Parse(txtTongCong.Text);
            if (tongTien != 0)
            {
                txtTongTienSauPhi.EditValue = (double.Parse(txtTongCong.Text) + double.Parse(txtPhiVanChuyen.Text)).ToString();
            }
            else
            {
                txtTongTienSauPhi.EditValue = txtPhiVanChuyen.EditValue;
            }
        }
        private void txtPhiVanChuyen_TextChanged(object sender, EventArgs e)
        {
            double phiVanChuyen = txtPhiVanChuyen.Text == "" ? 0 : double.Parse(txtPhiVanChuyen.Text);
            if (phiVanChuyen != 0)
            {
                txtTongTienSauPhi.EditValue = (double.Parse(txtTongCong.Text) + double.Parse(txtPhiVanChuyen.Text)).ToString();
            }
            else
            {
                txtTongTienSauPhi.EditValue = txtTongCong.EditValue;
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
        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (slkNCC2.EditValue.ToString() == "") return;
            int id = int.Parse(slkNCC2.EditValue.ToString());
            tb_NHACUNGCAP ncc = _ncc.GetItem(id);
            txtHoTen.Text = ncc.HOTEN;
            txtDiaChi.Text = ncc.DIACHI;
            txtDienThoai.Text = ncc.SODIENTHOAI;
        }
        // shortcut
        private void frmNhapHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnThem_ItemClick(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuu_ItemClick(null, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnRefresh_ItemClick(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.W)
            {
                this.Close();
            }
            else if (e.Control && e.KeyCode == Keys.T)
            {
                btnThemSP_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                dtTuNgay.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                btnIn_ItemClick(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.M)
            {
                frmCamera frm = new frmCamera();
                frm.captureEvent += FrmCamera_captureEvent;
                frm.Show();
            }
        }
        private void FrmCamera_captureEvent(string result)// result = idhh
        {
            AppendDataFromCamera(result);
        }
        private void gvDanhSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaSP_Click(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnXoaSP_Click(null, null);
            }
        }
        private void gvDanhSachPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowPhieuNhap();
            }
        }
        // form closing
        private void frmNhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isSaved == false)
            {
                if (Func.ShowMessage("Phiếu nhập chưa lưu vào database, bạn có muốn lưu không?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    btnLuu_ItemClick(null, null);
                }
            }
        }
        #endregion

        #region xử lý dữ liệu
        // xử lý quyền
        void ShowHideButton()
        {
            // permission
            bool addPer = Func.checkPermission("NHAPHANG", "ADD");
            bool updatePer = Func.checkPermission("NHAPHANG", "UPDATE");
            bool deletePer = Func.checkPermission("NHAPHANG", "DELETE");

            btnThem.Enabled = addPer;
            btnThemSP.Enabled = addPer;
            btnSuaSP.Enabled = updatePer;
            btnXoaSP.Enabled = deletePer;
            btnLuu.Enabled = addPer && updatePer;
            btnLuuPN.Enabled = addPer && updatePer;
        }
        // load data
        void LoadData()
        {
            gvDanhSach.OptionsBehavior.Editable = false;

            // khúc này bug, phải copy 1 list mới rồi ms gán vào datasource, éo biết sao luôn dkm
            List<CHITIETPHIEUNHAP_DTO> newList = new List<CHITIETPHIEUNHAP_DTO>();
            newList.AddRange(_listSP);
            gcDanhSach.DataSource = newList;
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
        void LoadCboNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nv.getList();
            slkNhanVien.Properties.DisplayMember = "HOTEN";
            slkNhanVien.Properties.ValueMember = "IDNV";
        }
        void LoadListPN()
        {
            var tuNgay = DateTime.Parse(dtTuNgay.EditValue.ToString());
            // đến cuối ngày (23:59:59) của ngày đó
            var denNgay = DateTime.Parse(dtDenNgay.EditValue.ToString()).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            var idncc = slkNCC1.EditValue != null ? int.Parse(slkNCC1.EditValue.ToString()) : -1;
            gvDanhSachPhieu.OptionsBehavior.Editable = false;
            gcDanhSachPhieu.DataSource = _pn.GetListPN_DTO(tuNgay, denNgay, idncc);
        }
        void InitPNFromListIDHH()
        {
            foreach (string idhh in _listIDHH)
            {
                HANGHOAFULL_DTO hanghoa_dto = _hh.GetItemHangHoaFullDTO(idhh);
                var gia = hanghoa_dto.LISTGIA[hanghoa_dto.LISTGIA.Count -1];
                CHITIETPHIEUNHAP_DTO ctpn = new CHITIETPHIEUNHAP_DTO();
                ctpn.IDPN = txtMaPhieu.Text;
                ctpn.IDHH = idhh;
                ctpn.TENHH = hanghoa_dto.TENHH;
                ctpn.GHICHU = "";
                ctpn.DONVITINH = gia.DONVITINH;
                ctpn.QUYDOI = double.Parse(gia.QUYDOI.ToString());
                ctpn.DONGIA = double.Parse(gia.GIANHAP.ToString());
                ctpn.SOLUONG = int.Parse(hanghoa_dto.DINHMUCTON.ToString());
                ctpn.THANHTIEN = ctpn.DONGIA * ctpn.SOLUONG;

                // thêm vào list chi tiết
                _listSP.Add(ctpn);
                _isSaved = false;
                LoadData();
            }
        }
        void ShowPhieuNhap()
        {
            if (_isSaved == false)
            {
                if (Func.ShowMessage("Phiếu nhập chưa lưu vào database, bạn có muốn lưu không?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    btnLuu_ItemClick(null, null);
                }
            }

            var index = gvDanhSachPhieu.GetFocusedDataSourceRowIndex();
            if (index >= 0)
            {
                _isAdd = false;
                _isSaved = true;

                PHIEUNHAP_DTO pn_selected = ((List<PHIEUNHAP_DTO>)gvDanhSachPhieu.DataSource)[index];
                dtNgayLap.Text = pn_selected.NGAY.ToString();
                txtMaPhieu.Text = pn_selected.IDPN;
                txtNguoiLap.Text = _user.getFullNameUser(pn_selected.IDUSER);
                slkNCC2.EditValue = pn_selected.IDNCC;
                slkNhanVien.EditValue = pn_selected.IDNV;
                txtGhiChu.Text = pn_selected.GHICHU;
                var coppyList = new List<CHITIETPHIEUNHAP_DTO>();
                coppyList.AddRange(pn_selected.listCTPN_DTO);
                _listSP = coppyList;
                txtPhiVanChuyen.Text = pn_selected.PHIVANCHUYEN.ToString();

                LoadData();
            }
            else
            {
                Func.ShowMessage("Bạn chưa chọn phiếu nào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // reset
        void ResetForm()
        {
            _isAdd = true;
            slkNCC2.Text = "";
            dtNgayLap.EditValue = DateTime.Now;
            txtNguoiLap.Text = Func.FULLNAMEUSER;
            txtMaPhieu.Text = _pn.GetMaxID();
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtPhiVanChuyen.Text = "0";
            txtGhiChu.Text = "";
            _listSP.Clear();
        }
        // xử lý data
        bool ValidateForm()
        {
            // kiểm tra quyền, rỗng
            if (!Func.checkPermission("NHAPHANG", "ADD") || !Func.checkPermission("NHAPHANG", "UPDATE"))
            {
                Func.ShowMessage("Bạn không có quyền sửa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_listSP.Count <= 0)
            {
                Func.ShowMessage("Bạn chưa thêm hàng hóa nào, không thể lưu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_listSP.Any(x => x.TENHH == ""))
            {
                Func.ShowMessage("Có hàng hóa bị trống, vui lòng thêm chi tiết hàng hóa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (slkNCC2.EditValue.ToString() == "")
            {
                Func.ShowMessage("Bạn chưa thêm nhà cung cấp, không thể lưu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        void SaveData()
        {
            // kiểm tra thông tin trước khi lưu
            if (ValidateForm() == false) return;

            // bắt đầu xử lý thêm hoặc sửa
            // lấy thông tin trên form
            PHIEUNHAP_DTO pn_dto = new PHIEUNHAP_DTO();
            pn_dto.IDPN = txtMaPhieu.Text;
            pn_dto.IDNCC = int.Parse(slkNCC2.EditValue.ToString());
            pn_dto.IDUSER = Func.IDUSER;
            pn_dto.NGAY = DateTime.Parse(dtNgayLap.EditValue.ToString());
            pn_dto.PHIVANCHUYEN = double.Parse(txtPhiVanChuyen.Text);
            pn_dto.GHICHU = txtGhiChu.Text;
            pn_dto.TONGTIEN = double.Parse(txtTongTienSauPhi.Text);
            pn_dto.listCTPN_DTO = _listSP;
            if (slkNhanVien.EditValue == null)
            {
                pn_dto.IDNV = null;
            }else
            {
                pn_dto.IDNV = slkNhanVien.EditValue.ToString();
            }

            // xử lý db
            if (_isAdd)
            {
                _pn.Add(pn_dto);
                Func.ShowMessage("Thêm phiếu nhập hàng thành công!");
                _isAdd = false;
            }
            else
            {
                _pn.Update(pn_dto);
                Func.ShowMessage("Chỉnh sửa phiếu nhập hàng thành công!");
            }
            _isSaved = true;
            LoadListPN();
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
                Func.ShowMessage("Bạn không có quyền sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _isSaved = false;
                LoadData();
            }
            else
                Func.ShowMessage("Bạn không có quyền xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void AppendDataFromCamera(string barcode)
        {
            if (!Func.checkPermission("NHAPHANG", "ADD") || !Func.checkPermission("NHAPHANG", "UPDATE"))
            {
                Func.ShowMessage("Bạn không có quyền thêm hoặc sửa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CHITIETPHIEUNHAP_DTO ctpb = new CHITIETPHIEUNHAP_DTO();
            ctpb.IDPN = txtMaPhieu.Text;
            HANGHOAFULL_DTO hanghoa = _hh.GetItemHangHoaFullDTOByBarcode(barcode);
            // trường hợp quét sai mã QR
            if (hanghoa == null) return;
            System.Media.SystemSounds.Beep.Play();
            // nếu đã có hàng hóa trong bảng rồi thì tăng số lượng lên 1
            // và cập nhật lại thành tiền
            var item = _listSP.Find(x => x.IDHH == hanghoa.IDHH);
            if (item != null)
            {
                item.SOLUONG += 1;
                item.THANHTIEN = item.SOLUONG * item.DONGIA;
                _isSaved = false;
                LoadData();
                return;
            }

            // thêm mới chi tiết bán vào gridview
            tb_GIA gia;
            gia = hanghoa.LISTGIA.Last();
            ctpb.IDHH = hanghoa.IDHH;
            ctpb.TENHH = hanghoa.TENHH;
            ctpb.GHICHU = "";
            ctpb.DONVITINH = gia.DONVITINH;
            ctpb.QUYDOI = double.Parse(gia.QUYDOI.ToString());
            ctpb.DONGIA = double.Parse(gia.GIANHAP.ToString());

            ctpb.SOLUONG = 1;
            ctpb.THANHTIEN = ctpb.SOLUONG * ctpb.DONGIA;

            _listSP.Add(ctpb);
            _isSaved = false;
            LoadData();
        }

        #endregion

    }
}
