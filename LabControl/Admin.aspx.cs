using login.Account.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabControl
{
    public partial class WebForm2 : System.Web.UI.Page{

         DataUser dataUser = new DataUser();
        User user = new User();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            if ((User)Session["User"] == null || user.Role != 1)
            {
                Response.Redirect("/Welcome.aspx");
            }


                //Populating a DataTable from database
                DataTable dt = dataUser.tableUser();

                GridView1.DataSource = dt;
                GridView1.DataBind();
            
        }
    

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string password = this.generatePassword();
            int i;
            lblErrorNombre.Visible = false;
            lblErrorCorreo.Visible = false;
            lblErrorCarnet.Visible = false;
            btnGuardarNewUser.Enabled = false;


            //Revisa si los textboxes estan vacidos
            if (txtName.Text.Equals("") || txtEmail.Text.Equals("") || txtStudentId.Text.Equals(""))
            {
                if (txtName.Text.Equals(""))
                    lblErrorNombre.Visible = true;

                if (txtEmail.Text.Equals(""))
                    lblErrorCorreo.Visible = true;

                if (txtStudentId.Text.Equals(""))
                {
                    lblErrorCarnet.Text = "*Carnet no puede estar vacido";
                    lblErrorCarnet.Visible = true;
                }

            }

            else
            {
                //revisa si carnet o rol son numericos
                if (!int.TryParse(txtStudentId.Text, out i))
                {
                    if (!int.TryParse(txtStudentId.Text, out i))
                    {
                        lblErrorCarnet.Text = "*Carnet ocupa ser un numero";
                        lblErrorCarnet.Visible = true;
                    }
                }

                else
                {

                    dataUser.insertUser(txtName.Text, txtEmail.Text, int.Parse(txtStudentId.Text), password, int.Parse(RolList.SelectedValue));

                    lblNombre.Visible = false;
                    lblEmail.Visible = false;
                    lblStudentId.Visible = false;
                    lblRole.Visible = false;

                    txtName.Visible = false;
                    txtEmail.Visible = false;
                    txtStudentId.Visible = false;
                    RolList.Visible = false;

                    btnCancelar.Visible = false;
                    btnGuardarNewUser.Visible = false;
                   
                    
                    this.sendPassword(password);  

                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtStudentId.Text = "";

                   

                }
            }
            Response.Redirect("Admin.aspx");

            
        }

       

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
     

            txtName.Text = "";
            txtEmail.Text= "";
            txtStudentId.Text = "";




            lblErrorNombre.Visible = false;
            lblErrorCorreo.Visible = false;
            lblErrorCarnet.Visible = false;
            RolList.Visible = false;


        }

        protected void Selection_Change(object sender, EventArgs e)
        {

        }

        public string generatePassword()
        {
            Random random = new Random();
            int i = 0;
            char a = '\0';
            String password = "";

            i = random.Next(97, 122);
            a = (char)i;
            password += a;

            i = random.Next(1, 10);
            password += i;

            i = random.Next(97, 122);
            a = (char)i;

            password += a;
            i = random.Next(1, 10);
            password += i;

            i = random.Next(97, 122);
            a = (char)i;

            password += a;
            i = random.Next(1, 10);
            password += i;

            return password;
        }

        public void sendPassword(string password)
        {
            var fromAddress = new MailAddress("LabControl2015@gmail.com");
            var toAddress = new MailAddress("" + txtEmail.Text);
            const string fromPassword = "ManuelAntonio";
            const string subject = "Bienvenido a LabControl";
            string body = "Te damos la bienvenida a LabControl!" + Environment.NewLine + "Nombre:" + txtName.Text + "  Carnet:" + txtStudentId.Text + Environment.NewLine + "Tu contraseña es: " + password + Environment.NewLine + "Por favor cambiarla lo mas pronto possible";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)GridView1.DataKeys[e.RowIndex].Value;
            dataUser.deleteUser(id);
            Response.Redirect("Admin.aspx");
            
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

               

                Session["UserEdit"] = dataUser.getUserEdit(i);
                Response.Redirect("/updateUser.aspx");

            }
        }

        protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DataTable dt = dataUser.tableUser();

            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }
}