using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class UserBLL
    {
        private User currentUser;

        public User CurrentUser { get { return currentUser; } }

        private static UserBLL instance;

        public static UserBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserBLL();
                return instance;
            }
        }
        private UserBLL() { }
        public bool CheckLogin(string username, string password)
        {
            User user = UserDAL.Instance.GetUser(username, password);
            if (user != null)
            {   
                currentUser= user;
                return true;
            }
            return false;
        }

        public bool CreateAccount(string username, string password, string personalId)
        {
            bool isCreated = UserDAL.Instance.CreateUser(username, password, personalId);
            return isCreated;
        }

        public string GetCurrentUserId()
        {
            return UserDAL.Instance.GetUserId(currentUser);
        }
    }
}
