using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public class Connect
    {
        public Connect(string server, string user, string pass, string database)
        {
            this.servername = server;
            this.username = user;
            this.passwd = pass;
            this.database = database;
        }
        public string servername;

        public string Servername
        {
            get { return servername; }
            set { servername = value; }
        }

        public string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string passwd;

        public string Passwd
        {
            get { return passwd; }
            set { passwd = value; }
        }

        public string database;

        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        public void SaveFile()
        {
            // nếu có file rồi thì ghi đè
            if (File.Exists("connectDB.dba"))
                File.Delete("connectDB.dba");
            FileStream fs = File.Open("connectDB.dba", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
    }
}
