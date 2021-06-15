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

        public void ListByMentorId(int mentorId)
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
                Console.WriteLine("По Id ментора " + mentorId + " не найдены периоды менторинга");
            }
        }

        public void ListByMenteeId(int menteeId)
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
                Console.WriteLine("По Id обучающегося " + menteeId + " не найдены периоды менторинга");
            }
        }

        public void ListByMentorIdDate(int mentorId, DateTime startPeriodCheck, DateTime endPeriodCheck)
        {
            List<Mentorship> mentorships = _mentorshipRepository.FindByMentorIdDate(mentorId, startPeriodCheck, endPeriodCheck);
            if (mentorships.Count != 0)
            {
                foreach (var mentorship in mentorships)
                {
                    Console.WriteLine(mentorship.ToString());
                }
            }
            else
            {
                Console.WriteLine("За этот период менторинги не найдены");
            }
        }

        public void ListByMenteeIdDate(int menteeId, DateTime startPeriodCheck, DateTime endPeriodCheck)
        {
            List<Mentorship> mentorships = _mentorshipRepository.FindByMenteeIdDate(menteeId, startPeriodCheck, endPeriodCheck);
            if (mentorships.Count != 0)
            {
                foreach (var mentorship in mentorships)
                {
                    Console.WriteLine(mentorship.ToString());
                }
            }
            else
            {
                Console.WriteLine("За этот период менторинги не найдены");
            }
        }
    }
}
