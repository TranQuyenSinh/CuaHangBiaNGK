using BusinessLayer.DTO;
using BusinessLayer;
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
using DataLayer;

namespace QL_BIA_NGK
{
    public partial class frmLoaiHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiHangHoa()
        {
            InitializeComponent();
        }
        LOAIHANGHOA _loai;
        private void frmLoaiHangHoa_Load(object sender, EventArgs e)
        {
            Func.WriteLog("[Loại hàng][XEM]");
            // inititials
            _loai = new LOAIHANGHOA();

            ShowHideButton();
            LoadData();
        }

        void ShowHideButton()
        {
            // permission
            btnThem.Enabled = Func.checkPermission("LOAIHANGHOA", "ADD");
            btnSua.Enabled = Func.checkPermission("LOAIHANGHOA", "UPDATE");
            btnXoa.Enabled = Func.checkPermission("LOAIHANGHOA", "DELETE");
        }
        void LoadData()
        {
            _loai = new LOAIHANGHOA();
            gvDanhSach.OptionsBehavior.Editable = false;
            gcDanhSach.DataSource = _loai.getList();
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
            if (Func.checkPermission("LOAIHANGHOA", "ADD"))
            {
                frmChiTietLoaiHangHoa frm = new frmChiTietLoaiHangHoa();
                frm.ShowDialog();
                LoadData();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void DeleteData()
        {
            if (Func.checkPermission("LOAIHANGHOA", "DELETE"))
            {
                var id = gvDanhSach.GetFocusedRowCellValue("IDLOAI");
                var ten = gvDanhSach.GetFocusedRowCellValue("TENLOAI");

                if (id != null)
                {
                    if (Func.ShowMessage("Bạn chắc chắn muốn xóa '" + ten + "' không?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            _loai.Delete(int.Parse(id.ToString()));
                            LoadData();
                        }
                        catch (Exception)
                        {
                            Func.ShowMessage("Bạn không thể xóa vì còn hàng hóa đang thuộc loại này", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void UpdateData()
        {
            if (Func.checkPermission("LOAIHANGHOA", "UPDATE"))
            {
                var id = gvDanhSach.GetFocusedRowCellValue("IDLOAI");
                if (id != null)
                {
                    frmChiTietLoaiHangHoa frm = new frmChiTietLoaiHangHoa(int.Parse(id.ToString()));
                    frm.ShowDialog();
                    LoadData();
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // shortcut
        private void frmLoaiHangHoa_KeyDown(object sender, KeyEventArgs e)
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
            }else if (e.KeyCode == Keys.Enter)
            {
                UpdateData();
            }else if (e.Control && e.KeyCode == Keys.W)
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
    }
}