/*******************************************************************
* Name: Steven McGraw
* Date: June 7, 2026
* Assignment: One Rep Further - Database Implementation
*
* Represents a cardio workout.
*******************************************************************/

public class CardioWorkout : Workout
{
    public CardioWorkout(
        string workoutName,
        int duration,
        int caloriesBurned)
        : base(workoutName, duration, caloriesBurned, "Cardio")
    {
    }
}