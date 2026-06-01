/*******************************************************************
* Name: Steven McGraw
* Date: 05/31/2026
* Assignment: SDC320 Course Project Week 3
*
* Represents a workout plan assigned to a gym member.
*/

public class WorkoutPlan
{
    public int WorkoutPlanId { get; set; }
    public string WorkoutName { get; set; }
    public string DifficultyLevel { get; set; }
    public int DurationMinutes { get; set; }

    public WorkoutPlan(
        int workoutPlanId,
        string workoutName,
        string difficultyLevel,
        int durationMinutes)
    {
        WorkoutPlanId = workoutPlanId;
        WorkoutName = workoutName;
        DifficultyLevel = difficultyLevel;
        DurationMinutes = durationMinutes;
    }

    public string DisplayWorkout()
    {
        return ToString();
    }

    public override string ToString()
    {
        return
            "Workout Plan ID: " + WorkoutPlanId + "\n" +
            "Workout Name: " + WorkoutName + "\n" +
            "Difficulty Level: " + DifficultyLevel + "\n" +
            "Duration: " + DurationMinutes + " minutes";
    }
}