using login.Account.App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login
{
    public class Proxy
    {
        //hola
        public Boolean proxyAdmin(User user)
        {
            try
            {
                if (user.Role == 1)
                {

                    return true;
                }
                else
                    return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        public Boolean proxyLogistica(User user)
        {
            try
            {
                if (user.Role == 2)
                {

                    return true;
                }
                else
                    return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }

        }

        public Boolean proxyUsuario(User user) { 
          try
            {
                if (user.Role == 1 || user.Role == 2 || user.Role == 3)
                {

                    return true;
                }
                else
                    return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }

        }
        
        }
    }