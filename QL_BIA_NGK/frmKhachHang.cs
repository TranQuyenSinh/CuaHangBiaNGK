using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BIA_NGK
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        KHACHHANG _kh;
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Func.WriteLog("[Khách hàng][XEM]");
            // inititials
            _kh = new KHACHHANG();

            ShowHideButton();
            LoadData();
        }

        void ShowHideButton()
        {
            // permission
            btnThem.Enabled = Func.checkPermission("KHACHHANG", "ADD");
            btnSua.Enabled = Func.checkPermission("KHACHHANG", "UPDATE");
            btnXoa.Enabled = Func.checkPermission("KHACHHANG", "DELETE");
        }
        void LoadData()
        {
            _kh = new KHACHHANG();
            gvDanhSach.OptionsBehavior.Editable = false;
            gcDanhSach.DataSource = _kh.getList();
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

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void AddData()
        {
            if (Func.checkPermission("KHACHHANG", "ADD"))
            {
                frmChiTietKhachHang frm = new frmChiTietKhachHang();
                frm.ShowDialog();
                LoadData();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void DeleteData()
        {
            if (Func.checkPermission("KHACHHANG", "DELETE"))
            {
                var id = gvDanhSach.GetFocusedRowCellValue("IDKH");
                var ten = gvDanhSach.GetFocusedRowCellValue("HOTEN");

                if (id != null)
                {
                    if (Func.ShowMessage("Bạn chắc chắn muốn xóa '" + ten + "' không?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _kh.Delete(id.ToString());
                        LoadData();
                    }
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void UpdateData()
        {
            if (Func.checkPermission("KHACHHANG", "UPDATE"))
            {
                var id = gvDanhSach.GetFocusedRowCellValue("IDKH");
                if (id != null)
                {
                    frmChiTietKhachHang frm = new frmChiTietKhachHang(id.ToString());
                    frm.ShowDialog();
                    LoadData();
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // shortcut
        private void frmKhachHang_KeyDown(object sender, KeyEventArgs e)
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