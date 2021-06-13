using System.Collections.Generic;

namespace Mentoring.Repository
{
    interface IMentorRepository
    {
        public void Add(Mentor mentor);
        public List<Mentor> Find();
    }
}
