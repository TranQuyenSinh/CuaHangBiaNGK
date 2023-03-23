using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class USER
    {
        Entities db = Entities.CreateEntities();

        // success => return iduser
        // failed  => return -1
        public int LoginUser(string username, string password)
        {
            var user = db.tb_USER.Where(x => x.DELETED == false && x.USERNAME == username && x.PASSWORD == password).FirstOrDefault();

            if (user != null)
                return user.IDUSER;
            return -1;
        }
        public List<tb_USER> getListByIdNhom(int idnhom)
        {
            db = Entities.CreateEntities();
            return db.tb_USER.Where(x => x.IDNHOM == idnhom).ToList();
        }
        public string GetUsername(int iduser)
        {
            return db.tb_USER.FirstOrDefault(x => x.IDUSER == iduser).USERNAME;
        }
        // true if username not existed
        public bool CheckUsernameExisted(string username)
        {
            var user = db.tb_USER.Where(x => x.USERNAME == username).FirstOrDefault();
            return user == null;
        }
        public string getFullNameUser(int iduser)
        {
            return db.tb_USER.FirstOrDefault(x => x.IDUSER == iduser).TENDAYDU;
        }
        public List<tb_PHANQUYEN> GetListPermission(int iduser)
        {
            var idnhom = db.tb_USER.FirstOrDefault(x => x.IDUSER == iduser).IDNHOM;
            var listQuyenCuaNhom = db.tb_PHANQUYEN.Where(x => x.IDNHOM == idnhom).ToList();

            return listQuyenCuaNhom;
        }
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            var user = db.tb_USER.FirstOrDefault(x => x.IDUSER == Func.IDUSER);
            if (user.PASSWORD == oldPassword)
            {
                user.PASSWORD = newPassword;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public tb_USER getItem(int iduser)
        {
            return db.tb_USER.FirstOrDefault(x => x.IDUSER == iduser);
        }
        public void Add(tb_USER dt)
        {
            try
            {
                dt.DELETED = false;
                db.tb_USER.Add(dt);
                db.SaveChanges();
                Func.Log("ADD", "User", $"ID:{dt.IDUSER}, UserName:{dt.USERNAME}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(tb_USER dt)
        {
            try
            {
                var _dt = db.tb_USER.FirstOrDefault(x => x.IDUSER == dt.IDUSER);
                string oldValue = $"ID:{_dt.IDUSER}, Name: {_dt.TENDAYDU}, UserName:{_dt.USERNAME}, Password: {_dt.PASSWORD}";
                string newValue = $"ID:{dt.IDUSER}, Name: {dt.TENDAYDU}, UserName:{dt.USERNAME}, Password: {dt.PASSWORD}";
                _dt.TENDAYDU = dt.TENDAYDU;
                _dt.USERNAME = dt.USERNAME;
                _dt.PASSWORD = dt.PASSWORD;
                _dt.IDNHOM = dt.IDNHOM;

                db.SaveChanges();
                Func.Log("UPDATE", "User", newValue, oldValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int iduser)
        {
            try
            {
                var dt = db.tb_USER.FirstOrDefault(x => x.IDUSER == iduser);
                dt.IDNHOM = null;
                dt.DELETED = true;
                db.SaveChanges();
                Func.Log("DELETE", "User", $"ID:{dt.IDUSER}, UserName:{dt.USERNAME}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
