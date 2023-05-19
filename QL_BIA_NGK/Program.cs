using BusinessLayer;
using DataLayer;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DataAccess.DataFederation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BIA_NGK
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists("ConnectConfig.xml"))
            {
                string conStr = "";
                Connect.ReadFile();
                string deCryptServer = Connect.servername;
                string deCryptUsername = Connect.username;
                string deCryptPassword = Connect.passwd;
                string deCryptDatabase = Connect.dbname;

                Entities.SERVER = deCryptServer;
                Entities.USERNAME = deCryptUsername;
                Entities.PASSWORD = deCryptPassword;
                Entities.DATABASE = deCryptDatabase;

                conStr += "Data source = " + deCryptServer + "; Initial Catalog = " + deCryptDatabase + "; User ID = " + deCryptUsername + "; Password = " + deCryptPassword + "; ";
                connoi = conStr;
                SqlConnection con = new SqlConnection(conStr);

                try
                {
                    con.Open();
                    Application.Run(new MainForm());
                }
                catch (Exception)
                {
                    Func.ShowMessage("Không thể kết nối cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Run(new frmKetNoiDB());
                    if (!string.IsNullOrEmpty(Entities.SERVER))
                    {
                        MainForm frm = new MainForm();
                        frm.ShowDialog();
                    }
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                Application.Run(new frmKetNoiDB());
                if (!string.IsNullOrEmpty(Entities.SERVER))
                {
                    MainForm frm = new MainForm();
                    frm.ShowDialog();
                }
            }
        }
        public static string connoi = "";
    }
}
