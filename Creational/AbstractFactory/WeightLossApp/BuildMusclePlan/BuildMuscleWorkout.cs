using AbstractFactory.WeightLossApp.Abstractions;

namespace AbstractFactory.WeightLossApp.BuildMusclePlan;

/// <summary>
/// Represents a workout plan designed for building muscle.
/// </summary>
public class BuildMuscleWorkout : IWorkoutPlan
{
    /// <inheritdoc />
    public override string ToString()
    {
        return "Build Muscle Workout";
    }
}