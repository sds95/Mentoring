using System.Collections.Generic;

namespace Mentoring.Repository
{
    interface IMenteeRepository
    {
        public void Add(Mentee mentee);
        public List<Mentee> Find();
    }
}
