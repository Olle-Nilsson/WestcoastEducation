namespace WestcoastEducation;

class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
        teacher.Address = "DummyVägen 2";
        teacher.City = "Mamlö";
        teacher.FirstName = "Bengt";
        teacher.LastName = "Nilsson";
        teacher.PhoneNumber = "075-9432744";
        teacher.SocialSecurityNumber = "19830524-6786";
        teacher.ZipCode = "250-00";
        teacher.FiledOfExpertise = "Programmering";

        CourseLeader courseLeader = new CourseLeader();
        courseLeader.Address = "DummyGatan 7";
        courseLeader.City = "Mamlö";
        courseLeader.FirstName = "Greta";
        courseLeader.LastName = "Olsson";
        courseLeader.PhoneNumber = "077-7349656";
        courseLeader.SocialSecurityNumber = "19531002-4584";
        courseLeader.ZipCode = "250-00";
        courseLeader.FiledOfExpertise = "Programmering";
        courseLeader.DateOfEmployment = DateTime.Now;

        Admin admin = new Admin();
        admin.Address = "DummyVägen 5";
        admin.City = "Mamlö";
        admin.FirstName = "Olof";
        admin.LastName = "Persson";
        admin.PhoneNumber = "071-4849784";
        admin.SocialSecurityNumber = "20020625-6374";
        admin.ZipCode = "250-00";
        admin.FiledOfExpertise = "Programmering";
        admin.DateOfEmployment = DateTime.Now;

        Student student = new Student();
        student.Address = "DummyGatan 5";
        student.City = "Mamlö";
        student.FirstName = "Nils";
        student.LastName = "Nilssson";
        student.PhoneNumber = "072-9839286";
        student.SocialSecurityNumber = "20051201-3840";
        student.ZipCode = "250-01";

        Course course = new Course(teacher: teacher, courseLeader: courseLeader, admin: admin, numberOfWeeks: 16, startDate: DateTime.Now);
        course.CourseName = "Programmering i C#";
        course.CourseType = CourseType.InPerson;
        course.AddStudent(student);

        Console.WriteLine(course);

        var path = string.Concat(Environment.CurrentDirectory, "/data/courses.json");
        JsonManager.WriteJson(path, [course]);


        var course1 = JsonManager.ReadJson(path);
        foreach (var c in course1)
        {
            Console.WriteLine(c);
        }












    }
}
