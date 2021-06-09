using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.Repository
{
    interface IMentorRepository
    {
        public void Add(Mentor mentor);
        public List<Mentor> Find();
    }
}
