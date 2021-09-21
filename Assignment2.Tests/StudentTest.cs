using System;
using System.Text;
using Xunit;
using ClassLibrary;

namespace Assignment2.Tests
{
    public class StudentTest
    {
        [Fact]
        public void StudentToString()
        {
            var student = new Student(1, "Name", "Last Name", new DateTime(2019, 8, 30), new DateTime(2020, 8, 12), new DateTime(2020, 8, 12));

            StringBuilder expectedString = new StringBuilder("", 100);
            expectedString.Append("ID: " + 1);
            expectedString.Append(" Given Name: " + "Name");
            expectedString.Append(" Surname: " + "Last Name");
            expectedString.Append(" Start Date: 30/08/2019 00.00.00");
            expectedString.Append(" End Date: 12/08/2020 00.00.00");
            expectedString.Append(" Graduation Date: 12/08/2020 00.00.00");
            expectedString.Append(" Status: " + "Graduated");

            Assert.Equal(expectedString.ToString(), student.ToString());
        }

        [Fact]
        public void Student_yet_to_start_has_new_status()
        {
            var startDate = new DateTime(2022, 8, 30);
            var endDate = new DateTime(2024, 8, 12);
            var graduationDate = new DateTime(2024, 9, 7);

            var student = new Student(1, "Name", "Last Name", startDate, endDate, graduationDate);

            Assert.Equal(Student.Status.New, student.status);
        }

        [Fact]
        public void Student_with_end_date_before_graduation_has_dropout_status()
        {
            var startDate = new DateTime(2019, 8, 30);
            var endDate = new DateTime(2020, 8, 12);
            var graduationDate = new DateTime(2024, 9, 7);

            var student = new Student(1, "Name", "Last Name", startDate, endDate, graduationDate);

            Assert.Equal(Student.Status.Dropout, student.status);
        }
    }
}
