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
    public partial class EditWorkStation : System.Web.UI.Page
    {
        DataWorkStation dataWorkStation = new DataWorkStation();
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            WorkStation workStation = (WorkStation)Session["workStationSession"];
            DataLab dataLab = new DataLab();
            int idLab = workStation.IdLab;
            if (!IsPostBack)
            {
                lblIDEDIT.Text = Convert.ToString(workStation.Id);
                txtDescripcionEDIT.Text = workStation.Description;
                DropDownList1.SelectedValue = dataLab.changeIdToName(idLab);
                chbxRESERVADOEDIT.Checked = workStation.Busy;
                
            }
            DropDownList ddl = dataLab.readLabName();
            DropDownList1.DataSource = ddl.DataSource;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "name";
            DropDownList1.DataBind();
        }

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
            WorkStation workStation = (WorkStation)Session["workStationSession"];
            if (txtDescripcionEDIT.Text.Equals(""))
            {
                lblErrorDescriptionEDIT.Visible = true;
            }
            else
            {
                dataWorkStation.updateWorkStation(Convert.ToInt32(lblIDEDIT.Text), txtDescripcionEDIT.Text,  Convert.ToInt32(DropDownList1.SelectedValue));
                Response.Redirect("/CRUDWorkStation.aspx");
            }
                
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/CRUDWorkStation.aspx");
        }
    }
      
}