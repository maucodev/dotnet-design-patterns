using System;
using AbstractFactory.BasicExample.Widgets;

namespace AbstractFactory.BasicExample.MaterialDesign;

/// <summary>
/// A Material design text box implementation.
/// </summary>
public class MaterialTextBox : ITextBox
{
    /// <inheritdoc />
    public void Render()
    {
        Console.WriteLine("Material Text Box");
    }
}