using System;
using System.Text;
using Xunit;
using ClassLibrary;

namespace Assignment2.Tests
{
    public class ImmutableStudentTests
    {
        [Fact]
        public void immutable_student_gives_all_public_fields_in_to_string()
        {
            var student = new ImmutableStudent(1, "Name", "Last Name", new DateTime(2019, 8, 30), new DateTime(2020, 8, 12), new DateTime(2020, 9, 7));

            var actualString = student.ToString();
            var expectedString = "ImmutableStudent { id = 1, givenName = Name, surname = Last Name, status = New, startDate = 30/08/2019 00.00.00, EndDate = 12/08/2020 00.00.00, GraduationDate = 07/09/2020 00.00.00 }";

            Assert.Equal(expectedString, actualString);
        }

        [Fact]
        public void immutable_student_equals_other_instance_with_same_fields()
        {
            var student1 = new ImmutableStudent(1, "Name", "Last Name", new DateTime(2019, 8, 30), new DateTime(2020, 8, 12), new DateTime(2020, 9, 7));
            var student2 = new ImmutableStudent(1, "Name", "Last Name", new DateTime(2019, 8, 30), new DateTime(2020, 8, 12), new DateTime(2020, 9, 7));

            Assert.True(student1 == student2);
        }
    }
}
