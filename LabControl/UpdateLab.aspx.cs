using Attempt1.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabControl
{
    public partial class UpdateLab : System.Web.UI.Page
    {
   DataLab dataUser = new DataLab();
        int i;

        protected void Page_Load(object sender, EventArgs e)
        {
            Lab Lab = (Lab)Session["LabEdit"];
            if (!IsPostBack)
            {
               
                txtName.Value = Lab.Name;
                txtDesciption.Value = Lab.Description;
                
            }

        }


        protected void Selection_Change(object sender, EventArgs e)
        {

        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/CrudLab.aspx");
        }

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
            if (txtName.Value.Equals("") || txtDesciption.Value.Equals(""))
            {
                if (txtName.Value.Equals(""))
                    lblErrorNombre.Visible = true;

                if (txtDesciption.Value.Equals(""))
                    lblErrorDescription.Visible = true;


            }
                else
                {
                    Lab lab = (Lab)Session["LabEdit"];

                    dataUser.updateLab(lab.Id, txtName.Value, txtDesciption.Value);
                    Response.Redirect("/CrudLab.aspx");

                }
            }

        }
    }

