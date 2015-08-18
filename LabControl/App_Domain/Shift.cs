using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabControl.App_Domain
{
    public class Shift
    {
        private int id;
        private string startTime;
        private string endTime;
  
        public Shift()
        {

        }

        public Shift(int id, string startTime, string endTime)
        {
            this.id = id;
            this.startTime = startTime;
            this.endTime = endTime;
      
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
   

    }
}