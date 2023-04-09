namespace QL_BIA_NGK
{
    partial class frmHangTonSapHet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangTonSapHet));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelCheck = new System.Windows.Forms.Label();
            this.btnTaoPNAll = new System.Windows.Forms.Button();
            this.btnTaoPN = new System.Windows.Forms.Button();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIANHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABANLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABANSI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DINHMUCTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkNhapHang = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhapHang)).BeginInit();
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
            this.btnRefresh,
            this.btnIn,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1205, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 648);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1205, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 624);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1205, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 624);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelCheck);
            this.splitContainer1.Panel1.Controls.Add(this.btnTaoPNAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnTaoPN);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1205, 624);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 11;
            // 
            // labelCheck
            // 
            this.labelCheck.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelCheck.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCheck.Image = global::QL_BIA_NGK.Properties.Resources.check;
            this.labelCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCheck.Location = new System.Drawing.Point(660, 25);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(293, 28);
            this.labelCheck.TabIndex = 2;
            this.labelCheck.Text = "Hiện không có hàng hóa nào sắp hết       ";
            this.labelCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTaoPNAll
            // 
            this.btnTaoPNAll.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaoPNAll.Image = global::QL_BIA_NGK.Properties.Resources.plus;
            this.btnTaoPNAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPNAll.Location = new System.Drawing.Point(328, 19);
            this.btnTaoPNAll.Name = "btnTaoPNAll";
            this.btnTaoPNAll.Size = new System.Drawing.Size(288, 43);
            this.btnTaoPNAll.TabIndex = 1;
            this.btnTaoPNAll.Text = "Tạo phiếu nhập cho tất cả hàng hóa";
            this.btnTaoPNAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoPNAll.UseVisualStyleBackColor = true;
            this.btnTaoPNAll.Click += new System.EventHandler(this.btnTaoPNAll_Click);
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaoPN.Image = global::QL_BIA_NGK.Properties.Resources.plus;
            this.btnTaoPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPN.Location = new System.Drawing.Point(21, 19);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(301, 43);
            this.btnTaoPN.TabIndex = 0;
            this.btnTaoPN.Text = "Tạo phiếu nhập cho hàng hóa đã chọn";
            this.btnTaoPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoPN.UseVisualStyleBackColor = true;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkNhapHang});
            this.gcDanhSach.Size = new System.Drawing.Size(1205, 541);
            this.gcDanhSach.TabIndex = 7;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvDanhSach.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDanhSach.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvDanhSach.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvDanhSach.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvDanhSach.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Blue;
            this.gvDanhSach.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDanhSach.Appearance.FocusedCell.Options.UseFont = true;
            this.gvDanhSach.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDanhSach.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Red;
            this.gvDanhSach.Appearance.GroupFooter.Options.UseFont = true;
            this.gvDanhSach.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDanhSach.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDanhSach.Appearance.GroupRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDanhSach.Appearance.GroupRow.BorderColor = System.Drawing.Color.RosyBrown;
            this.gvDanhSach.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.GroupRow.ForeColor = System.Drawing.Color.DarkRed;
            this.gvDanhSach.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvDanhSach.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvDanhSach.Appearance.GroupRow.Options.UseFont = true;
            this.gvDanhSach.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDanhSach.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvDanhSach.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDHH,
            this.TENHH,
            this.TENLOAI,
            this.IDGIA,
            this.GIANHAP,
            this.GIABANLE,
            this.GIABANSI,
            this.DINHMUCTON,
            this.TONKHO});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.GroupCount = 1;
            this.gvDanhSach.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", this.TENHH, "Có {0} sản phẩm")});
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsSelection.MultiSelect = true;
            this.gvDanhSach.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhSach.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gvDanhSach.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhSach.OptionsView.EnableAppearanceOddRow = true;
            this.gvDanhSach.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhSach.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TENLOAI, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDanhSach.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvDanhSach_CustomRowCellEdit);
            this.gvDanhSach.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDanhSach_SelectionChanged);
            this.gvDanhSach.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDanhSach_CellValueChanging);
            // 
            // IDHH
            // 
            this.IDHH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IDHH.AppearanceCell.Options.UseFont = true;
            this.IDHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IDHH.AppearanceHeader.Options.UseFont = true;
            this.IDHH.Caption = "Mã hàng hóa";
            this.IDHH.FieldName = "IDHH";
            this.IDHH.MaxWidth = 150;
            this.IDHH.MinWidth = 150;
            this.IDHH.Name = "IDHH";
            this.IDHH.Visible = true;
            this.IDHH.VisibleIndex = 1;
            this.IDHH.Width = 150;
            // 
            // TENHH
            // 
            this.TENHH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TENHH.AppearanceCell.Options.UseFont = true;
            this.TENHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TENHH.AppearanceHeader.Options.UseFont = true;
            this.TENHH.Caption = "Tên hàng hóa";
            this.TENHH.FieldName = "TENHH";
            this.TENHH.MaxWidth = 200;
            this.TENHH.MinWidth = 200;
            this.TENHH.Name = "TENHH";
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 2;
            this.TENHH.Width = 200;
            // 
            // TENLOAI
            // 
            this.TENLOAI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TENLOAI.AppearanceCell.Options.UseFont = true;
            this.TENLOAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TENLOAI.AppearanceHeader.Options.UseFont = true;
            this.TENLOAI.Caption = "Loại hàng hóa";
            this.TENLOAI.FieldName = "TENLOAI";
            this.TENLOAI.MaxWidth = 100;
            this.TENLOAI.MinWidth = 100;
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.Visible = true;
            this.TENLOAI.VisibleIndex = 1;
            this.TENLOAI.Width = 100;
            // 
            // IDGIA
            // 
            this.IDGIA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IDGIA.AppearanceCell.Options.UseFont = true;
            this.IDGIA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IDGIA.AppearanceHeader.Options.UseFont = true;
            this.IDGIA.Caption = "Đơn vị tính";
            this.IDGIA.FieldName = "IDGIA";
            this.IDGIA.MaxWidth = 100;
            this.IDGIA.MinWidth = 100;
            this.IDGIA.Name = "IDGIA";
            this.IDGIA.Visible = true;
            this.IDGIA.VisibleIndex = 3;
            this.IDGIA.Width = 100;
            // 
            // GIANHAP
            // 
            this.GIANHAP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GIANHAP.AppearanceCell.Options.UseFont = true;
            this.GIANHAP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GIANHAP.AppearanceHeader.Options.UseFont = true;
            this.GIANHAP.Caption = "Giá nhập";
            this.GIANHAP.DisplayFormat.FormatString = "n0";
            this.GIANHAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIANHAP.FieldName = "GIANHAP";
            this.GIANHAP.MaxWidth = 100;
            this.GIANHAP.MinWidth = 100;
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.Visible = true;
            this.GIANHAP.VisibleIndex = 4;
            this.GIANHAP.Width = 100;
            // 
            // GIABANLE
            // 
            this.GIABANLE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GIABANLE.AppearanceCell.Options.UseFont = true;
            this.GIABANLE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GIABANLE.AppearanceHeader.Options.UseFont = true;
            this.GIABANLE.Caption = "Giá bán lẻ";
            this.GIABANLE.DisplayFormat.FormatString = "n0";
            this.GIABANLE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIABANLE.FieldName = "GIABANLE";
            this.GIABANLE.MaxWidth = 100;
            this.GIABANLE.MinWidth = 100;
            this.GIABANLE.Name = "GIABANLE";
            this.GIABANLE.Visible = true;
            this.GIABANLE.VisibleIndex = 5;
            this.GIABANLE.Width = 100;
            // 
            // GIABANSI
            // 
            this.GIABANSI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GIABANSI.AppearanceCell.Options.UseFont = true;
            this.GIABANSI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GIABANSI.AppearanceHeader.Options.UseFont = true;
            this.GIABANSI.Caption = "Giá bán sỉ";
            this.GIABANSI.DisplayFormat.FormatString = "n0";
            this.GIABANSI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIABANSI.FieldName = "GIABANSI";
            this.GIABANSI.MaxWidth = 100;
            this.GIABANSI.MinWidth = 100;
            this.GIABANSI.Name = "GIABANSI";
            this.GIABANSI.Visible = true;
            this.GIABANSI.VisibleIndex = 6;
            this.GIABANSI.Width = 100;
            // 
            // DINHMUCTON
            // 
            this.DINHMUCTON.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DINHMUCTON.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.DINHMUCTON.AppearanceCell.Options.UseFont = true;
            this.DINHMUCTON.AppearanceCell.Options.UseForeColor = true;
            this.DINHMUCTON.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DINHMUCTON.AppearanceHeader.Options.UseFont = true;
            this.DINHMUCTON.Caption = "Định mức tồn";
            this.DINHMUCTON.DisplayFormat.FormatString = "###,###,##0.##";
            this.DINHMUCTON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DINHMUCTON.FieldName = "DINHMUCTON";
            this.DINHMUCTON.MaxWidth = 100;
            this.DINHMUCTON.MinWidth = 100;
            this.DINHMUCTON.Name = "DINHMUCTON";
            this.DINHMUCTON.Visible = true;
            this.DINHMUCTON.VisibleIndex = 7;
            this.DINHMUCTON.Width = 100;
            // 
            // TONKHO
            // 
            this.TONKHO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TONKHO.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.TONKHO.AppearanceCell.Options.UseFont = true;
            this.TONKHO.AppearanceCell.Options.UseForeColor = true;
            this.TONKHO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TONKHO.AppearanceHeader.Options.UseFont = true;
            this.TONKHO.Caption = "Tồn kho hiện tại";
            this.TONKHO.DisplayFormat.FormatString = "###,###,##0.##";
            this.TONKHO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TONKHO.FieldName = "TONKHO";
            this.TONKHO.MaxWidth = 100;
            this.TONKHO.MinWidth = 100;
            this.TONKHO.Name = "TONKHO";
            this.TONKHO.Visible = true;
            this.TONKHO.VisibleIndex = 8;
            this.TONKHO.Width = 100;
            // 
            // chkNhapHang
            // 
            this.chkNhapHang.AutoHeight = false;
            this.chkNhapHang.CheckBoxOptions.SvgColorChecked = System.Drawing.Color.Blue;
            this.chkNhapHang.Name = "chkNhapHang";
            // 
            // frmHangTonSapHet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 668);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "frmHangTonSapHet";
            this.Text = "HÀNG TỒN SẮP HẾT";
            this.Load += new System.EventHandler(this.frmHangTonSapHet_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHangTonSapHet_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnTaoPN;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IDHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn IDGIA;
        private DevExpress.XtraGrid.Columns.GridColumn GIANHAP;
        private DevExpress.XtraGrid.Columns.GridColumn GIABANLE;
        private DevExpress.XtraGrid.Columns.GridColumn GIABANSI;
        private DevExpress.XtraGrid.Columns.GridColumn DINHMUCTON;
        private DevExpress.XtraGrid.Columns.GridColumn TONKHO;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkNhapHang;
        private System.Windows.Forms.Button btnTaoPNAll;
        private System.Windows.Forms.Label labelCheck;
    }
}