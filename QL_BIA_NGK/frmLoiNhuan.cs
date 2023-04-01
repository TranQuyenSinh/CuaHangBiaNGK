using BusinessLayer;
using BusinessLayer.DTO;
using DevExpress.Utils;
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

namespace QL_BIA_NGK
{
    public partial class frmLoiNhuan : DevExpress.XtraEditors.XtraForm
    {
        LOINHUAN _ln;
        public frmLoiNhuan()
        {
            InitializeComponent();
        }

        private void frmLoiNhuan_Load(object sender, EventArgs e)
        {
            _ln = new LOINHUAN();

            // init date
            dtTuNgay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtDenNgay.EditValue = DateTime.Now.AddHours(1);

            // không cho chỉnh sửa data của gridview
            gvDanhSachKH.OptionsBehavior.Editable = false;
            gvDanhSachSP.OptionsBehavior.Editable = false;

            LoadData();
        }
        void LoadData()
        {
            var tuNgay = DateTime.Parse(dtTuNgay.EditValue.ToString());
            // đến cuối ngày (23:59:59) của ngày đó
            var denNgay = DateTime.Parse(dtDenNgay.EditValue.ToString()).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            if (radSP.Checked == true)
            {
                // show gridView sản phẩm
                gcDanhSach.MainView = gvDanhSachSP;
                // load data lợi nhuận theo hàng hóa
                gcDanhSach.DataSource = _ln.getListLoiNhuanSP(tuNgay, denNgay);
            }
            else
            {
                gcDanhSach.MainView = gvDanhSachKH;
                // load data lợi nhuận theo khách hàng
                gcDanhSach.DataSource = _ln.getListLoiNhuanKH(tuNgay, denNgay);
            }
        }
        // làm tiếp: kéo cột loinhuan ra dài xíu để groupsumary dễ thấy
        // tìm cách hiển thị groupsumary theo dạng ###,###,##0.##
        // lên màu đỏ, bold cho groupsumary
        // tạo group theo idhh trong gvdanhsachsp và hoten trong gvdanhsachkh, nhớ expand
        // fix dtTuNgay, dtDenNgay như mấy form trước(copy zo)
        // thêm 1 số textbox hiển thị thông tin thống kê tổng bên dưới gridview, vd: tổng lợi nhuận
        // to be continued =))))
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmLoiNhuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                this.Close();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                btnIn_ItemClick(null, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnRefresh_ItemClick(null, null);
            }
        }

        private void gcDanhSach_DataSourceChanged(object sender, EventArgs e)
        {
            var currentSource = gcDanhSach.DataSource;
            if (currentSource.GetType() == typeof(List<LOINHUAN_KH_DTO>))
            {
                List<LOINHUAN_KH_DTO> dataSource = (List<LOINHUAN_KH_DTO>)currentSource;
                double tongLoiNhuan = dataSource.Sum(row => row.LOINHUAN);
                txtTongLoiNhuan.Text = tongLoiNhuan.ToString("###,###,##0.##") + " VNĐ";
            }
            else
            {
                List<LOINHUAN_SP_DTO> dataSource = (List<LOINHUAN_SP_DTO>)currentSource;
                double tongLoiNhuan = dataSource.Sum(row => row.LOINHUAN);
                txtTongLoiNhuan.Text = tongLoiNhuan.ToString("###,###,##0.##") + " VNĐ";
            }
        }
    }
}