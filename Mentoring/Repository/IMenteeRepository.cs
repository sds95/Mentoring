using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.Repository
{
    interface IMenteeRepository
    {
        public void Add(Mentee mentee);
        public List<Mentee> Find();
    }
}
