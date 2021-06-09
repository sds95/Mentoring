using Services.Mentorship;
using System;
using System.Collections.Generic;

namespace TestProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Mentorship program");
            var mentees = new List<Mentee>();
            mentees.Add(new Mentee("Slava"));
            var mentorship = new Mentorship(
                new Mentor("Vanya"),
                mentees,
                new DateTime(2021,1,1),
                new DateTime(2021,6,8)
            );
            mentorship.getMentorship();
        }
    }
}
