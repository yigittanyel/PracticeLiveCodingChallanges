namespace StackImplementation;

internal class StackImplementation<T>
{
    private List<T> elements;

    internal StackImplementation()
    {
        elements = new List<T>();
    }

    internal void Push(T element)
    {
        elements.Add(element);
    }

    internal T Pop()
    {
           if (elements.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T element = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return element;
    }

    internal T Peek()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return elements[elements.Count - 1];
    }
}
