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
using DataLayer;
using DevExpress.XtraGrid.Views.Grid;

namespace QL_BIA_NGK
{
    public partial class frmChiTietTonKho : DevExpress.XtraEditors.XtraForm
    {
        string _idhh;
        tb_HANGHOA _hanghoa_item;
        HANGHOA _hh;
        public frmChiTietTonKho(string idhh)
        {
            InitializeComponent();
            _idhh = idhh;
        }

        private void frmChiTietTonKho_Load(object sender, EventArgs e)
        {
            _hh = new HANGHOA();
            _hanghoa_item = _hh.getItemHangHoa(_idhh);
            // load combobox
            var list_dvt = _hh.getListGia(_idhh);
            cboDonViTinh.DataSource = list_dvt;
            cboDonViTinh.DisplayMember = "DONVITINH";
            cboDonViTinh.ValueMember = "IDGIA";
            // load text
            txtQuyDoi.Text = list_dvt[0].QUYDOI.ToString();
            txtTonKho.Text = (_hanghoa_item.TONKHO * list_dvt[0].QUYDOI).ToString();
            txtTen.Text = $"Mặt hàng: {_hanghoa_item.IDHH} - {_hanghoa_item.TENHH}";
        }

        private void cboDonViTinh_SelectedValueChanged(object sender, EventArgs e)
        {
            List<tb_GIA> list_gia = (List<tb_GIA>)cboDonViTinh.DataSource;
            var quydoi = double.Parse(((tb_GIA)cboDonViTinh.SelectedItem).QUYDOI.ToString());

            double tonkho = double.Parse(_hanghoa_item.TONKHO.ToString());
            double tonkhoNew = tonkho / quydoi;
            txtTonKho.Text = tonkhoNew.ToString("###,###,##0.##");
            txtQuyDoi.Text = quydoi.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int thaydoi = txtThayDoi.EditValue == null ? 0 : int.Parse(txtThayDoi.EditValue.ToString());
            string donvitinh = cboDonViTinh.Text.ToUpper();
            var quydoi = double.Parse(((tb_GIA)cboDonViTinh.SelectedItem).QUYDOI.ToString());

            // tonkhoMoi này là tồn kho theo đơn vị tính hiện tại, vd: 3 thùng,
            // khi thêm vào db phải quy đổi về mặc định: tonkhoMoi * quydoi
            double tonKhoMoi = double.Parse(_hanghoa_item.TONKHO.ToString()) / quydoi + thaydoi;
            string messageXacNhan = $"Bạn có chắc muốn thêm {txtThayDoi.Text} {donvitinh}? \n Tồn kho hiện tại: {txtTonKho.Text} {donvitinh} \n Tồn kho sau khi thêm: {(tonKhoMoi).ToString("###,###,##0.##")} {donvitinh}";
            if (Func.ShowMessage(messageXacNhan, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _hh.UpdateTonKho(_idhh, tonKhoMoi * quydoi);
                Func.ShowMessage("Thêm thành công");
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double tonKhoMoi = txtThayDoi.EditValue == null ? 0 : double.Parse(txtThayDoi.EditValue.ToString());
            string donvitinh = cboDonViTinh.Text.ToUpper();
            var quydoi = double.Parse(((tb_GIA)cboDonViTinh.SelectedItem).QUYDOI.ToString());

            // tonkhoMoi này là tồn kho theo đơn vị tính hiện tại, vd: 3 thùng,
            // khi thêm vào db phải quy đổi về mặc định: tonkhoMoi * quydoi
            string messageXacNhan = $"Bạn có chắc muốn thay đổi tồn kho thành {txtThayDoi.Text} {donvitinh}? \n Tồn kho hiện tại: {txtTonKho.Text} {donvitinh} \n Tồn kho sau khi sửa: {tonKhoMoi.ToString("###,###,##0.##")} {donvitinh}";
            if (Func.ShowMessage(messageXacNhan, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _hh.UpdateTonKho(_idhh, tonKhoMoi * quydoi);
                Func.ShowMessage("Thay đổi thành công");
                this.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietTonKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
