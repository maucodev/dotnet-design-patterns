using System;
using AbstractFactory.BasicExample.Widgets;

namespace AbstractFactory.BasicExample.MaterialDesign;

/// <summary>
/// A Material design button implementation.
/// </summary>
public class MaterialButton : IButton
{
    /// <inheritdoc />
    public void Render()
    {
        Console.WriteLine("Material Button");
    }
}