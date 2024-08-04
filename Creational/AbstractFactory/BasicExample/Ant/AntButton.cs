using System;
using AbstractFactory.BasicExample.Widgets;

namespace AbstractFactory.BasicExample.Ant;

/// <summary>
/// An Ant design button implementation.
/// </summary>
public class AntButton : IButton
{
    /// <inheritdoc />
    public void Render()
    {
        Console.WriteLine("Ant Button");
    }
}