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
    public partial class frmChiTietLoaiHangHoa : DevExpress.XtraEditors.XtraForm
    {

        LOAIHANGHOA _loai;
        tb_LOAIHANGHOA _currentRecord;
        int _id;
        bool _isAdd;
        public frmChiTietLoaiHangHoa()
        {
            InitializeComponent();
            _isAdd = true;
        }
        public frmChiTietLoaiHangHoa(int id) // update
        {
            InitializeComponent();
            _id = id;
            _isAdd = false;
        }

        private void frmChiTietLoaiHangHoa_Load(object sender, EventArgs e)
        {
            _loai = new LOAIHANGHOA();
            if (_isAdd == false) // update
            {
                _currentRecord = _loai.GetItem(_id);
                txtTen.Text = _currentRecord.TENLOAI;
            }
            else
                _currentRecord = new tb_LOAIHANGHOA();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTen.Text))
            {
                tb_LOAIHANGHOA cpyRecord = new tb_LOAIHANGHOA();
                cpyRecord.TENLOAI = txtTen.Text;
                if (_isAdd)
                {
                    _loai.Add(cpyRecord);
                }
                else
                {
                    cpyRecord.IDLOAI = _id;
                    _loai.Update(cpyRecord);
                }

                this.Close();
            }
            else
            {
                Func.ShowMessage("Tên không được bỏ trống!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietLoaiHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}