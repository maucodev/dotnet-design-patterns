using AbstractFactory.WeightLossApp.Abstractions;

namespace AbstractFactory.WeightLossApp.BuildMusclePlan;

/// <summary>
/// A factory that creates workout and meal plans tailored to building muscle.
/// </summary>
public class BuildMuscleFactory : IGoalFactory
{
    /// <inheritdoc />
    public IWorkoutPlan CreateWorkoutPlan()
    {
        return new BuildMuscleWorkout();
    }

    /// <inheritdoc />
    public IMealPlan CreateMealPlan()
    {
        return new BuildMuscleMeal();
    }
}