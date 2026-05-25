/*******************************************************************
* Name: Steven McGraw
* Date: 05/25/2026
* Assignment: SDC320 Course Project Week 2
*
* Tracks workout progress for a gym member and implements ITrackable.
*/

public class WorkoutTracker : ITrackable
{
    public int SessionsCompleted { get; set; }
    public int CaloriesBurned { get; set; }

    public WorkoutTracker()
    {
        SessionsCompleted = 0;
        CaloriesBurned = 0;
    }

    public WorkoutTracker(int sessionsCompleted, int caloriesBurned)
    {
        SessionsCompleted = sessionsCompleted;
        CaloriesBurned = caloriesBurned;
    }

    public void AddWorkoutSession()
    {
        SessionsCompleted++;
        CaloriesBurned += 250;
    }

    public void ViewProgress()
    {
        System.Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return string.Format(
            "Workout Progress\nSessions Completed: {0}\nCalories Burned: {1}",
            SessionsCompleted,
            CaloriesBurned);
    }
}