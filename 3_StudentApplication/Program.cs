using StudentApplication;
/* Before adding constructor
Students student1 = new Students();
student1.Name = "Ana";
student1.Age = 20;
student1.Career = "Computer Science";

Students student2 = new Students();
student2.Name = "Carlos";
student2.Age = 22;
student2.Career = "Cybersecurity";
*/

/*
//By setting up constructor in class we can just simply declear like....
Students student1 = new Students("Ana", 20, "Computer Science");
Students student2 = new Students("Ben", 24, "Electronic Engineering");
Console.WriteLine($"{student1.Name} - {student1.Career}");
Console.WriteLine($"{student2.Name} - {student2.Career}");
*/
Students.ShowMessage();
/*
Students student1 = new Students("Ana");
Students student2 = new Students("Luis");
//Because of "status" can just call the num without new()
Console.WriteLine(Students.TotalStudents);
*/
Console.WriteLine("=======class_with_method========");
/*
//use PrintSummary method to print info
student1.PrintSummary();

//methods to return values
int years = student1.GetYearsToGraduate();
Console.WriteLine($"Years to graduate : {years}");

student1.CelebrateBirthday(1);
*/
/*
Console.WriteLine($"Student: {student1.Name}");
Console.WriteLine($"Age: {student1.Age}");
Console.WriteLine($"Career: {student1.Career}");

Console.WriteLine($"{student1.Name} is {student1.Age} years old.");
Console.WriteLine($"{student2.Name} is {student2.Age} years old.");
*/

List<Students> students = new List<Students>();

students.Add(new Students("Ana", 20));
students.Add(new Students("Luis", 22));

foreach (Students student in students)
{
    Console.WriteLine($"{student.Name} - {student.Age}");
    if (student.Age >= 21)
    {
        Console.WriteLine($"Adult student : {student.Name}");
    }
}

Console.WriteLine();
List<Courses> courses = new List<Courses>();
courses.Add(new Courses("Computer Science", 3));
courses.Add(new Courses("OOP", 4));
courses.Add(new Courses("Soft Datamining", 4));
Console.WriteLine();


foreach (Courses course in courses)
{
    Console.WriteLine($"{course.Name} - {course.Credits}");
}
//Courses course1 = new Courses("Computer Science", 6);
/*
course1.Name = "OOP";
course1.Credits = 4 ;
course1.Teacher = "Luis";
*/

Console.WriteLine(Courses.TotalCourses);
//Console.WriteLine($"Course: {course1.Name}");
//Console.WriteLine($"Credits: {course1.Credits}");
//Console.WriteLine($"Teacher: {course1.Teacher}");


//===================================================

Books book1 = new Books();
book1.Title = "Harry Pottter";
book1.Author = "JK";
book1.Pages = 250;

Books book2 = new Books();
book2.Title = "Le Petit Prince";
book2.Author = " Antoine";
book2.Pages = 300;

Books book3 = new Books();
book3.Title = "Percy Jackson";
book3.Author = "Rick Riordan";
book3.Pages = 470;

List<Books> books = new List<Books>();
books.Add(book1);
books.Add(book2);
books.Add(book3);

foreach (Books book in books)
{
    Console.WriteLine($"{book.Title} -- {book.Author}");
}

Console.WriteLine("-------------------------------");

Products product1 = new Products("pencil", 23, 100);
Products product2 = new Products("eraser", 10, 50);
Console.WriteLine($"Product : {product1.Name}");
Console.WriteLine($"Price : {product1.Price}");
Console.WriteLine($"Stock : {product1.Stock}");

Console.WriteLine();

Console.WriteLine($"Product : {product2.Name}");
Console.WriteLine($"Price : {product2.Price}");
Console.WriteLine($"Stock : {product2.Stock}");