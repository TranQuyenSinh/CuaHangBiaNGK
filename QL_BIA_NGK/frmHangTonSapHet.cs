using BusinessLayer;
using BusinessLayer.DTO;
using DataLayer;
using DevExpress.Emf;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
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
    public partial class frmHangTonSapHet : DevExpress.XtraEditors.XtraForm
    {
        public frmHangTonSapHet()
        {
            InitializeComponent();
        }
        HANGHOA _hh;
        List<string> list_idhh_selected;
        private void frmHangTonSapHet_Load(object sender, EventArgs e)
        {
            _hh = new HANGHOA();
            list_idhh_selected = new List<string>();

            ShowHideButton();
            LoadData();
        }
        void ShowHideButton()
        {
            // permission
            btnIn.Enabled = Func.checkPermission("HANGHOA", "PRINT");
            btnTaoPN.Enabled = btnTaoPNAll.Enabled = Func.checkPermission("NHAPHANG", "ADD");
        }
        void LoadData()
        {
            _hh = new HANGHOA();
            list_idhh_selected.Clear();

            List<HANGHOA_DTO> list = _hh.GetListHangHoaDTOSapHet(true);
            // hiển thị label thông báo ko có hàng hóa nào cần thêm nếu list rỗng
            int hangHoaSapHetCount = list.Count;
            if (hangHoaSapHetCount == 0)
                ChangeStateLabel(false);
            else
                ChangeStateLabel(true, hangHoaSapHetCount);
            gcDanhSach.DataSource = list;
            gvDanhSach.ExpandAllGroups();
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
                double tonkho_new = tonkho / quydoi;
                double gianhap = double.Parse(dvt.GIANHAP.ToString());
                double giabanle = double.Parse(dvt.GIABANLE.ToString());
                double giabansi = double.Parse(dvt.GIABANSI.ToString());
                double dinhmucton_new = double.Parse(hh.DINHMUCTON.ToString()) / quydoi;
                view.SetRowCellValue(e.RowHandle, "QUYDOI", dvt.QUYDOI);
                view.SetRowCellValue(e.RowHandle, "TONKHO", tonkho_new.ToString("###,###,##0.##"));
                view.SetRowCellValue(e.RowHandle, "DINHMUCTON", dinhmucton_new.ToString("###,###,##0.##"));
                view.SetRowCellValue(e.RowHandle, "GIANHAP", gianhap);
                view.SetRowCellValue(e.RowHandle, "GIABANLE", giabanle);
                view.SetRowCellValue(e.RowHandle, "GIABANSI", giabansi);
            }
        }

        // thêm idhh vào list mỗi khi được select
        private void gvDanhSach_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var value = gvDanhSach.GetRowCellValue(e.ControllerRow, "IDHH");
            if (value == null) return;
            var idhh = value.ToString();
            if (list_idhh_selected.Contains(idhh))
                list_idhh_selected.Remove(idhh);
            else
                list_idhh_selected.Add(idhh);
        }

        // làm tiếp: kiểm tra list rỗng, ko có select, kiểm tra quyền add nhaphang
        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            if (Func.checkPermission("NHAPHANG", "ADD") == true)
            {
                if (list_idhh_selected.Count > 0)
                {
                    ShowFormNhapHang(list_idhh_selected);
                }
                else
                {
                    Func.ShowMessage("Bạn chưa chọn hàng hóa nào!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Func.ShowMessage("Bạn không có quyền thêm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTaoPNAll_Click(object sender, EventArgs e)
        {
            if (Func.checkPermission("NHAPHANG", "ADD") == true)
            {

                List<string> list_idhh_all = new List<string>();
                var datasource = (List<HANGHOA_DTO>)gvDanhSach.DataSource;
                if (datasource.Count == 0)
                {
                    Func.ShowMessage("Không có hàng hóa nào cần thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                foreach (var item in datasource)
                    list_idhh_all.Add(item.IDHH);
                ShowFormNhapHang(list_idhh_all);
            }
            else
            {
                Func.ShowMessage("Bạn không có quyền thêm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowFormNhapHang(List<string> listIDHH)
        {
            frmNhapHang frm = new frmNhapHang(listIDHH);
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                if (frm.GetType() == f.GetType())
                {
                    f.Close();
                    break;
                }
            }
            frm.MdiParent = this.MdiParent;
            frm.Show();
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

        private void frmHangTonSapHet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnRefresh_ItemClick(null, null);
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
        // state = true khi có hàng hóa sắp hết
        void ChangeStateLabel(bool state, int soluonghanghoacanthem = -1)
        {
            if (state == true)
            {
                labelCheck.Image = Properties.Resources.alarm;
                labelCheck.Text = $"Có {soluonghanghoacanthem} hàng hóa sắp hết        ";
                labelCheck.ForeColor = ARGBColor.FromArgb(1, 255, 128, 0).ToColor();
            }
            else
            {
                labelCheck.Image = Properties.Resources.check;
                labelCheck.Text = $"Hiện không có hàng hóa nào sắp hết        ";
                labelCheck.ForeColor = Color.ForestGreen;
            }
        }
    }
}