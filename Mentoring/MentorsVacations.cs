using System;

namespace Mentoring
{
    class MentorsVacations
    {
        private int _idMentor;
        private DateTime _startVacation;
        private DateTime _endVacation;

        public MentorsVacations(int id, DateTime start, DateTime end)
        {
            _idMentor = id;
            _startVacation = start;
            _endVacation = end;
        }
    }
}
