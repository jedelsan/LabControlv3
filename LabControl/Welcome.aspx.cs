using login.Account.App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabControl
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           User user = (User)Session["User"];

            if ((User)Session["User"] == null )
            {
                Response.Redirect("/index.aspx");
            }

            if (user.Role != 1)
            {
                admin.Visible = false;
                a1.Visible = false;
                lab.Visible = false;
                workstations.Visible = false;
            }
            else if(user.Role !=2 && user.Role !=1) 
            {
                
               cuatro.Visible = true;
            }
        }
    }
}