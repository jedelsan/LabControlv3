using LabControl.App_Domain;
using LabControl.Data;
using login.Account.App_Domain;
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
    public partial class WebForm4 : System.Web.UI.Page
    {
       
        DataCareer dataCareer = new DataCareer();
        Career career = new Career();
        private GridView dataGridView1 = new GridView();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            if ((User)Session["User"] == null || user.Role != 1)
            {
                Response.Redirect("/Welcome.aspx");
            }

            //Populating a DataTable from database
            DataTable dt = dataCareer.tableCareer();

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            lblErrorNombre.Visible = false;
            lblErrorDescription.Visible = false;
            lblErrorCode.Visible = false;
            

            //Revisa si los textboxes estan vacidos
            if (txtName.Text.Equals("") || txtDescription.Text.Equals("") || txtCode.Text.Equals(""))
            {
                if (txtName.Text.Equals(""))
                    lblErrorNombre.Visible = true;

                if (txtDescription.Text.Equals(""))
                    lblErrorDescription.Visible = true;

                if (txtCode.Text.Equals(""))
                {
                    lblErrorCode.Text = "*Carnet no puede estar vacido";
                    lblErrorCode.Visible = true;
                }

            }
                else
                {

                    dataCareer.insertCareer(txtName.Text, txtDescription.Text, txtCode.Text);

                    lblNombre.Visible = false;
                    lblDescription.Visible = false;
                    lblCode.Visible = false;
                    

                    txtName.Visible = false;
                    txtDescription.Visible = false;
                    txtCode.Visible = false;
                 

                    btnCancelar.Visible = false;
                    btnGuardarNewCareer.Visible = false;
                   

                    txtName.Text = "";
                    txtDescription.Text = "";
                    txtCode.Text = "";

                    // this.sendPassword(password);  

                }
            

            Response.Redirect("/AdminCareer.aspx");
        }

        protected void hlbtnCreateCareer_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = true;
            lblDescription.Visible = true;
            lblCode.Visible = true;
          

            txtName.Visible = true;
            txtDescription.Visible = true;
            txtCode.Visible = true;
          


            btnGuardarNewCareer.Visible = true;
          
            btnCancelar.Visible = true;



        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
    
         

            txtName.Text = "";
            txtDescription.Text = "";
            txtCode.Text = "";



          
          
            

            lblErrorNombre.Visible = false;
            lblErrorDescription.Visible = false;
            lblErrorCode.Visible = false;



        }

        protected void Selection_Change(object sender, EventArgs e)
        {

        }
   

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)GridView1.DataKeys[e.RowIndex].Value;
            dataCareer.deleteCareer(id);
            Response.Redirect("/AdminCareer.aspx");
        }



        protected void gvResults_RowCommand(object sender,
  GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                // Retrieve the row index stored in the 
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);



                int i = (int)GridView1.DataKeys[index].Value;           
                 career = dataCareer.getCareerEdit(i);
                 Session["careerEdit"] = career;
                Response.Redirect("/updateCareer.aspx");

            }
        }
        protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DataTable dt = dataCareer.tableCareer();

            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}