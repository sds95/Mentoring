﻿using System.Collections.Generic;

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

        /*public List<Mentorship> FindByMentorId(int mentorId)
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

    }
}
