//Q3

using AssignmentDay3.DataModel;

namespace AssignmentDay3.Repository;

public interface IRepository<T> where T : Entity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        if (item == null) throw new ArgumentNullException(nameof(item));
        items.Add(item);
    }

    public void Remove(T item)
    {
        if (item == null || !items.Contains(item))
            throw new InvalidOperationException("Item not found in the repository.");
        items.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Changes saved successfully.");
    }

    public IEnumerable<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        return items.FirstOrDefault(item => item.Id == id);
    }
}