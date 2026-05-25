/*******************************************************************
* Name: Steven McGraw
* Date: 05/25/2026
* Assignment: SDC320 Course Project Week 2
*
* Represents a strength training workout.
*/

public class StrengthWorkout : Workout
{
    public int CaloriesBurned { get; set; }
    public double WeightUsed { get; set; }
    public int Reps { get; set; }

    public StrengthWorkout(
        string workoutName,
        int durationMinutes,
        string difficultyLevel,
        int caloriesBurned,
        double weightUsed,
        int reps)
        : base(workoutName, durationMinutes, difficultyLevel)
    {
        CaloriesBurned = caloriesBurned;
        WeightUsed = weightUsed;
        Reps = reps;
    }

    public override string ToString()
    {
        return string.Format(
            "{0}\nCalories Burned: {1}\nWeight Used: {2}\nReps: {3}",
            base.ToString(),
            CaloriesBurned,
            WeightUsed,
            Reps);
    }
}