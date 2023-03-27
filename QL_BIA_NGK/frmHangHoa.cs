using BusinessLayer;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }
        HANGHOA _hh;
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            // inititials
            _hh = new HANGHOA();

            ShowHideButton();
            LoadData();
        }

        void ShowHideButton()
        {
            // permission
            btnThem.Enabled = Func.checkPermission("HANGHOA", "ADD");
            btnSua.Enabled = Func.checkPermission("HANGHOA", "UPDATE");
            btnXoa.Enabled = Func.checkPermission("HANGHOA", "DELETE");
            btnIn.Enabled = Func.checkPermission("HANGHOA", "PRINT");
        }
        void LoadData()
        {
            _hh = new HANGHOA();
            var listHangHoa = _hh.getListHangHoaDTO(false);
            foreach (var item in listHangHoa)
            {
                item.TONKHO = item.TONKHO / item.QUYDOI;
            }
            gcDanhSach.DataSource = listHangHoa;
            gvDanhSach.OptionsBehavior.Editable = false;
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
            if (Func.checkPermission("HANGHOA", "ADD"))
            {
                frmChiTietHangHoa frm = new frmChiTietHangHoa();
                frm.ShowDialog();
                LoadData();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void DeleteData()
        {
            if (Func.checkPermission("HANGHOA", "DELETE"))
            {
                var id = gvDanhSach.GetFocusedRowCellValue("IDHH");
                var ten = gvDanhSach.GetFocusedRowCellValue("TENHH");

                if (id != null)
                {
                    if (Func.ShowMessage("Bạn chắc chắn muốn xóa '" + ten + "' không?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _hh.Delete(id.ToString());
                        LoadData();
                    }
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void UpdateData()
        {
            if (Func.checkPermission("HANGHOA", "UPDATE"))
            {
                var id = gvDanhSach.GetFocusedRowCellValue("IDHH");
                if (id != null)
                {
                    frmChiTietHangHoa frm = new frmChiTietHangHoa(id.ToString());
                    frm.ShowDialog();
                    LoadData();
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // shortcut
        private void frmHangHoa_KeyDown(object sender, KeyEventArgs e)
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