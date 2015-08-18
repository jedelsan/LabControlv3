using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attempt1.App_Domain
{
    public class Lab
    {
        private int id;
        private string name;
        private string description;
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        private List<WorkStation> workStations;


        public Lab()
        {

        }

        public Lab(int id, string name, string description, int code)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.code = code;


        }

        public Lab( string name, string description,int code)
        {
          
            this.name = name;
            this.description = description;
            this.code = code;

        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public List<WorkStation> WorkStations 
        {
            get { return workStations; }
            set { workStations = value; }
        }
    }
}