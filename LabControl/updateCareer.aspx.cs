using LabControl.App_Domain;
using LabControl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataCareer dataUser = new DataCareer();
        int i;

        protected void Page_Load(object sender, EventArgs e)
        {
            Career career = (Career)Session["CareerEdit"];
            if (!IsPostBack)
            {
                txtName.Value = career.Name;
                txtDesciption.Value = career.Description;
                txtCode.Value = career.Code;

            }

        }


        protected void Selection_Change(object sender, EventArgs e)
        {

        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/AdminCareer.aspx");
        }

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
            if (txtName.Value.Equals("") || txtDesciption.Value.Equals("") || txtCode.Value.Equals(""))
            {
                if (txtName.Value.Equals(""))
                    lblErrorNombre.Visible = true;

                if (txtDesciption.Value.Equals(""))
                    lblErrorDescription.Visible = true;

                if (txtCode.Value.Equals(""))
                {
                    lblErrorCode.Text = "*Code no puede estar vacido";
                    lblErrorCode.Visible = true;
                }

            }
                else
                {
                    Career career = (Career)Session["CareerEdit"];

                    dataUser.updateCareer(career.Id, txtName.Value, txtDesciption.Value, txtCode.Value);
                    Response.Redirect("/AdminCareer.aspx");

                }
            }

        }
    }
