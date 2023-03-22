using BusinessLayer.DTO;
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
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DataLayer;

namespace QL_BIA_NGK
{
    public partial class frmChiTietNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietNhanVien()
        {
            InitializeComponent();
        }
        NHANVIEN _nv;
        tb_NHANVIEN _currentRecord;
        string _id;
        bool _isAdd;
        public frmChiTietNhanVien(string idnv)
        {
            InitializeComponent();
            _nv = new NHANVIEN();
            _id = idnv;
            _currentRecord = _nv.GetItem(_id);

            if (_currentRecord != null)
                _isAdd = false;
            else
            {
                _currentRecord = new tb_NHANVIEN();
                _isAdd = true;
            }
        }

        private void frmChiTietNhanVien_Load(object sender, EventArgs e)
        {
            txtIDNV.Text = _id;
            if (_isAdd == false) // update NV
            {
                txtHoTen.Text = _currentRecord.HOTEN;
                dtNgaySinh.EditValue = _currentRecord.NGAYSINH;
                chkNam.Checked = _currentRecord.GIOITINH == true ? true : false;
                txtDiaChi.Text = _currentRecord.DIACHI;
                txtDienThoai.Text = _currentRecord.SODIENTHOAI;
                txtEmail.Text = _currentRecord.EMAIL;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dtDTO = new tb_NHANVIEN();
            dtDTO.IDNV = txtIDNV.Text;
            dtDTO.HOTEN = txtHoTen.Text;
            dtDTO.NGAYSINH = Convert.ToDateTime(dtNgaySinh.EditValue);
            dtDTO.GIOITINH = chkNam.Checked;
            dtDTO.DIACHI = txtDiaChi.Text;
            dtDTO.EMAIL = txtEmail.Text;
            dtDTO.SODIENTHOAI = txtDienThoai.Text;
            if (_isAdd)
                _nv.Add(dtDTO);
            else
                _nv.Update(dtDTO);

            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}