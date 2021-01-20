using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book
    {
        private string name;
        private List<double> grades = new List<double>();

       
        public Book(string name)
        {
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                if (number > highGrade)
                {
                    highGrade = number;
                }
                else if (number < lowGrade)
                {
                    lowGrade = number;
                }
                result += number;
            }

            var avarage = result / grades.Count;

            Console.WriteLine($"The avarage grade is {avarage:N1}");
            Console.WriteLine($"The highets grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {lowGrade}");


        }
     
        public void WriteBookName() 
        {
            Console.WriteLine($"This is: {this.name}");
        }

        public void ChangeBookName(string newName)
        {
            this.name = newName;
            Console.WriteLine($"This is the new name: {this.name}");

        }


    }
}

