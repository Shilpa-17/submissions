using System;
using static System.Console;
public class Student

{
    private int id;
    private string name;
    private string dateOfBirth;
    public Student(int id, string name, string dateOfBirth)
    {
        this.id = id;
        this.name = name;
        this.dateOfBirth = dateOfBirth;
    }
    public int Id

    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }

    }
    public string DateOfBirth

    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }

}
public class Info

{
    public void Display(Student student)

    {
        WriteLine("Student Details:");
        WriteLine("ID: " + student.Id);
        WriteLine("Name: " + student.Name);
        WriteLine("Date of Birth: " + student.DateOfBirth);

        
    }

}
        


public class App

{
    public static void Main(string[] args)
    {
        // Scenario 1: 

        WriteLine("Scenario 1 - Enter Student Details==========>");
        Write("ID: ");
        int id1 = int.Parse(ReadLine());

        Write("Name=> ");
        string name1 = ReadLine();

        Write("Date of Birth (yyyy-MM-dd)=> ");
        string dateOfBirth1 = ReadLine();

        Student student1 = new Student(id1, name1, dateOfBirth1);
        Info info = new Info();
        info.Display(student1);


        WriteLine("--------------------------------------------------");

        // Scenario 2: 

        WriteLine("\nScenario 2 - Enter Student Details for 3 Students========>");

        Student[] students = new Student[3];
        for (int i = 0; i < 3; i++)
        {
            WriteLine($"\nStudent {i + 1}:");
            Write("ID=>");
            int id2 = int.Parse(ReadLine());
            Write("Name=> ");
            string name2 = ReadLine();
            Write("Date of Birth (yyyy-MM-dd)=> ");
            string dateOfBirth2 = ReadLine();
            students[i] = new Student(id2, name2, dateOfBirth2);

        }
        WriteLine("\nDisplaying Student Details====>");
        foreach (Student s in students)
        {
            info.Display(s);
        }
    }
}