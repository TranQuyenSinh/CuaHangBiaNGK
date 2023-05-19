using BusinessLayer;
using DataLayer;
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
    public partial class frmChiTietNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        NHACUNGCAP _ncc;
        tb_NHACUNGCAP _currentRecord;
        int _id;
        bool _isAdd;
        public frmChiTietNhaCungCap()
        {
            InitializeComponent();
            _isAdd = true;
        }
        public frmChiTietNhaCungCap(int id)
        {
            InitializeComponent();
            _id = id;
            _isAdd = false;
        }

        private void frmChiTietNhaCungCap_Load(object sender, EventArgs e)
        {
            _ncc = new NHACUNGCAP();
            if (_isAdd == false) // update
            {
                _currentRecord = _ncc.GetItem(_id);
                txtHoTen.Text = _currentRecord.HOTEN;
                txtDiaChi.Text = _currentRecord.DIACHI;
                txtDienThoai.Text = _currentRecord.SODIENTHOAI;
                txtEmail.Text = _currentRecord.EMAIL;
            }
            else
            {
                _currentRecord = new tb_NHACUNGCAP();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!CheckForm()) return;
            tb_NHACUNGCAP cpyRecord = new tb_NHACUNGCAP();
            cpyRecord.HOTEN = txtHoTen.Text;
            cpyRecord.DIACHI = txtDiaChi.Text;
            cpyRecord.SODIENTHOAI = txtDienThoai.Text;
            cpyRecord.EMAIL = txtEmail.Text;
            
            if (_isAdd)
            {
                _ncc.Add(cpyRecord);
            }
            else
            {
                cpyRecord.IDNCC = _id;
                _ncc.Update(cpyRecord);
            }

            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietNhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // nếu nhập chữ thì bỏ qua
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool CheckForm()
        {
            // kiểm tra quyền, rỗng
            if (txtHoTen.Text == "")
            {
                Func.ShowMessage("Tên không được bỏ trống!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}