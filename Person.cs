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


    public void GetInfo(int personId)
    {
        switch (personId)
        {
            case 1:
                Address = "DummyVägen 2";
                City = "Mamlö";
                FirstName = "Bengt";
                LastName = "Nilsson";
                PhoneNumber = "075-9432744";
                SocialSecurityNumber = "19830524-6786";
                ZipCode = "250-00";
                break;
            case 2:
                Address = "DummyGatan 7";
                City = "Mamlö";
                FirstName = "Greta";
                LastName = "Olsson";
                PhoneNumber = "077-7349656";
                SocialSecurityNumber = "19531002-45";
                ZipCode = "250-00";
                break;
            case 3:
                Address = "DummyVägen 5";
                City = "Mamlö";
                FirstName = "Olof";
                LastName = "Persson";
                PhoneNumber = "071-4849784";
                SocialSecurityNumber = "20020625-6374";
                ZipCode = "250-00";
                break;
            case 4:
                Address = "DummyGatan 5";
                City = "Mamlö";
                FirstName = "Nils";
                LastName = "Nilssson";
                PhoneNumber = "072-9839286";
                SocialSecurityNumber = "20051201-3840";
                ZipCode = "250-01";
                break;
        }
    }
    public override string ToString()
    {
        return $"Name: {FirstName} {LastName} PhoneNumber: {PhoneNumber} SocialSecurityNumber: {SocialSecurityNumber} Address: {Address} {City} {ZipCode}";
    }

}
