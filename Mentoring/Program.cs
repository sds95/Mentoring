﻿using System;
using Mentoring.Service;

namespace Mentoring
{
    class Program 
    {
        static void Main(string[] args)
        {
            IMentorService mentorService = new DefaultMentorService();
            IMenteeService menteeService = new DefaultMenteeService();
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
                    case "exit":
                        start = true;
                        break;
          
                    default:
                        Console.WriteLine("Не корректная команда");
                        start = true;
                        break;
                }
            }
        }
    }
}
