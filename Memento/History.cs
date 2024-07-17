using System.Collections.Generic;

namespace Memento;

/// <summary>
/// The 'Caretaker' class, which is responsible for keeping the mementos.
/// </summary>
public class History
{
    private readonly Stack<EditorState> _states = new();

    /// <summary>
    /// Pushes a new memento onto the stack.
    /// </summary>
    /// <param name="state">The <see cref="EditorState"/> to push.</param>
    public void Push(EditorState state)
    {
        _states.Push(state);
    }

    /// <summary>
    /// Pops the most recent memento from the stack.
    /// </summary>
    /// <returns>The most recent <see cref="EditorState"/>.</returns>
    public EditorState Pop()
    {
        return _states.Pop();
    }
}