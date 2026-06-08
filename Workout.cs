/*******************************************************************
* Name: Steven McGraw
* Date: June 7, 2026
* Assignment: SDC320 Course Project - Database Implementation
*
* Class that represents a workout record for One Rep Further.
*******************************************************************/

public class Workout
{
    public int ID { get; set; }
    public int MemberID { get; set; }
    public string WorkoutName { get; set; }
    public int Duration { get; set; }
    public int CaloriesBurned { get; set; }
    public string WorkoutType { get; set; }

    public Workout(string workoutName, int duration, int caloriesBurned, string workoutType)
    {
        WorkoutName = workoutName;
        Duration = duration;
        CaloriesBurned = caloriesBurned;
        WorkoutType = workoutType;
    }
}