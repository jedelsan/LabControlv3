using Attempt1.App_Domain;
using LabControl.Data;
using login.Account.App_Domain;
using login.App_Domain;
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
    public partial class reservation : System.Web.UI.Page
    {

        DataReservation dataReservation = new DataReservation();
        Reservation reservation1 = new Reservation();
        DataWorkStation dataWS = new DataWorkStation();
        DataLab dataLab = new DataLab();


        int idLab;
        string date;
        string lab;

        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            if ((User)Session["User"] == null)
            {
                Response.Redirect("/index.aspx");
            }

            DataLab dataLab = new DataLab();


            DropDownList ddl = dataLab.readLabName();
            ddlLab.DataSource = ddl.DataSource;
            ddlLab.DataTextField = "name";
            ddlLab.DataValueField = "name";
            ddlLab.DataBind();


        }


        protected void btnsumit_Click(object sender, EventArgs e)
        {
            if (txtaDescripcion.Text.Equals(""))
            {
                lblErrorDescription.Visible = true;
            }
            else
            {

                User user = (User)Session["User"];
                Reservation reservation = new Reservation();
                List<WorkStation> i = new List<WorkStation>();
                idLab = dataLab.changeNameToId(ddlLab.SelectedValue);

                reservation.Date = txbfecha.Value;
                reservation.Day = this.dateToDay(txbfecha.Value);
                reservation.Lab = dataReservation.getLabId(ddlLab.SelectedItem.Text);
                reservation.User = user.Id;
                reservation.StartTime = ddlTurnos.SelectedItem.Text;
                reservation.Detalle = txtaDescripcion.Text;

                i = selectBusy(idLab, reservation.StartTime, reservation.Day);

                Reservation reservation2 = new Reservation(i);
                Session["reservationBusy"] = reservation2;

                Session["Reservation"] = reservation;
                Response.Redirect("SelectReservation.aspx");



            }
        }



        public string dateToDay(string date)
        {

            DateTime myDate = DateTime.Parse(date);
            date = "" + myDate.DayOfWeek;
            return date;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txbfecha.Value.Equals("") || ddlLab.SelectedValue.Equals(""))
            {
                if (txbfecha.Value.Equals(""))
                {
                    LabelError.Visible = true;
                }
                else if (ddlLab.SelectedValue.Equals(""))
                {
                    lblErrorDate.Visible = true;
                }
            }
            else
            {
                date = this.dateToDay(txbfecha.Value);
                lab = Convert.ToString(ddlLab.SelectedValue);


                List<string> listShifts = dataReservation.getShifts(date, lab);

                foreach (string shift in listShifts)
                {
                    ddlTurnos.Items.Add(new ListItem(shift));
                }
                lbl.Visible = true;
                lblTurno.Visible = true;
                ddlTurnos.Visible = true;
                txtaDescripcion.Visible = true;
                LabelError.Visible = false;
            }
        }


        public List<WorkStation> selectBusy(int idlab, string startTime, string date)
        {

            int pos = 1;
            List<WorkStation> ws = new List<WorkStation>();
            WorkStation wsD = new WorkStation();
            idLab = dataLab.changeNameToId(ddlLab.SelectedValue);
            int contCode = dataReservation.SelectLabCode(idLab);
            int cont = 30 * (contCode - 1) + 1;
            for (int i = cont; i < 30 * contCode; i++)
            {

                ws.Add(dataWS.readWorkStationBusy(i, startTime, date));

                pos++;
            }
            ws.Add(wsD);
            return ws;
        }



    }
}