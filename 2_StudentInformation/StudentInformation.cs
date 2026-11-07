Console.WriteLine("Welcome to Student Information System!");
Console.WriteLine("================================");

List<int> grades = new List<int>();

Console.WriteLine("Press Enter after each input.");
Console.WriteLine("Press Enter on an empty line to finish");
Console.WriteLine("================================");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

//Imperative命令式
bool running = true;
while (running)
{
    if (grades.Count < 5)
    {   
        Console.WriteLine("Enter the grades of the students:");
        int grade = int.Parse(Console.ReadLine());
        if (grade < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative grade.");
        }
        else
        {   
            grades.Add(grade);
            Console.WriteLine($"You have entered {grades.Count} grades.");
            Console.WriteLine("-----------------------------------------");
        }
        
    }
    else
    {
        Console.WriteLine("===========================");
        Console.WriteLine("You have already entered 5 grades.");
        Console.WriteLine("Please press Enter to finish.");
        Console.ReadKey();
        running =false;
    }
}

//Declarative宣告式
int maxgrade = grades.Max();
int mingrade = grades.Min();
double averagegrade = grades.Average();


Console.WriteLine($"Maximum grade: {maxgrade}");
Console.WriteLine($"Minium grade: {mingrade}");
Console.WriteLine($"Average grade: {averagegrade}");