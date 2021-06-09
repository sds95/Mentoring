using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.Repository
{
    class DefaultMentorRepository : IMentorRepository
    {
        private readonly List<Mentor> mentors = new List<Mentor>();

        public void Add(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public List<Mentor> Find()
        {
            return mentors;
        }
    }
}
