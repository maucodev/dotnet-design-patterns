using AbstractFactory.WeightLossApp.Abstractions;

namespace AbstractFactory.WeightLossApp.WeightLossPlan;

/// <summary>
/// Represents a meal plan designed for weight loss.
/// </summary>
public class WeighLossMeal : IMealPlan
{
    /// <inheritdoc />
    public override string ToString()
    {
        return "Weigh Loss Meal";
    }
}