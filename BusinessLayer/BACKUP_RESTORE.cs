using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLayer
{
    public class BACKUP_RESTORE
    {
        public static void BackUpDB(string fileName)
        {
            using (var db = new Entities())
            {
                db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
                    string.Format("BACKUP DATABASE [{0}] TO DISK='{1}'", db.Database.Connection.Database, fileName));
            }
        }
        public static void RestoreDB(string fileName)
        {
            using (var db = new Entities())
            {
                db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
                    string.Format("USE [master]; ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE [{0}] FROM DISK='{1}' WITH REPLACE", db.Database.Connection.Database, fileName));
            }
        }
    }
}
