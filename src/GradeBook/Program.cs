using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.addGrade(72);
            book.addGrade(32);
            book.addGrade(50);
            book.showStatistics();
            
        }
    }
}
