using System;

namespace P03_Mankind
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i < 3; i++)
                {
                    var input = Console.ReadLine().Split(" ");
                    var firstName = input[0];
                    var lastName = input[1];

                    if (i % 2 != 0)
                    {
                        var facultyNumber = input[2];
                        var currentStudent = new Student(firstName, lastName, facultyNumber);
                        Console.WriteLine(currentStudent.ToString());
                    }
                    else
                    {
                        var weekSalary = int.Parse(input[2]);
                        var hoursPerDay = int.Parse(input[3]);
                        var currentWorker = new Worker(firstName, lastName, weekSalary, hoursPerDay);
                        Console.WriteLine(currentWorker.ToString());

                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
