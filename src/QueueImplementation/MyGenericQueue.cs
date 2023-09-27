namespace QueueImplementation;

internal class MyGenericQueue<T>
{
    private List<T> elements;

    public MyGenericQueue()
    {
        elements = new List<T>();
    }

    public void Enqueue(T element)
    {
        elements.Add(element);
    }

    public T Dequeue()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T element = elements[0];
        elements.RemoveAt(0);
        return element;
    }

    public T Peek()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return elements[0];
    }
}
