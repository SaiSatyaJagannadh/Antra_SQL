//Q2

using AssignmentDay3.DataModel;


namespace AssignmentDay3.Repository
{
    public class ListRepository<T>
    {
        private MyList<T> myList = new MyList<T>();

        public void Add(T element)
        {
            myList.Add(element);
        }
        
        

        public T Remove(int index)
        {
            return myList.Remove(index);
        }

        public bool Contains(T element)
        {
            return myList.Contains(element);
        }

        public void Clear()
        {
            myList.Clear();
        }

        public void InsertAt(T element, int index)
        {
            myList.InsertAt(element, index);
        }

        public void DeleteAt(int index)
        {
            myList.DeleteAt(index);
        }

        public T Find(int index)
        {
            return myList.Find(index);
        }
    }
}