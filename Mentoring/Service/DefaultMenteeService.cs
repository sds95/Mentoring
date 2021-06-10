using Mentoring.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.Service
{
    class DefaultMenteeService : IMenteeService
    {
        readonly IMenteeRepository menteeRepository = new DefaultMenteeRepository();

        public void Add(Mentee mentee)
        {
            menteeRepository.Add(mentee);
        }
        public void ListAllMentees()
        {
            List<Mentee> mentees = menteeRepository.Find();
            foreach (var mentee in mentees)
            {
                Console.WriteLine(mentee.Name);
            }
        }
    }
}
