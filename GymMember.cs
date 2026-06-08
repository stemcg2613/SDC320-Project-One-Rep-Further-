/*******************************************************************
* Name: Steven McGraw
* Date: June 7, 2026
* Assignment: One Rep Further - Database Implementation
*
* Represents a gym member in the One Rep Further application.
*******************************************************************/

public class GymMember
{
    // Database ID
    public int ID { get; set; }

    // Member information
    public string Name { get; set; }
    public int Age { get; set; }
    public string MembershipType { get; set; }

    // Constructor used when creating a new member
    public GymMember(string name, int age, string membershipType)
    {
        Name = name;
        Age = age;
        MembershipType = membershipType;
    }

    // Constructor used when loading a member from the database
    public GymMember(int id, string name, int age, string membershipType)
    {
        ID = id;
        Name = name;
        Age = age;
        MembershipType = membershipType;
    }

    public override string ToString()
    {
        return $"ID: {ID}\n" +
               $"Name: {Name}\n" +
               $"Age: {Age}\n" +
               $"Membership: {MembershipType}";
    }
}