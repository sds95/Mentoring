using System;
using System.Collections.Generic;

namespace Mentoring.Repository
{
    interface IMentorshipRepository
    {
        public void Add(Mentorship mentorship);
        public List<Mentorship> Find();
        public List<Mentorship> FindByMentorId(int mentorId);
        public List<Mentorship> FindByMenteeId(int menteeId);
        public List<Mentorship> FindByMentorIdDate(int mentorId, DateTime startPeriodCheck, DateTime endPeriodCheck);
        public List<Mentorship> FindByMenteeIdDate(int menteeId, DateTime startPeriodCheck, DateTime endPeriodCheck);
    }
}
