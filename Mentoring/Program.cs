using System;
using Mentoring.Service;

namespace Mentoring
{
    class Program 
    {
        static void Main(string[] args)
        {
            IMentorService mentorService = new DefaultMentorService();
            IMenteeService menteeService = new DefaultMenteeService();
            IMentorshipService mentorshipService = new DefaultMentorshipService();

            bool start = false;
            while (start == false)
            {
                Console.WriteLine("Введите команду: ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "mentor add":
                        {
                            Console.Write("Введите имя ментора - ");
                            string name = Console.ReadLine();

                            Mentor mentor = new Mentor(name);
                            mentorService.Add(mentor);
                            break;
                        }
                    case "mentor list":
                        {
                            mentorService.ListAllMentors();
                            break;
                        }
                    case "mentee add":
                        {
                            Console.Write("Введите имя обучающегося - ");
                            string name = Console.ReadLine();

                            Mentee mentee = new Mentee(name);
                            menteeService.Add(mentee);
                            break;
                        }
                    case "mentee list":
                        {
                            menteeService.ListAllMentees();
                            break;
                        }
                    case "mentorship add":
                        {
                            Console.WriteLine("Выберите ментора ");
                            mentorService.ListAllMentors();
                            int mentorId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Выберите обучающегося ");
                            menteeService.ListAllMentees();
                            int menteeId = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Введите дату начала обучения ");
                            DateTime startMentoring = DateTime.Parse(Console.ReadLine());
                            startMentoring = startMentoring.Date;
                            Console.Write("Введите дату окончания обучения ");
                            DateTime endMentoring = DateTime.Parse(Console.ReadLine());
                            endMentoring = endMentoring.Date;

                            Mentorship mentorship = new Mentorship(mentorId, menteeId, startMentoring, endMentoring);
                            mentorshipService.Add(mentorship); 

                            break;
                        }
                    case "mentorship list -all":
                        {
                            mentorshipService.ListAllMentorships();
                            break;
                        }
                    case "mentorship mentor -id":
                        {
                            Console.WriteLine("Введите Id ментора - ");
                            int mentorId = Convert.ToInt32(Console.ReadLine());

                            mentorshipService.ListByMentorId(mentorId);

                            break;
                        }
                    case "mentorship mentee -id":
                        { 
                            Console.WriteLine("Введите Id обучающегося - ");
                            int menteeId = Convert.ToInt32(Console.ReadLine());

                            mentorshipService.ListByMenteeId(menteeId);

                            break;
                        }
                    case "mentorship mentor -date":
                        {
                            Console.WriteLine("Введите Id ментора - ");
                            int mentorId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите дату начала периода ");
                            DateTime startPeriodCheck = DateTime.Parse(Console.ReadLine());
                            startPeriodCheck = startPeriodCheck.Date;
                            Console.Write("Введите дату окончания периода ");
                            DateTime endPeriodCheck = DateTime.Parse(Console.ReadLine());
                            endPeriodCheck = endPeriodCheck.Date;

                            mentorshipService.ListByMentorIdDate(mentorId, startPeriodCheck, endPeriodCheck);
    
                            break;
                        }
                    case "mentorship mentee -date":
                        {
                            Console.WriteLine("Введите Id ментора - ");
                            int menteeId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите дату начала периода ");
                            DateTime startPeriodCheck = DateTime.Parse(Console.ReadLine());
                            startPeriodCheck = startPeriodCheck.Date;
                            Console.Write("Введите дату окончания периода ");
                            DateTime endPeriodCheck = DateTime.Parse(Console.ReadLine());
                            endPeriodCheck = endPeriodCheck.Date;

                            mentorshipService.ListByMenteeIdDate(menteeId, startPeriodCheck, endPeriodCheck);
    
                            break;
                        }

                    case "exit":
                        start = true;
                        break;
          
                    default:
                        Console.WriteLine("Не корректная команда");
                        break;
                }
            }
        }
    }
}
