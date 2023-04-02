using BusinessLayer;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QL_BIA_NGK
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        System.Windows.Forms.Timer timer;
        int h, m, s;
        public MainForm()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            h = m = s = 0;
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
            foreach (var item in ribbon.Items)
            {
                if (item.GetType() == typeof(BarButtonItem))
                {
                    BarButtonItem button = (BarButtonItem)item;
                    if (button.Tag == null) continue;
                    button.Enabled = Func.checkPermission(button.Tag.ToString(), "SHOW");
                }
            }
        }

        void HideAllButton() //  except btnDangNhap
        {
            foreach (var item in ribbon.Items)
            {
                if (item.GetType() == typeof(BarButtonItem))
                {
                    BarButtonItem button = (BarButtonItem)item;
                    button.Enabled = false;
                }
            }
            btnDangNhap.Enabled = true;
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
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 60)
            {
                s = 0;
                m++;
            }
            if (m == 60)
            {
                m = 0;
                h++;
            }
            txtTimer.Caption = string.Format("Thời gian sử dụng: {0:00}:{1:00}:{2:00}", h, m, s);
        }

        void Logout()
        {
            Func.Log("LOGOUT");
            CloseAllForm();
            // reset userinfo
            Func.LISTQUYENCUANHOM.Clear();
            Func.IDUSER = -1;
            Func.FULLNAMEUSER = "";
            txtCurrentUserInfo.Caption = "";
            // reset timer
            timer.Stop();
            h = m = s = 0;
            txtTimer.Caption = "";
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

        private void btnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "backup_database_" + DateTime.Now.ToShortDateString().Replace("/", "_");
            dialog.Filter = "Back up file (*.bak)|*.bak";
            dialog.OverwritePrompt = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BACKUP_RESTORE.BackUpDB(dialog.FileName);
                Func.ShowMessage("Sao lưu dữ liệu thành công");
            }
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Back up file (*.bak)|*.bak";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BACKUP_RESTORE.RestoreDB(dialog.FileName);
                Func.ShowMessage("Phục hồi dữ liệu thành công");
            }
        }
        void CloseAllForm()
        {
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
        }
    }
}