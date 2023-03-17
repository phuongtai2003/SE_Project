using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        private String _personalId;
        private String _userName;
        private String _userPassword;
        
        public String UserName { get { return _userName; }  }
        public String UserPassword { get { return _userPassword;}  }
        public String PersonalId { get { return _personalId; }  }

        public User(String userName, String personalId, String password)
        {
            _userName = userName;
            _personalId = personalId;
            _userPassword = password;
        }


    }
}
