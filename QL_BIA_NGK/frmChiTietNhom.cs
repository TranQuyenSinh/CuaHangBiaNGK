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
    public partial class frmChiTietNhom : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietNhom()
        {
            InitializeComponent();
            _isAdd = true;
        }
        public frmChiTietNhom(int idnhom)
        {
            InitializeComponent();
            _id = idnhom;
            _isAdd = false;
        }
        NHOM _nhom;
        tb_NHOM _currentNhom;
        int _id;
        bool _isAdd;
        private void frmChiTietNhom_Load(object sender, EventArgs e)
        {
            _nhom = new NHOM();
            if (!_isAdd)
            {
                _currentNhom = _nhom.getItem(_id);
                txtTenNhom.Text = _currentNhom.TENNHOM;
            }
            else
                _currentNhom = new tb_NHOM();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenNhom.Text))
            {
                tb_NHOM cpyRecord = new tb_NHOM();
                cpyRecord.TENNHOM = txtTenNhom.Text;
                if (_isAdd)
                {
                    _nhom.Add(cpyRecord);
                }
                else
                {
                    cpyRecord.IDNHOM = _id;
                    _nhom.Update(cpyRecord);
                }
                this.Close();
            }
            else
            {
                Func.ShowMessage("Thất bại, thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietNhom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}