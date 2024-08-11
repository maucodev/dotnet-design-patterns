using AbstractFactory.WeightLossApp.Abstractions;

namespace AbstractFactory.WeightLossApp.WeightLossPlan;

/// <summary>
/// Represents a workout plan designed for weight loss.
/// </summary>
public class WeightLossWorkout : IWorkoutPlan
{
    /// <inheritdoc />
    public override string ToString()
    {
        return "Weight Loss Workout";
    }
}