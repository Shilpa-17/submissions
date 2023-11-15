using System;
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

    private Student[] students = new Student[100];

    private int studentCount = 0;

    private Course[] courses = new Course[50];

    private int courseCount = 0;

    private Enrollment[] enrollments = new Enrollment[500];

    private int enrollmentCount = 0;



    public void Introduce(Course course)

    {

        WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");

        courses[courseCount++] = course;

    }



    public void Register(Student student)

    {

        students[studentCount++] = student;

    }



    public Student[] ListOfStudents()

    {

        Student[] result = new Student[studentCount];

        Array.Copy(students, result, studentCount);

        return result;

    }



    public Course[] ListOfCourses()

    {

        Course[] result = new Course[courseCount];

        Array.Copy(courses, result, courseCount);

        return result;

    }



    public void Enroll(Student student, Course course)

    {

        enrollments[enrollmentCount++] = new Enrollment { Student = student, Course = course, EnrollmentDate = DateTime.Now };

    }



    public Enrollment[] ListOfEnrollments()

    {

        Enrollment[] result = new Enrollment[enrollmentCount];

        Array.Copy(enrollments, result, enrollmentCount);

        return result;

    }

}



public class Info

{

    public void DisplayEnrollmentDetails(Enrollment enrollment)

    {

        WriteLine($"Student: {enrollment.Student.Name}, Course: {enrollment.Course.CourseName}, Enrollment Date: {enrollment.EnrollmentDate}");

    }
    public void DisplayCourseDetails(Course course)
    {
        WriteLine($"Course ID:{course.CourseId},Course Name:{course.CourseName}");
    }
}



class Program

{

    static void Main(string[] args)

    {

        AppEngine engine = new AppEngine();

        Info info = new Info();



        WriteLine("Enter the number of courses to add:");

        int numberOfCourses = int.Parse(ReadLine());



        

        for (int i = 0; i < numberOfCourses; i++)

        {

            WriteLine($"Enter course details for course {i + 1}:");

            Write("Course ID: ");

            int courseId = int.Parse(ReadLine());

            Write("Course Name: ");

            string courseName = ReadLine();



            Course course = new Course { CourseId = courseId, CourseName = courseName };

            engine.Introduce(course);

        }



        WriteLine("Enter the number of student enrollment details to add:");

        int numberOfStudents = int.Parse(ReadLine());



        for (int i = 0; i < numberOfStudents; i++)

        {

            WriteLine($"Enter student details for student {i + 1}:");

            Write("ID: ");

            int studentId = int.Parse(ReadLine());

            Write("Name: ");

            string studentName = ReadLine();

            Write("Date of Birth: ");

            string studentDob = ReadLine();



            Student student = new Student { Id = studentId, Name = studentName, DateOfBirth = studentDob };

            engine.Register(student);



            WriteLine($"Select a course for student {student.Name}:");



            foreach (var course in engine.ListOfCourses())

            {

                WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");

            }



            int selectedCourseId = int.Parse(ReadLine());

            Course selectedCourse = engine.ListOfCourses().FirstOrDefault(c => c.CourseId == selectedCourseId);



            if (selectedCourse != null)

            {

                engine.Enroll(student, selectedCourse);

            }

            else

            {

                WriteLine("Invalid course selection. Enrollment not recorded.");

            }

        }



       WriteLine("List of Students:");

        var listOfStudents = engine.ListOfStudents();

        foreach (var student in listOfStudents)

        {

            WriteLine($"ID: {student.Id}, Name: {student.Name}, Date of Birth: {student.DateOfBirth}");

        }



        WriteLine("List of Courses:");

        var listOfCourses = engine.ListOfCourses();

        foreach (var course in listOfCourses)

        {

           WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");
            info.DisplayCourseDetails(course);


        }



        WriteLine("List of Enrollments:");

        var listOfEnrollments = engine.ListOfEnrollments();

        foreach (var enrollment in listOfEnrollments)

        {

            info.DisplayEnrollmentDetails(enrollment);

        }



        Read();

    }

}



