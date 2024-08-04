using System;
using AbstractFactory.BasicExample.Widgets;

namespace AbstractFactory.BasicExample.Ant;

/// <summary>
/// An Ant Design text box implementation.
/// </summary>
public class AntTextBox : ITextBox
{
    /// <inheritdoc />
    public void Render()
    {
        Console.WriteLine("Ant Text Box");
    }
}