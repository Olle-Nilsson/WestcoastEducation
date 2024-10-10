namespace WestcoastEducation;

public interface IPerson
{
    public int PersonId { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string FirstName { get; set; }
    public string PhoneNumber { get; set; }
    public string LastName { get; set; }
    public string SocialSecurityNumber { get; set; }
    public string ZipCode { get; set; }
    public void GetInfo(int personId);
    public string ToString();
}
