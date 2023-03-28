namespace QL_BIA_NGK
{
    partial class frmChiTietPhieuBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHienTon = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtQuyDoi = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.slkLoaiHH = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtHienTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkLoaiHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHienTon
            // 
            this.txtHienTon.EditValue = "1";
            this.txtHienTon.Enabled = false;
            this.txtHienTon.Location = new System.Drawing.Point(51, 274);
            this.txtHienTon.Name = "txtHienTon";
            this.txtHienTon.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtHienTon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtHienTon.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtHienTon.Properties.Appearance.Options.UseFont = true;
            this.txtHienTon.Properties.Appearance.Options.UseForeColor = true;
            this.txtHienTon.Properties.Appearance.Options.UseTextOptions = true;
            this.txtHienTon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtHienTon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtHienTon.Properties.MaskSettings.Set("mask", "n2");
            this.txtHienTon.Properties.NullText = "0";
            this.txtHienTon.Properties.ReadOnly = true;
            this.txtHienTon.Properties.UseMaskAsDisplayFormat = true;
            this.txtHienTon.Size = new System.Drawing.Size(101, 22);
            this.txtHienTon.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(48, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 99;
            this.label10.Text = "Hiện tồn";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Image = global::QL_BIA_NGK.Properties.Resources.close;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(602, 266);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 30);
            this.btnDong.TabIndex = 84;
            this.btnDong.Text = "Thoát";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = global::QL_BIA_NGK.Properties.Resources.diskette__1_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(511, 266);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 30);
            this.btnLuu.TabIndex = 83;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.EditValue = "0";
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(584, 211);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtThanhTien.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtThanhTien.Properties.Appearance.Options.UseFont = true;
            this.txtThanhTien.Properties.Appearance.Options.UseForeColor = true;
            this.txtThanhTien.Properties.Appearance.Options.UseTextOptions = true;
            this.txtThanhTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtThanhTien.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtThanhTien.Properties.MaskSettings.Set("mask", "n0");
            this.txtThanhTien.Properties.NullText = "0";
            this.txtThanhTien.Properties.ReadOnly = true;
            this.txtThanhTien.Properties.UseMaskAsDisplayFormat = true;
            this.txtThanhTien.Size = new System.Drawing.Size(101, 22);
            this.txtThanhTien.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(584, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 97;
            this.label9.Text = "Thành tiền";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = "0";
            this.txtSoLuong.Location = new System.Drawing.Point(450, 211);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtSoLuong.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Properties.Appearance.Options.UseForeColor = true;
            this.txtSoLuong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSoLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSoLuong.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSoLuong.Properties.MaskSettings.Set("mask", "n0");
            this.txtSoLuong.Properties.NullText = "0";
            this.txtSoLuong.Properties.UseMaskAsDisplayFormat = true;
            this.txtSoLuong.Size = new System.Drawing.Size(101, 22);
            this.txtSoLuong.TabIndex = 82;
            this.txtSoLuong.EditValueChanged += new System.EventHandler(this.txtSoLuong_EditValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(450, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 95;
            this.label7.Text = "Số lượng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(127, 131);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(560, 24);
            this.txtGhiChu.TabIndex = 79;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.EditValue = "0";
            this.txtGiaBan.Location = new System.Drawing.Point(316, 210);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtGiaBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtGiaBan.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtGiaBan.Properties.Appearance.Options.UseFont = true;
            this.txtGiaBan.Properties.Appearance.Options.UseForeColor = true;
            this.txtGiaBan.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGiaBan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGiaBan.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGiaBan.Properties.MaskSettings.Set("mask", "n0");
            this.txtGiaBan.Properties.NullText = "0";
            this.txtGiaBan.Properties.UseMaskAsDisplayFormat = true;
            this.txtGiaBan.Size = new System.Drawing.Size(101, 22);
            this.txtGiaBan.TabIndex = 81;
            this.txtGiaBan.EditValueChanged += new System.EventHandler(this.txtGiaNhap_EditValueChanged);
            // 
            // txtQuyDoi
            // 
            this.txtQuyDoi.EditValue = "1";
            this.txtQuyDoi.Enabled = false;
            this.txtQuyDoi.Location = new System.Drawing.Point(182, 210);
            this.txtQuyDoi.Name = "txtQuyDoi";
            this.txtQuyDoi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtQuyDoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtQuyDoi.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtQuyDoi.Properties.Appearance.Options.UseFont = true;
            this.txtQuyDoi.Properties.Appearance.Options.UseForeColor = true;
            this.txtQuyDoi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuyDoi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuyDoi.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtQuyDoi.Properties.MaskSettings.Set("mask", "n0");
            this.txtQuyDoi.Properties.NullText = "0";
            this.txtQuyDoi.Properties.ReadOnly = true;
            this.txtQuyDoi.Properties.UseMaskAsDisplayFormat = true;
            this.txtQuyDoi.Size = new System.Drawing.Size(101, 22);
            this.txtQuyDoi.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(316, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 94;
            this.label8.Text = "Giá bán";
            // 
            // cboDVT
            // 
            this.cboDVT.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Items.AddRange(new object[] {
            "Chai",
            "Lon",
            "Thùng",
            "Lốc"});
            this.cboDVT.Location = new System.Drawing.Point(48, 209);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(101, 24);
            this.cboDVT.TabIndex = 80;
            this.cboDVT.SelectedValueChanged += new System.EventHandler(this.cboDVT_SelectedValueChanged);
            // 
            // slkLoaiHH
            // 
            this.slkLoaiHH.EditValue = "[Loại hàng hóa]";
            this.slkLoaiHH.Location = new System.Drawing.Point(127, 25);
            this.slkLoaiHH.Name = "slkLoaiHH";
            this.slkLoaiHH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.slkLoaiHH.Properties.Appearance.Options.UseFont = true;
            this.slkLoaiHH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkLoaiHH.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkLoaiHH.Properties.SelectFirstRowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.slkLoaiHH.Size = new System.Drawing.Size(560, 22);
            this.slkLoaiHH.TabIndex = 78;
            this.slkLoaiHH.EditValueChanged += new System.EventHandler(this.slkLoaiHH_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDHH,
            this.TENHH,
            this.TONKHO});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(19, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 93;
            this.label5.Text = "Chọn hàng hóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(182, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 92;
            this.label6.Text = "Quy đổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(48, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 91;
            this.label4.Text = "Đơn vị tính";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMoTa.Location = new System.Drawing.Point(127, 95);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(560, 24);
            this.txtMoTa.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(80, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 90;
            this.label3.Text = "Mô tả";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenHH.Location = new System.Drawing.Point(127, 59);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.ReadOnly = true;
            this.txtTenHH.Size = new System.Drawing.Size(560, 24);
            this.txtTenHH.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "Tên hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(68, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Ghi chú";
            // 
            // IDHH
            // 
            this.IDHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IDHH.AppearanceHeader.Options.UseFont = true;
            this.IDHH.Caption = "Mã hàng hóa";
            this.IDHH.FieldName = "IDHH";
            this.IDHH.MaxWidth = 100;
            this.IDHH.MinWidth = 100;
            this.IDHH.Name = "IDHH";
            this.IDHH.Visible = true;
            this.IDHH.VisibleIndex = 0;
            this.IDHH.Width = 100;
            // 
            // TENHH
            // 
            this.TENHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TENHH.AppearanceHeader.Options.UseFont = true;
            this.TENHH.Caption = "Tên hàng hóa";
            this.TENHH.FieldName = "TENHH";
            this.TENHH.MaxWidth = 200;
            this.TENHH.MinWidth = 200;
            this.TENHH.Name = "TENHH";
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 1;
            this.TENHH.Width = 200;
            // 
            // TONKHO
            // 
            this.TONKHO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TONKHO.AppearanceHeader.Options.UseFont = true;
            this.TONKHO.Caption = "Tồn kho";
            this.TONKHO.FieldName = "TONKHO";
            this.TONKHO.MaxWidth = 100;
            this.TONKHO.MinWidth = 100;
            this.TONKHO.Name = "TONKHO";
            this.TONKHO.Visible = true;
            this.TONKHO.VisibleIndex = 2;
            this.TONKHO.Width = 100;
            // 
            // frmChiTietPhieuBan
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 321);
            this.Controls.Add(this.txtHienTon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtQuyDoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboDVT);
            this.Controls.Add(this.slkLoaiHH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmChiTietPhieuBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu bán";
            this.Load += new System.EventHandler(this.frmChiTietPhieuBan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChiTietPhieuBan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtHienTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkLoaiHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtHienTon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private DevExpress.XtraEditors.TextEdit txtThanhTien;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtGiaBan;
        private DevExpress.XtraEditors.TextEdit txtQuyDoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDVT;
        private DevExpress.XtraEditors.SearchLookUpEdit slkLoaiHH;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IDHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn TONKHO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}