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
            if (File.Exists("connectDB.dba"))
            {
                string conStr = "";
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open("connectDB.dba", FileMode.Open, FileAccess.Read);
                Connect cp = (Connect)bf.Deserialize(fs);

                string deCryptServer = Encryptor.GiaiMa(cp.servername, "hoiAdminde", true);
                string deCryptUsername = Encryptor.GiaiMa(cp.username, "hoiAdminde", true);
                string deCryptPassword = Encryptor.GiaiMa(cp.passwd, "hoiAdminde", true);
                string deCryptDatabase = Encryptor.GiaiMa(cp.database, "hoiAdminde", true);

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
                    fs.Close();
                    Application.Run(new MainForm());
                }
                catch (Exception)
                {
                    Func.ShowMessage("Không thể kết nối cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fs.Close();
                    Application.Run(new frmKetNoiDB());
                    if (!string.IsNullOrEmpty(Entities.SERVER))
                    {
                        MainForm frm = new MainForm();
                        frm.ShowDialog();
                    }
                }
                con.Close();
                fs.Close();
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
