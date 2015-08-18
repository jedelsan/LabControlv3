using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attempt1.App_Domain
{
    public class Schedule
    {
        private int idLab;
        private int idShift;
        private int idDay;
        private bool busy;
        public Schedule()
        {

        }

        public Schedule(int idLab, int idShift, int idDay, bool busy)
        {
            this.idLab = idLab;
            this.idShift = idShift;
            this.idDay = idDay;
            this.busy = busy;
        }


        public int IdLab
        {
            get { return idLab; }
            set { idLab = value; }
        }
        public int IdSchedule
        {
            get { return idShift; }
            set { idShift = value; }
        }
        public int IdDay
        {
            get { return idDay; }
            set { idDay = value; }
        }
        public bool Busy
        {
            get { return busy; }
            set { busy = value; }
        }
    }
}