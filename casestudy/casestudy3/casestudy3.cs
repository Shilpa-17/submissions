using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console; 

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string DateOfBirth { get; set; }

}

public class Course

{

    public int CourseId { get; set; }
    public string CourseName { get; set; }

}



public class Enrollment

{

    public Student Student { get; set; }
    public Course Course { get; set; }
    public DateTime EnrollmentDate { get; set; }

}



public class AppEngine

{

    private List<Student> students = new List<Student>();

    private List<Course> courses = new List<Course>();

    private List<Enrollment> enrollments = new List<Enrollment>();



    public void Introduce(Course course)

    {

        WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");

        courses.Add(course);

    }



    public void Register(Student student)

    {

        students.Add(student);

    }



    public Student[] ListOfStudents()

    {

        return students.ToArray();

    }



    public Course[] ListOfCourses()

    {

        return courses.ToArray();

    }



    public void Enroll(Student student, Course course)

    {

        enrollments.Add(new Enrollment { Student = student, Course = course, EnrollmentDate = DateTime.Now });

    }

    public Enrollment[] ListOfEnrollments()

    {

        return enrollments.ToArray();

    }

}



public abstract class UserInterface

{

    protected AppEngine appEngine;

    public UserInterface(AppEngine engine)

    {

        appEngine = engine;

    }



    public abstract void ShowFirstScreen();
    public abstract void ShowStudentScreen();
    public abstract void ShowAdminScreen();
    public abstract void ShowAllStudentsScreen();
    public abstract void ShowStudentRegistrationScreen();
    public abstract void IntroduceNewCourseScreen();
    public abstract void ShowAllCoursesScreen();
}



public class ConsoleUserInterface : UserInterface

{

    public ConsoleUserInterface(AppEngine engine) : base(engine) { }
    public override void ShowFirstScreen()

    {

        WriteLine("Welcome to SMS (Student Management System) ");

        WriteLine("Access through:\n1. Student\n2. Admin");

        Write("Please enter your choice (1 or 2)=> ");



        int choice = Convert.ToInt32(ReadLine());

        switch (choice)

        {

            case 1:

                ShowStudentScreen();

                break;



            case 2:

                ShowAdminScreen();

                break;



            default:

                WriteLine("Invalid choice, Re-enter 1 or 2.");

                ShowFirstScreen();

                break;

        }

    }
   
    public override void ShowStudentScreen()

    {

        WriteLine("Student Screen");

        WriteLine("1. Register Student ");

        WriteLine("2. List of Courses ");

        WriteLine("3. Enroll Students With a Course");

        WriteLine("4. Back to Main Menu");

        Write("Enter your choice: ");



        int choice = Convert.ToInt32(ReadLine());

        switch (choice)

        {

            case 1:

                ShowStudentRegistrationScreen();

                break;



            case 2:

                IntroduceNewCourseScreen();

                break;



            case 3:

                ShowAllStudentsScreen();

                break;





            case 4:

                ShowFirstScreen();

                break;



            default:

                WriteLine("Invalid choice,Re-enter a valid option.");

                ShowStudentScreen();

                break;

        }

    }



    public override void ShowAdminScreen()

    {

        WriteLine("Admin Screen");

        WriteLine("1. List of Courses");

        WriteLine("2. Back to Main Menu");

        Write("Enter your choice: ");



        int choice = Convert.ToInt32(ReadLine());

        switch (choice)

        {

            case 1:

                ShowAllCoursesScreen();

                break;



            case 2:

                ShowFirstScreen();

                break;



            default:

                WriteLine("Invalid choice, Re-enter a valid option.");

                ShowAdminScreen();

                break;

        }

    }



    

public override void ShowAllStudentsScreen()

    {
        WriteLine("List of Students:");

        var listOfStudents = appEngine.ListOfStudents();



        foreach (var student in listOfStudents)
        {

            WriteLine($"ID: {student.Id}, Name: {student.Name}, Date of Birth: {student.DateOfBirth}");

        }



        Write("Enter The Name Of The Student You Would Like To Select: ");

        string selectedStudentName = ReadLine();

        var selectedStudent = listOfStudents.FirstOrDefault(student => student.Name == selectedStudentName);




        if (selectedStudent != null)

        {

            WriteLine($"Selected Student: ID: {selectedStudent.Id}, Name: {selectedStudent.Name}");

            WriteLine("List of Courses:");

            var listOfCourses = appEngine.ListOfCourses();

            foreach (var course in listOfCourses)

            {

                WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");

            }



            Write("Enter The Name Of The Course You Want To Enroll The Student In: ");

            string selectedCourseName = ReadLine();



            var selectedCourse = listOfCourses.FirstOrDefault(course => course.CourseName == selectedCourseName);



            if (selectedCourse != null)

            {

                appEngine.Enroll(selectedStudent, selectedCourse);

                WriteLine($"Enrolled {selectedStudent.Name} in the course {selectedCourse.CourseName} successfully!\n");

            }



            else

            {

                WriteLine("Invalid Course Name. Enrollment failed.");

            }

        }

        else

        {

            WriteLine("Invalid student Name.");

        }

        ShowStudentScreen();

    }

    public override void ShowStudentRegistrationScreen()

    {

        WriteLine("Student Registration Screen");

        WriteLine("Enter the number of student enrollment details to add=>");

        int numberOfStudents = int.Parse(ReadLine());



        for (int i = 0; i < numberOfStudents; i++)

        {



            WriteLine($"Enter student details for student {i + 1}=>");



            Write("ID=> ");

            int studentId = int.Parse(ReadLine());



            Write("Name=> ");

            string studentName = ReadLine();



            Write("Date of Birth=> ");

            string studentDob = ReadLine();



            Student student = new Student { Id = studentId, Name = studentName, DateOfBirth = studentDob };

            appEngine.Register(student);



            WriteLine("Student registered successfully!");

        }

        ShowStudentScreen();

    }

    public override void IntroduceNewCourseScreen()

    {

        WriteLine("Introduce New Course Screen");

        WriteLine("Enter the number of courses to add=>");

        int numberOfCourses = int.Parse(ReadLine());



        



        for (int i = 0; i < numberOfCourses; i++)

        {

            WriteLine($"Enter course details for course {i + 1}=>");

            Write("Course ID=> ");

            int courseId = int.Parse(ReadLine());



            Write("Course Name=> ");

            string courseName = ReadLine();



            Course course = new Course { CourseId = courseId, CourseName = courseName };



            appEngine.Introduce(course);

            WriteLine("Course introduced successfully!");

        }

        ShowStudentScreen();

    }

    public override void ShowAllCoursesScreen()

    {

        WriteLine("List of Courses=>");

        var listOfCourses = appEngine.ListOfCourses();



        foreach (var course in listOfCourses)

        {

            WriteLine($"Course ID=> {course.CourseId}, Course Name=> {course.CourseName}");

        }

        ShowAdminScreen();

    }

}

class Program

{

    static void Main(string[] args)

    {

        AppEngine engine = new AppEngine();

        UserInterface ui = new ConsoleUserInterface(engine);

        ui.ShowFirstScreen();

    }

}