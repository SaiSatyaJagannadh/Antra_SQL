// Working with methods

//Implemented direcly in program class for method questions

//oops-- Designing and Building Classes using object-oriented principles

//Question1:---------------->

// Abstraction: Creating an abstract class with an abstract method
abstract class Vehicle
{
    public string Brand { get; set; }
    
    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public abstract void Start();  // Abstract method (must be implemented by derived classes)
}

// Encapsulation: Using private fields and public properties
class Car : Vehicle
{
    private int speed;  // Private field

    public int Speed    // Public property
    {
        get { return speed; }
        set
        {
            if (value >= 0)
                speed = value;
        }
    }

    public Car(string brand, int speed) : base(brand)
    {
        Speed = speed;
    }

    // Polymorphism: Overriding the Start method
    public override void Start()
    {
        Console.WriteLine($"The {Brand} car starts at speed {Speed} km/h.");
    }
}

// Inheritance: Bike inherits from Vehicle
class Bike : Vehicle
{
    public Bike(string brand) : base(brand) { }

    // Polymorphism: Overriding the Start method
    public override void Start()
    {
        Console.WriteLine($"The {Brand} bike starts smoothly.");
    }
}

//Question2 to 5:-------->



// Abstraction: Defining an abstract class Person with common properties
/*abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void DisplayInfo(); // Abstract method to be implemented by derived classes
}

// Inheritance: Student inherits from Person
class Student : Person
{
    private string _studentId; // Encapsulation: Private field

    public string StudentId  // Encapsulation: Public property
    {
        get { return _studentId; }
        private set { _studentId = value; } // Only accessible within the class
    }

    public Student(string name, int age, string studentId) : base(name, age)
    {
        StudentId = studentId;
    }

    // Polymorphism: Overriding DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}, ID: {StudentId}");
    }
}

// Inheritance: Instructor inherits from Person
class Instructor : Person
{
    private double _salary; // Encapsulation: Private field

    public double Salary  // Encapsulation: Public property
    {
        get { return _salary; }
        private set
        {
            if (value >= 0)
                _salary = value;
        }
    }

    public Instructor(string name, int age, double salary) : base(name, age)
    {
        Salary = salary;
    }

    // Polymorphism: Overriding DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Instructor Name: {Name}, Age: {Age}, Salary: ${Salary}");
    }
}*/


//question 6

// Interfaces
public interface IPersonService
{
    int CalculateAge();
    decimal GetSalary();
    List<string> GetAddresses();
}

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course, char grade);
    double CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    decimal CalculateBonusSalary();
}

public interface ICourseService
{
    void AddStudent(Student student, char grade);
    List<Student> GetEnrolledStudents();
}

public interface IDepartmentService
{
    void SetHead(Instructor instructor);
    void AddCourse(Course course);
}

// Base Person Class
public abstract class Person : IPersonService
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    private decimal salary;
    private List<string> addresses = new List<string>();

    public Person(string name, DateTime dob, decimal salary)
    {
        Name = name;
        DateOfBirth = dob;
        Salary = salary;
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0) throw new ArgumentException("Salary cannot be negative.");
            salary = value;
        }
    }

    public decimal GetSalary()
    {
        return Salary;
    }

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return new List<string>(addresses);
    }
}

// Student Class
public class Student : Person, IStudentService
{
    private Dictionary<Course, char> courses = new Dictionary<Course, char>();

    public Student(string name, DateTime dob) : base(name, dob, 0) { }

    public void EnrollInCourse(Course course, char grade)
    {
        courses[course] = grade;
        course.AddStudent(this, grade);
    }

    public double CalculateGPA()
    {
        if (courses.Count == 0) return 0.0;

        Dictionary<char, double> gradePoints = new Dictionary<char, double>
        {
            {'A', 4.0}, {'B', 3.0}, {'C', 2.0}, {'D', 1.0}, {'F', 0.0}
        };

        double totalPoints = 0;
        foreach (var entry in courses)
        {
            totalPoints += gradePoints[entry.Value];
        }

        return totalPoints / courses.Count;
    }
}

// Instructor Class
public class Instructor : Person, IInstructorService
{
    public DateTime JoinDate { get; private set; }
    public Department Department { get; set; }

    public Instructor(string name, DateTime dob, decimal salary, DateTime joinDate)
        : base(name, dob, salary)
    {
        JoinDate = joinDate;
    }

    public decimal CalculateBonusSalary()
    {
        int experience = DateTime.Now.Year - JoinDate.Year;
        return GetSalary() + (experience * 1000);
    }
}

// Course Class
public class Course : ICourseService
{
    public string CourseName { get; private set; }
    private Dictionary<Student, char> enrolledStudents = new Dictionary<Student, char>();

    public Course(string courseName)
    {
        CourseName = courseName;
    }

    public void AddStudent(Student student, char grade)
    {
        enrolledStudents[student] = grade;
    }

    public List<Student> GetEnrolledStudents()
    {
        return enrolledStudents.Keys.ToList();
    }
}

// Department Class
public class Department : IDepartmentService
{
    public string DepartmentName { get; private set; }
    public Instructor Head { get; private set; }
    public decimal Budget { get; set; }
    public DateTime SchoolYearStart { get; private set; }
    public DateTime SchoolYearEnd { get; private set; }
    private List<Course> courses = new List<Course>();

    public Department(string name, decimal budget, DateTime start, DateTime end)
    {
        DepartmentName = name;
        Budget = budget;
        SchoolYearStart = start;
        SchoolYearEnd = end;
    }

    public void SetHead(Instructor instructor)
    {
        Head = instructor;
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
}

// Question 7


class Color
{
    private int red, green, blue, alpha;

    // Constructor with all parameters
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = ValidateColorValue(red);
        this.green = ValidateColorValue(green);
        this.blue = ValidateColorValue(blue);
        this.alpha = ValidateColorValue(alpha);
    }

    // Constructor with default alpha (255)
    public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

    // Getters and Setters
    public int Red
    {
        get => red;
        set => red = ValidateColorValue(value);
    }

    public int Green
    {
        get => green;
        set => green = ValidateColorValue(value);
    }

    public int Blue
    {
        get => blue;
        set => blue = ValidateColorValue(value);
    }

    public int Alpha
    {
        get => alpha;
        set => alpha = ValidateColorValue(value);
    }

    // Grayscale calculation
    public int GetGrayscale()
    {
        return (red + green + blue) / 3;
    }

    // Ensure color values remain between 0 and 255
    private int ValidateColorValue(int value)
    {
        return Math.Max(0, Math.Min(255, value));
    }
}

class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    // Constructor
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    // Pop method - sets size to 0
    public void Pop()
    {
        size = 0;
    }

    // Throw method - only increments if not popped
    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }

    // Get throw count
    public int GetThrowCount()
    {
        return throwCount;
    }
}



