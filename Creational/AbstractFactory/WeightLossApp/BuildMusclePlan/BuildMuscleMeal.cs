using AbstractFactory.WeightLossApp.Abstractions;

namespace AbstractFactory.WeightLossApp.BuildMusclePlan;

/// <summary>
/// Represents a meal plan designed for building muscle.
/// </summary>
public class BuildMuscleMeal : IMealPlan
{
    /// <inheritdoc />
    public override string ToString()
    {
        return "Build Muscle Meal";
    }
}