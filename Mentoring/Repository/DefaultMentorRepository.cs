using System.Collections.Generic;

namespace Mentoring.Repository
{
    class DefaultMentorRepository : IMentorRepository
    {
        private readonly List<Mentor> _mentors = new List<Mentor>();

        public void Add(Mentor mentor)
        {
            mentor.Id = _mentors.Count + 1;
            _mentors.Add(mentor);
        }

        public List<Mentor> Find()
        {
            return _mentors;
        }
    }
}
