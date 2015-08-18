using Attempt1.App_Domain;
using LabControl.App_Domain;
using login.Account.App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.App_Domain
{
    public class Reservation
    {
        private int id;
        private string date;
        private int lab;
        private int user;
        private string day;
        private string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private List<int> workStations;
        private string shift;
        private string startTime;
        private List<WorkStation> wsBusy;

        public Reservation()
        {

        }
        public Reservation(int idUser, int idLab, string startTime, string day , string date) {
            this.user = idUser;
            this.lab = idLab;
            this.startTime = startTime;
            this.day = day;
            this.date = date;
        }
        public Reservation(List<WorkStation> wsBusy)
        {
            this.wsBusy = wsBusy;
        }
        public Reservation(int lab,int user, string date, List<int> ws, string shift) {
            this.lab = lab;
            this.date = date;
            this.shift = shift;
            this.user = user;
            this.workStations = ws;
        }
        public Reservation(int lab, string date, string startTime) {
            this.lab = lab;
            this.date = date;
            this.startTime = startTime;
        }

        public Reservation(int lab, string shift, List<WorkStation> wsBusy)
        {
            this.lab = lab;
            this.shift = shift;
            this.wsBusy = wsBusy;
        }
      
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Lab
        {
            get { return lab; }
            set { lab = value; }
        }


        public int User
        {
            get { return user; }
            set { user = value; }
        }

        public List<int> WorkStations
        {
            get { return workStations; }
            set { workStations = value; }
        }

        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }

        public string Day
        {
            get { return day; }
            set { day = value; }
        }

        public List<WorkStation> WsBusy
        {
            get { return wsBusy; }
            set { wsBusy = value; }
        }

        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        
    }
}