using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Helenes book");

            book.AddGrade(54.1);
            book.AddGrade(98.1);
            book.AddGrade(12.7);
            book.AddGrade(5.68);


            book.ShowStatistics();




         }
    }
}
