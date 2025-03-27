
public class Stack<T>
{
    private List<T> s = new List<T>();

    public int Count()
    {
        return s.Count;
    }

    public void Push(T item)
    {
        s.Add(item);
    }

    public T Pop()
    {
        if (s.Count == 0)
            throw new InvalidOperationException("Stack is empty!");

        T item = s[s.Count - 1];
        s.RemoveAt(s.Count - 1);
        return item;
    }
}