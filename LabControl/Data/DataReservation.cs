using Attempt1.App_Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using login.Data;
namespace LabControl.Data
{
    public class DataReservation : BaseData
    {
        public bool SelectAvailabilityStation(int idStation, string startTime, string date)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            bool busy = false;
            sqlCommand = new SqlCommand("availabilityWorkStation", con);
            sqlCommand.Parameters.AddWithValue("@idWorkStation", idStation);
            sqlCommand.Parameters.AddWithValue("@startTime", startTime);
            sqlCommand.Parameters.AddWithValue("@date", date);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                busy = true;
            }
            else
            {
                busy = false;
            }
            DatabaseConnection("close");
            return busy;
        }
        public List<string> SelectCodeLab()
        {
            List<string> listLab = new List<string>();
            string lab = "";
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand("getLabNombresDdl", con);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lab = reader.GetString(reader.GetOrdinal("name"));
                listLab.Add(lab);
            }
            DatabaseConnection("close");
            return listLab;
        }
        public List<string> getShifts(string dayName, string labName)
        {
            List<string> listShifts = new List<string>();
            string shift;
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("getStartTimeDdl", con);
                sqlCommand.Parameters.AddWithValue("@dayName", dayName);
                sqlCommand.Parameters.AddWithValue("@labName", labName);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    shift = reader.GetString(reader.GetOrdinal("start time"));
                    listShifts.Add(shift);
                }
              
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }
            finally
            {
                DatabaseConnection("close");
            }
            return listShifts;
        }
        public int getLabId(string nameLab)
        {
            int idLab = 0;
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("getLabId", con);
                sqlCommand.Parameters.AddWithValue("@nameLab", nameLab);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    idLab = reader.GetInt32(reader.GetOrdinal("id"));
                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }
            finally{
                DatabaseConnection("close");
            }
            return idLab;
        }
        public int insertAvailability(string startTime, string date)
        {
            int id = 0;
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("insertAvailability", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@startTime", SqlDbType.NVarChar).Value = startTime;
            cmd.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(reader.GetOrdinal("id"));
            }
            DatabaseConnection("close");
            return id;
        }
        public int insertDetailRequest(string day, string shift, string description)
        {
            int id = 0;
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("insertDeatil_Request", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@day", SqlDbType.NVarChar).Value = day;
            cmd.Parameters.Add("@shift", SqlDbType.NVarChar).Value = shift;
            cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(reader.GetOrdinal("id"));
            }
            DatabaseConnection("close");
            return id;
        }
        public int insertRequest(int idUser, int idLab, int idDetalle)
        {
            int id = 0;
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("insertRequest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idUser", SqlDbType.NVarChar).Value = idUser;
            cmd.Parameters.Add("@idLab", SqlDbType.NVarChar).Value = idLab;
            cmd.Parameters.Add("@idDetail", SqlDbType.NVarChar).Value = idDetalle;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(reader.GetOrdinal("id"));
            }
            DatabaseConnection("close");
            return id;
        }
        public void insertWSAvailability(int idWS, int idAvailability)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("insertAvailabilityWS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idAvailability", SqlDbType.NVarChar).Value = idAvailability;
            cmd.Parameters.Add("@idWorkStation", SqlDbType.NVarChar).Value = idWS;
            cmd.ExecuteNonQuery();
            DatabaseConnection("close");
        }
        public void insertrequestWS(int workStation, int request)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("insertRequestWS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@request", SqlDbType.NVarChar).Value = request;
            cmd.Parameters.Add("@workStation", SqlDbType.NVarChar).Value = workStation;
            cmd.ExecuteNonQuery();
            DatabaseConnection("close");
        }
        public int selectCodeLab(int idLab)
        {
            int code = 0;
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            try
            {
                sqlCommand = new SqlCommand("SelectLabCode", con);
                sqlCommand.Parameters.AddWithValue("@idLab", idLab);
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
        public int SelectLabCode(int idLab)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            int code = 0;
            try
            {
                sqlCommand = new SqlCommand("SelectLabCode", con);
                sqlCommand.Parameters.AddWithValue("@idLab", idLab);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    code = reader.GetInt32(reader.GetOrdinal("code"));
                }

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
    }
}