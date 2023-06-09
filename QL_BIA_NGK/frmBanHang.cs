﻿using BusinessLayer.DTO;
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
using DevExpress.Utils.Extensions;
using System.Media;
using DevExpress.XtraReports.Serialization;
using System.Data.SqlClient;
using QL_BIA_NGK.Reports;
using DevExpress.XtraReports.UI;

namespace QL_BIA_NGK
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        #region KhaiBaoBien
        KHACHHANG _kh;
        PHIEUBAN _pb;
        HANGHOA _hh;
        USER _user;
        NHANVIEN _nv;

        public static List<CHITIETPHIEUBAN_DTO> _listSP;
        public static bool _isSaved;
        bool _isAdd;
        string _id_currentPB;

        #endregion

        #region Sự kiện click
        // click button
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            Func.WriteLog("[Bán hàng][XEM]");

            _kh = new KHACHHANG();
            _pb = new PHIEUBAN();
            _hh = new HANGHOA();
            _user = new USER();
            _nv = new NHANVIEN();
            _isAdd = true;
            _isSaved = true;
            _listSP = new List<CHITIETPHIEUBAN_DTO>();

            dtTuNgay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtDenNgay.EditValue = DateTime.Now.AddHours(1);

            ShowHideButton();
            ResetForm();
            LoadCboKH();
            LoadData();
            LoadListPB();
            LoadCboNhanVien();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetForm();
            LoadData();
            slkKH2.Focus();
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            LoadCboKH();
            LoadListPB();
            LoadCboNhanVien();
            _id_currentPB = null;
        }
        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var focusValue = gvDanhSachPhieu.GetFocusedRowCellValue("IDPB");
            if (focusValue != null)
            {
                rptPhieuBanHang rpt = new rptPhieuBanHang(_pb.GetReport(focusValue.ToString()));
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
            AddSP();
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            UpdateSP();
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DeleteSP();
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (Func.checkPermission("KHACHHANG", "ADD"))
            {
                frmChiTietKhachHang frm = new frmChiTietKhachHang();
                frm.ShowDialog();
                LoadCboKH();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadListPB();
        }
        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Func.checkPermission("BANHANG", "DELETE"))
            {
                Func.ShowMessage("Bạn không có quyền xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_id_currentPB == null)
            {
                Func.ShowMessage("Bạn chưa chọn phiếu bán nào để xóa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Func.ShowMessage("Bạn có chắc muốn xóa phiếu bán hàng " + _id_currentPB + " ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
                return;

            try
            {
                _pb.Delete(_id_currentPB);
                Func.ShowMessage("Xóa thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                btnRefresh_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Func.ShowMessage("Xóa thất bại. Lỗi: " + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmCamera_captureEvent(string result)// result = idhh
        {
            AppendSPFromCamera(result);
        }
        // double click gridview
        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            UpdateSP();
        }
        private void gvDanhSachPhieu_DoubleClick(object sender, EventArgs e)
        {
            ShowPhieuBan();
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
        private void slkKH2_EditValueChanged(object sender, EventArgs e)
        {
            if (slkKH2.EditValue.ToString() == "") return;
            string id = slkKH2.EditValue.ToString();
            tb_KHACHHANG kh = _kh.GetItem(id);
            if (kh == null)
            {
                Func.ShowMessage("Khách hàng có thể đã bị xóa, hãy chọn khách hàng khác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadCboKH();
                return;
            }
            txtHoTen.Text = kh.HOTEN;
            txtDiaChi.Text = kh.DIACHI;
            txtDienThoai.Text = kh.SODIENTHOAI;
        }
        // shortcut
        private void frmBanHang_KeyDown(object sender, KeyEventArgs e)
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
                ShowPhieuBan();
            }
        }
        // form closing
        private void frmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isSaved == false)
            {
                if (Func.ShowMessage("Phiếu bán hàng chưa lưu vào database, bạn có muốn lưu không?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
            bool addPer = Func.checkPermission("BANHANG", "ADD");
            bool updatePer = Func.checkPermission("BANHANG", "UPDATE");
            bool deletePer = Func.checkPermission("BANHANG", "DELETE");

            btnThem.Enabled = addPer && updatePer;
            btnXoa.Enabled = deletePer;
            btnLuu.Enabled = addPer && updatePer;
            btnLuuPN.Enabled = addPer && updatePer;

            btnThemSP.Enabled = addPer && updatePer;
            btnSuaSP.Enabled = addPer && updatePer;
            btnXoaSP.Enabled = addPer && updatePer;
        }
        // load data
        void LoadData()
        {
            gvDanhSach.OptionsBehavior.Editable = false;

            // khúc này bug, phải copy 1 list mới rồi ms gán vào datasource, éo biết sao luôn dkm
            List<CHITIETPHIEUBAN_DTO> newList = new List<CHITIETPHIEUBAN_DTO>();
            newList.AddRange(_listSP);
            gcDanhSach.DataSource = newList;
        }
        void LoadCboKH()
        {
            // cbo khách hàng
            var listKH = _kh.getList();
            slkKH1.Properties.DataSource = listKH;
            slkKH2.Properties.DataSource = listKH;
            slkKH1.Properties.DisplayMember = "HOTEN";
            slkKH2.Properties.DisplayMember = "HOTEN";
            slkKH1.Properties.ValueMember = "IDKH";
            slkKH2.Properties.ValueMember = "IDKH";
        }

        void LoadCboNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nv.getList();
            slkNhanVien.Properties.DisplayMember = "HOTEN";
            slkNhanVien.Properties.ValueMember = "IDNV";
        }
        void LoadListPB()
        {
            var tuNgay = DateTime.Parse(dtTuNgay.EditValue.ToString());
            // đến cuối ngày (23:59:59) của ngày đó
            var denNgay = DateTime.Parse(dtDenNgay.EditValue.ToString()).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            var idkh = slkKH1.EditValue != null ? slkKH1.EditValue.ToString() : "";
            gvDanhSachPhieu.OptionsBehavior.Editable = false;
            gcDanhSachPhieu.DataSource = _pb.GetListPB_DTO(tuNgay, denNgay, idkh);
        }
        void ShowPhieuBan()
        {
            if (_isSaved == false)
            {
                if (Func.ShowMessage("Phiếu bán hàng chưa lưu vào database, bạn có muốn lưu không?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    btnLuu_ItemClick(null, null);
                }
            }

            var index = gvDanhSachPhieu.GetFocusedDataSourceRowIndex();
            if (index >= 0)
            {
                _isAdd = false;
                _isSaved = true;

                PHIEUBAN_DTO pb_selected = ((List<PHIEUBAN_DTO>)gvDanhSachPhieu.DataSource)[index];
                dtNgayLap.Text = pb_selected.NGAY.ToString();
                txtMaPhieu.Text = pb_selected.IDPB;
                txtNguoiLap.Text = _user.getFullNameUser(pb_selected.IDUSER);
                slkKH2.EditValue = pb_selected.IDKH;
                slkNhanVien.EditValue = pb_selected.IDNV;
                txtGhiChu.Text = pb_selected.GHICHU;
                var coppyList = new List<CHITIETPHIEUBAN_DTO>();
                coppyList.AddRange(pb_selected.listCTPB_DTO);
                _listSP = coppyList;
                txtPhiVanChuyen.Text = pb_selected.PHIVANCHUYEN.ToString();
                switchGiaSi.IsOn = bool.Parse(pb_selected.GIASI.ToString());

                LoadData();
                _id_currentPB = pb_selected.IDPB;
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
            slkKH2.Text = "";
            dtNgayLap.EditValue = DateTime.Now;
            txtNguoiLap.Text = Func.FULLNAMEUSER;
            txtMaPhieu.Text = _pb.GetMaxID();
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            switchGiaSi.IsOn = true;
            _id_currentPB = null;
            txtDienThoai.Text = "";
            txtPhiVanChuyen.Text = "0";
            txtGhiChu.Text = "";
            _listSP.Clear();
        }
        // xử lý data
        bool CheckForm()
        {
            // kiểm tra quyền, rỗng
            if (!Func.checkPermission("BANHANG", "ADD") || !Func.checkPermission("BANHANG", "UPDATE"))
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
            if (slkKH2.EditValue.ToString() == "")
            {
                Func.ShowMessage("Bạn chưa thêm khách hàng, không thể lưu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        void SaveData()
        {
            // kiểm tra thông tin trước khi lưu
            if (CheckForm() == false) return;

            // bắt đầu xử lý thêm hoặc sửa
            // lấy thông tin trên form
            PHIEUBAN_DTO pb_dto = new PHIEUBAN_DTO();
            pb_dto.IDPB = txtMaPhieu.Text;
            pb_dto.IDKH = slkKH2.EditValue.ToString();
            pb_dto.NGAY = DateTime.Parse(dtNgayLap.EditValue.ToString());
            pb_dto.PHIVANCHUYEN = double.Parse(txtPhiVanChuyen.Text);
            pb_dto.GHICHU = txtGhiChu.Text;
            pb_dto.GIASI = bool.Parse(switchGiaSi.EditValue.ToString());
            pb_dto.TONGTIEN = double.Parse(txtTongTienSauPhi.Text);
            pb_dto.listCTPB_DTO = _listSP;
            if (slkNhanVien.EditValue == null)
            {
                pb_dto.IDNV = null;
            }
            else
            {
                pb_dto.IDNV = slkNhanVien.EditValue.ToString();
            }
            // xử lý db
            if (_isAdd)
            {
                pb_dto.IDUSER = Func.IDUSER;
                _pb.Add(pb_dto);
                Func.ShowMessage("Thêm phiếu bán hàng thành công!");
                _isAdd = false;
            }
            else
            {
                pb_dto.IDUSER = int.Parse(_pb.GetItemPB(txtMaPhieu.Text).IDUSER.ToString());
                _pb.Update(pb_dto);
                Func.ShowMessage("Chỉnh sửa phiếu bán hàng thành công!");
            }
            _isSaved = true;
            _id_currentPB = pb_dto.IDPB;
            LoadListPB();
        }
        void AddSP()
        {
            if (Func.checkPermission("BANHANG", "ADD"))
            {
                CHITIETPHIEUBAN_DTO ctpb = new CHITIETPHIEUBAN_DTO();
                ctpb.IDPB = txtMaPhieu.Text;
                frmChiTietPhieuBan frm = new frmChiTietPhieuBan(ctpb, bool.Parse(switchGiaSi.EditValue.ToString()));
                frm.ShowDialog();
                LoadData();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void UpdateSP()
        {
            if (Func.checkPermission("BANHANG", "UPDATE"))
            {
                var index = gvDanhSach.GetFocusedDataSourceRowIndex();
                if (index >= 0)
                {
                    frmChiTietPhieuBan frm = new frmChiTietPhieuBan(_listSP[index], bool.Parse(switchGiaSi.EditValue.ToString()));
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
        void DeleteSP()
        {
            if (Func.checkPermission("BANHANG", "DELETE"))
            {
                var row = (CHITIETPHIEUBAN_DTO)gvDanhSach.GetFocusedRow();
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
        void AppendSPFromCamera(string barcode)
        {
            if (!Func.checkPermission("BANHANG", "ADD") || !Func.checkPermission("BANHANG", "UPDATE"))
            {
                Func.ShowMessage("Bạn không có quyền thêm hoặc sửa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CHITIETPHIEUBAN_DTO ctpb = new CHITIETPHIEUBAN_DTO();
            ctpb.IDPB = txtMaPhieu.Text;
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
            if (switchGiaSi.IsOn)
            {
                gia = hanghoa.LISTGIA.Last();
            }
            else
            {
                gia = hanghoa.LISTGIA.First();
            }
            ctpb.IDHH = hanghoa.IDHH;
            ctpb.TENHH = hanghoa.TENHH;
            ctpb.GHICHU = "";
            ctpb.DONVITINH = gia.DONVITINH;
            ctpb.QUYDOI = double.Parse(gia.QUYDOI.ToString());
            if (switchGiaSi.IsOn)
            {
                ctpb.DONGIA = double.Parse(gia.GIABANSI.ToString());
            }
            else
            {
                ctpb.DONGIA = double.Parse(gia.GIABANLE.ToString());
            }

            ctpb.SOLUONG = 1;
            ctpb.THANHTIEN = ctpb.SOLUONG * ctpb.DONGIA;

            _listSP.Add(ctpb);
            _isSaved = false;
            LoadData();
        }

        #endregion


    }
}