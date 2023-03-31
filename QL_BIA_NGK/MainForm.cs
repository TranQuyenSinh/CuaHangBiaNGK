using BusinessLayer;
using DevExpress.XtraBars;
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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void OpenForm(Type formType)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == formType)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(formType);
            f.MdiParent = this;
            f.Show();
        }
        // hiển thị các chức năng được phép truy cập
        void ShowAllowAcceptButton()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnPhanQuyen.Enabled = Func.checkPermission("PHANQUYEN", "SHOW");
            btnKhachHang.Enabled = Func.checkPermission("KHACHHANG", "SHOW");
            btnNhatKy.Enabled = Func.checkPermission("NHATKY", "SHOW");
            btnNhaCungCap.Enabled = Func.checkPermission("NHACUNGCAP", "SHOW");
            btnNhanVien.Enabled = Func.checkPermission("NHANVIEN", "SHOW");
            btnHangHoa.Enabled = Func.checkPermission("HANGHOA", "SHOW");
            btnLoaiHangHoa.Enabled = Func.checkPermission("LOAIHANGHOA", "SHOW");
            btnBanHang.Enabled = Func.checkPermission("BANHANG", "SHOW");
            btnNhapHang.Enabled = Func.checkPermission("NHAPHANG", "SHOW");
            btnKho.Enabled = Func.checkPermission("KHO", "SHOW");
            btnBaoCaoLoiNhuan.Enabled = Func.checkPermission("BAOCAOLOINHUAN", "SHOW");
            btnHangTon.Enabled = Func.checkPermission("BAOCAOHANGTON", "SHOW");
        }

        void HideAllButton() //  except btnDangNhap
        {
            btnDangNhap.Enabled = true;
            btnDoiMatKhau.Enabled = false;
            btnDangXuat.Enabled = false;
            btnPhanQuyen.Enabled = false;
            btnKhachHang.Enabled = false;
            btnNhatKy.Enabled = false;
            btnNhaCungCap.Enabled = false;
            btnNhanVien.Enabled = false;
            btnHangHoa.Enabled = false;
            btnLoaiHangHoa.Enabled = false;
            btnBanHang.Enabled = false;
            btnNhapHang.Enabled = false;
            btnKho.Enabled = false;
            btnBaoCaoLoiNhuan.Enabled = false;
            btnHangTon.Enabled = false;
        }
        void Login()
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            if (Func.IDUSER != -1) // login success
            {
                Func.Log("LOGIN");
                ShowAllowAcceptButton();
                txtCurrentUserInfo.Caption = "Xin chào " + Func.FULLNAMEUSER;
            }
        }
        void Logout()
        {
            Func.Log("LOGOUT");
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            Func.LISTQUYENCUANHOM.Clear();
            Func.IDUSER = -1;
            Func.FULLNAMEUSER = "";
            txtCurrentUserInfo.Caption = "";
            HideAllButton();
        }
        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Login();
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmKhachHang));
        }

        private void btnNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmNhaCungCap));
        }

        private void btnHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmHangHoa));
        }

        private void btnLoaiHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmLoaiHangHoa));
        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmBanHang));
        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmKhoHang));
        }

        private void btnHangTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmHangTonSapHet));
        }

        private void btnBaoCaoLoiNhuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmLoiNhuan));
        }

        private void btnNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmNhapHang));
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmNhanVien));
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Func.ShowMessage("Bạn có muốn đăng xuất không?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Logout();
                Login();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Func.IDUSER != -1)
            {
                Func.Log("LOGOUT");
            }
            Application.Exit();
        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPhanQuyen));
        }

        private void btnNhatKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmNhatKy));
        }
    }
}