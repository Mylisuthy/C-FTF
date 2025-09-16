using Objeto.Models;

namespace taller;

public static class Program
{
    public static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "ana", Age = 21 },
            new Student { Id = 2, Name = "gisela", Age = 15 },
            new Student { Id = 3, Name = "pablo", Age = 17 },
            new Student { Id = 4, Name = "camila", Age = 21 },
            new Student { Id = 5, Name = "marta", Age = 14 }
        };
        
        var courses = new List<Course>
        {
            new Course { Id = 1, Title = "ana", Credits = 15 },
            new Course { Id = 2, Title = "gisela", Credits = 15 },
            new Course { Id = 3, Title = "pablo", Credits = 17 },
            new Course { Id = 4, Title = "camila", Credits = 16 },
            new Course { Id = 5, Title = "marta", Credits = 14 }
        };
        
        var enrolments = new List<Enrollment>
        {
            new Enrollment { Id = 1, CourseId = 5, StudentId = 1 },
            new Enrollment { Id = 2, CourseId = 4, StudentId = 2 },
            new Enrollment { Id = 3, CourseId = 3, StudentId = 3 },
            new Enrollment { Id = 4, CourseId = 2, StudentId = 4 },
            new Enrollment { Id = 5, CourseId = 1, StudentId = 5 }
        };
        
        var queryMayor = students.Where(e => e.Age > 19);
        
        foreach (var e in queryMayor)
        {
            Console.WriteLine($"Estos son los estudiantes mayores a 20 años {e.Name}");
        }

        var course = courses.Where(c => c.Credits  );
        foreach (var c in course)
        {
            
            Console.WriteLine(c);
        }

    }
}