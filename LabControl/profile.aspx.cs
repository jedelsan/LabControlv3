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
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((User)Session["User"] == null)
            {
                Response.Redirect("/Default.aspx");
            }
            else
            {
                User user = (User)Session["User"];
                LblNombreUsuario.Text = user.Name;
                LblCarnetUsuario.Text = user.License.ToString();

                if (user.Role == 1)
                    LblRolUsuario.Text = "Admin";
                if (user.Role == 2)
                    LblRolUsuario.Text = "Logistica";
                if (user.Role == 3)
                    LblRolUsuario.Text = "Estudiante";
                if (user.Role == 4)
                    LblRolUsuario.Text = "Profesor";
            }


        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            lblConNueva.Visible = true;
            txtConNueva.Visible = true;
            lblConVieja.Visible = true;
            txtConVieja.Visible = true;
            btnGuardarCon.Visible = true;
            btnCambiarContraseña.Enabled = false;
            btnCancelar.Visible = true;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataUser dataUser = new DataUser();
            User user = (User)Session["User"];

            lblErrorCon.Visible = false;
            lblErrorCamposVacios.Visible = false;

            if (txtConNueva.Text.Equals("") || txtConVieja.Text.Equals(""))
            {
                lblErrorCamposVacios.Visible = true;
            }
            else
            {
                if (txtConVieja.Text.Equals(user.Password))
                {
                    user.Password = txtConNueva.Text;
                    dataUser.updatePassword(user);

                    lblErrorCon.Visible = false;
                    lblErrorCamposVacios.Visible = false;
                    lblConNueva.Visible = false;
                    txtConNueva.Visible = false;
                    lblConVieja.Visible = false;
                    txtConVieja.Visible = false;
                    btnGuardarCon.Visible = false;
                    btnCambiarContraseña.Enabled = true;
                    btnCancelar.Visible = false;

                }
                else
                    lblErrorCon.Visible = true;
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblConNueva.Visible = false;
            txtConNueva.Visible = false;
            lblConVieja.Visible = false;
            txtConVieja.Visible = false;
            btnGuardarCon.Visible = false;
            btnCambiarContraseña.Enabled = true;
            btnCancelar.Visible = false;

            lblErrorCamposVacios.Visible = false;
            lblErrorCon.Visible = false;
        }



    }
}
