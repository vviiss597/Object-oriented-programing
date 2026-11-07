namespace TeacherSystem;

public class Teacher
{
    public string? Name;
    private string? subject;
    private int yearsOfExperience;

    public Teacher(string? name, string? subject, int year)
    {
        Name = name;
        Subject = subject;
        YearsOfExperience = year;
    }

    public string? Subject
    {
        get {return subject;}
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Subject cannot be empty!");
            }
            else
            {
                subject = value;
            }
        }
    }
    public int YearsOfExperience
    {
        get {return yearsOfExperience;}
        set
        {
            if (value >=0)
            {
                yearsOfExperience = value;
            }
        }
    }

    public void ShowProfile()
    {
        Console.WriteLine($"Teacher's name: {Name}");
        Console.WriteLine($"Subject: {Subject}");
        Console.WriteLine($"Years of Experience: {YearsOfExperience}");
        Console.WriteLine("================================================");
    }



}
