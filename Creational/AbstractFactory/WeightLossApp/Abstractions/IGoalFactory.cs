namespace AbstractFactory.WeightLossApp.Abstractions;

/// <summary>
/// Interface that defines a factory for creating workout and meal plans based on a specific goal.
/// </summary>
public interface IGoalFactory
{
    /// <summary>
    /// Creates a workout plan tailored to a specific goal.
    /// </summary>
    /// <returns>An instance of <see cref="IWorkoutPlan"/> representing the workout plan.</returns>
    public IWorkoutPlan CreateWorkoutPlan();

    /// <summary>
    /// Creates a meal plan tailored to a specific goal.
    /// </summary>
    /// <returns>An instance of <see cref="IMealPlan"/> representing the meal plan.</returns>
    public IMealPlan CreateMealPlan();
}