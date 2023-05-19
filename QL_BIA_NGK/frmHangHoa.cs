using BusinessLayer;
using DataLayer;
using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }
        HANGHOA _hh;
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            Func.WriteLog("[Hàng hóa][XEM]");
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
            gvDanhSach.OptionsBehavior.EditorShowMode = EditorShowMode.Click;
            gvDanhSach.ExpandAllGroups();
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
                        _hh.DeleteHangHoa(id.ToString());
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

        private void gvDanhSach_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column == view.Columns["IDGIA"])
            {
                var currentIDHH = view.GetRowCellValue(e.RowHandle, "IDHH");
                if (currentIDHH == null)
                    return;

                string idhh = currentIDHH.ToString();
                e.RepositoryItem = InitItemLookUpEdit(idhh);
            }
        }
        public RepositoryItemLookUpEdit InitItemLookUpEdit(string idHH)
        {
            RepositoryItemLookUpEdit lookUpEditItem = new RepositoryItemLookUpEdit();

            lookUpEditItem.Columns.Add(new LookUpColumnInfo("DONVITINH", "Đơn vị tính"));
            lookUpEditItem.Columns.Add(new LookUpColumnInfo("QUYDOI", "Quy đổi"));

            List<tb_GIA> list = _hh.getListGia(idHH);
            lookUpEditItem.DataSource = list;
            lookUpEditItem.DisplayMember = "DONVITINH";
            lookUpEditItem.ValueMember = "IDGIA";
            lookUpEditItem.BestFitMode = BestFitMode.BestFitResizePopup;
            lookUpEditItem.NullText = "";
            return lookUpEditItem;
        }

        private void gvDanhSach_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            // tránh trường hợp cell value change là cell fillter
            if (e.Column == view.Columns["IDGIA"] && e.Value != null && view.GetRowCellValue(e.RowHandle, "IDHH") != null)
            {
                string idhh = view.GetRowCellValue(e.RowHandle, "IDHH").ToString();

                int IDGIA = int.Parse(e.Value.ToString());
                tb_GIA dvt = _hh.getItemGia(IDGIA);
                tb_HANGHOA hh = _hh.getItemHangHoa(idhh);

                double tonkho = double.Parse(hh.TONKHO.ToString());
                double quydoi = double.Parse(dvt.QUYDOI.ToString());
                double tonkhoNew = tonkho / quydoi;
                double gianhap = double.Parse(dvt.GIANHAP.ToString());
                double giabanle = double.Parse(dvt.GIABANLE.ToString());
                double giabansi = double.Parse(dvt.GIABANSI.ToString());
                view.SetRowCellValue(e.RowHandle, "QUYDOI", dvt.QUYDOI);
                view.SetRowCellValue(e.RowHandle, "TONKHO", tonkhoNew.ToString("###,###,##0.##"));
                view.SetRowCellValue(e.RowHandle, "GIANHAP", gianhap);
                view.SetRowCellValue(e.RowHandle, "GIABANLE", giabanle);
                view.SetRowCellValue(e.RowHandle, "GIABANSI", giabansi);
            }
        }

        private void btnIn_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptHangHoa rpt = new rptHangHoa(_hh.GetReport());
            rpt.ShowPreview();
        }
    }
}