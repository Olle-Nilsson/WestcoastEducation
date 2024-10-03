using System.Text;

namespace WestcoastEducation;

public class Teacher : Person
{
    public string FiledOfExpertise { get; set; } = "";
    public List<int> CourseIds { get; set; } = [];

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{base.ToString()} FiledOfExpertise: {FiledOfExpertise} CourseIds: ");
        foreach (int i in CourseIds)
        {
            sb.Append($"{i}, ");
        }
        return sb.ToString();
    }
}
