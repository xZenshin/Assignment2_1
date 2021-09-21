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

        public int id { get; }
        string givenName { get; set; }
        string surname { get; set; }
        public Status status
        {
            get
            {
                var now = DateTime.Now;

                if (now > startDate && now < EndDate)
                {
                    return Student.Status.Active;
                }
                else if (now < startDate)
                {
                    return Student.Status.New;
                }
                else if (EndDate < GraduationDate)
                {
                    return Student.Status.Dropout;
                }
                else if (now > GraduationDate)
                {
                    return Student.Status.Graduated;
                }

                return Student.Status.Dropout;
            }
        }
        DateTime startDate { get; set; }
        DateTime EndDate { get; set; }
        DateTime GraduationDate { get; set; }
        static String dateFormat = "dd/MM/yyyy HH.mm.ss";

        public Student(int id, string givenName, string surname, DateTime startDate, DateTime EndDate, DateTime GraduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            this.startDate = startDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("", 100);
            sb.Append("ID: " + id);
            sb.Append(" Given Name: " + givenName);
            sb.Append(" Surname: " + surname);
            sb.Append(" Start Date: " + startDate.ToString(dateFormat));
            sb.Append(" End Date: " + EndDate.ToString(dateFormat));
            sb.Append(" Graduation Date: " + GraduationDate.ToString(dateFormat));
            sb.Append(" Status: " + status);

            return sb.ToString();
        }

    }
}
