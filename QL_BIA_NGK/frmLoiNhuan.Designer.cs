namespace QL_BIA_NGK
{
    partial class frmLoiNhuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoiNhuan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblTong = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radSP = new System.Windows.Forms.RadioButton();
            this.radKH = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIANHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIAXUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIENLOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
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
            this.btnIn,
            this.btnDong,
            this.lblTong,
            this.btnRefresh});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 5;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.LargeImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1135, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 664);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1135, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 640);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1135, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 640);
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
            this.splitContainer1.Panel1.Controls.Add(this.radSP);
            this.splitContainer1.Panel1.Controls.Add(this.radKH);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dateEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1135, 640);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 11;
            // 
            // radSP
            // 
            this.radSP.AutoSize = true;
            this.radSP.Checked = true;
            this.radSP.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radSP.Location = new System.Drawing.Point(602, 22);
            this.radSP.Name = "radSP";
            this.radSP.Size = new System.Drawing.Size(121, 21);
            this.radSP.TabIndex = 2;
            this.radSP.TabStop = true;
            this.radSP.Text = "Theo sản phẩm";
            this.radSP.UseVisualStyleBackColor = true;
            // 
            // radKH
            // 
            this.radKH.AutoSize = true;
            this.radKH.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radKH.Location = new System.Drawing.Point(743, 22);
            this.radKH.Name = "radKH";
            this.radKH.Size = new System.Drawing.Size(133, 21);
            this.radKH.TabIndex = 3;
            this.radKH.Text = "Theo khách hàng";
            this.radKH.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Image = global::QL_BIA_NGK.Properties.Resources.search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(910, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xem";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(318, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(389, 21);
            this.dateEdit2.MenuManager = this.barManager1;
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(162, 22);
            this.dateEdit2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(100, 21);
            this.dateEdit1.MenuManager = this.barManager1;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(162, 22);
            this.dateEdit1.TabIndex = 0;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1135, 577);
            this.gcDanhSach.TabIndex = 7;
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
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDHH,
            this.TENHH,
            this.SLBAN,
            this.TENLOAI,
            this.IDGIA,
            this.GIANHAP,
            this.GIAXUAT,
            this.TIENLOI});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", this.TENHH, "Có {0} sản phẩm")});
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowAutoFilterRow = true;
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
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 2;
            this.TENHH.Width = 200;
            // 
            // SLBAN
            // 
            this.SLBAN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SLBAN.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.SLBAN.AppearanceCell.Options.UseFont = true;
            this.SLBAN.AppearanceCell.Options.UseForeColor = true;
            this.SLBAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SLBAN.AppearanceHeader.Options.UseFont = true;
            this.SLBAN.Caption = "SL bán";
            this.SLBAN.FieldName = "SLBAN";
            this.SLBAN.MaxWidth = 75;
            this.SLBAN.MinWidth = 75;
            this.SLBAN.Name = "SLBAN";
            this.SLBAN.Visible = true;
            this.SLBAN.VisibleIndex = 4;
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
            this.IDGIA.MaxWidth = 75;
            this.IDGIA.MinWidth = 75;
            this.IDGIA.Name = "IDGIA";
            this.IDGIA.Visible = true;
            this.IDGIA.VisibleIndex = 3;
            // 
            // GIANHAP
            // 
            this.GIANHAP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GIANHAP.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.GIANHAP.AppearanceCell.Options.UseFont = true;
            this.GIANHAP.AppearanceCell.Options.UseForeColor = true;
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
            this.GIANHAP.VisibleIndex = 5;
            this.GIANHAP.Width = 100;
            // 
            // GIAXUAT
            // 
            this.GIAXUAT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GIAXUAT.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.GIAXUAT.AppearanceCell.Options.UseFont = true;
            this.GIAXUAT.AppearanceCell.Options.UseForeColor = true;
            this.GIAXUAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GIAXUAT.AppearanceHeader.Options.UseFont = true;
            this.GIAXUAT.Caption = "Giá xuất";
            this.GIAXUAT.DisplayFormat.FormatString = "n0";
            this.GIAXUAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIAXUAT.FieldName = "GIAXUAT";
            this.GIAXUAT.MaxWidth = 100;
            this.GIAXUAT.MinWidth = 100;
            this.GIAXUAT.Name = "GIAXUAT";
            this.GIAXUAT.Visible = true;
            this.GIAXUAT.VisibleIndex = 6;
            this.GIAXUAT.Width = 100;
            // 
            // TIENLOI
            // 
            this.TIENLOI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TIENLOI.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.TIENLOI.AppearanceCell.Options.UseFont = true;
            this.TIENLOI.AppearanceCell.Options.UseForeColor = true;
            this.TIENLOI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TIENLOI.AppearanceHeader.Options.UseFont = true;
            this.TIENLOI.Caption = "Tiền lời";
            this.TIENLOI.DisplayFormat.FormatString = "n0";
            this.TIENLOI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TIENLOI.FieldName = "TIENLOI";
            this.TIENLOI.MaxWidth = 100;
            this.TIENLOI.MinWidth = 100;
            this.TIENLOI.Name = "TIENLOI";
            this.TIENLOI.Visible = true;
            this.TIENLOI.VisibleIndex = 7;
            this.TIENLOI.Width = 100;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 8;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // frmLoiNhuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 686);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLoiNhuan";
            this.Text = "BÁO CÁO LỢI NHUẬN";
            this.Load += new System.EventHandler(this.frmLoiNhuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem lblTong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IDHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn SLBAN;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn IDGIA;
        private DevExpress.XtraGrid.Columns.GridColumn GIANHAP;
        private DevExpress.XtraGrid.Columns.GridColumn GIAXUAT;
        private DevExpress.XtraGrid.Columns.GridColumn TIENLOI;
        private System.Windows.Forms.RadioButton radSP;
        private System.Windows.Forms.RadioButton radKH;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
    }
}