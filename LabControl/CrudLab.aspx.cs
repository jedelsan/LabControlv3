using Attempt1.App_Domain;
using login.Account.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabControl
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DataLab dataLab = new DataLab();
        Lab lab = new Lab();
        User user = new User();

        private GridView dgvLab = new GridView();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            if ((User)Session["User"] == null || user.Role != 1)
            {
                Response.Redirect("/Welcome.aspx");
            }


            //Populating a DataTable from database
            DataTable dt = dataLab.tableLab();

            GridView1.DataSource = dt;
            GridView1.DataBind();
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            
            lblErrorNombre.Visible = false;
            lblErrorDescripción.Visible = false;



            
            //Revisa si los textboxes estan vacidos
            if (txtName.Text.Equals("") || txtDescription.Text.Equals(""))
            {
                if (txtName.Text.Equals(""))
                    lblErrorNombre.Visible = true;

                if (txtDescription.Text.Equals(""))
                    lblErrorDescripción.Visible = true;

            }

            else
            {
                int code;
                int codeLab;
                code=dataLab.selectCode();
                codeLab=code + 1;

                dataLab.createLab(txtName.Text, txtDescription.Text,codeLab);


                    lblNombre.Visible = false;
                    lblDescription.Visible = false;
                

                    txtName.Visible = false;
                    txtDescription.Visible = false;

                    btnCancelar.Visible = false;
                    btnGuardarNewLab.Visible = false;
            

                    txtName.Text = "";
                    txtDescription.Text = "";

                }
            Response.Redirect("/CrudLab.aspx");
        }

  

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
           

            txtName.Text = "";
            txtDescription.Text = "";
  



       

            lblErrorNombre.Visible = false;
            lblErrorDescripción.Visible = false;

        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)GridView1.DataKeys[e.RowIndex].Value;
            dataLab.deleteLab(id);
            Response.Redirect("CrudLab.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gvResults_RowCommand(object sender, GridViewCommandEventArgs e){
            if (e.CommandName == "Edit")
            {
                // Retrieve the row index stored in the 
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);



                int i = (int)GridView1.DataKeys[index].Value;           
                 lab = dataLab.getLabEdit(i);
                 Session["labEdit"] = lab;
                Response.Redirect("/UpdateLab.aspx");

            }
        }
        protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DataTable dt = dataLab.tableLab();

            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
 }
