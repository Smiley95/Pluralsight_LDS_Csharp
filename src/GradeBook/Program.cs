using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("book");
            while(true)
            {
                Console.WriteLine("Enter an average  or q to quit: ");
                var grade= Console.ReadLine();
                if(grade.Equals("Q", StringComparison.OrdinalIgnoreCase)) break;
                try
                {
                    book.addGrade(Convert.ToDouble(grade));    
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
                
            }
            var stat= book.getStatistics();
            System.Console.WriteLine($"average grade {stat.average}");
            System.Console.WriteLine($"lowest grade  {stat.low}");
            System.Console.WriteLine($"highest grade {stat.high}");
        }
    }
}
