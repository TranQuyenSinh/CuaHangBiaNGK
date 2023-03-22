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
            gcDanhSach.DataSource = _hh.getListHangHoaDTO();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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

        }

        private void gvDanhSach_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column == view.Columns["IDDVT"])
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
            RepositoryItemLookUpEdit riMaterial = new RepositoryItemLookUpEdit();

            riMaterial.Columns.Add(new LookUpColumnInfo("DONVITINH", "Đơn vị tính"));
            riMaterial.Columns.Add(new LookUpColumnInfo("QUYDOI", "Quy đổi"));

            List<tb_DONVITINH> list = _hh.getListDonViTinh(idHH);
            riMaterial.DataSource = list;
            riMaterial.DisplayMember = "DONVITINH";
            riMaterial.ValueMember = "IDDVT";

            riMaterial.AutoSearchColumnIndex = 1;
            riMaterial.BestFitMode = BestFitMode.BestFitResizePopup;

            riMaterial.NullText = "";
            return riMaterial;
        }

        private void gvDanhSach_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column == view.Columns["IDDVT"] && e.Value != null)
            {
                string idhh = view.GetRowCellValue(e.RowHandle, "IDHH").ToString();

                int iddvt = int.Parse(e.Value.ToString());
                tb_DONVITINH dvt = _hh.getItemDonViTinh(iddvt);
                tb_HANGHOA hh = _hh.getItemHangHoa(idhh);

                double tonkho = double.Parse(hh.TONKHO.ToString());
                double quydoi = double.Parse(dvt.QUYDOI.ToString());
                double tonkhoNew = tonkho / quydoi;
                view.SetRowCellValue(e.RowHandle, "QUYDOI", dvt.QUYDOI);
                view.SetRowCellValue(e.RowHandle, "TONKHO", tonkhoNew.ToString("###,###,##0.##"));

                // nên chỉnh tồn kho, quy doi thanh double trong db       
            }
        }

    }
}
