using Attempt1.App_Domain;
using LabControl.App_Domain;
using LabControl.Data;
using login.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LabControl
{
    public partial class CRUDShift : System.Web.UI.Page
    {
        DataShift dataShift = new DataShift();
        DataSchedule dataSchedule = new DataSchedule();
        DataLab dataLab = new DataLab();
        DataDate dataDate = new DataDate();
        Shift shift = new Shift();
        Schedule schedule = new Schedule();
        Lab lab = new Lab();
        Date day = new Date();
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList ddl1 = dataLab.readLabName();
            DropDownList1.DataSource = ddl1.DataSource;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "name";
            DropDownList1.DataBind();

            DropDownList ddl2 = dataDate.readDateName();
            DropDownList2.DataSource = ddl2.DataSource;
            DropDownList2.DataTextField = "date";
            DropDownList2.DataValueField = "date";
            DropDownList2.DataBind();
        }


        protected void gvResults_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {

                int index = Convert.ToInt32(e.CommandArgument);



                int i = (int)GridView1.DataKeys[index].Value;
                shift = dataShift.readShiftEDITBusy(i);
                Session["shiftSession"] = shift;
                schedule = dataSchedule.readScheduleEDIT(shift.Id, DropDownList1.SelectedValue, DropDownList2.SelectedValue);
                Session["scheduleSession"] = schedule;
                dataShift.updateShift(dataShift.readLabEDIT(DropDownList1.SelectedValue), schedule.Busy, shift.Id, dataDate.readDateEDIT(DropDownList2.SelectedValue));
                Response.Redirect("/CRUDShift.aspx");

            }
        }

        protected void btnSelectLab_Click(object sender, EventArgs e)
        {
            DataTable dt = dataShift.readShiftEDIT(DropDownList1.SelectedValue, DropDownList2.SelectedValue);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        public void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DataTable dt = dataShift.readShiftEDIT(DropDownList1.SelectedValue, DropDownList2.SelectedValue);

            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
