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
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIENLAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDanhSachSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONVITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIANHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOINHUAN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachSP)).BeginInit();
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
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 8;
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
            this.splitContainer1.Panel1.Controls.Add(this.btnXem);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtDenNgay);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtTuNgay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
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
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.Blue;
            this.btnXem.Image = global::QL_BIA_NGK.Properties.Resources.search;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(910, 14);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(70, 37);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
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
            // dtDenNgay
            // 
            this.dtDenNgay.EditValue = null;
            this.dtDenNgay.Location = new System.Drawing.Point(389, 21);
            this.dtDenNgay.MenuManager = this.barManager1;
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtDenNgay.Properties.Appearance.Options.UseFont = true;
            this.dtDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDenNgay.Size = new System.Drawing.Size(162, 22);
            this.dtDenNgay.TabIndex = 1;
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
            // dtTuNgay
            // 
            this.dtTuNgay.EditValue = null;
            this.dtTuNgay.Location = new System.Drawing.Point(100, 21);
            this.dtTuNgay.MenuManager = this.barManager1;
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtTuNgay.Properties.Appearance.Options.UseFont = true;
            this.dtTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTuNgay.Size = new System.Drawing.Size(162, 22);
            this.dtTuNgay.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gcDanhSach);
            this.splitContainer2.Size = new System.Drawing.Size(1135, 577);
            this.splitContainer2.SplitterDistance = 516;
            this.splitContainer2.TabIndex = 0;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSachKH;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1135, 516);
            this.gcDanhSach.TabIndex = 8;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachKH,
            this.gvDanhSachSP});
            // 
            // gvDanhSachKH
            // 
            this.gvDanhSachKH.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvDanhSachKH.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDanhSachKH.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvDanhSachKH.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvDanhSachKH.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvDanhSachKH.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Blue;
            this.gvDanhSachKH.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDanhSachKH.Appearance.FocusedCell.Options.UseFont = true;
            this.gvDanhSachKH.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDanhSachKH.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvDanhSachKH.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Red;
            this.gvDanhSachKH.Appearance.GroupFooter.Options.UseFont = true;
            this.gvDanhSachKH.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDanhSachKH.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDanhSachKH.Appearance.GroupRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDanhSachKH.Appearance.GroupRow.BorderColor = System.Drawing.Color.RosyBrown;
            this.gvDanhSachKH.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvDanhSachKH.Appearance.GroupRow.ForeColor = System.Drawing.Color.DarkRed;
            this.gvDanhSachKH.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvDanhSachKH.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvDanhSachKH.Appearance.GroupRow.Options.UseFont = true;
            this.gvDanhSachKH.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDanhSachKH.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvDanhSachKH.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDanhSachKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.TIENLAI,
            this.HOTEN});
            this.gvDanhSachKH.GridControl = this.gcDanhSach;
            this.gvDanhSachKH.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LOINHUAN", this.TIENLAI, "Tổng: {0:n0} VNĐ")});
            this.gvDanhSachKH.Name = "gvDanhSachKH";
            this.gvDanhSachKH.OptionsView.AllowCellMerge = true;
            this.gvDanhSachKH.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhSachKH.OptionsView.EnableAppearanceOddRow = true;
            this.gvDanhSachKH.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Tên hàng hóa";
            this.gridColumn2.FieldName = "TENHH";
            this.gridColumn2.MaxWidth = 200;
            this.gridColumn2.MinWidth = 200;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 200;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn3.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "SL bán";
            this.gridColumn3.FieldName = "SLBAN";
            this.gridColumn3.MaxWidth = 75;
            this.gridColumn3.MinWidth = 75;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Đơn vị tính";
            this.gridColumn5.FieldName = "DONVITINH";
            this.gridColumn5.MaxWidth = 100;
            this.gridColumn5.MinWidth = 100;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn6.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Giá nhập";
            this.gridColumn6.DisplayFormat.FormatString = "n0";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "GIANHAP";
            this.gridColumn6.MaxWidth = 100;
            this.gridColumn6.MinWidth = 100;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn7.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.Caption = "Giá xuất";
            this.gridColumn7.DisplayFormat.FormatString = "n0";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "DONGIA";
            this.gridColumn7.MaxWidth = 100;
            this.gridColumn7.MinWidth = 100;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 100;
            // 
            // TIENLAI
            // 
            this.TIENLAI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TIENLAI.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.TIENLAI.AppearanceCell.Options.UseFont = true;
            this.TIENLAI.AppearanceCell.Options.UseForeColor = true;
            this.TIENLAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TIENLAI.AppearanceHeader.Options.UseFont = true;
            this.TIENLAI.Caption = "Lợi nhuận";
            this.TIENLAI.DisplayFormat.FormatString = "n0";
            this.TIENLAI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TIENLAI.FieldName = "LOINHUAN";
            this.TIENLAI.MaxWidth = 150;
            this.TIENLAI.MinWidth = 150;
            this.TIENLAI.Name = "TIENLAI";
            this.TIENLAI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.TIENLAI.Visible = true;
            this.TIENLAI.VisibleIndex = 6;
            this.TIENLAI.Width = 150;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.HOTEN.AppearanceCell.Options.UseFont = true;
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "Tên khách hàng";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 150;
            this.HOTEN.MinWidth = 150;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 0;
            this.HOTEN.Width = 150;
            // 
            // gvDanhSachSP
            // 
            this.gvDanhSachSP.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvDanhSachSP.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDanhSachSP.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvDanhSachSP.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvDanhSachSP.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvDanhSachSP.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Blue;
            this.gvDanhSachSP.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDanhSachSP.Appearance.FocusedCell.Options.UseFont = true;
            this.gvDanhSachSP.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDanhSachSP.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvDanhSachSP.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Red;
            this.gvDanhSachSP.Appearance.GroupFooter.Options.UseFont = true;
            this.gvDanhSachSP.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDanhSachSP.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDanhSachSP.Appearance.GroupRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDanhSachSP.Appearance.GroupRow.BorderColor = System.Drawing.Color.RosyBrown;
            this.gvDanhSachSP.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvDanhSachSP.Appearance.GroupRow.ForeColor = System.Drawing.Color.DarkRed;
            this.gvDanhSachSP.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvDanhSachSP.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvDanhSachSP.Appearance.GroupRow.Options.UseFont = true;
            this.gvDanhSachSP.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDanhSachSP.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDanhSachSP.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDanhSachSP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENLOAI,
            this.TENHH,
            this.SLBAN,
            this.DONVITINH,
            this.GIANHAP,
            this.DONGIA,
            this.LOINHUAN});
            this.gvDanhSachSP.GridControl = this.gcDanhSach;
            this.gvDanhSachSP.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LOINHUAN", this.LOINHUAN, "Tổng: {0:n0} VNĐ")});
            this.gvDanhSachSP.Name = "gvDanhSachSP";
            this.gvDanhSachSP.OptionsView.AllowCellMerge = true;
            this.gvDanhSachSP.OptionsView.ShowAutoFilterRow = true;
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
            this.TENLOAI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.TENLOAI.Visible = true;
            this.TENLOAI.VisibleIndex = 0;
            this.TENLOAI.Width = 100;
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
            this.TENHH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 1;
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
            this.SLBAN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.SLBAN.Visible = true;
            this.SLBAN.VisibleIndex = 3;
            // 
            // DONVITINH
            // 
            this.DONVITINH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DONVITINH.AppearanceCell.Options.UseFont = true;
            this.DONVITINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DONVITINH.AppearanceHeader.Options.UseFont = true;
            this.DONVITINH.Caption = "Đơn vị tính";
            this.DONVITINH.FieldName = "DONVITINH";
            this.DONVITINH.MaxWidth = 100;
            this.DONVITINH.MinWidth = 100;
            this.DONVITINH.Name = "DONVITINH";
            this.DONVITINH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.DONVITINH.Visible = true;
            this.DONVITINH.VisibleIndex = 2;
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
            this.GIANHAP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.GIANHAP.Visible = true;
            this.GIANHAP.VisibleIndex = 4;
            this.GIANHAP.Width = 100;
            // 
            // DONGIA
            // 
            this.DONGIA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DONGIA.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.DONGIA.AppearanceCell.Options.UseFont = true;
            this.DONGIA.AppearanceCell.Options.UseForeColor = true;
            this.DONGIA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DONGIA.AppearanceHeader.Options.UseFont = true;
            this.DONGIA.Caption = "Giá xuất";
            this.DONGIA.DisplayFormat.FormatString = "n0";
            this.DONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MaxWidth = 100;
            this.DONGIA.MinWidth = 100;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 5;
            this.DONGIA.Width = 100;
            // 
            // LOINHUAN
            // 
            this.LOINHUAN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LOINHUAN.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.LOINHUAN.AppearanceCell.Options.UseFont = true;
            this.LOINHUAN.AppearanceCell.Options.UseForeColor = true;
            this.LOINHUAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.LOINHUAN.AppearanceHeader.Options.UseFont = true;
            this.LOINHUAN.Caption = "Lợi nhuận";
            this.LOINHUAN.DisplayFormat.FormatString = "n0";
            this.LOINHUAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LOINHUAN.FieldName = "LOINHUAN";
            this.LOINHUAN.MaxWidth = 150;
            this.LOINHUAN.MinWidth = 150;
            this.LOINHUAN.Name = "LOINHUAN";
            this.LOINHUAN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.LOINHUAN.Visible = true;
            this.LOINHUAN.VisibleIndex = 6;
            this.LOINHUAN.Width = 100;
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
            this.KeyPreview = true;
            this.Name = "frmLoiNhuan";
            this.Text = "BÁO CÁO LỢI NHUẬN";
            this.Load += new System.EventHandler(this.frmLoiNhuan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLoiNhuan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachSP)).EndInit();
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
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtDenNgay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtTuNgay;
        private System.Windows.Forms.RadioButton radSP;
        private System.Windows.Forms.RadioButton radKH;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachKH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn TIENLAI;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachSP;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn SLBAN;
        private DevExpress.XtraGrid.Columns.GridColumn DONVITINH;
        private DevExpress.XtraGrid.Columns.GridColumn GIANHAP;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn LOINHUAN;
    }
}