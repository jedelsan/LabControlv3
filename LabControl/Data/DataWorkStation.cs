using Attempt1.App_Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LabControl.Data;
using System.Web.UI.WebControls;
namespace login.Data
{
    public class DataWorkStation : BaseData
    {
        public void createWorkStation(string description, int idLab, int numeroWorkStation)
        {
            try
            {
                SqlConnection con = DatabaseConnection("open");
                SqlCommand cmd = new SqlCommand("createWorkStation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@description", System.Data.SqlDbType.NVarChar).Value = description;
                cmd.Parameters.Add("@idLab", System.Data.SqlDbType.Int).Value = idLab;
                cmd.Parameters.AddWithValue("@numeroWorkStation", numeroWorkStation);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                SqlConnection con = DatabaseConnection("close");
            }
        }
        public DataTable readWorkStation()
        {
            DataTable dt = new DataTable();
            WorkStation workStation = new WorkStation();
            Lab lab = new Lab();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readWorkStation", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            DatabaseConnection("close");
            return dt;
        }

        public WorkStation readWorkStationEDIT(int id)
        {
            WorkStation workStation = new WorkStation();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readWorkStationEDIT", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                workStation.Id = reader.GetInt32(reader.GetOrdinal("id"));
                workStation.Description = reader.GetString(reader.GetOrdinal("description"));
                workStation.IdLab = reader.GetInt32(reader.GetOrdinal("idLab"));

            }
            cmd.Dispose();
            DatabaseConnection("close");
            return workStation;
        }
        public void updateWorkStation(int id, string description, int idLab)
        {
            try
            {
                SqlConnection con = DatabaseConnection("open");
                SqlCommand cmd = new SqlCommand("updateWorkStation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@description", System.Data.SqlDbType.NVarChar).Value = description;
                cmd.Parameters.Add("@idLab", System.Data.SqlDbType.Int).Value = idLab;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                SqlConnection con = DatabaseConnection("close");
            }
        }
        public void deleteWorkStation(int id, int idLab)
        {
            try
            {
                SqlConnection con = DatabaseConnection("open");
                SqlCommand cmd = new SqlCommand("deleteWorkStation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@idLab", System.Data.SqlDbType.Int).Value = idLab;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                SqlConnection con = DatabaseConnection("close");
            }
        }
        public WorkStation readWorkStationBusy(int id, string startTime, string date)
        {
            DataReservation dataReservation = new DataReservation();

            WorkStation workStation = new WorkStation();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readWorkStationEDIT", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                workStation.Id = reader.GetInt32(reader.GetOrdinal("id"));
                workStation.Description = reader.GetString(reader.GetOrdinal("description"));
                workStation.IdLab = reader.GetInt32(reader.GetOrdinal("idLab"));
                workStation.Busy = dataReservation.SelectAvailabilityStation(id, startTime, date);
            }
            cmd.Dispose();
            DatabaseConnection("close");
            return workStation;
        }
        public DropDownList readWorkStationDropDown()
        {
            DropDownList ddl = new DropDownList();
            DataTable dt = new DataTable();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readWorkStation", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ddl.DataSource = dt;
            ddl.DataTextField = "id";
            ddl.DataValueField = "id";
            ddl.DataBind();
            cmd.Dispose();
            DatabaseConnection("close");
            return ddl;
        }
    }
}