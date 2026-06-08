/*******************************************************************
* Name: Steven McGraw
* Date: June 7, 2026
* Assignment: SDC320 Course Project - Database Implementation
*
* Handles all database operations for Gym Members.
*******************************************************************/

using System.Collections.Generic;
using System.Data.SQLite;

public class GymMemberDB
{
    public static void CreateTable(SQLiteConnection conn)
    {
        string sql =
            @"CREATE TABLE IF NOT EXISTS GymMembers(
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Age INTEGER,
                MembershipType TEXT
            );";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void AddMember(SQLiteConnection conn, GymMember member)
    {
        string sql =
            @"INSERT INTO GymMembers(Name, Age, MembershipType)
              VALUES(@Name,@Age,@MembershipType);";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        cmd.Parameters.AddWithValue("@Name", member.Name);
        cmd.Parameters.AddWithValue("@Age", member.Age);
        cmd.Parameters.AddWithValue("@MembershipType", member.MembershipType);

        cmd.ExecuteNonQuery();
    }

    public static List<GymMember> GetAllMembers(SQLiteConnection conn)
    {
        List<GymMember> members = new List<GymMember>();

        string sql = "SELECT * FROM GymMembers";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            GymMember member = new GymMember(
                reader.GetString(1),
                reader.GetInt32(2),
                reader.GetString(3)
            );

            member.ID = reader.GetInt32(0);

            members.Add(member);
        }

        return members;
    }

    public static GymMember GetMember(SQLiteConnection conn, int id)
    {
        string sql = "SELECT * FROM GymMembers WHERE ID=@ID";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.Parameters.AddWithValue("@ID", id);

        SQLiteDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            GymMember member = new GymMember(
                reader.GetString(1),
                reader.GetInt32(2),
                reader.GetString(3)
            );

            member.ID = reader.GetInt32(0);

            return member;
        }

        return null;
    }

    public static void UpdateMember(SQLiteConnection conn, GymMember member)
    {
        string sql =
            @"UPDATE GymMembers
              SET Name=@Name,
                  Age=@Age,
                  MembershipType=@MembershipType
              WHERE ID=@ID;";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        cmd.Parameters.AddWithValue("@Name", member.Name);
        cmd.Parameters.AddWithValue("@Age", member.Age);
        cmd.Parameters.AddWithValue("@MembershipType", member.MembershipType);
        cmd.Parameters.AddWithValue("@ID", member.ID);

        cmd.ExecuteNonQuery();
    }

    public static void DeleteMember(SQLiteConnection conn, int id)
    {
        string sql = "DELETE FROM GymMembers WHERE ID=@ID";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.Parameters.AddWithValue("@ID", id);

        cmd.ExecuteNonQuery();
    }
}

