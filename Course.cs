using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Text;

namespace WestcoastEducation;

public class Course
{
    public int CourseId { get; set; } = new Random().Next(1000, 99000);
    public string CourseName { get; set; } = "";
    public int NumberOfWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public CourseType CourseType { get; set; }
    public Teacher Teacher { get; set; } = new();
    public CourseLeader CourseLeader { get; set; } = new();
    public Admin Admin { get; set; } = new();
    public List<Student> Students { get; set; } = [];
    public Course(Teacher teacher, CourseLeader courseLeader, Admin admin, int numberOfWeeks, DateTime startDate)
    {
        NumberOfWeeks = numberOfWeeks;
        StartDate = startDate;
        EndDate = StartDate.AddDays(NumberOfWeeks * 7);

        Teacher = teacher;
        teacher.CourseIds.Add(CourseId);
        CourseLeader = courseLeader;
        CourseLeader.CourseIds.Add(CourseId);
        Admin = admin;
        Admin.CourseIds.Add(CourseId);
    }
    public void AddStudent(Student student)
    {
        Students.Add(student);
        student.CourseId = CourseId;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"CourseId: {CourseId} CourseName: {CourseName} NumberOfWeeks: {NumberOfWeeks} StartDate: {StartDate} EndDate: {EndDate} \nTeacher: {Teacher} \nCourseLeader: {CourseLeader} \nAdmin: {Admin} \nStudents: ");
        foreach (var s in Students)
        {
            sb.Append("\n" + s);
        }
        return sb.ToString();
    }
}
