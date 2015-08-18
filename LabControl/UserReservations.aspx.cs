using LabControl.Data;
using login.Account.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabControl
{
    public partial class UserReservations : System.Web.UI.Page
    {
        DataUserReservation dataUR = new DataUserReservation();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int i = user.Id;
            DataTable dt = dataUR.tableUserReservation(i);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            if (GridView1.Rows.Count ==0)
            {
                Label1.Visible = true;
            }
 

        }
        protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            User user = (User)Session["User"];
            DataTable dt = dataUR.tableUserReservation(user.Id);

            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}