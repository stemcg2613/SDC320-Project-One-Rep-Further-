/*******************************************************************
* Name: Steven McGraw
* Date: 05/25/2026
* Assignment: SDC320 Course Project Week 2
*
* Represents a gym member in the One Rep Further application.
* This class demonstrates composition by containing Membership
* and WorkoutTracker objects.
*/

using System;
using System.Collections.Generic;

public class GymMember
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string FitnessGoal { get; set; }

    public Membership MemberMembership { get; set; }
    public WorkoutTracker Tracker { get; set; }
    public List<Workout> Workouts { get; set; }

    public GymMember(
        string name,
        int age,
        string fitnessGoal,
        Membership memberMembership,
        WorkoutTracker tracker)
    {
        Name = name;
        Age = age;
        FitnessGoal = fitnessGoal;
        MemberMembership = memberMembership;
        Tracker = tracker;
        Workouts = new List<Workout>();
    }

    public void AddWorkout(Workout workout)
    {
        Workouts.Add(workout);
    }

    public void DisplayWorkouts()
    {
        Console.WriteLine("Assigned Workouts:");

        foreach (Workout workout in Workouts)
        {
            Console.WriteLine(workout.ToString());
            Console.WriteLine();
        }
    }

    public override string ToString()
    {
        return string.Format(
            "Gym Member Information\nName: {0}\nAge: {1}\nFitness Goal: {2}\n\n{3}\n\n{4}",
            Name,
            Age,
            FitnessGoal,
            MemberMembership.ToString(),
            Tracker.ToString());
    }
}