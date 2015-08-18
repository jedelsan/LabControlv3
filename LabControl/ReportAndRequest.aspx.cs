using login.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabControl
{
    public partial class WebForm50 : System.Web.UI.Page
    {
        DataLab dataLab = new DataLab();
        DataWorkStation dataWorkStation = new DataWorkStation();
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList ddl = dataLab.readLabName();
            ddlLab.DataSource = ddl.DataSource;
            ddlLab.DataTextField = "name";
            ddlLab.DataValueField = "name";
            ddlLab.DataBind();
            ddlLab.DataTextField = "id";
            ddlLab.DataValueField = "id";
            ddlLab.DataBind();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            this.sendReports();
            Response.Redirect("Welcome.aspx");

        }

        public void sendReports()
        {
            MailMessage msg = new MailMessage();
            /*var fromAddress = new MailAddress("LabContol2015@gmail.com");
            var toAddress = new MailAddress("ukanlos91@gmail.com");
            const string fromPassword = "ManuelAntonio";*/
            msg.To.Add(new MailAddress("chris50bn@gmail.com"));
            msg.From = new MailAddress("ukanlos91@gmail.com");
            msg.Subject = this.ddlSubject.SelectedValue; 
           // string subject = this.ddlSubject.SelectedValue;

            string lab = this.ddlLab.SelectedValue;
            string workStation = this.TextBox1.Text;
            string description = this.txtDescription.Value;

            msg.Body = "Laboratorio " + lab + Environment.NewLine + "Estacion de Trabajo " + workStation + Environment.NewLine + "Descripcion del asunto " + description + "";
            /*
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 465,
               // EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
               smtp.Send(message);
            }*/

            SmtpClient clienteSmtp = new SmtpClient();
            clienteSmtp.Host = "smtp.gmail.com";
            clienteSmtp.Port = 587;
            clienteSmtp.UseDefaultCredentials = false;
            clienteSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            clienteSmtp.Credentials = new System.Net.NetworkCredential("LabControl2015@gmail.com", "ManuelAntonio");
            clienteSmtp.EnableSsl = true;
            clienteSmtp.Send(msg);
        }
    }
}