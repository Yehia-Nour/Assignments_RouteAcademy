using C44_G03_EF03.Data;
using C44_G03_EF03.Models;
using Microsoft.EntityFrameworkCore;

namespace C44_G03_EF03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ITIDbContext();

            var topic = new Topic { Name = "Programming" };
            context.Topics.Add(topic);

            var course = new Course
            {
                Name = "C# Basics",
                Description = "Intro to C#",
                Duration = "30 Hours",
                Topic = topic
            };
            context.Courses.Add(course);

            var dept = new Department { Name = "Computer Science", HiringDate = DateTime.Now };
            context.Departments.Add(dept);

            var student = new Student { FName = "Ahmed", LName = "Ali", Address = "Cairo", Age = 20, Department = dept };
            context.Students.Add(student);

            context.SaveChanges();


            var student1 = context.Students.FirstOrDefault(s => s.Id == 1);
            Console.WriteLine(student1.Department.Name);
            var students = context.Students
                            .Include(s => s.Department)
                            .Include(s => s.StudCourse)
                                .ThenInclude(sc => sc.Course)
                            .ToList();

            foreach (var s in students)
                Console.WriteLine($"{s.FName} - {s.Department.Name}");


            var studentToUpdate = context.Students.FirstOrDefault(s => s.Id == 1);
            if (studentToUpdate != null)
            {
                studentToUpdate.Address = "Alexandria";
                context.SaveChanges();
            }


            var studentToDelete = context.Students.FirstOrDefault(s => s.Id == 1);
            if (studentToDelete != null)
            {
                context.Students.Remove(studentToDelete);
                context.SaveChanges();
            }

        }
    }
}
