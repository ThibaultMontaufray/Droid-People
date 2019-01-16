namespace Droid.People
{
    public class FirstName
    {
        #region Attributes
        private string _value;
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
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion

        #region Constructor
        public FirstName()
        {

        }
        public FirstName(string value)
        {
            _value = value;
        }
        #endregion

        #region Methods publice
        public override string ToString()
        {
            return this.Value;
        }
        #endregion
    }
}
