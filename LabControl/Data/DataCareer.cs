using LabControl.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace LabControl.Data
{
    public class DataCareer : BaseData
    {
        public DataTable tableCareer()
        {
            DataTable dt = new DataTable();
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand("readCareerTable", con);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            sqlCommand.Dispose();
            DatabaseConnection("close");
            return dt;
        }
        public void insertCareer(string name, string description, string code)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand("insertCareer", con);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@description", description);
            sqlCommand.Parameters.AddWithValue("@code", code);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            sqlCommand.Dispose();
            DatabaseConnection("close");
        }
        public void deleteCareer(int id)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("deleteCareer", con);
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
        public Career getCareerEdit(int id)
        {
            Career career = new Career();
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand("readCareerEdit", con);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                career.Id = reader.GetInt32(reader.GetOrdinal("id"));
                career.Name = reader.GetString(reader.GetOrdinal("name"));
                career.Description = reader.GetString(reader.GetOrdinal("description"));
                career.Code = reader.GetString(reader.GetOrdinal("code"));
            }
            sqlCommand.Dispose();
            DatabaseConnection("close");
            return career;
        }
        public void updateCareer(int id, string name, string description, string code)
        {
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("updateCareer", con);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@description", description);
                sqlCommand.Parameters.AddWithValue("@code", code);
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
    }
}