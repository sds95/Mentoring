namespace Mentoring
{
    class Mentee
    {
        private int _id;
        private string _name;

        public Mentee(string name)
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
