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
    public partial class signIn : System.Web.UI.Page
    {
         DataUser dataUser = new DataUser();
        int i;

        protected void Page_Load(object sender, EventArgs e)
        {
           User user = (User)Session["UserEdit"];
           if (!IsPostBack)
           {
               txtName.Value = user.Name;
               txtEmail.Value = user.Email;
               txtStudentId.Value = "" + user.License;


               RolList.SelectedValue = "" + user.Role;
           }

        }


        protected void Selection_Change(object sender, EventArgs e)
        {

        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin.aspx");
        }

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
            if (txtName.Value.Equals("") || txtEmail.Value.Equals("") || txtStudentId.Value.Equals(""))
            {
                if (txtName.Value.Equals(""))
                    lblErrorNombre.Visible = true;

                if (txtEmail.Value.Equals(""))
                    lblErrorCorreo.Visible = true;

                if (txtStudentId.Value.Equals(""))
                {
                    lblErrorCarnet.Text = "*Carnet no puede estar vacido";
                    lblErrorCarnet.Visible = true;
                }

            }

            else
            {
                //revisa si carnet o rol son numericos
                if (!int.TryParse(txtStudentId.Value, out i))
                {
                    if (!int.TryParse(txtStudentId.Value, out i))
                    {
                        lblErrorCarnet.Text = "*Carnet ocupa ser un numero";
                        lblErrorCarnet.Visible = true;
                    }
                }


                else
                {
                    User user = (User)Session["UserEdit"];

                    dataUser.updateUser(user.Id, txtName.Value, txtEmail.Value, Int32.Parse(txtStudentId.Value), user.Password, Int32.Parse(RolList.SelectedValue));
                    Response.Redirect("/Admin.aspx");

                }
            }

        }

      
    }
    }
