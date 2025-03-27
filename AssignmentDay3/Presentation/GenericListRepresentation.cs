using AssignmentDay3.Repository;
//Q3

namespace AssignmentDay3.Presentation
{
    public class ManageMyListTwo
    {
        private MyListRepository<int> myListRepository = new MyListRepository<int>();
        //private ListRepository<int> myListRepository = new ListRepository<int>();


        public void Run()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. Check Contains");
                Console.WriteLine("4. Clear");
                Console.WriteLine("5. Insert At");
                Console.WriteLine("6. Delete At");
                Console.WriteLine("7. Find");
                Console.WriteLine("8. Exit");
                Console.Write("\nEnter your choice: ");
                
                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 8)
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
                }

                if (choice == 8) break;

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter value to add: ");
                            int value = Convert.ToInt32(Console.ReadLine());
                            myListRepository.Add(value);
                            Console.WriteLine("Value added.");
                            break;
                        case 2:
                            Console.Write("Enter index to remove: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Removed: " + myListRepository.Remove(index));
                            break;
                        case 3:
                            Console.Write("Enter value to check: ");
                            int check = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(myListRepository.Contains(check) ? "Exists" : "Does not exist");
                            break;
                        case 4:
                            myListRepository.Clear();
                            Console.WriteLine("List cleared.");
                            break;
                        case 5:
                            Console.Write("Enter value to insert: ");
                            int insertValue = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter index: ");
                            int insertIndex = Convert.ToInt32(Console.ReadLine());
                            myListRepository.InsertAt(insertValue, insertIndex);
                            Console.WriteLine("Value inserted.");
                            break;
                        case 6:
                            Console.Write("Enter index to delete: ");
                            int deleteIndex = Convert.ToInt32(Console.ReadLine());
                            myListRepository.DeleteAt(deleteIndex);
                            Console.WriteLine("Value deleted.");
                            break;
                        case 7:
                            Console.Write("Enter index to find: ");
                            int findIndex = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Found: " + myListRepository.Find(findIndex));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
