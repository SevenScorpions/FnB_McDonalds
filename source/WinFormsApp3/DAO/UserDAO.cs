using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using LogInDemo.DTO;
using System.Security.Cryptography;

namespace LogInDemo.DAO
{
    public class UserDAO:DAO<User>
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDAO();
                return instance;
            }
            private set => instance = value;
        }
        public bool signUp(string userName,string passWord,string name, string id, DateTime birthday, string email, string phone,string gender)
        {
            MessageBox.Show("Sign up successfully.");
            var line = string.Format(@"insert into CUSTOMER values('{0}','{1}',N'{2}','{3}','{4}','{5}','{6}','{7}','{8}')", userName.ToString(), passWord.ToString(), name.ToString(), id.ToString(), birthday, email, phone, gender, 0);
            DataProvider.Instance.ExcuteQuery(line);
            return true;
        }
        public bool forgotPassword(string username,string email)
        {
            List<User> users = GetAll();
            foreach(User user in users)
            {
                if (user.Username == username && user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
        public User GetAccount(string username,string password)
        {
            User account = null;
            List<User> users = GetAll();
            foreach(User user in users)
            {
                if(user.Username.Equals(username) && user.Password.Equals(password))
                {
                    account = user;
                    break;
                }
            }
            return account;
        }

        public override void Insert(User t)
        {
            string query = string.Format(@"insert into CUSTOMER values('{0}','{1}',N'{2}','{3}','{4}','{5}','{6}','{7}','{8}')", t.Username, t.Password, t.Name, t.Nid, t.Birthdate, t.Email, t.Phone, t.Gender, 0);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Delete(User t)
        {
            string query = string.Format(@"delete from CUSTOMER where username = '{0}'", t.Username);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Update(User t)
        {
            string query = string.Format(@"UPDATE CUSTOMER SET BIRTHDAY = '{0}', GENDER = '{1}', EMAIL = '{2}', PHONE = '{3}', NID = '{4}', NAME = N'{5}',POINT = {6}, PASSWORD = '{7}' where username = '{8}'", t.Birthdate.Date, t.Gender, t.Email, t.Phone, t.Nid, t.Name,t.Point,t.Password,t.Username);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override List<User> GetAll()
        {
            List<User> list = new List<User>();
            string query = @"Select * from CUSTOMER";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new User(row));
            }
            return list;
        }
    }
}
