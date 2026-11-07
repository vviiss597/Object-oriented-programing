Console.WriteLine("Student Task Manager");
Console.WriteLine("====================");

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("How many tasks do you want to complete today? ");
int taskGoal = int.Parse(Console.ReadLine());
//.Parse(Console.ReadLine());可以改物件類型
//int.TryParse()可以阻止程式崩潰

Console.Write("How many hours do you have available? ");
double availableHours = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Hello {name}!");
Console.WriteLine($"Your goal is {taskGoal} tasks.");
Console.WriteLine($"You have {availableHours} hours available.");
//$和{}是字串插值的語法，$表示字串插值，{}內的變數會被替換成其值。

Console.Write("How many tasks have you completed today? ");
int completedTasks = int.Parse(Console.ReadLine());

if (completedTasks == 0)
{
    Console.WriteLine("Time to get started!");
}
else if (completedTasks < taskGoal )
{
    Console.WriteLine("Good start. Keep going!");
}
else
{
    Console.WriteLine("Great progress!");
}

Console.WriteLine("====================");

List<string> tasks = new List<string>();
//List<T>can store multiple vaules of the same type.

tasks.Add("Review C# variables");
tasks.Add("Practice loops");
tasks.Add("Create a Console application");

//
//

void ShowTitle()
{
    Console.WriteLine();
    Console.WriteLine("Student Task Manager");
    Console.WriteLine("====================");
}

ShowTitle();

//

void ShowMessage(string message)
{
    Console.WriteLine($"[INFO] {message}");
}

ShowMessage("Application started.");
ShowMessage("Task add.");

//

int GetTaskCount(List<string> tasks)
{
    return tasks.Count;
}
//int function--need to return a value

int count = GetTaskCount(tasks);
Console.WriteLine($"You currently have {count} tasks.");

//

void ShowTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available.");
        return;
    }

    for (int i = 0 ; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i+1}. {tasks[i]}");
    }
    Console.WriteLine($"Total tasks: {tasks.Count}");
    Console.WriteLine();
}

//

void AddTask(List<string> tasks)
{
    
    const int MaxTasks = 10;

    if (tasks.Count >= MaxTasks)
    {
        Console.WriteLine("Maximum number of tasks reached.");
    }
    else
    {
        Console.WriteLine("Enter task : ");
        tasks.Add(Console.ReadLine());
        Console.WriteLine("Task added.");
    }
    
}

//
void RemoveTask(List<string> tasks)
{
    Console.WriteLine("Task to remove : ");
    int remove = int.Parse(Console.ReadLine());
    if (remove <= tasks.Count)
    {
        tasks.RemoveAt(remove -1);
        Console.WriteLine("Task removed.");
    }
    else
    {
        Console.WriteLine("Invalid task number.");
    }
}

//*****
int ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Remove task");
    Console.WriteLine("4. Show task count");
    Console.WriteLine("0. Exit");

    Console.WriteLine("Choose: ");
    int youroption = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return youroption;
}
//
    void ShowTaskCount(List<string> tasks)
    {
        int capacity = 10 - tasks.Count;
        Console.WriteLine($"You currently have {tasks.Count} tasks. ");
        Console.WriteLine($"Maximum allowed: 10");
        Console.WriteLine($"Remaining capacity: {capacity}");
        Console.WriteLine();
    }


//
//

bool running = true;
while (running)
{
    int youroption = ShowMenu();

    switch (youroption)
    {
        case 1 : 
        AddTask(tasks);
        break;

        case 2 : 
        ShowTasks(tasks);
        break;

        case 3 :
        RemoveTask(tasks);
        break;

        case 4 :
        ShowTaskCount(tasks);
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

Console.WriteLine("----------------------------");

TaskPriority priority = TaskPriority.High;
Console.WriteLine(priority);

switch (priority)
{
    case TaskPriority.Low:
        Console.WriteLine("This task can wait.");
        break;

    case TaskPriority.Medium:
        Console.WriteLine("Try to finish this task today.");
        break;

    case TaskPriority.High:
        Console.WriteLine("Prioritize this task.");
        break;
}

enum TaskPriority
{
    Low,
    Medium,
    High
}