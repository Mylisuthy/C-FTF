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
            new Student { Id = 5, Name = "marta", Age = 14 },
            new Student { Id = 6, Name = "jairo", Age = 18 },
        };
        
        var courses = new List<Course>
        {
            new Course { Id = 1, Title = "python", Credits = 15 },
            new Course { Id = 2, Title = "HTML", Credits = 15 },
            new Course { Id = 3, Title = "javascript", Credits = 17 },
            new Course { Id = 4, Title = "css", Credits = 16 },
            new Course { Id = 5, Title = "C#", Credits = 14 },
            new Course { Id = 6, Title = "java", Credits = 18 }
        };
        
        var enrollments = new List<Enrollment>
        {
            new Enrollment { Id = 1, CourseId = 5, StudentId = 1, Grade = 4 },
            new Enrollment { Id = 2, CourseId = 4, StudentId = 2, Grade = 3 },
            new Enrollment { Id = 3, CourseId = 3, StudentId = 3, Grade = 4 },
            new Enrollment { Id = 4, CourseId = 2, StudentId = 4, Grade = 5 },
            new Enrollment { Id = 5, CourseId = 1, StudentId = 5, Grade = 3 },
            new Enrollment { Id = 6, CourseId = 2, StudentId = 6, Grade = 5 }
        };
        
        Console.WriteLine("---------- 1 ----------");
        var queryMayor = students.Where(e => e.Age > 19);
        foreach (var e in queryMayor)
        {
            Console.WriteLine($"Estos son los estudiantes mayores a 20 años {e.Name}");
        }
        
        Console.WriteLine("---------- 2 ----------");
        var course = courses.OrderByDescending(c => c.Id  );
        foreach (var c in course)
        {
            Console.WriteLine($"nombre: {c.Title}, Credits: {c.Credits}");
        }
        
        Console.WriteLine("---------- 3 ----------");
        var specificCourse = courses.Where(e => e.Id == 1);
        foreach (var e in specificCourse)
        {
            Console.WriteLine($"nombre: {e.Title}");
        }
        
        Console.WriteLine("---------- 4 ----------");
        var countMatriculas = students.Select(e => e.Id).Count();
        Console.WriteLine($"la cantidad de matriculas es: {countMatriculas}");
        
        Console.WriteLine("---------- 5 ----------");
        var union = from i in enrollments
            join e in students on i.StudentId equals e.Id
            select new { e.Id, e.Name };
        foreach (var e in union)
        {
            if (e.Id == 1)
            {
                Console.WriteLine($"Nombre Estudiante: {e.Name}");
                break;
            }
            else
            {
                Console.WriteLine("ningun Id Coincidio");
            }
        }


    }
}