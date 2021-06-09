using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring
{
    class Mentor
    {
        //private int _id;
        private string _name;

        public Mentor(/*int id*/ string name)
        {
            //_id = id;
            _name = name;
        }

        //public int Id => _id;
        public string Name => _name;
    }
}
