//Q3
// custom generic list class.
namespace AssignmentDay3.Repository
{
    public class MyList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T element)
        {
            items.Add(element);
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= items.Count)
                throw new IndexOutOfRangeException("Invalid index");

            T removedItem = items[index];
            items.RemoveAt(index);
            return removedItem;
        }

        public bool Contains(T element)
        {
            return items.Contains(element);
        }

        public void Clear()
        {
            items.Clear();
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > items.Count)
                throw new IndexOutOfRangeException("Invalid index");

            items.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index >= items.Count)
                throw new IndexOutOfRangeException("Invalid index");

            items.RemoveAt(index);
        }

        public T Find(int index)
        {
            if (index < 0 || index >= items.Count)
                throw new IndexOutOfRangeException("Invalid index");

            return items[index];
        }

        public int FindCount()
        {
            return items.Count;
        }
    }
}
