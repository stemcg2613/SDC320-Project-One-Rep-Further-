/*******************************************************************
* Name: Steven McGraw
* Date: 05/25/2026
* Assignment: SDC320 Course Project Week 2
*
* Main application file for the One Rep Further project.
* This program demonstrates inheritance, polymorphism, composition,
* and interface usage.
*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Steven McGraw");
        Console.WriteLine("One Rep Further");
        Console.WriteLine("SDC320 Course Project Week 2");
        Console.WriteLine();

        Console.WriteLine("Welcome to One Rep Further!");
        Console.WriteLine("This app helps gym members track workouts, memberships, and progress.");
        Console.WriteLine();

        Membership membership = new Membership(
            "Premium",
            "05/25/2026",
            true);

        WorkoutTracker tracker = new WorkoutTracker(
            3,
            750);

        GymMember member = new GymMember(
            "Steven McGraw",
            36,
            "Build strength and stay consistent",
            membership,
            tracker);

        // CardioWorkout
        CardioWorkout cardio = new CardioWorkout(
            "Treadmill Run",
            30,
            "Moderate",
            250,
            2.5);

        // StrengthWorkout
        StrengthWorkout strength = new StrengthWorkout(
    "Bench Press",
    45,
    "Hard",
    350,
    135.0,
    10);

        member.AddWorkout(cardio);
        member.AddWorkout(strength);

        Console.WriteLine("Member Details");
        Console.WriteLine(member.ToString());
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

        Console.WriteLine("Interface Demonstration");

        ITrackable trackable = tracker;

        trackable.AddWorkoutSession();
        trackable.ViewProgress();

        Console.WriteLine();

        Console.WriteLine("Composition Demonstration");
        Console.WriteLine(
            "The GymMember object contains a Membership object, " +
            "a WorkoutTracker object, and a list of Workout objects.");
    }

    private static void PrintWorkoutInfo(Workout workout)
    {
        Console.WriteLine(workout.ToString());
    }
}