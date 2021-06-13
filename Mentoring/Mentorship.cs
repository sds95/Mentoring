using System;

namespace Mentoring
{
    class Mentorship
    {
        private int _mentorId;
        private int _menteeId;
        private DateTime _startMentoring;
        private DateTime _endMentoring;

        public Mentorship(int mentorId, int menteeId, DateTime startMentoring, DateTime endMentoring)
        {
            _mentorId = mentorId;
            _menteeId = menteeId;
            _startMentoring = startMentoring;
            _endMentoring = endMentoring;
        }

        public override string ToString()
        {
            string all = _mentorId + " " + _menteeId + " " + _startMentoring + " " + _endMentoring;
            return all;
        }

        public int MentorId => _mentorId;
        public int MenteeId => _menteeId;
        public DateTime StartMentoring => _startMentoring;
        public DateTime EndMentoring => _endMentoring;
    }
}
