using login.Account.App_Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace login.Data
{
    public class DataUser : BaseData
    {
        public DataTable tableUser()
        {
            DataTable dt = new DataTable();
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("readUserTable", con);
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
        public List<User> readUser()
        {
            List<User> userList = new List<User>();
            User user = new User();

            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;

            try
            {
                sqlCommand = new SqlCommand("readUser", con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    user.Name = reader.GetString(reader.GetOrdinal("name"));
                    user.Email = reader.GetString(reader.GetOrdinal("mail"));
                    user.License = reader.GetInt32(reader.GetOrdinal("license"));
                    user.Password = reader.GetString(reader.GetOrdinal("password"));
                    user.Role = reader.GetInt32(reader.GetOrdinal("idRol"));
                    userList.Add(user);
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
            return userList;
        }
        public User getUserData(string mail, string password)
        {
            User user = new User();

            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;


            sqlCommand = new SqlCommand("readUserData", con);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@mail", mail);
            sqlCommand.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    user.Name = reader.GetString(reader.GetOrdinal("name"));
                    user.Email = reader.GetString(reader.GetOrdinal("mail"));
                    user.License = reader.GetInt32(reader.GetOrdinal("license"));
                    user.Password = reader.GetString(reader.GetOrdinal("password"));
                    user.Role = reader.GetInt32(reader.GetOrdinal("idRol"));
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
            return user;
        }
        public void updatePassword(User user)
        {
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;

            try
            {
                sqlCommand = new SqlCommand("updatePassword", con);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@password", user.Password);
                sqlCommand.Parameters.AddWithValue("@id", user.Id);
                sqlCommand.Parameters.AddWithValue("@name", user.Name);
                sqlCommand.Parameters.AddWithValue("@mail", user.Email);
                sqlCommand.Parameters.AddWithValue("@license", user.License);
                sqlCommand.Parameters.AddWithValue("@idRol", user.Role);
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
        public void insertUser(string name, string email, int license, string password, int role)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;


            sqlCommand = new SqlCommand("insertUser", con);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@mail", email);
            sqlCommand.Parameters.AddWithValue("@licence", license);
            sqlCommand.Parameters.AddWithValue("@password", password);
            sqlCommand.Parameters.AddWithValue("@idRol", role);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            sqlCommand.Dispose();
            DatabaseConnection("close");

        }
        public void deleteUser(int id)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;


            sqlCommand = new SqlCommand("deleteUser", con);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            sqlCommand.Dispose();
            DatabaseConnection("close");

        }
        public User getUserEdit(int id)
        {
            User user = new User();
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            string databaseCommand = "SELECT id, name, mail, license, password, idRol FROM [LabControl].[dbo].[User] WHERE id =" + id;
            try
            {
                sqlCommand = new SqlCommand(databaseCommand, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    user.Name = reader.GetString(reader.GetOrdinal("name"));
                    user.Email = reader.GetString(reader.GetOrdinal("mail"));
                    user.License = reader.GetInt32(reader.GetOrdinal("license"));
                    user.Password = reader.GetString(reader.GetOrdinal("password"));
                    user.Role = reader.GetInt32(reader.GetOrdinal("idRol"));
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
            return user;
        }
        public void updateUser(int id, string name, string mail, int license, string password, int idRol)
        {
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            string databaseCommand = "UPDATE [LabControl].[dbo].[User] SET[LabControl].[dbo].[User].name = '" + name + "', [LabControl].[dbo].[User].mail = '" + mail + "', [LabControl].[dbo].[User].license = " + license + ", [LabControl].[dbo].[User].password = '" + password + "', [LabControl].[dbo].[User].idRol = " + idRol + " WHERE [LabControl].[dbo].[User].id =" + id;
            try
            {
                sqlCommand = new SqlCommand(databaseCommand, con);
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