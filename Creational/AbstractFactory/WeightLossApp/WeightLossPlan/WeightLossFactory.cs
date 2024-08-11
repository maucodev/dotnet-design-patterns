using AbstractFactory.WeightLossApp.Abstractions;

namespace AbstractFactory.WeightLossApp.WeightLossPlan;

/// <summary>
/// A factory that creates workout and meal plans tailored to weight loss.
/// </summary>
public class WeightLossFactory : IGoalFactory
{
    /// <inheritdoc />
    public IWorkoutPlan CreateWorkoutPlan()
    {
        return new WeightLossWorkout();
    }

    /// <inheritdoc />
    public IMealPlan CreateMealPlan()
    {
        return new WeighLossMeal();
    }
}