using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabControl.App_Domain
{
    public class Career
    {
        private int id;
        private string name;
        private string description;
        private string code;

        public Career(){}

        public Career(int id, string name, string description, string code) {
            this.id = id;
            this.name = name;
            this.description = description;
            this.code = code;
        }

        public Career(string name, string description, string code)
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

        public string Code
        {
            get { return code; }
            set { code = value; }
        }


    }
}