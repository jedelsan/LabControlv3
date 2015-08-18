using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attempt1.App_Domain
{
    public class WorkStation
    {
        private int id;
        private string description;
        private bool busy;
        private int idLab;
        

        public WorkStation()
        {

        }

        public WorkStation(int id, string name, bool busy, int idLab)
        {
            this.id = id;
            this.description = name;
            this.busy = busy;
            this.idLab = idLab;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int IdLab
        {
            get { return idLab; }
            set { idLab = value; }
        }
        public bool Busy
        {
            get { return busy; }
            set { busy = value; }
        }
    }
}