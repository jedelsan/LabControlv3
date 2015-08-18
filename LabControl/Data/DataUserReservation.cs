using login.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace LabControl.Data
{
    public class DataUserReservation : BaseData
    {
      public DataTable tableUserReservation(int idUser)
        {

            DataTable dt = new DataTable();



            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {


                sqlCommand = new SqlCommand("SelectUserReservation", con);
                sqlCommand.Parameters.AddWithValue("@idUser", idUser);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dt);

                sqlCommand.Dispose();
            }

            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());

            }
            finally {
                DatabaseConnection("close");

            }

            return dt;
        }
    
        public DataTable tableUserReservationAdmin()
        {
            DataTable dt = new DataTable();
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand("SelectUserReservationAdmin", con);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            sqlCommand.Dispose();
            DatabaseConnection("close");
            return dt;
        }
    }
}