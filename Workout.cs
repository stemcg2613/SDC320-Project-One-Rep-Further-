/*******************************************************************
* Name: Steven McGraw
* Date: 05/25/2026
* Assignment: SDC320 Course Project Week 2
*
* Base class for all workout types.
*/

public class Workout
{
    public string WorkoutName { get; set; }
    public int DurationMinutes { get; set; }
    public string DifficultyLevel { get; set; }

    public Workout(string workoutName, int durationMinutes, string difficultyLevel)
    {
        WorkoutName = workoutName;
        DurationMinutes = durationMinutes;
        DifficultyLevel = difficultyLevel;
    }

    public virtual string GetWorkoutInfo()
    {
        return ToString();
    }

    public override string ToString()
    {
        return string.Format(
            "Workout Name: {0}\nDuration: {1} minutes\nDifficulty: {2}",
            WorkoutName,
            DurationMinutes,
            DifficultyLevel);
    }
}