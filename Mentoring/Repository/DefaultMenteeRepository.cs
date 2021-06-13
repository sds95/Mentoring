using System.Collections.Generic;

namespace Mentoring.Repository
{
    class DefaultMenteeRepository : IMenteeRepository
    {
        private readonly List<Mentee> _mentees = new List<Mentee>();

        public void Add(Mentee mentee)
        {
            mentee.Id = _mentees.Count + 1;
            _mentees.Add(mentee);
        }

        public List<Mentee> Find()
        {
            return _mentees;
        }
    }
}
