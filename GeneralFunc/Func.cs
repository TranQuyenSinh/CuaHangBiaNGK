using DataLayer;
using QL_BIA_NGK;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralFunc
{
    public class Func
    {
        public class Func
        {
            public static bool checkPermission(string func_code, string action)
            {
                bool allow = false;
                List<tb_PHANQUYEN> listPermission = frmDangNhap.LISTQUYENCUANHOM;
                switch (action)
                {
                    case "SHOW":
                        allow = listPermission.Where(x => x.FUNC_CODE == func_code).FirstOrDefault().SHOW == true;
                        break;
                    case "ADD":
                        allow = listPermission.Where(x => x.FUNC_CODE == func_code).FirstOrDefault().ADD == true;
                        break;
                    case "UPDATE":
                        allow = listPermission.Where(x => x.FUNC_CODE == func_code).FirstOrDefault().UPDATE == true;
                        break;
                    case "DELETE":
                        allow = listPermission.Where(x => x.FUNC_CODE == func_code).FirstOrDefault().DELETE == true;
                        break;
                    case "PRINT":
                        allow = listPermission.Where(x => x.FUNC_CODE == func_code).FirstOrDefault().PRINT == true;
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
            public static void Log(string action, string tbName = null, string newValue = null, string oldValue = null)
            {
                QL_BIA_NGKEntities db = new QL_BIA_NGKEntities();
                tb_LOG log = new tb_LOG();
                log.IDUSER = frmDangNhap.IDUSER;
                log.TIME = DateTime.Now;
                switch (action)
                {
                    case "LOGIN":
                        log.MESSAGE = "Login vào hệ thống";
                        db.tb_LOG.Add(log);
                        break;
                    case "LOGOUT":
                        log.MESSAGE = "Logout hệ thống";
                        db.tb_LOG.Add(log);
                        break;
                    case "ADD":
                        log.MESSAGE = $"Thêm: {newValue}\nvào {tbName}";
                        break;
                    case "UPDATE":
                        log.MESSAGE = $"Chỉnh sửa: {oldValue}\nthành {newValue}\ntrong {tbName}";
                        break;
                    case "DELETE":
                        log.MESSAGE = $"Xóa: {newValue}\ntrong {tbName}";
                        break;
                    case "PRINT":
                        log.MESSAGE = $"In trong {tbName}";
                        break;
                }
                db.tb_LOG.Add(log);
                db.SaveChanges();
            }
        }
    }
}
