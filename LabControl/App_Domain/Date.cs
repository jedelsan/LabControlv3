using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.App_Domain
{
    public class Date
    {

        private int id;
        private string date;


        public Date()
        {
        }
        public Date(int id, string date)
        {
            this.id = id;
            this.date = date;

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Date1
        {
            get { return date; }
            set { date = value; }
        }







    }
}