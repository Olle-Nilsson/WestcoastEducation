using System.Text.Encodings.Web;
using System.Text.Json;

namespace WestcoastEducation;

static public class JsonManager
{
    static private JsonSerializerOptions _option = new JsonSerializerOptions
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };
    static public void WriteJson(string path, List<Course> courses)
    {
        var json = JsonSerializer.Serialize(courses, _option);
        File.WriteAllText(path, json);
    }
    static public List<Course> ReadJson(string path)
    {
        var json = File.ReadAllText(path);
        var courses = JsonSerializer.Deserialize<List<Course>>(json, _option);
        return courses!;
    }
}
