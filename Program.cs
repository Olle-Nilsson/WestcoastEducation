namespace WestcoastEducation;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.GetInfo(1);

        Teacher teacher = new Teacher();
        teacher.GetInfo(2);
        teacher.FiledOfExpertise = "Programmering";

        CourseLeader courseLeader = new CourseLeader();
        courseLeader.GetInfo(3);
        courseLeader.FiledOfExpertise = "Programmering";
        courseLeader.DateOfEmployment = DateTime.Now;

        Admin admin = new Admin();
        admin.GetInfo(4);
        admin.FiledOfExpertise = "Programmering";
        admin.DateOfEmployment = DateTime.Now;


        Course course = new Course(teacher: teacher, courseLeader: courseLeader, admin: admin, numberOfWeeks: 16, startDate: DateTime.Now);
        course.CourseName = "Programmering i C#";
        course.CourseType = CourseType.InPerson;
        course.AddStudent(student);

        Console.WriteLine(course);



        var path = string.Concat(Environment.CurrentDirectory, "/data/courses.json");


        // JsonManager.WriteJson(path, [course]);

        var courses = JsonManager.ReadJson(path);

        foreach (var c in courses)
        {
            Console.WriteLine(c);
        }
    }
}
