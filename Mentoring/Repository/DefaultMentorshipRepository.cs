using System;
using System.Collections.Generic;

namespace Mentoring.Repository
{
    class DefaultMentorshipRepository : IMentorshipRepository
    {
        private readonly List<Mentorship> _mentorships = new List<Mentorship>();

        public void Add(Mentorship mentorship)
        {
            _mentorships.Add(mentorship);
        }

        public List<Mentorship> Find()
        {
            return _mentorships;
        }

        /*public List<Mentorship> ListByMentorId(int mentorId)
        {
            List<Mentorship> mentorshipsByMentorId = new List<Mentorship>();
            foreach (var mentorship in _mentorships)
            {
                if (mentorId == mentorship.MentorId)
                    mentorshipsByMentorId.Add(mentorship);
            }
            return mentorshipsByMentorId;
        }*/

        public List<Mentorship> FindByMentorId(int mentorId)
        {
            return _mentorships.FindAll(
            delegate (Mentorship mentorship)
            {
                return mentorId == mentorship.MentorId;
            }
            );
        }

        public List<Mentorship> FindByMenteeId(int menteeId)
        {
            return _mentorships.FindAll(
            delegate (Mentorship mentorship)
            {
                return menteeId == mentorship.MenteeId;
            }
            );
        }

        public List<Mentorship> FindByMentorIdDate(int mentorId, DateTime startPeriodCheck, DateTime endPeriodCheck)
        {
            List<Mentorship> mentorshipsByMentorIdDate = new List<Mentorship>();
            foreach (var mentorship in _mentorships)
            {
                if (mentorId == mentorship.MentorId)
                {
                    if (mentorship.StartMentoring <= endPeriodCheck && mentorship.EndMentoring >= startPeriodCheck) 
                    {
                        mentorshipsByMentorIdDate.Add(mentorship);
                    }
                }
            }
            return mentorshipsByMentorIdDate;
        }
         
        public List<Mentorship> FindByMenteeIdDate(int menteeId, DateTime startPeriodCheck, DateTime endPeriodCheck)
        {
            List<Mentorship> mentorshipsByMenteeIdDate = new List<Mentorship>();
            foreach (var mentorship in _mentorships)
            {
                if (menteeId == mentorship.MenteeId)
                {
                    if (mentorship.StartMentoring <= endPeriodCheck && mentorship.EndMentoring >= startPeriodCheck) 
                    {
                        mentorshipsByMenteeIdDate.Add(mentorship);
                    }
                }
            }
            return mentorshipsByMenteeIdDate;
        }
    }
}
