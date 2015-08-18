using login;
using login.Account.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabControl
{
    public partial class index : System.Web.UI.Page
    {
        DataUser userData = new DataUser();
        Proxy proxy = new Proxy();
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User"] != null)
            {
                Response.Redirect("/Welcome.aspx");
            }


        }


        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            user = userData.getUserData(UserName.Text, Password.Text);


            lblErrorUsuario.Visible = false;
            lblErrorContraseña.Visible = false;


            if (UserName.Text.Equals("") || Password.Text.Equals(""))
            {
                if (UserName.Text.Equals(""))
                    lblErrorUsuario.Visible = true;

                if (Password.Text.Equals(""))
                {
                    lblErrorContraseña.Text = "Contraseña no puede estar vacia";
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
                    Session["User"] = user;
                    Response.Redirect("/Welcome.aspx");

                }
            }
        }

    }
}
