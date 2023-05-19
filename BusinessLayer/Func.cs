using DataLayer;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace BusinessLayer
{
    public class Func
    {
        // user info
        public static int IDUSER;
        public static string FULLNAMEUSER;
        public static List<tb_PHANQUYEN> LISTQUYENCUANHOM;
        public static bool checkPermission(string func_code, string action)
        {
            bool allow = false;

            switch (action)
            {
                case "SHOW":
                    allow = LISTQUYENCUANHOM.Where(x => x.FUNC_CODE == func_code).FirstOrDefault().SHOW == true;
                    break;
                case "ADD":
                    allow = LISTQUYENCUANHOM.Where(x => x.FUNC_CODE == func_code).FirstOrDefault().ADD == true;
                    break;
                case "UPDATE":
                    allow = LISTQUYENCUANHOM.Where(x => x.FUNC_CODE == func_code).FirstOrDefault().UPDATE == true;
                    break;
                case "DELETE":
                    allow = LISTQUYENCUANHOM.Where(x => x.FUNC_CODE == func_code).FirstOrDefault().DELETE == true;
                    break;
            }

            return allow;
        }

        public static DialogResult ShowMessage(string msg, MessageBoxButtons btn = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None)
        {
            return MessageBox.Show(msg, "PHẦN MỀM QUẢN LÝ BÁN HÀNG", btn, icon);
        }

        // func này code mạng: dùng để xóa dấu trong string, rất => rat
        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder(capacity: normalizedString.Length);

            for (int i = 0; i < normalizedString.Length; i++)
            {
                char c = normalizedString[i];
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder
                .ToString()
                .Normalize(NormalizationForm.FormC);
        }
       // hàm tìm những thay đổi trong db
        public static string FindChanged(Entities db, string tbName)
        {
            // Lấy danh sách các thay đổi
            var addedEntries = db.ChangeTracker.Entries().Where(e => e.State == EntityState.Added);
            var changedEntries = db.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified);
            var logMessage = "";
            // Ghi log các thay đổi
            foreach (var entry in changedEntries)
            {
                logMessage = $"[{tbName}][UPDATE]: ";
                foreach (var propertyName in entry.CurrentValues.PropertyNames)
                {
                    if (!object.Equals(entry.CurrentValues[propertyName], entry.OriginalValues[propertyName]))
                    {
                        logMessage += $"[{propertyName}:({entry.OriginalValues[propertyName]})=>({entry.CurrentValues[propertyName]})]; ";
                    }
                }
                return logMessage;
            }
           
            foreach (var entry in addedEntries)
            {
                logMessage = $"[{tbName}][INSERT]: ";
                foreach (var propertyName in entry.CurrentValues.PropertyNames)
                {
                    logMessage += $"[{propertyName}={entry.CurrentValues[propertyName]}]";
                }
                return logMessage;
            }
            return "";
        }

        public static void WriteLog(string message)
        {
            Entities db = Entities.CreateEntities();
            tb_LOG log = new tb_LOG();
            log.IDUSER = IDUSER;
            log.TIME = DateTime.Now;
            log.MESSAGE = message;
            db.tb_LOG.Add(log);
            db.SaveChanges();
        }


        // hàm tạo QRCode
        public static Bitmap GetQRCode(string text)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData data = generator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);

            QRCode qrcode = new QRCode(data);
            Bitmap bitmap = qrcode.GetGraphic(20);
            return bitmap;
        }
    }
}
