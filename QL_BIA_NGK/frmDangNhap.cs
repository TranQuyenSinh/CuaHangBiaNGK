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
using BusinessLayer;
using DataLayer;
namespace QL_BIA_NGK
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        USER _user;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            _user = new USER();
            Func.IDUSER = -1;
            Func.LISTQUYENCUANHOM = new List<tb_PHANQUYEN>();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var iduser = _user.LoginUser(txtUserName.Text, txtPassword.Text);
            if (iduser != -1)
            {
                Func.IDUSER = iduser;
                Func.LISTQUYENCUANHOM = _user.GetListPermission(iduser);
                this.Hide();
            }
            else
                Func.ShowMessage("Đăng nhập thất bại");
        }

        private void btnThayDoiKetNoi_Click(object sender, EventArgs e)
        {
            frmKetNoiDB frm = new frmKetNoiDB();
            frm.ShowDialog();
        }
    }
}