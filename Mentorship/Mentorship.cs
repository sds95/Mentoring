using System;
using System.Collections.Generic;

namespace Services.Mentorship
{
    public class Mentorship
    {
        private Mentor mentor = null;
        private List<Mentee> mentees = new List<Mentee>();
        private DateTime startDate;
        private DateTime endDate;
        
        public Mentorship(Mentor mentor, List<Mentee> mentees, DateTime startDate, DateTime endDate)
        {
            this.mentor = mentor;
            this.mentees = mentees;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public void getMentorship()
        {
            Console.Write($"My first Mentorship. Mentor is {mentor.Name}, ");
            if(mentees.Count == 1)
            {
                Console.Write($"mentee is {mentees[0].Name}");
            } else
            {
                Console.Write("mentees are");
                foreach(Mentee mentee in mentees)
                {
                    Console.Write($" {mentee.Name}");
                }
            }
            Console.WriteLine(".");
            Console.WriteLine($"Mentoring is started on {startDate.Date.ToString("dd-MM-yyyy")} and ended on {endDate.Date.ToString("dd-MM-yyyy")}");
        }
        //public Mentor GetMentor()
        //{
        //    return mentor;
        //}        

        //public List<Mentee> GetMentees()
        //{
        //    return mentees;
        //}

        //public void AddMentees(List<Mentee> newMentees)
        //{
        //    foreach(Mentee mentee in newMentees)
        //    {
        //        mentees.Add(mentee);
        //    }
        //}
    }
}
