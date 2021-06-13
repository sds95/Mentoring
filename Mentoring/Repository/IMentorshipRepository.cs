using System.Collections.Generic;

namespace Mentoring.Repository
{
    interface IMentorshipRepository
    {
        public void Add(Mentorship mentorship);
        public List<Mentorship> Find();
        public List<Mentorship> FindByMentorId(int mentorId);
        public List<Mentorship> FindByMenteeId(int menteeId);
    }
}
