using System.Collections.Generic;

namespace Memento;

/// <summary>
/// The 'Caretaker' class, which is responsible for keeping the mementos.
/// </summary>
public class History
{
    private readonly Stack<DocumentState> _states = new();

    /// <summary>
    /// Pushes a new memento onto the stack.
    /// </summary>
    /// <param name="state">The <see cref="DocumentState"/> to push.</param>
    public void Push(DocumentState state)
    {
        _states.Push(state);
    }

    /// <summary>
    /// Pops the most recent memento from the stack.
    /// </summary>
    /// <returns>The most recent <see cref="DocumentState"/>.</returns>
    public DocumentState Pop()
    {
        return _states.Count == 0 
            ? null 
            : _states.Pop();
    }
}