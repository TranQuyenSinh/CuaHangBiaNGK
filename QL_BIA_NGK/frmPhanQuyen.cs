using BusinessLayer;
using BusinessLayer.DTO;
using DataLayer;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
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
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        QUYEN _quyen;
        NHOM _nhom;
        USER _user;
        int _idNhom;
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            _quyen = new QUYEN();
            _nhom = new NHOM();
            _user = new USER();
            _idNhom = -1;

            ShowHideButton();
            LoadData(_idNhom);
            LoadTree();
        }
        void ShowHideButton()
        {
            // permission
            btnThemUser.Enabled = Func.checkPermission("PHANQUYEN", "ADD");
            btnThemNhom.Enabled = Func.checkPermission("PHANQUYEN", "ADD");
            btnLuu.Enabled = Func.checkPermission("PHANQUYEN", "UPDATE");
            btnXoa.Enabled = Func.checkPermission("PHANQUYEN", "DELETE");
        }
        void LoadData(int idnhom)
        {
            gcDanhSach.DataSource = _quyen.getList(idnhom);
        }
        void LoadTree()
        {
            // load nhóm
            treeView1.Nodes.Clear();
            var listNhom = _nhom.getList();
            foreach (var nhom in listNhom)
            {
                TreeNode node = new TreeNode();
                node.Text = nhom.TENNHOM;
                node.Tag = nhom.IDNHOM;

                // load user trong nhóm
                var listUser = _user.getListUserByIdNhom(nhom.IDNHOM);
                foreach (var user in listUser)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = user.TENDAYDU;
                    childNode.Tag = user.IDUSER;
                    node.Nodes.Add(childNode);
                }

                treeView1.Nodes.Add(node);
                treeView1.ExpandAll();
            }
        }

        private void btnThemNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddGroup();
        }

        private void btnThemUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddUser();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData(_idNhom);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            TreeNode parentNode = selectedNode.Parent;
            string name;
            if (parentNode == null) // selectedNode = Nhóm
            {
                _idNhom = int.Parse(selectedNode.Tag.ToString());
                name = selectedNode.Text;
            }
            else
            {
                _idNhom = int.Parse(parentNode.Tag.ToString());
                name = parentNode.Text;
            }
            LoadData(_idNhom);
            lblCurrentNhom.Text = "Nhóm: " + name;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveQuyen();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (Func.checkPermission("PHANQUYEN", "UPDATE"))
            {
                TreeNode node = e.Node;
                if (node.Parent == null) // node = nhom
                {
                    int idnhom = int.Parse(node.Tag.ToString());
                    frmChiTietNhom frm = new frmChiTietNhom(idnhom);
                    frm.ShowDialog();
                }
                else  // node = user
                {
                    int iduser = int.Parse(node.Tag.ToString());
                    frmChiTietTaiKhoan frm = new frmChiTietTaiKhoan(iduser, true);
                    frm.ShowDialog();
                }
                LoadTree();
            }
            else
                Func.ShowMessage("Bạn không có quyền chỉnh sửa");
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
        void SaveQuyen()
        {
            if (Func.checkPermission("PHANQUYEN", "UPDATE"))
            {
                gvDanhSach.PostEditor();
                List<QUYEN_DTO> list = gcDanhSach.DataSource as List<QUYEN_DTO>;
                foreach (var dto in list)
                {
                    _quyen.Update(dto);
                }
                Func.ShowMessage("Lưu thành công");
            }
            else
                Func.ShowMessage("Bạn không có quyền chỉnh sửa");
        }
        void RefreshData(int idnhom)
        {
            LoadData(idnhom);
            LoadTree();
            lblCurrentNhom.Text = "Nhóm: ";
        }


        // handle fullControl button in grid
        private void gvDanhSach_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName != "FULL") return;

            bool isFullControl;
            var rowIndex = e.RowHandle;

            if (e.Value.ToString() == bool.TrueString)
            {
                isFullControl = true;
            }
            else
            {
                isFullControl = false;
            }
            gvDanhSach.SetRowCellValue(rowIndex, "SHOW", isFullControl);
            gvDanhSach.SetRowCellValue(rowIndex, "ADD", isFullControl);
            gvDanhSach.SetRowCellValue(rowIndex, "UPDATE", isFullControl);
            gvDanhSach.SetRowCellValue(rowIndex, "DELETE", isFullControl);
            gvDanhSach.SetRowCellValue(rowIndex, "PRINT", isFullControl);

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }

        void AddUser()
        {
            if (Func.checkPermission("PHANQUYEN", "ADD"))
            {
                frmChiTietTaiKhoan frm = new frmChiTietTaiKhoan(_idNhom, false);
                frm.ShowDialog();
                LoadTree();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm");
        }

        void AddGroup()
        {
            if (Func.checkPermission("PHANQUYEN", "ADD"))
            {
                frmChiTietNhom frm = new frmChiTietNhom();
                frm.ShowDialog();
                LoadTree();
            }
            else
                Func.ShowMessage("Bạn không có quyền thêm");
        }

        void Delete()
        {
            if (Func.checkPermission("PHANQUYEN", "DELETE"))
            {
                TreeNode node = treeView1.SelectedNode;
                if (node == null) return;
                if (Func.ShowMessage("Bạn có chắc muốn xóa " + node.Text + " không?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (node.Parent == null) // node = nhom
                    {
                        try
                        {
                            _nhom = new NHOM();
                            _nhom.Delete(int.Parse(node.Tag.ToString()));
                        }
                        catch (Exception)
                        {
                            Func.ShowMessage("Thất bại! Không thể xóa nhóm còn user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else  // node = user
                    {
                        _user.Delete(int.Parse(node.Tag.ToString()));
                    }
                    Func.ShowMessage("Xóa thành công");
                    RefreshData(_idNhom);
                }
            }
            else
                Func.ShowMessage("Bạn không có quyền xóa");
        }
        private void frmPhanQuyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) // AddUser
            {
                AddUser();
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                AddGroup();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                SaveQuyen();
            }
            else if (e.KeyCode == Keys.F5)
            {
                RefreshData(_idNhom);
            }
            else if (e.Control && e.KeyCode == Keys.W)
            {
                this.Close();
            }
        }

        private void thêmNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroup();
        }

        private void thêmUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser();
        }
    }
}