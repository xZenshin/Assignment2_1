using System;

namespace ClassLibrary
{
    public record ImmutableStudent
    {
        public int id { get; init; }
        public string givenName { get; init; }
        public string surname { get; init; }
        public Student.Status status
        {
            get
            {
                var now = DateTime.Now;

                if (now > startDate && now < EndDate)
                {
                    return Student.Status.Active;
                }
                else if (now > startDate && now > EndDate && EndDate < GraduationDate)
                {
                    return Student.Status.Dropout;
                }
                else if (now > GraduationDate)
                {
                    return Student.Status.Graduated;
                }

                return Student.Status.New;
            }
        }
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
        }
    }
}
