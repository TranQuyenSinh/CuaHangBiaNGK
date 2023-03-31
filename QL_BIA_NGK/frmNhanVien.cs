using BusinessLayer;
using BusinessLayer.DTO;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QL_BIA_NGK
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NHANVIEN _nv;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // inititials
            _nv = new NHANVIEN();

            ShowHideButton();
            LoadData();
        }

        void ShowHideButton()
        {
            // permission
            btnThem.Enabled = Func.checkPermission("NHANVIEN", "ADD");
            btnSua.Enabled = Func.checkPermission("NHANVIEN", "UPDATE");
            btnXoa.Enabled = Func.checkPermission("NHANVIEN", "DELETE");
            btnIn.Enabled = Func.checkPermission("NHANVIEN", "PRINT");
        }
        void LoadData()
        {
            _nv = new NHANVIEN();
            gvDanhSach.OptionsBehavior.Editable = false;
            gcDanhSach.DataSource = _nv.getList();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddData();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData();
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteData();
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

        void AddData()
        {
            if (Func.checkPermission("NHANVIEN", "ADD"))
            {
                frmChiTietNhanVien frm = new frmChiTietNhanVien(_nv.GetMaxID());
                frm.ShowDialog();
                LoadData();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void DeleteData()
        {
            if (Func.checkPermission("NHANVIEN", "DELETE"))
            {
                var idnv = gvDanhSach.GetFocusedRowCellValue("IDNV");
                var hoten = gvDanhSach.GetFocusedRowCellValue("HOTEN");
                // đang error

                if (idnv != null)
                {
                    if (Func.ShowMessage("Bạn chắc chắn muốn xóa '" + hoten + "' không?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            _nv.Delete(idnv.ToString());
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            Func.ShowMessage(ex.Message);
                        }
                    }
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền xóa", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }
        void UpdateData()
        {
            if (Func.checkPermission("NHANVIEN", "UPDATE"))
            {
                var idnv = gvDanhSach.GetFocusedRowCellValue("IDNV");
                if (idnv != null)
                {
                    frmChiTietNhanVien frm = new frmChiTietNhanVien(idnv.ToString());
                    frm.ShowDialog();
                    LoadData();
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // shortcut
        private void frmNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl+N: Add
            if (e.Control && e.KeyCode == Keys.N)
            {
                AddData();
            }
            else if (e.KeyCode == Keys.F5)
            {
                // F5: Refresh
                LoadData();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                // Delete: Delete
                DeleteData();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                UpdateData();
            }
            else if (e.Control && e.KeyCode == Keys.W)
            {
                this.Close();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                btnIn_ItemClick(null, null);
            }
        }
        // double click row to update it
        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void gvDanhSach_RowCountChanged(object sender, EventArgs e)
        {
            lblTong.Caption = $"Có {gvDanhSach.RowCount} dòng";
        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void gvDanhSach_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            ColumnView view = sender as ColumnView;

            foreach (GridColumn column in view.Columns)
            {
                string value = Func.RemoveDiacritics(view.GetListSourceRowCellValue(e.ListSourceRow, column).ToString()).ToLower();
                string filterStr = Func.RemoveDiacritics(view.EditingValue == null ? "" : view.EditingValue.ToString()).ToLower();

                if (column == gvDanhSach.FocusedColumn)
                {
                    List<char> valueChars = value.ToList();
                    List<char> filterTextChars = filterStr.ToList();

                    foreach (char c in valueChars)
                        if (filterTextChars.Count != 0 && c == filterTextChars.First())
                        {
                            filterTextChars.RemoveAt(0);

                        }
                    if (filterTextChars.Count == 0)
                    {
                        e.Visible = true;
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
