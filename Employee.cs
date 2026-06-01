/*******************************************************************
* Name: Steven McGraw
* Date: 05/31/2026
* Assignment: SDC320 Course Project Week 3
*
* Represents a gym employee and inherits from the User base class.
*/

public class Employee : User
{
    public string EmployeeRole { get; set; }
    public double HourlyRate { get; set; }

    public Employee(
        int userId,
        string firstName,
        string lastName,
        string email,
        string employeeRole,
        double hourlyRate)
        : base(userId, firstName, lastName, email)
    {
        EmployeeRole = employeeRole;
        HourlyRate = hourlyRate;
    }

    public override string GetRole()
    {
        return "Employee";
    }

    public string CreateWorkoutPlan()
    {
        return FirstName + " created a new workout plan.";
    }

    public string ManageMembership()
    {
        return FirstName + " updated a gym membership.";
    }

    public override string ToString()
    {
        return
            base.ToString() + "\n" +
            "Employee Role: " + EmployeeRole + "\n" +
            "Hourly Rate: $" + HourlyRate;
    }
}