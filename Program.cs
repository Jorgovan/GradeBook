using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main()

        {
            Console.WriteLine("Enter a students name");
            var name = Console.ReadLine();
            var book = new DiskBook(name);
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"The book name is {book.Name}");
            Console.WriteLine($"Highest grade is {stats.High}");
            Console.WriteLine($"Lowest grade is {stats.Low}");
            Console.WriteLine($"Average grade is {stats.Average}");
            Console.ReadKey();

        }


        private static void EnterGrades(Book book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or press q to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    book.AddGrade(double.Parse(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {

                }

            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
           Console.WriteLine("A grade was added"); 
        }

    
    }
}
