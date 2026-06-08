/*******************************************************************
* Name: Steven McGraw
* Date: June 7, 2026
* Assignment: SDC320 Course Project - Database Implementation
*
* Handles all database operations for workout records.
*******************************************************************/

using System.Collections.Generic;
using System.Data.SQLite;

public class WorkoutDB
{
    public static void CreateTable(SQLiteConnection conn)
    {
        string sql =
            @"CREATE TABLE IF NOT EXISTS Workouts(
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                MemberID INTEGER,
                WorkoutName TEXT,
                Duration INTEGER,
                CaloriesBurned INTEGER,
                WorkoutType TEXT
            );";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void AddWorkout(SQLiteConnection conn, int memberId, Workout workout)
    {
        string sql =
            @"INSERT INTO Workouts(MemberID, WorkoutName, Duration, CaloriesBurned, WorkoutType)
              VALUES(@MemberID,@WorkoutName,@Duration,@CaloriesBurned,@WorkoutType);";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        cmd.Parameters.AddWithValue("@MemberID", memberId);
        cmd.Parameters.AddWithValue("@WorkoutName", workout.WorkoutName);
        cmd.Parameters.AddWithValue("@Duration", workout.Duration);
        cmd.Parameters.AddWithValue("@CaloriesBurned", workout.CaloriesBurned);
        cmd.Parameters.AddWithValue("@WorkoutType", workout.WorkoutType);

        cmd.ExecuteNonQuery();
    }

    public static List<Workout> GetAllWorkouts(SQLiteConnection conn)
    {
        List<Workout> workouts = new List<Workout>();

        string sql = "SELECT * FROM Workouts";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Workout workout = new Workout(
                reader.GetString(2),
                reader.GetInt32(3),
                reader.GetInt32(4),
                reader.GetString(5)
            );

            workout.ID = reader.GetInt32(0);
            workout.MemberID = reader.GetInt32(1);

            workouts.Add(workout);
        }

        return workouts;
    }

    public static void DeleteWorkout(SQLiteConnection conn, int id)
    {
        string sql = "DELETE FROM Workouts WHERE ID=@ID";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.Parameters.AddWithValue("@ID", id);

        cmd.ExecuteNonQuery();
    }
}