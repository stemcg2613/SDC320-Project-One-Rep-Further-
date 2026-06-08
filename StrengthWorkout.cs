/*******************************************************************
* Name: Steven McGraw
* Date: June 7, 2026
* Assignment: One Rep Further - Database Implementation
*
* Represents a strength workout.
*******************************************************************/

public class StrengthWorkout : Workout
{
    public StrengthWorkout(
        string workoutName,
        int duration,
        int caloriesBurned)
        : base(workoutName, duration, caloriesBurned, "Strength")
    {
    }
}