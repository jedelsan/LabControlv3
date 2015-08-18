using login.Account.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.App_Business
{
    public class UserBusiness
    {
       DataUser userData;

        public UserBusiness(DataUser userData) {
            this.userData = userData;
        }

        public User getUserData(string nombre, string clave) {
             User user =userData.getUserData(nombre, clave);
             return user;
        }
    }
}