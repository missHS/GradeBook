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
            book.WriteBookName();

            

            string choice = "";

            while (choice != "no" && choice != "yes")
            {
                Console.WriteLine($"Would you like to rename your book? (Yes/No)");

                choice = Console.ReadLine().ToLower(); ;
                
                if (choice is "yes")
                {
                    Console.WriteLine("Please choose a new name: ");
                    string newName = Console.ReadLine();
                    book.ChangeBookName(newName);
                    Console.WriteLine("Ok! Now Closing the program");
                }
                else if (choice is "no")
                {
                    Console.WriteLine("Ok! Now Closing the program");
                }
                else
                {
                    Console.WriteLine("you did not make a valid choice");
                }
            }
         }
    }
}
