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
    public partial class frmChiTietHangHoa : DevExpress.XtraEditors.XtraForm
    {
        LOAIHANGHOA _loai = new LOAIHANGHOA();
        HANGHOA _hh = new HANGHOA();
        List<TextEdit> listTxtGiaNhap;
        List<TextEdit> listTxtGiaBanSi;
        List<TextEdit> listTxtGiaBanLe;
        List<TextEdit> listTxtQuyDoi;
        List<CheckBox> listChk;
        List<System.Windows.Forms.ComboBox> listcbo;
        tb_HANGHOA _currentHangHoa;
        List<tb_GIA> _listDVT;

        string _id;
        bool _isAdd;
        public frmChiTietHangHoa() // add
        {
            InitializeComponent();

            _currentHangHoa = new tb_HANGHOA();
            _listDVT = new List<tb_GIA>();
            _isAdd = true;
        }
        public frmChiTietHangHoa(string idhh) // update
        {
            InitializeComponent();

            _currentHangHoa = _hh.getItemHangHoa(idhh);
            _listDVT = _hh.getListDonViTinh(idhh);
            _id = idhh;
            _isAdd = false;
        }

        private void frmChiTietHangHoa_Load(object sender, EventArgs e)
        {
            LoadCboLoaiHH();
            listTxtQuyDoi = new List<TextEdit> { txtQuyDoiGoc, txtQuyDoi2, txtQuyDoi3, txtQuyDoi4 }; ;
            listTxtGiaNhap = new List<TextEdit> { txtGiaNhapGoc, txtGiaNhap2, txtGiaNhap3, txtGiaNhap4 }; ;
            listTxtGiaBanLe = new List<TextEdit> { txtGiaBanLeGoc, txtGiaBanLe2, txtGiaBanLe3, txtGiaBanLe4 };
            listTxtGiaBanSi = new List<TextEdit> { txtGiaBanSiGoc, txtGiaBanSi2, txtGiaBanSi3, txtGiaBanSi4 };
            listChk = new List<CheckBox> { chkGoc, chk2, chk3, chk4 };
            listcbo = new List<System.Windows.Forms.ComboBox> { cboDVTGoc, cboDVT2, cboDVT3, cboDVT4 };
            if (!_isAdd)
            {
                // thông tin hàng hóa
                slkLoaiHH.EditValue = _currentHangHoa.IDLOAI;
                txtIDHH.Text = _currentHangHoa.IDHH;
                txtIDHH.Enabled = false;
                txtTenHH.Text = _currentHangHoa.TENHH;
                txtMoTa.Text = _currentHangHoa.MOTA;
                txtDinhMucTon.Text = _currentHangHoa.DINHMUCTON.ToString();
                txtTonKho.Text = _currentHangHoa.TONKHO.ToString();
                // thông tin đơn vị tính
                LoadDonViTinh();
            }
        }
        void LoadDonViTinh()
        {
            for (int i = 0; i < _listDVT.Count; i++)
            {
                listChk[i].Checked = true;
                listChk[i].Enabled = false;
                listcbo[i].Text = _listDVT[i].DONVITINH;
                listTxtQuyDoi[i].Text = _listDVT[i].QUYDOI.ToString();
                listTxtGiaNhap[i].Text = _listDVT[i].GIANHAP.ToString();
                listTxtGiaBanLe[i].Text = _listDVT[i].GIABANLE.ToString();
                listTxtGiaBanSi[i].Text = _listDVT[i].GIABANSI.ToString();
            }
        }

        void LoadCboLoaiHH()
        {
            slkLoaiHH.Properties.DataSource = _loai.getList();
            slkLoaiHH.Properties.DisplayMember = "TENLOAI";
            slkLoaiHH.Properties.ValueMember = "IDLOAI";
        }

        void SaveHangHoa()
        {
            tb_HANGHOA hanghoa = new tb_HANGHOA();

            hanghoa.TENHH = txtTenHH.Text;
            hanghoa.IDLOAI = int.Parse(slkLoaiHH.EditValue.ToString());
            hanghoa.MOTA = txtMoTa.Text;
            hanghoa.DINHMUCTON = double.Parse(txtDinhMucTon.Text);
            hanghoa.TONKHO = double.Parse(txtTonKho.Text);
            

            if (_isAdd)
            {
                hanghoa.IDHH = txtIDHH.Text;
                _hh.AddHangHoa(hanghoa);
                SaveDonViTinh();
            }
            else
            {
                hanghoa.IDHH = _id;
                _hh.UpdateHangHoa(hanghoa);
                SaveDonViTinh();
            }
        }

        void SaveDonViTinh()
        {
            int dem = 0;
            List<tb_GIA> listdvt = new List<tb_GIA>();
            for (int i = 0; i < 4; i++)
            {
                if (listChk[i].Checked == true)
                {
                    dem++;
                    tb_GIA dvt = new tb_GIA();
                    if (i < _listDVT.Count) //  add new DVT
                    {
                        dvt.IDGIA = _listDVT[i].IDGIA;
                    }
                    dvt.IDHH = txtIDHH.Text;
                    dvt.DONVITINH = listcbo[i].Text;
                    dvt.QUYDOI = double.Parse(listTxtQuyDoi[i].Text);
                    dvt.GIANHAP = double.Parse(listTxtGiaNhap[i].Text);
                    dvt.GIABANLE = double.Parse(listTxtGiaBanLe[i].Text);
                    dvt.GIABANSI = double.Parse(listTxtGiaBanSi[i].Text);
                    listdvt.Add(dvt);
                }
            }
            if (_isAdd)
            {
                foreach (var dvt in listdvt)
                    _hh.AddDonViTinh(dvt);
            }
            else
            {
                for (int i = 0; i < _listDVT.Count; i++)
                {
                    _hh.UpdateDonViTinh(listdvt[i]);
                }
                int newRowCount = dem - _listDVT.Count;
                if (newRowCount > 0)
                {
                    for (int i = _listDVT.Count; i < dem; i++)
                    {
                        _hh.AddDonViTinh(listdvt[i]);
                    }                                          
                }
            }
            Func.ShowMessage("Lưu thành công");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkForm() == true)
            {
                try
                {
                    SaveHangHoa();
                    this.Close();
                }
                catch (Exception)
                {
                    Func.ShowMessage("Thêm thất bại, trùng khóa chính");
                }
            }
            else
                Func.ShowMessage("Thiếu dữ liệu");
        }
        private void btnThemLoaiHH_Click(object sender, EventArgs e)
        {
            if (Func.checkPermission("LOAIHANGHOA", "ADD"))
            {
                frmChiTietLoaiHangHoa frm = new frmChiTietLoaiHangHoa();
                frm.ShowDialog();
                LoadCboLoaiHH();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm");
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool checkForm()
        {
            bool isChecked = true;

            // check thông tin hàng hóa
            if (slkLoaiHH.Text == "" || txtIDHH.Text == "" || txtTenHH.Text == "")
                isChecked = false;

            // check đơn vị tính
            if (cboDVTGoc.Text == "")
                isChecked = false;
            if (chk2.Checked && cboDVT2.Text == "")
                isChecked = false;
            if (chk3.Checked && cboDVT3.Text == "")
                isChecked = false;
            if (chk4.Checked && cboDVT4.Text == "")
                isChecked = false;
            return isChecked;
        }
        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            cboDVT2.Enabled = chk2.Checked;
            txtQuyDoi2.Enabled = chk2.Checked;
            txtGiaNhap2.Enabled = chk2.Checked;
            txtGiaBanLe2.Enabled = chk2.Checked;
            txtGiaBanSi2.Enabled = chk2.Checked;
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            cboDVT3.Enabled = chk3.Checked;
            txtQuyDoi3.Enabled = chk3.Checked;
            txtGiaNhap3.Enabled = chk3.Checked;
            txtGiaBanLe3.Enabled = chk3.Checked;
            txtGiaBanSi3.Enabled = chk3.Checked;
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            cboDVT4.Enabled = chk4.Checked;
            txtQuyDoi4.Enabled = chk4.Checked;
            txtGiaNhap4.Enabled = chk4.Checked;
            txtGiaBanLe4.Enabled = chk4.Checked;
            txtGiaBanSi4.Enabled = chk4.Checked;
        }

        double formatStrToDouble(string str)
        {
            return double.Parse(string.IsNullOrEmpty(str) == true ? "0" : str);
        }
        private void txtQuyDoi2_TextChanged(object sender, EventArgs e)
        {
            double quyDoi = formatStrToDouble(txtQuyDoi2.Text);
            quyDoi = quyDoi < 2 ? 2 : quyDoi;
            txtQuyDoi2.Text = quyDoi.ToString();

            double giaNhapGoc = formatStrToDouble(txtGiaNhapGoc.Text);
            txtGiaNhap2.Text = (giaNhapGoc * quyDoi).ToString();

            double giaBanSiGoc = formatStrToDouble(txtGiaBanSiGoc.Text);
            txtGiaBanSi2.Text = (giaBanSiGoc * quyDoi).ToString();

            double giaBanLeGoc = formatStrToDouble(txtGiaBanLeGoc.Text);
            txtGiaBanLe2.Text = (giaBanLeGoc * quyDoi).ToString();
        }

        private void txtQuyDoi3_TextChanged(object sender, EventArgs e)
        {
            double quyDoi = formatStrToDouble(txtQuyDoi3.Text);
            quyDoi = quyDoi < 2 ? 2 : quyDoi;
            txtQuyDoi3.Text = quyDoi.ToString();

            double giaNhapGoc = formatStrToDouble(txtGiaNhapGoc.Text);
            txtGiaNhap3.Text = (giaNhapGoc * quyDoi).ToString();

            double giaBanSiGoc = formatStrToDouble(txtGiaBanSiGoc.Text);
            txtGiaBanSi3.Text = (giaBanSiGoc * quyDoi).ToString();

            double giaBanLeGoc = formatStrToDouble(txtGiaBanLeGoc.Text);
            txtGiaBanLe3.Text = (giaBanLeGoc * quyDoi).ToString();
        }

        private void txtQuyDoi4_TextChanged(object sender, EventArgs e)
        {
            double quyDoi = formatStrToDouble(txtQuyDoi4.Text);
            quyDoi = quyDoi < 2 ? 2 : quyDoi;
            txtQuyDoi4.Text = quyDoi.ToString();

            double giaNhapGoc = formatStrToDouble(txtGiaNhapGoc.Text);
            txtGiaNhap4.Text = (giaNhapGoc * quyDoi).ToString();

            double giaBanSiGoc = formatStrToDouble(txtGiaBanSiGoc.Text);
            txtGiaBanSi4.Text = (giaBanSiGoc * quyDoi).ToString();

            double giaBanLeGoc = formatStrToDouble(txtGiaBanLeGoc.Text);
            txtGiaBanLe4.Text = (giaBanLeGoc * quyDoi).ToString();
        }

        private void frmChiTietHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}