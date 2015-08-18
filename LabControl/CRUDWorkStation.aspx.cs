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
    public partial class CRUDWorkStation : System.Web.UI.Page
    {
        DataWorkStation dataWorkStation = new DataWorkStation();
        DataLab dataLab = new DataLab();
        WorkStation workStation = new WorkStation();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            if ((User)Session["User"] == null || user.Role != 1)
            {
                Response.Redirect("/Welcome.aspx");
            }

            DataTable dt = dataWorkStation.readWorkStation();
            GridView1.DataSource = dt;
            GridView1.DataBind();
            DropDownList ddl = dataLab.readLabName();
            ddlIdLab.DataSource = ddl.DataSource;
            ddlIdLab.DataTextField = "name";
            ddlIdLab.DataValueField = "name";
            ddlIdLab.DataBind();
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            int idLab;
            if (txtDescripcion.Text.Equals(""))
            {
                if (txtDescripcion.Text.Equals(""))
                    lblErrorDescription.Visible = true;
            }
            else
            {
                idLab = dataLab.changeNameToId(ddlIdLab.SelectedValue);
                dataWorkStation.createWorkStation(txtDescripcion.Text, idLab, 30);
              
            }
            Response.Redirect("/CRUDWorkStation.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)GridView1.DataKeys[e.RowIndex].Value;
            workStation = dataWorkStation.readWorkStationEDIT(id);
            dataWorkStation.deleteWorkStation(id, workStation.IdLab);
            Response.Redirect("/CRUDWorkStation.aspx");
        }
        protected void gvResults_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int i = (int)GridView1.DataKeys[index].Value;
                workStation = dataWorkStation.readWorkStationEDIT(i);
                Session["workStationSession"] = workStation;
                Response.Redirect("/EditWorkStation.aspx");
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void btnCancelWorkStation_Click(object sender, EventArgs e)
        {
            
            txtDescripcion.Text = "";
            
        }
        public void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DataTable dt = dataWorkStation.readWorkStation();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}