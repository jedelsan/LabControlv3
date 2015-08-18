using login.Account.App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attempt1.App_Domain
{
    public class Register
    {
        private User user;

        public Register()
        {
            user = new User();
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }

    }
}