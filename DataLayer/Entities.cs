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
        private Entities(DbConnection connectionString, bool contextOwnsConnection = true)
            : base() { }
        public static Entities CreateEntities(bool contextOwnsConnection = true)
        {
            // thông tin connection
            string deCryptServer;
            string deCryptUsername;
            string deCryptPassword;
            string deCryptDatabase;
            // nếu không có file connect thì lấy thông tin connection từ form
            if (!File.Exists("connectDB.dba"))
            {
                deCryptServer = SERVER;
                deCryptUsername = USERNAME;
                deCryptPassword = PASSWORD;
                deCryptDatabase = DATABASE;
            }
            // ngược lại thì giải mã thông tin connection từ file ra
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open("connectDB.dba", FileMode.Open, FileAccess.Read);
                Connect cp = (Connect)bf.Deserialize(fs);

                deCryptServer = Encryptor.GiaiMa(cp.servername, "hoiAdminde", true);
                deCryptUsername = Encryptor.GiaiMa(cp.username, "hoiAdminde", true);
                deCryptPassword = Encryptor.GiaiMa(cp.passwd, "hoiAdminde", true);
                deCryptDatabase = Encryptor.GiaiMa(cp.database, "hoiAdminde", true);
                fs.Close();
            }


            // tạo connection string cho Entity
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            SqlConnectionStringBuilder sqlConnectBuilder = new SqlConnectionStringBuilder();
            sqlConnectBuilder.DataSource = deCryptServer;
            sqlConnectBuilder.InitialCatalog = deCryptDatabase;
            sqlConnectBuilder.UserID = deCryptUsername;
            sqlConnectBuilder.Password = deCryptPassword;

            string sqlConnectString = sqlConnectBuilder.ConnectionString;

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlConnectString;

            entityBuilder.Metadata = @"res://*/QL_BIA_NGK.csdl|res://*/QL_BIA_NGK.ssdl|res://*/QL_BIA_NGK.msl";

            EntityConnection connection = new EntityConnection(entityBuilder.ToString());

           
            return new Entities(connection);
        }
    }
}
