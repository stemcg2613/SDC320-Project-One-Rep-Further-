/*******************************************************************
* Name: Steven McGraw
* Date: 05/25/2026
* Assignment: SDC320 Course Project Week 2
*
* Represents a cardio workout.
*/

public class CardioWorkout : Workout
{
    public int CaloriesBurned { get; set; }
    public double DistanceMiles { get; set; }

    public CardioWorkout(
        string workoutName,
        int durationMinutes,
        string difficultyLevel,
        int caloriesBurned,
        double distanceMiles)
        : base(workoutName, durationMinutes, difficultyLevel)
    {
        CaloriesBurned = caloriesBurned;
        DistanceMiles = distanceMiles;
    }

    public override string ToString()
    {
        return string.Format(
            "{0}\nCalories Burned: {1}\nDistance: {2} miles",
            base.ToString(),
            CaloriesBurned,
            DistanceMiles);
    }
}