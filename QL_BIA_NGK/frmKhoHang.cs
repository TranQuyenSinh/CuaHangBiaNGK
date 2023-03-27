using BusinessLayer;
using DataLayer;
using DevExpress.Data.Svg;
using DevExpress.Persistent.Base;
using DevExpress.Utils;
using DevExpress.Utils.DirectXPaint;
using DevExpress.Utils.Filtering.Internal;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace QL_BIA_NGK
{
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoHang()
        {
            InitializeComponent();
        }
        HANGHOA _hh;

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            _hh = new HANGHOA();
            LoadData();
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
            // ngăn việc bôi đen content trong cell, không thể kích hoạt event double click
            gvDanhSach.OptionsBehavior.EditorShowMode = EditorShowMode.Click;
        }
        void UpdateData()
        {
            if (Func.checkPermission("KHO", "UPDATE"))
            {
                var id = gvDanhSach.GetFocusedRowCellValue("IDHH");
                if (id != null)
                {
                    frmChiTietTonKho frm = new frmChiTietTonKho(id.ToString());
                    frm.ShowDialog();
                    LoadData();
                }
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

        private void gvDanhSach_RowCountChanged(object sender, EventArgs e)
        {
            lblTong.Caption = $"Có {gvDanhSach.RowCount} dòng";
        }

        private void frmKhoHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                // F5: Refresh
                LoadData();
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

        private void gvDanhSach_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
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

        private void gvDanhSach_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
                view.SetRowCellValue(e.RowHandle, "QUYDOI", dvt.QUYDOI);
                view.SetRowCellValue(e.RowHandle, "TONKHO", tonkhoNew.ToString("###,###,##0.##"));
            }
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void gvDanhSach_RowCellClick(object sender, RowCellClickEventArgs e)
        {

            e.Handled = true;

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
