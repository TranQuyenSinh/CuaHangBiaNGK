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
    public partial class frmChiTietKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KHACHHANG _kh = new KHACHHANG();
        tb_KHACHHANG _currentRecord;
        string _id;
        bool _isAdd;
        public frmChiTietKhachHang()
        {
            InitializeComponent();
            _currentRecord = new tb_KHACHHANG();
            _id = _kh.GetMaxID();
            _isAdd = true;
        }

        public frmChiTietKhachHang(string id)
        {
            InitializeComponent();
            _currentRecord = _kh.GetItem(id);
            _id = id;
            _isAdd = false;
        }

        private void frmChiTietKhachHang_Load(object sender, EventArgs e)
        {
            txtIDKH.Text = _id;

            if (_isAdd == false) // update NV
            {
                txtHoTen.Text = _currentRecord.HOTEN;
                txtDiaChi.Text = _currentRecord.DIACHI;
                txtDienThoai.Text = _currentRecord.SODIENTHOAI;
                txtEmail.Text = _currentRecord.EMAIL;
                dtNgaySinh.EditValue = _currentRecord.NGAYSINH;
                chkGioiTinh.Checked = _currentRecord.GIOITINH == true ? true : false;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!CheckForm()) return;
            tb_KHACHHANG kh = new tb_KHACHHANG();

            kh.IDKH = _id;
            kh.HOTEN = txtHoTen.Text;
            kh.NGAYSINH = Convert.ToDateTime(dtNgaySinh.EditValue);
            kh.GIOITINH = chkGioiTinh.Checked == true ? true : false;
            kh.DIACHI = txtDiaChi.Text;
            kh.EMAIL = txtEmail.Text;
            kh.SODIENTHOAI = txtDienThoai.Text;
            if (_isAdd)
                _kh.Add(kh);
            else
                _kh.Update(kh);

            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
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