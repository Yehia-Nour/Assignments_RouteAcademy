using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignments_RouteAcademy.C44_G03_OOP03
{
    #region Part 1
    public enum Gender
    {
        Male, Female
    }

    public enum SecurityLevel
    {
        Guest, Developer, Secretary, DBA
    }

    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            if (!IsValidDate(day, month, year))
            {
                Console.WriteLine("Invalid Date Entered, Setting Default Date 01/01/2000");
                Day = 1;
                Month = 1;
                Year = 2025;
            }
            else
            {
                Day = day;
                Month = month;
                Year = year;
            }
        }

        private bool IsValidDate(int day, int month, int year)
        {
            return DateTime.TryParse($"{day}/{month}/{year}", out _);
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Salary cannot be negative for Employee ID {Id}. Setting Salary to 0.");
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }

        public HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }

        public Employee(int id, string name, Gender gender, SecurityLevel security, decimal salary, HiringDate hireDate)
        {
            Id = id;
            Name = name;
            Gender = gender;
            SecurityLevel = security;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate}, Gender: {Gender}";
        }
    }
    #endregion

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    #region Part 2
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }

    public class EBook : Book
    {
        public double FileSize { get; set; }

        public EBook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)
        {
            FileSize = fileSize;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Size: {FileSize} MB");
        }
    }

    public class PrintedBook : Book
    {
        public int PageCount { get; set; }

        public PrintedBook(string title, string author, string isbn, int pageCount)
            : base(title, author, isbn)
        {
            PageCount = pageCount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Page Count: {PageCount}");
        }
    } 
    #endregion
    internal class Assignment03
    {

    }
}
