using Attempt1.App_Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
namespace login.Data
{
    public class DataLab : BaseData
    {
        public DataTable tableLab()
        {
            DataTable dtLab = new DataTable();
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("readLabTable", con);
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dtLab);
                sqlCommand.Dispose();
              
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }
            finally
            {
                DatabaseConnection("close"); 
            }
            return dtLab;
        }
        public List<Lab> readLab()
        {
            List<Lab> LabList = new List<Lab>();
            Lab Lab = new Lab();
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("readLab", con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Lab.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    Lab.Name = reader.GetString(reader.GetOrdinal("name"));
                    Lab.Description = reader.GetString(reader.GetOrdinal("description"));
                    LabList.Add(Lab);
                }
                sqlCommand.Dispose();
               
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }
            finally
            {
                DatabaseConnection("close");
            }
            return LabList;
        }
        public void createLab(string name, string description, int code)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("insertLab", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
            cmd.Parameters.Add("@code", SqlDbType.Int).Value = code;
            cmd.ExecuteNonQuery();
            DatabaseConnection("close");
        }
        public void updateLab(int id, string name, string description)
        {
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("updateLab", con);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@description", description);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
              
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }
            finally
            {
                DatabaseConnection("close");
            }
        }
        public Lab getLabEdit(int id)
        {
            Lab lab = new Lab();
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand("SelectLabID", con);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                lab.Id = reader.GetInt32(reader.GetOrdinal("id"));
                lab.Name = reader.GetString(reader.GetOrdinal("name"));
                lab.Description = reader.GetString(reader.GetOrdinal("description"));
            }
            sqlCommand.Dispose();
            DatabaseConnection("close");
            return lab;
        }
        public void deleteLab(int id)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("DeleteLab", con);
                sqlCommand.Parameters.AddWithValue("@idLab", id);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
           
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }
            finally
            {
                DatabaseConnection("close");
            }
        }
        public int selectCode()
        {
            int code = 0;
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("SelectCodeLab", con);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    code = reader.GetInt32(reader.GetOrdinal("code"));
                }
                sqlCommand.Dispose();
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }
            finally
            {
                DatabaseConnection("close");

            }
            return code;
        }
        public DropDownList readLabName()
        {
            DropDownList ddl = new DropDownList();
            Lab lab = new Lab();
            DataTable dt = new DataTable();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("SelectLab", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ddl.DataSource = dt;
            ddl.DataTextField = "name";
            ddl.DataValueField = "name";
            ddl.DataBind();
            cmd.Dispose();
            DatabaseConnection("close");
            return ddl;
        }
        public DropDownList readLabIdName()
        {
            DropDownList ddl = new DropDownList();
            Lab lab = new Lab();
            DataTable dt = new DataTable();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("SelectIDNameLab", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ddl.DataTextField = "name";
            ddl.DataValueField = "id";
            ddl.DataSource = dt;
            ddl.DataBind();
            cmd.Dispose();
            DatabaseConnection("close");
            return ddl;
        }
        public int changeNameToId(string name)
        {
            Lab lab = new Lab();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("changeNameToId", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lab.Id = reader.GetInt32(reader.GetOrdinal("id"));
            }
            cmd.Dispose();
            DatabaseConnection("close");
            return lab.Id;
        }
        public string changeIdToName(int idLab)
        {
            Lab lab = new Lab();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("changeIdToName", con);
            cmd.Parameters.AddWithValue("@idLab", idLab);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lab.Name = reader.GetString(reader.GetOrdinal("name"));
            }
            cmd.Dispose();
            DatabaseConnection("close");
            return lab.Name;
        }

    }
}