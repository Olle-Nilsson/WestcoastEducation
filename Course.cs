using System.Dynamic;

namespace WestcoastEducation;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; } = "";
    public int NumberOfWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public CourseType CourseType { get; set; }
    public Teacher Teacher { get; set; } = new();
    public CourseLeader CourseLeader { get; set; } = new();
    public Admin Admin { get; set; } = new();
    public List<Student> Students { get; set; } = [];

    public override string ToString()
    {
        return $"{CourseId} {CourseName} {NumberOfWeeks} {StartDate} {EndDate} {Teacher} {CourseLeader} {Admin} {Students}";
    }
}
