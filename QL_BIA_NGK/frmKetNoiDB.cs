using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BIA_NGK
{
    public partial class frmKetNoiDB : DevExpress.XtraEditors.XtraForm
    {
        public frmKetNoiDB()
        {
            InitializeComponent();
        }
        SqlConnection getConnection(string server, string username, string password, string database)
        {
            return new SqlConnection("Data source=" + server + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + password + ";");
        }

        private void frmKetNoiDB_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = getConnection(txtServerName.Text, txtUsername.Text, txtPassword.Text, txtDBName.Text);
            try
            {
                conn.Open();
                Func.ShowMessage("Kết nối thành công");
                Entities.SERVER = txtServerName.Text;
                Entities.USERNAME = txtUsername.Text;
                Entities.PASSWORD = txtPassword.Text;
                Entities.DATABASE = txtDBName.Text;

                if (chkLuu.Checked)
                {
                    LuuFileCauHinh();
                }

                this.Close();
            }
            catch (Exception)
            {
                Func.ShowMessage("Kết nối không thành công");
            }
        }
        void LuuFileCauHinh()
        {
            Connect.servername = txtServerName.Text;
            Connect.username = txtUsername.Text;
            Connect.passwd = txtPassword.Text;
            Connect.dbname = txtDBName.Text;
            Connect.SaveFile();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}