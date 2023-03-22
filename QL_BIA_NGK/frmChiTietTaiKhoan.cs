using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BIA_NGK
{
    public partial class frmChiTietTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        tb_USER _currentUser;
        USER _user;
        NHOM _nhom;
        int _id;

        bool _isUpdate;

        // (id=iduser và isUpdate = true): chỉnh sửa tài khoản
        // (id=idnhom và isUpdate = false): thêm mới tài khoản vào nhóm truyền vào
        public frmChiTietTaiKhoan(int id, bool isUpdate)
        {
            InitializeComponent();
            _id = id; // id có thể là id nhóm hoặc iduser, tùy vào biến isUpdate
            _isUpdate = isUpdate;
        }
        private void frmChiTietTaiKhoan_Load(object sender, EventArgs e)
        {
            _nhom = new NHOM();
            _user = new USER();
            LoadComboBox();

            if (_isUpdate)
            {
                txtUsername.Enabled = false;
                _currentUser = _user.getItem(_id);

                txtTen.Text = _currentUser.TENDAYDU;
                txtUsername.Text = _currentUser.USERNAME;
                txtPassword.Text = _currentUser.PASSWORD;
                cboNhom.SelectedValue = _currentUser.IDNHOM;
            }
            else
            {
                _currentUser = new tb_USER();
                cboNhom.SelectedValue = _id;
            }
        }

        void LoadComboBox()
        {
            cboNhom.DataSource = _nhom.getList();
            cboNhom.DisplayMember = "TENNHOM";
            cboNhom.ValueMember = "IDNHOM";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!string.IsNullOrEmpty(ten) && !string.IsNullOrEmpty(username) &&
                !string.IsNullOrEmpty(password) && cboNhom.SelectedValue != null)
            {

                tb_USER cpyRecord = new tb_USER();
                cpyRecord.IDNHOM = int.Parse(cboNhom.SelectedValue.ToString());
                cpyRecord.TENDAYDU = ten;
                cpyRecord.USERNAME = username;
                cpyRecord.PASSWORD = password;
                if (_isUpdate)
                {
                    cpyRecord.IDUSER = _id;
                    _user.Update(cpyRecord);
                }
                else // add
                {
                    if (_user.CheckUsernameExisted(username))
                    {
                        _user.Add(cpyRecord);
                    }
                    else
                    {
                        Func.ShowMessage("Thao tác thất bại, trùng username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Func.ShowMessage("Thành công");
                this.Close();
            }

            else
            {
                Func.ShowMessage("Thao tác thất bại, thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}