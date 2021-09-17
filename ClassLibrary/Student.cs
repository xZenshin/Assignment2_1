using System;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        public enum Status
        {
            New,
            Active,
            Dropout,
            Graduated
        }

        public int id {get;}
        string givenName  {get; set;}
        string surname  {get; set;}
        Status status {get; set;}
        DateTime startDate  {get; set;}
        DateTime EndDate  {get; set;}
        DateTime GraduationDate  {get; set;}

        public Student(int id, string givenName, string surname, DateTime startDate, Status status, DateTime EndDate, DateTime GraduationDate) {
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            this.startDate = startDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;
            this.status = status;
        }

        public override string ToString() {
                StringBuilder sb = new StringBuilder("", 100);
                sb.Append("ID: " + id);
                sb.Append(" Given Name: " + givenName);
                sb.Append(" Surname: " + surname);
                sb.Append(" Start Date: " + startDate);
                sb.Append(" End Date: " + EndDate);
                sb.Append(" Graduation Date: " + GraduationDate);
                sb.Append(" Status: " + status); 


                return sb.ToString();
        }

    }
}
