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

namespace QL_BIA_NGK
{
    public partial class frmChiTietTonKho : DevExpress.XtraEditors.XtraForm
    {
        string _idhh;
        HANGHOA_DTO hh_dto;
        HANGHOA _hh;
        public frmChiTietTonKho(string idhh)
        {
            InitializeComponent();
            _idhh = idhh;
        }

        private void frmChiTietTonKho_Load(object sender, EventArgs e)
        {
            _hh = new HANGHOA();

            hh_dto = _hh.GetItemHangHoaDTO(_idhh);
            var list_dvt = _hh.getListDonViTinh(_idhh);
            cboDonViTinh.DataSource = list_dvt;
            cboDonViTinh.DisplayMember = "DONVITINH";
            cboDonViTinh.ValueMember = "IDGIA";
            txtQuyDoi.Text = list_dvt[0].QUYDOI.ToString();
            txtTonKho.Text = hh_dto.TONKHO.ToString();
            txtTen.Text = hh_dto.IDHH + " - " + hh_dto.TENHH;
        }
    }
}