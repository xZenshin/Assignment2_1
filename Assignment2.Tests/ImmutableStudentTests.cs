using System;
using Xunit;
using ClassLibrary;

namespace Assignment2.Tests
{
    public class ImmutableStudentTests
    {
        [Fact]
        public void immutable_student_equals_other_instance_with_same_fields()
        {
            var student1 = new ImmutableStudent(1, "Name", "Last Name", new DateTime(2019, 8, 30), new DateTime(2020, 8, 12), new DateTime(2020, 9, 7));
            var student2 = new ImmutableStudent(1, "Name", "Last Name", new DateTime(2019, 8, 30), new DateTime(2020, 8, 12), new DateTime(2020, 9, 7));

            Assert.True(student1 == student2);
        }

        [Fact]
        public void immutable_student_to_string_equals_to_string_of_other_instance_with_same_fields()
        {
            var student1 = new ImmutableStudent(1, "Name", "Last Name", new DateTime(2019, 8, 30), new DateTime(2020, 8, 12), new DateTime(2020, 9, 7));
            var student2 = new ImmutableStudent(1, "Name", "Last Name", new DateTime(2019, 8, 30), new DateTime(2020, 8, 12), new DateTime(2020, 9, 7));

            var string1 = student1.ToString();
            var string2 = student1.ToString();

            Assert.True(string1 == string2);
        }
    }
}
