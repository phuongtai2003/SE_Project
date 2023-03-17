using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class UserDAL
    {
        private static UserDAL instance;
        
        public static UserDAL Instance { 
            get {
                if(instance == null)
                    instance = new UserDAL();
                return instance; 
            } 
        }
        private UserDAL() { }
        public User GetUser(string username, string password)
        {
            string cmd = String.Format("Select * from Customer WHERE userName = '{0}' AND userPassword = '{1}' ", username, password);
            DataTable data = DatabaseProvider.Instance.ExecuteQueryCmd(cmd);
            if(data.Rows.Count == 1)
            {
                foreach(DataRow row in data.Rows)
                {
                    string personalId = row[1].ToString();
                    string userName = row[2].ToString();
                    string userPassword = row[3].ToString();
                    return new User(userName, personalId, userPassword);
                }
            }
            return null;
        }
        public bool CreateUser(string username, string password, string personalId) {
            string cmd = String.Format("SELECT * FROM Customer WHERE userName = '{0}' OR personalId = '{1}'", username, personalId);
            DataTable data = DatabaseProvider.Instance.ExecuteQueryCmd(cmd);
            if(data.Rows.Count >= 1) {
                return false;
            }
            string insertCmd = String.Format("INSERT INTO Customer (personalId,userName, userPassword) VALUES ('{0}', '{1}', '{2}')", personalId, username, password);
            DatabaseProvider.Instance.ExecuteNonQueryCmd(insertCmd);
            return true;
        }

        public String GetUserId(User user)
        {
            string personalId = user.PersonalId;
            string userName = user.UserName;
            string userPass = user.UserPassword;
            string sql = string.Format("SELECT userId FROM Customer WHERE personalId = '{0}' and userName = '{1}' and userPassword = '{2}'", personalId, userName, userPass);
            DataTable data = DatabaseProvider.Instance.ExecuteQueryCmd(sql);
            if(data.Rows.Count == 1)
            {
                string id = "";
                foreach(DataRow row in data.Rows)
                {
                    id = row[0].ToString();
                }
                return id;
            }
            else
            {
                return null;
            }
        }
    }
}
