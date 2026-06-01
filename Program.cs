/*******************************************************************
* Name: Steven McGraw
* Date: 05/31/2026
* Assignment: SDC320 Course Project Week 3
*
* Main application file for the One Rep Further project.
* This program demonstrates class implementation, inheritance,
* abstraction, polymorphism, composition, constructors,
* access specifiers, and interface usage.
*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Steven McGraw");
        Console.WriteLine("One Rep Further");
        Console.WriteLine("SDC320 Course Project Week 3");
        Console.WriteLine();

        Console.WriteLine("Welcome to One Rep Further!");
        Console.WriteLine("This version demonstrates the main class structure for the project.");
        Console.WriteLine();

        Membership membership = new Membership(
            "Premium",
            "05/31/2026",
            true);

        WorkoutTracker tracker = new WorkoutTracker(
            3,
            750);

        GymMember gymMember = new GymMember(
            "Steven McGraw",
            36,
            "Build strength and stay consistent",
            membership,
            tracker);

        CardioWorkout cardio = new CardioWorkout(
            "Treadmill Run",
            30,
            "Moderate",
            250,
            2.5);

        StrengthWorkout strength = new StrengthWorkout(
            "Bench Press",
            45,
            "Hard",
            350,
            135.0,
            10);

        gymMember.AddWorkout(cardio);
        gymMember.AddWorkout(strength);

        Member member = new Member(
            1,
            "Steven",
            "McGraw",
            "steven@example.com",
            "Premium",
            240.0,
            "Strength training and consistency");

        Employee employee = new Employee(
            2,
            "Alex",
            "Trainer",
            "alex.trainer@example.com",
            "Personal Trainer",
            25.50);

        WorkoutPlan workoutPlan = new WorkoutPlan(
            101,
            "Upper Body Strength",
            "Intermediate",
            45);

        Console.WriteLine("Gym Member Composition Example");
        Console.WriteLine(gymMember);
        Console.WriteLine();

        Console.WriteLine("Workout List Using Polymorphism");

        List<Workout> workouts = new List<Workout>();
        workouts.Add(cardio);
        workouts.Add(strength);

        foreach (Workout workout in workouts)
        {
            PrintWorkoutInfo(workout);
            Console.WriteLine();
        }

        Console.WriteLine("User List Using Polymorphism");

        List<User> users = new List<User>();
        users.Add(member);
        users.Add(employee);

        foreach (User user in users)
        {
            PrintUserInfo(user);
            Console.WriteLine();
        }

        Console.WriteLine("Interface Demonstration");

        ITrackable trackable = tracker;
        trackable.AddWorkoutSession();
        trackable.ViewProgress();

        Console.WriteLine();

        Console.WriteLine("Workout Plan Information");
        Console.WriteLine(workoutPlan.DisplayWorkout());
        Console.WriteLine();

        Console.WriteLine("Employee Actions");
        Console.WriteLine(employee.CreateWorkoutPlan());
        Console.WriteLine(employee.ManageMembership());
    }

    private static void PrintWorkoutInfo(Workout workout)
    {
        Console.WriteLine(workout.ToString());
    }

    private static void PrintUserInfo(User user)
    {
        Console.WriteLine(user.ToString());
    }
}