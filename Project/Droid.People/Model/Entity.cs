using Droid.Scheduler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.People
{
    public class Entity : ICloneable
    {
        #region Enum
        public enum Family
        {
            PEOPLE,
            COMPANY
        }
        #endregion

        #region Attributes
        protected string _id;
        protected string _name;
        protected string _address;
        protected string _postCode;
        protected string _city;
        protected string _country;
        protected string _phone;
        protected string _mail;
        protected string _comment;
        protected Family _family;
        protected List<ICalendar> _calendars;
        private System.Drawing.Image _logo;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "logo")]
        [JsonConverter(typeof(ImageConverter))]
        public System.Drawing.Image Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
        [JsonProperty(PropertyName = "family")]
        public Family FamilyType
        {
            get { return _family; }
            set { _family = value; }
        }
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [JsonProperty(PropertyName = "mail")]
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty(PropertyName = "phone")]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        [JsonProperty(PropertyName = "country")]
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        [JsonProperty(PropertyName = "city")]
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        [JsonProperty(PropertyName = "postcode")]
        public string PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }
        [JsonProperty(PropertyName = "address")]
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        [JsonProperty(PropertyName = "comment")]
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public List<ICalendar> Calendars
        {
            get { return _calendars; }
            set { _calendars = value; }
        }
        #endregion

        #region Constructor
        public Entity()
        {

        }
        #endregion

        #region Methods public
        public static Entity GetEntity(string id)
        {
            return new Entity();
        }

        public string GetName()
        {
            return _name;
        }
        public object Clone()
        {
            Entity e = new Entity();
            e._name = _name;
            e._mail = _mail;
            e._comment = _comment;

            return e;
        }
        public override string ToString()
        {
            return string.Format("{0}_{1}.peo", _name, _mail);
        }
        public void Save()
        {
            string path = Path.Combine(InterfacePeople.WORKING_DIRECTORY, this.ToString());
            if (!string.IsNullOrEmpty(path))
            {
                FileInfo fi = new FileInfo(path);
                if (!Directory.Exists(fi.DirectoryName)) { Directory.CreateDirectory(path); }
                using (StreamWriter sw = new StreamWriter(path, false)) { sw.Write(ExportJson()); }
            }
        }
        public void Load(string path)
        {

        }
        public string ExportJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
