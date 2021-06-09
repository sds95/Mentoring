using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mentorship
{
    public class Mentee
    {
        public Mentee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
