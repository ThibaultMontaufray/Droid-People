namespace Droid_People
{
    public class FirstName
    {
        #region Attributes
        private string _firstname;
        private string _univers;
        private string _type;
        private string _gender;
        private string _description;
        private string _culture;
        private string _origin;
        #endregion

        #region Properties
        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }
        public string Culture
        {
            get { return _culture; }
            set { _culture = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Univers
        {
            get { return _univers; }
            set { _univers = value; }
        }
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        #endregion

        #region Methods publice
        public override string ToString()
        {
            return this.Firstname;
        }
        #endregion
    }
}
