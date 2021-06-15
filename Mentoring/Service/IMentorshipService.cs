using System;

namespace Mentoring.Service
{
    interface IMentorshipService
    {
        public void Add(Mentorship mentorship);
        public void ListAllMentorships();
        public void ListByMentorId(int mentorId);
        public void ListByMenteeId(int menteeId);
        public void ListByMentorIdDate(int mentorId, DateTime startPeriodCheck, DateTime endPeriodCheck);
        public void ListByMenteeIdDate(int menteeId, DateTime startPeriodCheck, DateTime endPeriodCheck);
 
    }
}
