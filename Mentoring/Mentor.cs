namespace Mentoring
{
    class Mentor
    {
        private int _id;
        private string _name;

        public Mentor(string name)
        {
            _name = name;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name => _name;
    }
}
