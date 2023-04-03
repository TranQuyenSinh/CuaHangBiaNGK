using BusinessLayer.REPORT;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QL_BIA_NGK.Reports
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien(List<NHANVIEN_REPORT> list)
        {
            InitializeComponent();
            this.objectDataSource1.DataSource = list;
        }

    }
}
