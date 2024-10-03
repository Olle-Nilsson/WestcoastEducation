
namespace WestcoastEducation;
public class CourseLeader : Teacher
{
    public DateTime DateOfEmployment { get; set; }
    public override string ToString()
    {
        return $"{base.ToString()} DateOfEmployment: {DateOfEmployment}";
    }
}
