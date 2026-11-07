
using TeacherSystem;

Console.WriteLine("Teacher System");
Console.WriteLine("====================");

List<Teacher> teachers = new List<Teacher>();

teachers.Add(new Teacher("Ana", "OOP", 10));
teachers.Add(new Teacher("Li", "soft Datamining", 15));
teachers.Add(new Teacher("Ben", "Game Devolopment", 20));

foreach (Teacher teacher in teachers)
{
    teacher.ShowProfile();
}

static int ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("1. Add teachers");
    Console.WriteLine("2. Show teachers");
    Console.WriteLine("3. Count how many teachers exist");
    Console.WriteLine("4. Show the average years of experience");
    Console.WriteLine("0. Exit");

    Console.WriteLine("Choose: ");
    int youroption = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return youroption;
}

static void Add(List<Teacher> teachers)
{
    Console.WriteLine("Add new teacher : ");
    string? name = Console.ReadLine();

    Console.WriteLine("Enter Subject : ");
    string? subject = Console.ReadLine();

    Console.WriteLine("Enter years of experience : ");
    int year = int.Parse(Console.ReadLine());

    teachers.Add(new Teacher(name, subject, year));
    Console.WriteLine("Teacher added successfully!\n");
}

static void ShowTeachers(List<Teacher> teachers)
{
    foreach (Teacher teacher in teachers)
    {
        teacher.ShowProfile();
    }
}

static void CountTeachers(List<Teacher> teachers)
{
    Console.WriteLine($"Total teachers: {teachers.Count}");
}

static void ShowAverage(List<Teacher> teachers)
{
    Console.WriteLine($"Average years of experience : {teachers.Average(t => t.YearsOfExperience)}");
}

bool running =true;
while (running)
{
    int youroption = ShowMenu();
    switch (youroption)
    {
        case 1 : 
        Add(teachers);
        break;

        case 2 : 
        ShowTeachers(teachers);
        break;

        case 3 :
        CountTeachers(teachers);
        break;

        case 4 :
        ShowAverage(teachers);
        break;

        case 0 :
        Console.WriteLine("Goodbye!");
        running = false;
        break;

        default :
        Console.WriteLine("Invalid option.");
        break;
    }
}