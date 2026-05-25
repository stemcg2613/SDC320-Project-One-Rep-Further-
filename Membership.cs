/*******************************************************************
* Name: Steven McGraw
* Date: 05/25/2026
* Assignment: SDC320 Course Project Week 2
*
* Stores membership information for a gym member.
*/

public class Membership
{
    public string MembershipType { get; set; }
    public string StartDate { get; set; }
    public bool IsActive { get; set; }

    public Membership(string membershipType, string startDate, bool isActive)
    {
        MembershipType = membershipType;
        StartDate = startDate;
        IsActive = isActive;
    }

    public void CancelMembership()
    {
        IsActive = false;
    }

    public void RenewMembership()
    {
        IsActive = true;
    }

    public override string ToString()
    {
        string status = IsActive ? "Active" : "Inactive";

        return string.Format(
            "Membership Type: {0}\nStart Date: {1}\nStatus: {2}",
            MembershipType,
            StartDate,
            status);
    }
}