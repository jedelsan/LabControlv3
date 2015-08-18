using Attempt1.App_Domain;
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
    public class DataShift : BaseData
    {
        public DataTable readShiftEDIT(string name, string date)
        {
            DataTable dt = new DataTable();
            Shift shift = new Shift();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readShift", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            DatabaseConnection("close");
            return dt;
        }
        public Shift readShiftEDITBusy(int id)
        {
            Shift shift = new Shift();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readShiftEDIT", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                shift.Id = reader.GetInt32(reader.GetOrdinal("id"));
                shift.StartTime = reader.GetString(reader.GetOrdinal("start time"));
                shift.EndTime = reader.GetString(reader.GetOrdinal("end time"));
            }
            cmd.Dispose();
            DatabaseConnection("close");
            return shift;
        }
        public void updateShift(int idLab, bool busy, int idShift, int idDay)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("updateShift", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@idLab", System.Data.SqlDbType.Int).Value = idLab;
            cmd.Parameters.Add("@idDay", System.Data.SqlDbType.Int).Value = idDay;
            cmd.Parameters.Add("@idShift", System.Data.SqlDbType.Int).Value = idShift;
            if (busy == true)
                cmd.Parameters.Add("@busy", System.Data.SqlDbType.Bit).Value = false;
            else
                cmd.Parameters.Add("@busy", System.Data.SqlDbType.Bit).Value = true;
            cmd.ExecuteNonQuery();
            con = DatabaseConnection("close");
        }
        public int readLabEDIT(string name)
        {
            Lab lab = new Lab();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readLabEDIT", con);
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
    }
}