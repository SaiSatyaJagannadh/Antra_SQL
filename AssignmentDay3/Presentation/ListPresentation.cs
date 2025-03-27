//Q2
using AssignmentDay3.Repository;


namespace AssignmentDay3.Repository
{
    public class ManageMyList
    {
        private ListRepository<int> myListRepository = new ListRepository<int>();

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to Add");
            Console.WriteLine("Press 2 to Remove");
            Console.WriteLine("Press 3 to Check Contains");
            Console.WriteLine("Press 4 to Clear");
            Console.WriteLine("Press 5 to Insert At");
            Console.WriteLine("Press 6 to Delete At");
            Console.WriteLine("Press 7 to Find");
            Console.WriteLine("Press 8 to Exit");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 8)
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value to add: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        myListRepository.Add(value);
                        break;
                    case 2:
                        Console.Write("Enter index to remove: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        myListRepository.Remove(index);
                        break;
                    case 3:
                        Console.Write("Enter value to check: ");
                        int check = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(myListRepository.Contains(check) ? "Exists" : "Does not exist");
                        break;
                    case 4:
                        myListRepository.Clear();
                        Console.WriteLine("List cleared");
                        break;
                    case 5:
                        Console.Write("Enter value to insert: ");
                        int insertValue = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter index: ");
                        int insertIndex = Convert.ToInt32(Console.ReadLine());
                        myListRepository.InsertAt(insertValue, insertIndex);
                        break;
                    case 6:
                        Console.Write("Enter index to delete: ");
                        int deleteIndex = Convert.ToInt32(Console.ReadLine());
                        myListRepository.DeleteAt(deleteIndex);
                        break;
                    case 7:
                        Console.Write("Enter index to find: ");
                        int findIndex = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Found: " + myListRepository.Find(findIndex));
                        break;
                    default:
                        Console.WriteLine("Incorrect choice");
                        break;
                }
                Console.WriteLine("Enter choice again:");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
