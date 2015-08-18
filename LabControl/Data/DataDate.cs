using Attempt1.App_Domain;
using LabControl.App_Domain;
using login.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
namespace LabControl.Data
{
    public class DataDate : BaseData
    {
        public int readDateEDIT(string date)
        {
            Date date1 = new Date();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readDateEDIT", con);
            cmd.Parameters.AddWithValue("@nameDay", date);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                date1.Id = reader.GetInt32(reader.GetOrdinal("id"));
            }
            cmd.Dispose();
            DatabaseConnection("close");
            return date1.Id;
        }
        public Date readDate(int id, int idLab, string startTime, string endTime, string date)
        {
            Date date1 = new Date();
            Lab lab = new Lab();
            Shift shift = new Shift();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readDate", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@idLab", idLab);
            cmd.Parameters.AddWithValue("@start time", startTime);
            cmd.Parameters.AddWithValue("@end time", endTime);
            cmd.Parameters.AddWithValue("@date", startTime);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                date1.Id = reader.GetInt32(reader.GetOrdinal("id"));
            }
            cmd.Dispose();
            DatabaseConnection("close");
            return date1;
        }
        public DropDownList readDateName()
        {
            DropDownList ddl = new DropDownList();
            DataTable dt = new DataTable();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readNameDay", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ddl.DataTextField = "date";
            ddl.DataValueField = "date";
            ddl.DataSource = dt;
            ddl.DataBind();
            cmd.Dispose();
            DatabaseConnection("close");
            return ddl;
        }
    }
}