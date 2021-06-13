using Mentoring.Repository;
using System;
using System.Collections.Generic;

namespace Mentoring.Service
{
    class DefaultMentorshipService : IMentorshipService
    {
        private readonly IMentorshipRepository _mentorshipRepository = new DefaultMentorshipRepository();

        public void Add(Mentorship mentorship)
        {
            _mentorshipRepository.Add(mentorship);
        }

        public void ListAllMentorships()
        {
            List<Mentorship> mentorships = _mentorshipRepository.Find();
            foreach (var mentorship in mentorships)
            {
                Console.WriteLine(mentorship.ToString());
            }
        }

        public void FindByMentorId(int mentorId)
        {
            List<Mentorship> mentorships = _mentorshipRepository.FindByMentorId(mentorId);
            if (mentorships.Count != 0)
            {
                foreach (var mentorship in mentorships)
                {
                    Console.WriteLine(mentorship.ToString());
                }
            }
            else
            {
                Console.WriteLine("Такого ментора нет в базе данных");
            }
        }

        public void FindByMenteeId(int menteeId)
        {
            List<Mentorship> mentorships = _mentorshipRepository.FindByMenteeId(menteeId);
            if (mentorships.Count != 0)
            {
                foreach (var mentorship in mentorships)
                {
                    Console.WriteLine(mentorship.ToString());
                }
            }
            else
            {
                Console.WriteLine("Такого обучающегося нет в базе данных");
            }
        }
    }
}
