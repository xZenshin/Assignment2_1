using System;
using System.Text;
using Xunit;
using ClassLibrary;

namespace Assignment2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void StudentToString()
        {
            var student = new Student(1, "Name", "Last Name", new DateTime(2019, 8, 30), Student.Status.New, new DateTime(2020, 8, 12), new DateTime(2020, 9, 7));

            StringBuilder expectedString = new StringBuilder("", 100);
                expectedString.Append("ID: " + 1);
                expectedString.Append(" Given Name: " + "Name");
                expectedString.Append(" Surname: " + "Last Name");
                expectedString.Append(" Start Date: " + new DateTime(2019, 8, 30));
                expectedString.Append(" End Date: " + new DateTime(2020, 8, 12));
                expectedString.Append(" Graduation Date: " + new DateTime(2020, 9, 7));
                expectedString.Append(" Status: " + "New"); 

            Assert.Equal(expectedString.ToString(), student.ToString());
        }
    }
}
