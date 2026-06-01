/*******************************************************************
* Name: Steven McGraw
* Date: 05/31/2026
* Assignment: SDC320 Course Project Week 3
*
* Represents a gym member and inherits from the User base class.
*/

public class Member : User
{
    public string MembershipType { get; set; }
    public double Weight { get; set; }
    public string FitnessGoal { get; set; }

    public Member(
        int userId,
        string firstName,
        string lastName,
        string email,
        string membershipType,
        double weight,
        string fitnessGoal)
        : base(userId, firstName, lastName, email)
    {
        MembershipType = membershipType;
        Weight = weight;
        FitnessGoal = fitnessGoal;
    }

    public override string GetRole()
    {
        return "Gym Member";
    }

    public void UpdateWeight(double newWeight)
    {
        Weight = newWeight;
    }

    public override string ToString()
    {
        return
            base.ToString() + "\n" +
            "Membership Type: " + MembershipType + "\n" +
            "Weight: " + Weight + "\n" +
            "Fitness Goal: " + FitnessGoal;
    }
}