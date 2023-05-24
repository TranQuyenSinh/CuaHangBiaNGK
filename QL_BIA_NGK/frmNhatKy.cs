using BusinessLayer;
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
    public partial class frmNhatKy : DevExpress.XtraEditors.XtraForm
    {
        public frmNhatKy()
        {
            InitializeComponent();
        }
        LOG _log;
        DateTime _tuNgay, _denNgay;

        private void frmNhatKy_Load(object sender, EventArgs e)
        {
            _log = new LOG();
            dtTuNgay.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtDenNgay.DateTime = DateTime.Now.AddHours(1);
            _tuNgay = dtTuNgay.DateTime;
            _denNgay = dtDenNgay.DateTime;
            LoadData();
        }
        void LoadData()
        {
            gvDanhSach.OptionsBehavior.Editable = false;
            gcDanhSach.DataSource = _log.getList(_tuNgay, _denNgay);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            _tuNgay = dtTuNgay.DateTime;
            _denNgay = dtDenNgay.DateTime;
            LoadData();
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }


        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void frmNhatKy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                // F5: Refresh
                LoadData();
            }
            else if (e.Control && e.KeyCode == Keys.W)
            {
                this.Close();
            }
        }

        private void gvDanhSach_RowCountChanged(object sender, EventArgs e)
        {
            lblTong.Caption = $"Có {gvDanhSach.RowCount} dòng";
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            var text = gvDanhSach.GetFocusedRowCellValue("MESSAGE");
            if (text!=null)
            {
                new frmChiTietNhatKy(text.ToString()).ShowDialog();
            }
        }

        private void gvDanhSach_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            ColumnView view = sender as ColumnView;

            foreach (GridColumn column in view.Columns)
            {
                // text trong grid cần check
                string value = Func.RemoveDiacritics(view.GetListSourceRowCellValue(e.ListSourceRow, column).ToString()).ToLower();
                // text filter do user nhập
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