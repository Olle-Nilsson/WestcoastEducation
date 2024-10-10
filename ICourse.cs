namespace WestcoastEducation;

public interface ICourse
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int NumberOfWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public CourseType CourseType { get; set; }
    public Teacher Teacher { get; set; }
    public CourseLeader CourseLeader { get; set; }
    public Admin Admin { get; set; }
    public List<Student> Students { get; set; }
    public void AddStudent(Student student);
    public string ToString();
}
