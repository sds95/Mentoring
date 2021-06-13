using Mentoring.Repository;
using Mentoring.Service;
using System;
using System.Collections.Generic;

namespace Mentoring
{
    class DefaultMentorService : IMentorService
    {
        private readonly IMentorRepository _repository = new DefaultMentorRepository();

        public void Add(Mentor mentor)
        {
            _repository.Add(mentor);
        }

        public void ListAllMentors()
        {
            List<Mentor> mentors = _repository.Find();
            foreach (var mentor in mentors)
            {
                Console.WriteLine(mentor.Id + " " + mentor.Name);
            }
        }
    }
}
