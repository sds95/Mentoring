using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.Repository
{
    class DefaultMenteeRepository : IMenteeRepository
    {
        private readonly List<Mentee> mentees = new List<Mentee>();

        public void Add(Mentee mentee)
        {
            mentees.Add(mentee);
        }
        public List<Mentee> Find()
        {
            return mentees;
        }
    }
}
