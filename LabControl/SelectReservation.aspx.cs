using Attempt1.App_Domain;
using LabControl.Data;
using login.Account.App_Domain;
using login.App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace LabControl
{
    public partial class SelectReservation : System.Web.UI.Page
    {
        DataReservation dataReservation = new DataReservation();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            if ((User)Session["User"] == null)
            {
                Response.Redirect("/index.aspx");
            }

            createTable();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
        }
        public void createTable()
        {
            Reservation reservation = (Reservation)Session["reservationBusy"];
            List<WorkStation> busy = new List<WorkStation>(reservation.WsBusy);
            int cont = 1;
            int z = 0;
            for (int i = 0; i < 6; i++)
            {
                TableRow tr = new TableRow();
                myTable.Rows.Add(tr);
                for (int j = 0; j < 5; j++)
                {
                    TableCell tc = new TableCell();
                    tc.ID = "" + cont;
                    ImageButton btn = new ImageButton();
                    if (z < busy.Count)
                    {
                        if (busy[z].Busy == true)
                        {
                            btn.ImageUrl = "img/StationBusy.png";
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.ImageUrl = "Images/indice.png";
                        }
                    }
                    btn.Click += new ImageClickEventHandler(btn_Click);
                    tc.Controls.Add(btn);
                    tr.Cells.Add(tc);
                    cont++;
                    z++;
                }
            }
        }
        void btn_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = sender as ImageButton;
            List<int> selection = new List<int>();
            if (btn.ImageUrl == "Images/verde.png")
            {
                TableCell cell = btn.Parent as TableCell;
                TableRow row = cell.Parent as TableRow;
                int indexRow = myTable.Rows.GetRowIndex(row);
                int indexCell = myTable.Rows[indexRow].Cells.GetCellIndex(cell);
                string ID = myTable.Rows[indexRow].Cells[indexCell].ID;
                ListBox2.AutoPostBack = false;
                ListBox2.Items.Remove(ID);
                btn.ImageUrl = "Images/indice.png";
            }
            else
            {
                TableCell cell = btn.Parent as TableCell;
                TableRow row = cell.Parent as TableRow;
                int indexRow = myTable.Rows.GetRowIndex(row);
                int indexCell = myTable.Rows[indexRow].Cells.GetCellIndex(cell);
                string ID = myTable.Rows[indexRow].Cells[indexCell].ID;
                ListBox2.AutoPostBack = false;
                ListBox2.Items.Add(ID);
                btn.ImageUrl = "Images/verde.png";
                Label1.Text = ID + ",";
            }
        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            Reservation reservation = (Reservation)Session["Reservation"];
            List<int> listWS = new List<int>();
            foreach (ListItem listItem in ListBox2.Items)
            {
                listWS.Add(Convert.ToInt32(listItem.Value));
            }
            this.insertReservation(reservation.User, reservation.Lab, reservation.Day, reservation.StartTime, reservation.Date, reservation.StartTime, reservation.Detalle, listWS);
            Response.Redirect("Welcome.aspx");
        }
        public void insertReservation(int idUser, int idLab, string day, string shift, string date, string startTime, string description, List<int> listWS)
        {
            int idAvailability = dataReservation.insertAvailability(startTime, day);
            int idDetalle = dataReservation.insertDetailRequest(date, shift, description);
            int request = dataReservation.insertRequest(idUser, idLab, idDetalle);
            foreach (int i in listWS)
            {
                int ws = i;
                int code = dataReservation.selectCodeLab(idLab);
                int idWorkStation = code - 1;
                idWorkStation = idWorkStation * 30;
                idWorkStation = idWorkStation + ws;
                dataReservation.insertWSAvailability(idWorkStation, idAvailability);
                dataReservation.insertrequestWS(idWorkStation, request);
            }
        }
    }
}