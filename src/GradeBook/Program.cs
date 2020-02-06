using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.addGrade(72);
            book.addGrade(45);
            book.addGrade(60);
            var stat= book.getStatistics();
            System.Console.WriteLine($"average grade {stat.average}");
            System.Console.WriteLine($"lowest grade {stat.low}");
            System.Console.WriteLine($"highest grade {stat.high}");
        }
    }
}
