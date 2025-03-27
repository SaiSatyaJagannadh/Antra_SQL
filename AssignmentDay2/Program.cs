
//oops 
//1

/*Vehicle myCar = new Car("Toyota", 80);
Vehicle myBike = new Bike("Yamaha");

myCar.Start();  // Calls Car's overridden method
myBike.Start(); // Calls Bike's overridden method*/

//2 to 5
/*Person student = new Student("Alice", 20, "S12345");
Person instructor = new Instructor("Dr. Smith", 45, 75000);

student.DisplayInfo();  // Calls Student's overridden method
instructor.DisplayInfo(); // Calls Instructor's overridden method*/

//Question 6


// Creating Department


Department csDepartment = new Department("Computer Science", 500000, new DateTime(2024, 1, 1), new DateTime(2024, 12, 31));

// Creating Instructor
Instructor profJohn = new Instructor("Dr. John", new DateTime(1975, 5, 20), 90000, new DateTime(2000, 8, 15));
csDepartment.SetHead(profJohn);

// Creating Students
Student alice = new Student("Alice", new DateTime(2003, 6, 15));
Student bob = new Student("Bob", new DateTime(2002, 9, 22));

// Creating Courses
Course math101 = new Course("Math 101");
Course cs101 = new Course("CS 101");

// Adding Courses to Department
csDepartment.AddCourse(math101);
csDepartment.AddCourse(cs101);

// Enrolling Students in Courses
alice.EnrollInCourse(math101, 'A');
alice.EnrollInCourse(cs101, 'B');
bob.EnrollInCourse(cs101, 'C');

// Displaying Information
Console.WriteLine($"Department: {csDepartment.DepartmentName}, Budget: ${csDepartment.Budget}");
Console.WriteLine($"Head of Department: {csDepartment.Head.Name}");

Console.WriteLine($"Instructor: {profJohn.Name}, Base Salary: ${profJohn.GetSalary()}, Bonus Salary: ${profJohn.CalculateBonusSalary()}");

Console.WriteLine($"Student: {alice.Name}, Age: {alice.CalculateAge()}, GPA: {alice.CalculateGPA()}");
Console.WriteLine($"Student: {bob.Name}, Age: {bob.CalculateAge()}, GPA: {bob.CalculateGPA()}");

Console.WriteLine($"Courses in {csDepartment.DepartmentName}:");
foreach (var course in new List<Course> { math101, cs101 })
{
    Console.WriteLine($"- {course.CourseName}, Enrolled Students: {course.GetEnrolledStudents().Count}");
}
 

//Question 7

// Creating Color objects
Color redColor = new Color(255, 0, 0);
Color blueColor = new Color(0, 0, 255);
        
// Creating Ball objects
Ball ball1 = new Ball(10, redColor);
Ball ball2 = new Ball(15, blueColor);

// Throwing balls
ball1.Throw();
ball1.Throw();
ball2.Throw();

Console.WriteLine($"Ball 1 throw count: {ball1.GetThrowCount()}");
Console.WriteLine($"Ball 2 throw count: {ball2.GetThrowCount()}");

// Popping ball1 and trying to throw it again
ball1.Pop();
ball1.Throw(); // This should not increase count

Console.WriteLine($"Ball 1 throw count after popping: {ball1.GetThrowCount()}");



//Method
//Q1
class Program1
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(10); // Generate an array of 10 numbers
        Console.WriteLine("Original Array:");
        PrintNumbers(numbers); // Print the original array
        
        Reverse(numbers); // Reverse the array
        
        Console.WriteLine("Reversed Array:");
        PrintNumbers(numbers); // Print the reversed array
    }

    // Method to generate an array of given length
    static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1; // Fill array with 1, 2, 3, ..., length
        }
        return numbers;
    }

    // Method to reverse the array in place
    static void Reverse(int[] numbers)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            // Swap numbers[left] and numbers[right]
            int temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;

            left++;
            right--;
        }
    }

    // Method to print the array
    static void PrintNumbers(int[] numbers)
    {
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine(); // Print new line
    }
}


//Q2

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("First 10 Fibonacci Numbers:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
        Console.WriteLine();
    }

    // Recursive method to calculate Fibonacci number
    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
            return 1; // Base case: First and second Fibonacci numbers are 1
        
        return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive case
    }
}


