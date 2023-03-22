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

namespace QL_BIA_NGK
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        USER _user;
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            _user = new USER();
            txtUsername.Text = _user.GetUsername(Func.IDUSER);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_user.ChangePassword(txtOldPassword.Text.Trim(), txtNewPassword.Text.Trim()) == true)
            {
                Func.ShowMessage("Đã đổi thành công!", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }else
                Func.ShowMessage("Đổi mật khẩu thất bại! Sai thông tin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}