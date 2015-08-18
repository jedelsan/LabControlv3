using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabControl.App_Domain
{
    public class UserReservation
    {
        int idUser;

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        int idLab;

        public int IdLab
        {
            get { return idLab; }
            set { idLab = value; }
        }
        int idReservation;

        public int IdReservation
        {
            get { return idReservation; }
            set { idReservation = value; }
        }
        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        string shift;

        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }

        public UserReservation(int idUser,int idLab, int idReservation, DateTime date, string shift) {
            this.idLab = idLab;
            this.idUser = idUser;
            this.idReservation = idReservation;
            this.date = date;
            this.shift = shift;
        }
    }
}