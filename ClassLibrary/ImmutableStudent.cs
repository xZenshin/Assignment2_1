using System;

namespace ClassLibrary
{
    public record ImmutableStudent
    {
        public int id { get; init; }
        public string givenName { get; init; }
        public string surname { get; init; }
        public Student.Status status { get; init; }
        public DateTime startDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }

        public ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime EndDate, DateTime GraduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            this.startDate = startDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;
            // this.status = 
        }
    }
}
