using System;
using System.Collections.Generic;

namespace Decorator.EditorExample;

/// <summary>
/// Represents an editor that can open projects and manage artefacts.
/// </summary>
public class Editor
{
    /// <summary>
    /// Opens a project and decorates the artefacts within it.
    /// </summary>
    /// <param name="path">The path to the project to open.</param>
    public void OpenProject(string path)
    {
        var artefacts = new List<AbstractArtefact>
        {
            new Artefact("Main"),
            new Artefact("Demo"),
            new Artefact("EmailClient"),
            new Artefact("EmailProvider")
        };

        artefacts[0] = new ErrorDecorator(new MainDecorator(artefacts[0]));
        artefacts[2] = new ErrorDecorator(artefacts[2]);

        foreach (var artefact in artefacts)
        {
            Console.WriteLine(artefact.Render());
        }
    }
}