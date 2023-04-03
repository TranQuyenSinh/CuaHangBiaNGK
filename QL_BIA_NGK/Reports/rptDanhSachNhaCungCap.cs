using BusinessLayer.REPORT;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QL_BIA_NGK.Reports
{
    public partial class rptDanhSachNhaCungCap : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhaCungCap(List<NHACUNGCAP_REPORT> list)
        {
            InitializeComponent();
            this.objectDataSource1.DataSource = list;
        }

    }
}
