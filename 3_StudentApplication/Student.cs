namespace StudentApplication;

public class Students
{
    /*
    private string? name;
    */
    private int age;
    
    //private string? career;
    public string? Name;

    //by setting "static" no need to set variable in new() 
    public static int TotalStudents = 0;

    public Students(string? name, int age)
    {
        Name = name;
        Age = age;
        TotalStudents++;
    }

    /*
    //By using get set to "Encapsulation" to prodect data
    public string? Name
    {
        get {return name;}
        set {name =value;}
    }
    */
    public int Age
    {
        get {return age;}
        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }
    
    /*
    public string? Career
    { 
        get {return career;}
        set {career = value;}
    }
    */
    /*
    //class with constructor
        public Students(string name, int age, string career)
    {
        Name = name;
        Age = age;
        Career = career;
    }
    */

    /*default(預設) constructor
    public Students()
    {
        Name = "Unknown";
        Age = 0;
    }
    */

    //Class with methods
    public void PrintSummary()
    {
        Console.WriteLine($"Student : {Name} - Age :{Age}");
    }

    //Method to return vlues
    public int GetYearsToGraduate()
    {
        return 4 ;
    }

    //Methods with parameters
    public void CelebrateBirthday(int years)
    {
        //input age from student1, and int year from method
        Age += years;
        Console.WriteLine($"Happy Birthday{Name}! You are now {Age}.");
    }

    public static void ShowMessage()
    {
        Console.WriteLine("Welcome to the student system!");
        Console.WriteLine();
    }
}

public class Courses
{
    public string? Name ;
    public int Credits;
    public string? Teacher ;

    public static int TotalCourses = 0;

    public Courses(string? name, int credits)
    {
        Name = name;
        Credits = credits;
        TotalCourses++;
    }
}

public class Books
{
    public string? Title;
    public string? Author;
    public int Pages;

}

public class Products
{
    public string? Name;
    public int Price;
    public int Stock;

    public Products (string? name, int price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
}

public class Person
{
    private string? name;
    private int age;

    public string? Name
    {
        get {return name;}
        set {name = value;}
    }
    public int Age
    {
        get {return age;}
        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }
}