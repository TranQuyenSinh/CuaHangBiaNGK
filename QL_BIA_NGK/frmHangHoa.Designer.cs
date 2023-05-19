namespace QL_BIA_NGK
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblTong = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIANHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABANLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABANSI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUYDOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
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
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnRefresh,
            this.btnDong,
            this.lblTong,
            this.btnIn});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
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
            this.lblTong.Caption = "Tổng";
            this.lblTong.Id = 7;
            this.lblTong.Name = "lblTong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1198, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 662);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1198, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 638);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1198, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 638);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.ContextMenuStrip = this.contextMenuStrip1;
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 24);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1198, 638);
            this.gcDanhSach.TabIndex = 5;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::QL_BIA_NGK.Properties.Resources.close;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
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
            this.MOTA,
            this.TENLOAI,
            this.IDGIA,
            this.GIANHAP,
            this.GIABANLE,
            this.GIABANSI,
            this.TONKHO,
            this.QUYDOI});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.GroupCount = 1;
            this.gvDanhSach.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", this.TENHH, "Có {0} sản phẩm")});
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhSach.OptionsView.EnableAppearanceOddRow = true;
            this.gvDanhSach.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhSach.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvDanhSach.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TENLOAI, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDanhSach.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvDanhSach_CustomRowCellEdit);
            this.gvDanhSach.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDanhSach_CellValueChanging);
            this.gvDanhSach.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gvDanhSach_CustomRowFilter);
            this.gvDanhSach.DoubleClick += new System.EventHandler(this.gvDanhSach_DoubleClick);
            this.gvDanhSach.RowCountChanged += new System.EventHandler(this.gvDanhSach_RowCountChanged);
            // 
            // IDHH
            // 
            this.IDHH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IDHH.AppearanceCell.Options.UseFont = true;
            this.IDHH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IDHH.AppearanceHeader.Options.UseFont = true;
            this.IDHH.Caption = "Mã hàng hóa";
            this.IDHH.FieldName = "IDHH";
            this.IDHH.MaxWidth = 100;
            this.IDHH.MinWidth = 100;
            this.IDHH.Name = "IDHH";
            this.IDHH.OptionsFilter.AllowFilter = false;
            this.IDHH.Visible = true;
            this.IDHH.VisibleIndex = 0;
            this.IDHH.Width = 100;
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
            this.TENHH.OptionsFilter.AllowFilter = false;
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 1;
            this.TENHH.Width = 200;
            // 
            // MOTA
            // 
            this.MOTA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.MOTA.AppearanceCell.Options.UseFont = true;
            this.MOTA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MOTA.AppearanceHeader.Options.UseFont = true;
            this.MOTA.Caption = "Mô tả";
            this.MOTA.FieldName = "MOTA";
            this.MOTA.MaxWidth = 200;
            this.MOTA.MinWidth = 200;
            this.MOTA.Name = "MOTA";
            this.MOTA.OptionsFilter.AllowFilter = false;
            this.MOTA.Visible = true;
            this.MOTA.VisibleIndex = 2;
            this.MOTA.Width = 200;
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
            this.TENLOAI.OptionsFilter.AllowFilter = false;
            this.TENLOAI.Visible = true;
            this.TENLOAI.VisibleIndex = 2;
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
            this.IDGIA.MaxWidth = 75;
            this.IDGIA.MinWidth = 75;
            this.IDGIA.Name = "IDGIA";
            this.IDGIA.OptionsFilter.AllowFilter = false;
            this.IDGIA.Visible = true;
            this.IDGIA.VisibleIndex = 3;
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
            this.GIANHAP.OptionsFilter.AllowFilter = false;
            this.GIANHAP.Visible = true;
            this.GIANHAP.VisibleIndex = 5;
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
            this.GIABANLE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.GIABANLE.FieldName = "GIABANLE";
            this.GIABANLE.MaxWidth = 100;
            this.GIABANLE.MinWidth = 100;
            this.GIABANLE.Name = "GIABANLE";
            this.GIABANLE.OptionsFilter.AllowFilter = false;
            this.GIABANLE.Visible = true;
            this.GIABANLE.VisibleIndex = 6;
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
            this.GIABANSI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.GIABANSI.FieldName = "GIABANSI";
            this.GIABANSI.MaxWidth = 100;
            this.GIABANSI.MinWidth = 100;
            this.GIABANSI.Name = "GIABANSI";
            this.GIABANSI.OptionsFilter.AllowFilter = false;
            this.GIABANSI.Visible = true;
            this.GIABANSI.VisibleIndex = 7;
            this.GIABANSI.Width = 100;
            // 
            // TONKHO
            // 
            this.TONKHO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TONKHO.AppearanceCell.Options.UseFont = true;
            this.TONKHO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TONKHO.AppearanceHeader.Options.UseFont = true;
            this.TONKHO.Caption = "Tồn kho";
            this.TONKHO.DisplayFormat.FormatString = "###,###,##0.##";
            this.TONKHO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TONKHO.FieldName = "TONKHO";
            this.TONKHO.MaxWidth = 75;
            this.TONKHO.MinWidth = 75;
            this.TONKHO.Name = "TONKHO";
            this.TONKHO.OptionsFilter.AllowFilter = false;
            this.TONKHO.Visible = true;
            this.TONKHO.VisibleIndex = 8;
            // 
            // QUYDOI
            // 
            this.QUYDOI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.QUYDOI.AppearanceCell.Options.UseFont = true;
            this.QUYDOI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.QUYDOI.AppearanceHeader.Options.UseFont = true;
            this.QUYDOI.Caption = "Quy đổi";
            this.QUYDOI.FieldName = "QUYDOI";
            this.QUYDOI.MaxWidth = 75;
            this.QUYDOI.MinWidth = 75;
            this.QUYDOI.Name = "QUYDOI";
            this.QUYDOI.Visible = true;
            this.QUYDOI.VisibleIndex = 4;
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 8;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick_1);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 684);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "frmHangHoa";
            this.Text = "DANH SÁCH HÀNG HÓA";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHangHoa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem lblTong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IDHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn MOTA;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn IDGIA;
        private DevExpress.XtraGrid.Columns.GridColumn GIANHAP;
        private DevExpress.XtraGrid.Columns.GridColumn GIABANLE;
        private DevExpress.XtraGrid.Columns.GridColumn GIABANSI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn TONKHO;
        private DevExpress.XtraGrid.Columns.GridColumn QUYDOI;
        private DevExpress.XtraBars.BarButtonItem btnIn;
    }
}