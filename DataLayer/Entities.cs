using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public partial class Entities : DbContext
    {
        public static string SERVER;
        public static string USERNAME;
        public static string PASSWORD;
        public static string DATABASE;
        private Entities(string connectionString)
            : base(connectionString) { }
        public static Entities CreateEntities()
        {
            // thông tin connection
            string deCryptServer;
            string deCryptUsername;
            string deCryptPassword;
            string deCryptDatabase;
            // nếu không có file connect thì lấy thông tin connection từ form
            if (!File.Exists("ConnectConfig.xml"))
            {
                deCryptServer = SERVER;
                deCryptUsername = USERNAME;
                deCryptPassword = PASSWORD;
                deCryptDatabase = DATABASE;
            }
            // ngược lại thì giải mã thông tin connection từ file ra
            else
            {
                deCryptServer = Connect.servername;
                deCryptUsername = Connect.username;
                deCryptPassword = Connect.passwd;
                deCryptDatabase = Connect.dbname;
            }

            string connectStr = string.Format(@"metadata=res://*/QL_BIA_NGK.csdl|res://*/QL_BIA_NGK.ssdl|res://*/QL_BIA_NGK.msl;
                                                provider=System.Data.SqlClient;provider connection string='
                                                data source={0};
                                                initial catalog={1};
                                                user id={2};
                                                password={3};
                                                MultipleActiveResultSets=True;App=EntityFramework'",deCryptServer, deCryptDatabase, deCryptUsername, deCryptPassword);

            return new Entities(connectStr);
        }
    }
}
