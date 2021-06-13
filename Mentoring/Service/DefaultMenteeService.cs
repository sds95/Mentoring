using Mentoring.Repository;
using System;
using System.Collections.Generic;

namespace Mentoring.Service
{
    class DefaultMenteeService : IMenteeService
    {
        private readonly IMenteeRepository _menteeRepository = new DefaultMenteeRepository();

        public void Add(Mentee mentee)
        {
            _menteeRepository.Add(mentee);
        }

        public void ListAllMentees()
        {
            List<Mentee> mentees = _menteeRepository.Find();
            foreach (var mentee in mentees)
            {
                Console.WriteLine(mentee.Id + " " + mentee.Name);
            }
        }
    }
}
