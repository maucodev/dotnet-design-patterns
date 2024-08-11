using System;
using AbstractFactory.WeightLossApp.Abstractions;

namespace AbstractFactory.WeightLossApp.App;

/// <summary>
/// Represents the home page where the user can set a fitness goal and receive a workout and meal plan.
/// </summary>
public class HomePage
{
    /// <summary>
    /// Gets the workout plan based on the user's goal.
    /// </summary>
    public IWorkoutPlan WorkoutPlan { get; private set; }

    /// <summary>
    /// Gets the meal plan based on the user's goal.
    /// </summary>
    public IMealPlan MealPlan { get; private set; }

    /// <summary>
    /// Sets the fitness goal using a specific goal factory and updates the workout and meal plans accordingly.
    /// </summary>
    /// <param name="goalFactory">The goal factory that creates workout and meal plans.</param>
    public void SetGoal(IGoalFactory goalFactory)
    {
        WorkoutPlan = goalFactory.CreateWorkoutPlan();
        MealPlan = goalFactory.CreateMealPlan();

        Console.WriteLine($"Workout plan: {WorkoutPlan}");
        Console.WriteLine($"Meal plan: {MealPlan}");
    }
}