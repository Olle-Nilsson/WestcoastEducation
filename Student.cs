using System.Security.Cryptography;

namespace WestcoastEducation;

public class Student : Person
{
    public int CourseId { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} CurrentCourseId: {CourseId} ";
    }
}
