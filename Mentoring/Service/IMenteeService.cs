﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.Service
{
    interface IMenteeService
    {
        public void Add(Mentee mentee);
        public void ListAllMentees();
    }
}
