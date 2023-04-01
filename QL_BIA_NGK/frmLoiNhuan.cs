using BusinessLayer;
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

            LoadData();
        }
        void LoadData()
        {
            if (radSP.Checked == true)
            {
                // show gridView sản phẩm
                gcDanhSach.MainView = gvDanhSachSP;
                // load data lợi nhuận theo hàng hóa
                gcDanhSach.DataSource = _ln.getListLoiNhuanSP(DateTime.Parse(dtTuNgay.EditValue.ToString()), DateTime.Parse(dtDenNgay.EditValue.ToString()));
            }
            else
            {
                gcDanhSach.MainView = gvDanhSachKH;
                // load data lợi nhuận theo khách hàng
                gcDanhSach.DataSource = _ln.getListLoiNhuanKH(DateTime.Parse(dtTuNgay.EditValue.ToString()), DateTime.Parse(dtDenNgay.EditValue.ToString()));
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

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmLoiNhuan_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gvDanhSach_RowCountChanged(object sender, EventArgs e)
        {
            lblTong.Caption = $"Có {gvDanhSachSP.DataRowCount} dòng";
        }
    }
}