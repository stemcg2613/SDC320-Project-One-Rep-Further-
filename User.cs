/*******************************************************************
* Name: Steven McGraw
* Date: 05/31/2026
* Assignment: SDC320 Course Project Week 3
*
* Abstract base class for users in the One Rep Further application.
* Demonstrates abstraction and inheritance.
*/

public abstract class User
{
    public int UserId { get; protected set; }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public string Email { get; protected set; }

    public User(int userId, string firstName, string lastName, string email)
    {
        UserId = userId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public abstract string GetRole();

    public virtual string DisplayUserInfo()
    {
        return
            "User ID: " + UserId + "\n" +
            "Name: " + FirstName + " " + LastName + "\n" +
            "Email: " + Email + "\n" +
            "Role: " + GetRole();
    }

    public override string ToString()
    {
        return DisplayUserInfo();
    }
}