/*******************************************************************
* Name: Steven McGraw
* Date: June 7, 2026
* Assignment: One Rep Further - Database Implementation
*
* Main application class for the One Rep Further fitness tracker.
*******************************************************************/

using System;
using System.Collections.Generic;
using System.Data.SQLite;

public class Program
{
    public static void Main(string[] args)
    {
        const string dbName = "OneRepFurther.db";

        SQLiteConnection conn = SQLiteDatabase.Connect(dbName);

        GymMemberDB.CreateTable(conn);
        WorkoutDB.CreateTable(conn);

        Console.WriteLine("====================================");
        Console.WriteLine("One Rep Further Fitness Tracker");
        Console.WriteLine("Steven McGraw - Week 4 Database Project");
        Console.WriteLine("====================================");

        Console.WriteLine("\nWelcome!");
        Console.WriteLine("Use the menu below to manage gym members and workouts.");
        Console.WriteLine("You can add, view, update, and delete records stored");
        Console.WriteLine("in the SQLite database.");

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nOne Rep Further Fitness Tracker");
            Console.WriteLine("1. Add Gym Member");
            Console.WriteLine("2. View Gym Members");
            Console.WriteLine("3. Add Workout");
            Console.WriteLine("4. View Workouts");
            Console.WriteLine("5. Update Gym Member");
            Console.WriteLine("6. Delete Gym Member");
            Console.WriteLine("7. Delete Workout");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGymMember(conn);
                    break;
                case "2":
                    ViewGymMembers(conn);
                    break;
                case "3":
                    AddWorkout(conn);
                    break;
                case "4":
                    ViewWorkouts(conn);
                    break;
                case "5":
                    UpdateGymMember(conn);
                    break;
                case "6":
                    DeleteGymMember(conn);
                    break;
                case "7":
                    DeleteWorkout(conn);
                    break;
                case "8":
                    running = false;
                    Console.WriteLine("Exiting One Rep Further. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        conn.Close();
    }

    private static void AddGymMember(SQLiteConnection conn)
    {
        Console.Write("Enter member name: ");
        string name = Console.ReadLine();

        Console.Write("Enter member age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter membership type: ");
        string membershipType = Console.ReadLine();

        GymMember member = new GymMember(name, age, membershipType);
        GymMemberDB.AddMember(conn, member);

        Console.WriteLine("Gym member added successfully.");
    }

    private static void ViewGymMembers(SQLiteConnection conn)
    {
        List<GymMember> members = GymMemberDB.GetAllMembers(conn);

        Console.WriteLine("\nGym Members");

        foreach (GymMember member in members)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(member);
        }
    }

    private static void AddWorkout(SQLiteConnection conn)
    {
        Console.Write("Enter member ID: ");
        int memberId = int.Parse(Console.ReadLine());

        GymMember member = GymMemberDB.GetMember(conn, memberId);

        if (member == null)
        {
            Console.WriteLine("Member not found.");
            return;
        }

        Console.Write("Enter workout name: ");
        string workoutName = Console.ReadLine();

        Console.Write("Enter duration in minutes: ");
        int duration = int.Parse(Console.ReadLine());

        Console.Write("Enter calories burned: ");
        int caloriesBurned = int.Parse(Console.ReadLine());

        Console.Write("Enter workout type: ");
        string workoutType = Console.ReadLine();

        Workout workout = new Workout(workoutName, duration, caloriesBurned, workoutType);
        WorkoutDB.AddWorkout(conn, memberId, workout);

        Console.WriteLine("Workout added successfully.");
    }

    private static void ViewWorkouts(SQLiteConnection conn)
    {
        List<Workout> workouts = WorkoutDB.GetAllWorkouts(conn);

        Console.WriteLine("\nWorkouts");

        foreach (Workout workout in workouts)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Workout ID: " + workout.ID);
            Console.WriteLine("Member ID: " + workout.MemberID);
            Console.WriteLine("Workout Name: " + workout.WorkoutName);
            Console.WriteLine("Duration: " + workout.Duration + " minutes");
            Console.WriteLine("Calories Burned: " + workout.CaloriesBurned);
            Console.WriteLine("Workout Type: " + workout.WorkoutType);
        }
    }

    private static void UpdateGymMember(SQLiteConnection conn)
    {
        Console.Write("Enter member ID to update: ");
        int id = int.Parse(Console.ReadLine());

        GymMember member = GymMemberDB.GetMember(conn, id);

        if (member == null)
        {
            Console.WriteLine("Member not found.");
            return;
        }

        Console.Write("Enter updated name: ");
        string name = Console.ReadLine();

        Console.Write("Enter updated age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter updated membership type: ");
        string membershipType = Console.ReadLine();

        member.Name = name;
        member.Age = age;
        member.MembershipType = membershipType;

        GymMemberDB.UpdateMember(conn, member);

        Console.WriteLine("Gym member updated successfully.");
    }

    private static void DeleteGymMember(SQLiteConnection conn)
    {
        Console.Write("Enter member ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        GymMemberDB.DeleteMember(conn, id);

        Console.WriteLine("Gym member deleted successfully.");
    }

    private static void DeleteWorkout(SQLiteConnection conn)
    {
        Console.Write("Enter workout ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        WorkoutDB.DeleteWorkout(conn, id);

        Console.WriteLine("Workout deleted successfully.");
    }
}