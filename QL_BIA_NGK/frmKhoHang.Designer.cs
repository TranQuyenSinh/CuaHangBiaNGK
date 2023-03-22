﻿namespace QL_BIA_NGK
{
    partial class frmKhoHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblTong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DINHMUCTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUYDOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slkDVT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkDVT)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnLuu,
            this.btnRefresh,
            this.btnIn,
            this.btnDong,
            this.lblTong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 5;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.LargeImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblTong)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // lblTong
            // 
            this.lblTong.Caption = "Tong";
            this.lblTong.Id = 8;
            this.lblTong.Name = "lblTong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1107, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 646);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1107, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 622);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1107, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 622);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 24);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.slkDVT});
            this.gcDanhSach.Size = new System.Drawing.Size(1107, 622);
            this.gcDanhSach.TabIndex = 6;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gvDanhSach.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Yellow;
            this.gvDanhSach.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Red;
            this.gvDanhSach.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDanhSach.Appearance.FocusedCell.Options.UseFont = true;
            this.gvDanhSach.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDanhSach.Appearance.FocusedRow.BackColor = System.Drawing.Color.Chartreuse;
            this.gvDanhSach.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.GreenYellow;
            this.gvDanhSach.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.FocusedRow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gvDanhSach.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDanhSach.Appearance.FocusedRow.Options.UseFont = true;
            this.gvDanhSach.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvDanhSach.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gvDanhSach.Appearance.GroupRow.Options.UseFont = true;
            this.gvDanhSach.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDHH,
            this.TENHH,
            this.TENLOAI,
            this.TONKHO,
            this.IDLOAI,
            this.DINHMUCTON,
            this.QUYDOI,
            this.IDDVT});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.GroupCount = 1;
            this.gvDanhSach.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", this.TENHH, "Có {0} sản phẩm")});
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvDanhSach.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhSach.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TENLOAI, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDanhSach.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvDanhSach_CustomRowCellEdit);
            this.gvDanhSach.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDanhSach_CellValueChanging);
            this.gvDanhSach.RowCountChanged += new System.EventHandler(this.gvDanhSach_RowCountChanged);
            // 
            // IDHH
            // 
            this.IDHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IDHH.AppearanceHeader.Options.UseFont = true;
            this.IDHH.Caption = "Mã hàng hóa";
            this.IDHH.FieldName = "IDHH";
            this.IDHH.MaxWidth = 150;
            this.IDHH.MinWidth = 150;
            this.IDHH.Name = "IDHH";
            this.IDHH.OptionsFilter.AllowFilter = false;
            this.IDHH.Visible = true;
            this.IDHH.VisibleIndex = 0;
            this.IDHH.Width = 150;
            // 
            // TENHH
            // 
            this.TENHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TENHH.AppearanceHeader.Options.UseFont = true;
            this.TENHH.Caption = "Tên hàng hóa";
            this.TENHH.FieldName = "TENHH";
            this.TENHH.MaxWidth = 250;
            this.TENHH.MinWidth = 250;
            this.TENHH.Name = "TENHH";
            this.TENHH.OptionsFilter.AllowFilter = false;
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 1;
            this.TENHH.Width = 250;
            // 
            // TENLOAI
            // 
            this.TENLOAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TENLOAI.AppearanceHeader.Options.UseFont = true;
            this.TENLOAI.Caption = "Loại hàng hóa";
            this.TENLOAI.FieldName = "TENLOAI";
            this.TENLOAI.MaxWidth = 100;
            this.TENLOAI.MinWidth = 100;
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.OptionsFilter.AllowFilter = false;
            this.TENLOAI.Visible = true;
            this.TENLOAI.VisibleIndex = 1;
            this.TENLOAI.Width = 100;
            // 
            // TONKHO
            // 
            this.TONKHO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TONKHO.AppearanceHeader.Options.UseFont = true;
            this.TONKHO.Caption = "Tồn kho";
            this.TONKHO.DisplayFormat.FormatString = "###,###,##0.##";
            this.TONKHO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TONKHO.FieldName = "TONKHO";
            this.TONKHO.MaxWidth = 100;
            this.TONKHO.MinWidth = 100;
            this.TONKHO.Name = "TONKHO";
            this.TONKHO.OptionsFilter.AllowFilter = false;
            this.TONKHO.UnboundDataType = typeof(string);
            this.TONKHO.Visible = true;
            this.TONKHO.VisibleIndex = 4;
            this.TONKHO.Width = 100;
            // 
            // IDLOAI
            // 
            this.IDLOAI.Caption = "IDLOAI";
            this.IDLOAI.Name = "IDLOAI";
            // 
            // DINHMUCTON
            // 
            this.DINHMUCTON.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DINHMUCTON.AppearanceHeader.Options.UseFont = true;
            this.DINHMUCTON.Caption = "Định mức tồn";
            this.DINHMUCTON.FieldName = "DINHMUCTON";
            this.DINHMUCTON.MaxWidth = 100;
            this.DINHMUCTON.MinWidth = 100;
            this.DINHMUCTON.Name = "DINHMUCTON";
            this.DINHMUCTON.OptionsFilter.AllowFilter = false;
            this.DINHMUCTON.Visible = true;
            this.DINHMUCTON.VisibleIndex = 5;
            this.DINHMUCTON.Width = 100;
            // 
            // QUYDOI
            // 
            this.QUYDOI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.QUYDOI.AppearanceHeader.Options.UseFont = true;
            this.QUYDOI.Caption = "Quy đổi";
            this.QUYDOI.FieldName = "QUYDOI";
            this.QUYDOI.Name = "QUYDOI";
            this.QUYDOI.OptionsColumn.FixedWidth = true;
            this.QUYDOI.OptionsColumn.ReadOnly = true;
            this.QUYDOI.OptionsFilter.AllowFilter = false;
            this.QUYDOI.Visible = true;
            this.QUYDOI.VisibleIndex = 3;
            this.QUYDOI.Width = 100;
            // 
            // IDDVT
            // 
            this.IDDVT.AppearanceCell.Options.UseTextOptions = true;
            this.IDDVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.IDDVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IDDVT.AppearanceHeader.Options.UseFont = true;
            this.IDDVT.Caption = "Đơn vị tính";
            this.IDDVT.FieldName = "IDDVT";
            this.IDDVT.MaxWidth = 100;
            this.IDDVT.MinWidth = 100;
            this.IDDVT.Name = "IDDVT";
            this.IDDVT.OptionsFilter.AllowFilter = false;
            this.IDDVT.Visible = true;
            this.IDDVT.VisibleIndex = 2;
            this.IDDVT.Width = 100;
            // 
            // slkDVT
            // 
            this.slkDVT.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.slkDVT.AutoHeight = false;
            this.slkDVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkDVT.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DONVITINH", "Đơn vị tính"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QUYDOI", "Quy đổi")});
            this.slkDVT.Name = "slkDVT";
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "frmKhoHang";
            this.Text = "KHO HÀNG";
            this.Load += new System.EventHandler(this.frmKhoHang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKhoHang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkDVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IDHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn TONKHO;
        private DevExpress.XtraGrid.Columns.GridColumn IDLOAI;
        private DevExpress.XtraBars.BarButtonItem lblTong;
        private DevExpress.XtraGrid.Columns.GridColumn DINHMUCTON;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit slkDVT;
        private DevExpress.XtraGrid.Columns.GridColumn IDDVT;
        private DevExpress.XtraGrid.Columns.GridColumn QUYDOI;
    }
}