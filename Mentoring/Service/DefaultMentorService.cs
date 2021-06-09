using Mentoring.Repository;
using Mentoring.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring
{
    class DefaultMentorService : IMentorService
    {
        IMentorRepository repository = new DefaultMentorRepository();

        public void Add(Mentor mentor)
        {
           repository.Add(mentor);
        }
        public void ListAllMentors()
        {
            List<Mentor> mentors = repository.Find();
            foreach (var mentor in mentors)
            {
                Console.WriteLine(mentor.Name);
            }
        }
    }
}
