using System;
//Q3

namespace AssignmentDay3.Repository
{
    public class MyListRepository<T>
    {
        private MyList<T> myList = new MyList<T>();

        public void Add(T element)
        {
            myList.Add(element);
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= myList.FindCount())
                throw new IndexOutOfRangeException("Invalid index");
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
            if (index < 0 || index > myList.FindCount())
                throw new IndexOutOfRangeException("Invalid index");
            myList.InsertAt(element, index);
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index >= myList.FindCount())
                throw new IndexOutOfRangeException("Invalid index");
            myList.DeleteAt(index);
        }

        public T Find(int index)
        {
            if (index < 0 || index >= myList.FindCount())
                throw new IndexOutOfRangeException("Invalid index");
            return myList.Find(index);
        }
    }
}