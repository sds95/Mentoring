namespace Mentoring.Service
{
    interface IMentorshipService
    {
        public void Add(Mentorship mentorship);
        public void ListAllMentorships();
        public void FindByMentorId(int mentorId);
        public void FindByMenteeId(int menteeId);
    }
}
