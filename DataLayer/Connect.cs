using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DataLayer
{
    public class Connect
    {
        public static string servername;
        public static string username;
        public static string passwd;
        public static string dbname;

        public static void ReadFile()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectConfig.xml");

            var connectInfo = doc.SelectSingleNode("/root/connectConfig");
            servername = Encryptor.GiaiMa(connectInfo.Attributes["servername"].Value, "hoiAdminde", true);
            username = Encryptor.GiaiMa(connectInfo.Attributes["username"].Value, "hoiAdminde", true);
            passwd = Encryptor.GiaiMa(connectInfo.Attributes["password"].Value, "hoiAdminde", true);
            dbname = Encryptor.GiaiMa(connectInfo.Attributes["dbname"].Value, "hoiAdminde", true);
        }
        public static void SaveFile()
        {
            string enCryptServer = Encryptor.MaHoa(servername, "hoiAdminde", true);
            string enCryptUsername = Encryptor.MaHoa(username, "hoiAdminde", true);
            string enCryptPassword = Encryptor.MaHoa(passwd, "hoiAdminde", true);
            string enCryptDatabase = Encryptor.MaHoa(dbname, "hoiAdminde", true);

            // nếu có file rồi thì sửa
            if (File.Exists("ConnectConfig.xml"))
            {
                File.Delete("ConnectConfig.xml");
            }
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("root");
            doc.AppendChild(root);

            XmlElement connectConfig = doc.CreateElement("connectConfig");
            connectConfig.SetAttribute("servername", enCryptServer);
            connectConfig.SetAttribute("username", enCryptUsername);
            connectConfig.SetAttribute("password", enCryptPassword);
            connectConfig.SetAttribute("dbname", enCryptDatabase);
            root.AppendChild(connectConfig);

            doc.Save("ConnectConfig.xml");
        }
    }
}
