using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.Service
{
    interface IMentorService
    {
        public void Add(Mentor mentor);
        public void ListAllMentors();
    }
}
