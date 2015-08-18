using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using login.Account.App_Domain;
using login.Data;

namespace login.Account
{  
    public partial class Login : Page
    {

        DataUser userData = new DataUser();
        Proxy proxy = new Proxy();
        User user = new User();


        protected void LogIn(object sender, EventArgs e)
        {

            user = userData.getUserData(UserName.Text, Password.Text);
            Session["User"] = user;

            lblErrorUsuario.Visible = false;
            lblErrorContraseña.Visible = false;
            

            if (UserName.Text.Equals("") || Password.Text.Equals(""))
            {
                if (UserName.Text.Equals(""))
                lblErrorUsuario.Visible = true;
                if (Password.Text.Equals(""))
                {
                    lblErrorContraseña.Text = "Contraseña no puede estar vacido";
                    lblErrorContraseña.Visible = true;
                }
            }
            else
            {
                if (user.Role == 0 && user.Name == null && user.Password == null)
                {
                    lblErrorContraseña.Text = "Usuario o Contraseña estan incorrectos";
                    lblErrorContraseña.Visible = true;
                }
                else
                {
                    Response.Redirect("/Default.aspx");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
    }
