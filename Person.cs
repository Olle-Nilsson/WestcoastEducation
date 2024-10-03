namespace WestcoastEducation;

public class Person
{
    public int PersonId { get; set; } = new Random().Next(1000, 99000);
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string LastName { get; set; } = "";
    public string SocialSecurityNumber { get; set; } = "";
    public string ZipCode { get; set; } = "";

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName} PhoneNumber: {PhoneNumber} SocialSecurityNumber: {SocialSecurityNumber} Address: {Address} {City} {ZipCode}";
    }

}
