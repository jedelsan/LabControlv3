using Attempt1.App_Domain;
using LabControl.App_Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace login.Data
{
    public class DataSchedule : BaseData
    {

        public Schedule readScheduleEDIT(int id, string nameLab, string date)
        {
            Schedule schedule = new Schedule();
            SqlConnection con = DatabaseConnection("open");
            SqlCommand cmd = new SqlCommand("readScheduleEdit", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nameLab", nameLab);
            cmd.Parameters.AddWithValue("@nameDay", date);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                schedule.Busy = reader.GetBoolean(reader.GetOrdinal("busy"));
            }
            cmd.Dispose();
            DatabaseConnection("close");
            return schedule;
        }
    }
}