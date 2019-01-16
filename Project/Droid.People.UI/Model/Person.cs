// Log code 04 00

using Droid.Scheduler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Tools.Utilities;

namespace Droid.People
{
    [Serializable]
    public class Person : Entity
    {
        #region Attribute
        protected const int DEFAULTATTRIBUTSLEVEL = 10;

        protected Caracteristics _caracteristics;
        protected Humors _currentHumors;
        protected FirstName _firstname;
        protected string _nickName;
        protected DateTime _birthday;
        protected List<Person> _chiefs;
        protected List<Person> _teamMembers;
        //private List<Image> _pictures;
        protected List<Activities> _activities;
        protected List<Project> _projects;
        protected List<Skill> _skills;
        protected string _nationality;
        protected Gender _gender;
        protected List<string> _documents;
        //private string _workingDirectory;
        protected List<string> _serializedPictures;
        #endregion

        #region Properties
        //[JsonProperty(PropertyName = "workingDirectory")]
        //public string WorkingDirectory
        //{
        //    get { return _workingDirectory; }
        //    set { _workingDirectory = value; }
        //}
        [JsonProperty(PropertyName = "documents")]
        public List<string> Documents
        {
            get { return _documents; }
        }
        [JsonProperty(PropertyName = "caracteristics")]
        public Caracteristics Caracteristics
        {
            get { return _caracteristics; }
            set { _caracteristics = value; }
        }
        [JsonProperty(PropertyName = "firstname")]
        public FirstName FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        [JsonProperty(PropertyName = "birthday")]
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        [JsonProperty(PropertyName = "nickname")]
        public string Nickname
        {
            get { return _nickName; }
            set { _nickName = value; }
        }
        [JsonProperty(PropertyName = "chiefs")]
        public List<Person> Chiefs
        {
            get { return _chiefs; }
            set { _chiefs = value; }
        }
        [JsonProperty(PropertyName = "teammembers")]
        public List<Person> TeamMembers
        {
            get { return _teamMembers; }
            set { _teamMembers = value; }
        }
        [XmlIgnore]
        [JsonIgnore]
        public List<System.Drawing.Image> Pictures
        {
            get
            {
                List<System.Drawing.Image> li = new List<System.Drawing.Image>();
                foreach (var item in _serializedPictures)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        try
                        {
                            byte[] array = Convert.FromBase64String(item);
                            li.Add(System.Drawing.Image.FromStream(new MemoryStream(array)));
                        }
                        catch (Exception exp)
                        {
                            Log.Write("[ ERR : 0400 ] Error while converting image to string. \n\n" + exp.Message);
                        }

                        //li.Add(Droid.Image.Interface_image.ACTION_137_unserialize_image(item));
                    }
                }
                return li;
            }
            //set
            //{
            //    if (_serializedPictures == null) _serializedPictures = new List<string>();
            //    foreach (var item in value)
            //    {
            //        if (item != null)
            //        {
            //            MemoryStream ms = new MemoryStream();
            //            item.Save(ms, item.RawFormat);
            //            byte[] array = ms.ToArray();
            //            _serializedPictures.Add(Convert.ToBase64String(array));

            //            //_serializedPictures.Add(Droid.Image.Interface_image.ACTION_136_serialize_image(item));
            //        }
            //    }
            //}

            //get { return _pictures; }
            //set { _pictures = value; }
        }
        [JsonProperty(PropertyName = "activities")]
        public List<Activities> Activities
        {
            get { return _activities; }
            set { _activities = value; }
        }
        [JsonProperty(PropertyName = "projects")]
        public List<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }
        [JsonProperty(PropertyName = "skills")]
        public List<Skill> Skills
        {
            get { return _skills; }
            set { _skills = value; }
        }
        [JsonProperty(PropertyName = "nationality")]
        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }
        [JsonProperty(PropertyName = "pictureserialised")]
        public List<string> SerializedPicture
        {
            get { return _serializedPictures; }
            set { _serializedPictures = value; }
            //get
            //{
            //    List<string> ls = new List<string>();
            //    if (_pictures != null)
            //    { 
            //        foreach (var item in _pictures)
            //        {
            //            if (item != null)
            //            {
            //                try
            //                {
            //                    MemoryStream ms = new MemoryStream();
            //                    item.Save(ms, item.RawFormat);
            //                    byte[] array = ms.ToArray();
            //                    string imgString = Convert.ToBase64String(array);
            //                    string _serialiseString = Convert.ToBase64String(array);

            //                    ls.Add(_serialiseString);
            //                }
            //                catch (Exception exp)
            //                {
            //                    Log.Write("[ ERR : 0400 ] Error while converting image to string. \n\n" + exp.Message);
            //                }
            //            }
            //        }
            //    }
            //    return ls;
            //}
            //set
            //{
            //    _serializedPictures = value;
            //    List<Image> li = new List<Image>();
            //    foreach (var item in value)
            //    {
            //        if (!string.IsNullOrEmpty(item))
            //        { 
            //            li.Add(Droid.Image.Interface_image.ACTION_137_unserialize_image(item));
            //        }
            //    }
            //    _pictures = li;
            //}
        }
        [JsonProperty(PropertyName = "gender")]
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        [JsonProperty(PropertyName = "humors")]
        public Humors CurrentHumors
        {
            get { return _currentHumors; }
            set { _currentHumors = value; }
        }
        #endregion

        #region Constructor
        public Person()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            _id = string.Format("people.{0}-{1}-{2}", rand.Next(), (int)DateTime.Now.Ticks, rand.Next());

            _gender = Gender.UNKNOW;
            _chiefs = new List<Person>();
            _teamMembers = new List<Person>();
            _serializedPictures = new List<string>();
            _activities = new List<Droid.People.Activities>();
            _projects = new List<Project>();
            _skills = new List<Skill>();
            _documents = new List<string>();
            _caracteristics = new Caracteristics(DEFAULTATTRIBUTSLEVEL);
            _firstname = new FirstName();
            //_workingDirectory = Path.Combine(workingDirectory, _id);
        }
        public Person(string firstname, string familyname)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            _id = string.Format("people.{0}-{1}-{2}", rand.Next(), (int)DateTime.Now.Ticks, rand.Next());

            Person p = PeopleControler.Search(firstname, familyname);
            Import(p, this);
        }
        public Person(string pathFile)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            _id = string.Format("people.{0}-{1}-{2}", rand.Next(), (int)DateTime.Now.Ticks, rand.Next());

            //_gender = GENDER.UNKNOW;
            _chiefs = new List<Person>();
            _teamMembers = new List<Person>();
            //_pictures = new List<Image>();
            _serializedPictures = new List<string>();
            _activities = new List<Droid.People.Activities>();
            _projects = new List<Project>();
            _skills = new List<Skill>();
            _documents = new List<string>();
            _firstname = new FirstName();
            //_workingDirectory = Path.Combine(workingDirectory, _id);

            LoadPerson(pathFile);
        }
        public Person(string id, DataTable dumpDatabaseInfo, DataTable dumpDatabaseAttributs) : base()
        {
            _gender = Gender.UNKNOW;
            _chiefs = new List<Person>();
            _teamMembers = new List<Person>();
            _serializedPictures = new List<string>();
            _activities = new List<Droid.People.Activities>();
            _projects = new List<Project>();
            _skills = new List<Skill>();
            _documents = new List<string>();
            _caracteristics = new Caracteristics(DEFAULTATTRIBUTSLEVEL);
            _firstname = new FirstName();

            _id = id;
            LoadAttributs(dumpDatabaseAttributs);
            LoadInformation(dumpDatabaseInfo);
        }
        #endregion

        #region Methods public
        public new object Clone()
        {
            Person p = new Person();
            p._activities = _activities;
            p._birthday = _birthday;
            p._chiefs = _chiefs;
            p._comment = _comment;
            p._documents = _documents;
            p._name = _name;
            p._firstname = _firstname;
            p._gender = _gender;
            p._id = _id;
            p._mail = _mail;
            p._nationality = _nationality;
            p._nickName = _nickName;
            p._serializedPictures = _serializedPictures;
            p._projects = _projects;
            p._skills = _skills;
            p._teamMembers = _teamMembers;

            p._caracteristics.Perception = _caracteristics.Perception;
            p._caracteristics.Franchise = _caracteristics.Franchise;
            p._caracteristics.Vivacite = _caracteristics.Vivacite;
            p._caracteristics.Coordination = _caracteristics.Coordination;
            p._caracteristics.Humilite = _caracteristics.Humilite;
            p._caracteristics.Crualite = _caracteristics.Crualite;
            p._caracteristics.Instinct_de_survie = _caracteristics.Instinct_de_survie;
            p._caracteristics.Patience = _caracteristics.Patience;
            p._caracteristics.Determination = _caracteristics.Determination;
            p._caracteristics.Imagination = _caracteristics.Imagination;
            p._caracteristics.Curiosite = _caracteristics.Curiosite;
            p._caracteristics.Agressivite = _caracteristics.Agressivite;
            p._caracteristics.Loyaute = _caracteristics.Loyaute;
            p._caracteristics.Empathie = _caracteristics.Empathie;
            p._caracteristics.Tenacite = _caracteristics.Tenacite;
            p._caracteristics.Courage = _caracteristics.Courage;
            p._caracteristics.Sensualite = _caracteristics.Sensualite;
            p._caracteristics.Charme = _caracteristics.Charme;
            p._caracteristics.Humour = _caracteristics.Humour;

            //p._workingDirectory = _workingDirectory;
            return p;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", (_firstname != null && !string.IsNullOrEmpty(_firstname.Value)) ? _firstname.Value : "_______", !string.IsNullOrEmpty(_name) ? _name.ToUpper() : "_______");
        }
        public void Save(string path)
        {
            //SaveFile(GenerateXml());
            SaveFile(path);
        }
        public void AddDocument(string workingDirectory, ref string document)
        {
            FileInfo documentFi = new FileInfo(document);

            if (Path.Combine(workingDirectory, _id, documentFi.Name) != documentFi.FullName)
            { 
                if (!Directory.Exists(Path.Combine(workingDirectory, _id))) Directory.CreateDirectory(Path.Combine(workingDirectory, _id));
                if (File.Exists(Path.Combine(workingDirectory, _id, documentFi.Name))) { File.Delete(Path.Combine(workingDirectory, _id, documentFi.Name)); }
                File.Copy(documentFi.FullName, Path.Combine(workingDirectory, _id, documentFi.Name));
                //document = Path.Combine(workingDirectory, _id, documentFi.Name);
                _documents.Add(documentFi.Name);
            }
            Save(workingDirectory);
        }
        public void RemoveDocument(string workingDirectory, string document)
        {
            File.Delete(document);
            _documents.Remove(Path.GetFileName(document));
            Save(workingDirectory);
        }
        public string GetName()
        {
            return string.Format("{0} {1}", _name.ToUpper(), _firstname.Value.Substring(0, 1).ToUpper() + _firstname.Value.Substring(1, _firstname.Value.Length - 1).ToLower());
        }

        public static Person GetUserByText(object o, List<Person> persons)
        {
            if (o == null) return null;
            string personText = o.ToString();

            foreach (Person person in persons)
            {
                if (personText.Equals(person.ToString()))
                {
                    return person;
                }
            }
            return null;
        }
        public static Person GetPersonFromId(string id, List<Person> persons)
        {
            var lst = persons.Where(u => u.Id.Equals(id)).ToList();
            if (lst.Count > 0) return lst.First();
            else return null;
        }
        public static string GetFullName(Person person)
        {
            string fullName = string.Empty;

            if (!string.IsNullOrEmpty(person.Name) && !string.IsNullOrEmpty(person.FirstName.Value)) { fullName = person.FirstName.Value.Substring(0, 1).ToUpper() + person.FirstName.Value.Substring(1, person.FirstName.Value.Length - 1).ToLower() + " " + person.Name.ToUpper(); }
            else if (string.IsNullOrEmpty(person.Name) && !string.IsNullOrEmpty(person.FirstName.Value)) { fullName = person.Name.ToUpper(); }
            else if (!string.IsNullOrEmpty(person.Name) && string.IsNullOrEmpty(person.FirstName.Value)) { fullName = person.FirstName.Value.Substring(0, 1).ToUpper() + person.FirstName.Value.Substring(1, person.FirstName.Value.Length - 1).ToLower(); }
            else { fullName = "UNKNOW PERSON"; }

            return fullName;
        }
        #endregion

        #region Methods private
        private void SaveFile(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!Directory.Exists(Path.Combine(path, _id)))
            {
                Directory.CreateDirectory(Path.Combine(path, _id));
            }
            string filePath = Path.Combine(path, string.Format("{0}//{0}.xml", _id));
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.Write(JsonConvert.SerializeObject(this));
            }
        }
        private void Import(Person source, Person target)
        {
            target._activities = source._activities;
            target._birthday = source._birthday;
            target._chiefs = source._chiefs;
            target._comment = source._comment;
            target._documents = source._documents;
            target._name = source._name;
            target._firstname = source._firstname;
            target._gender = source._gender;
            target._id = source._id;
            target._mail = source._mail;
            target._nationality = source._nationality;
            target._nickName = source._nickName;
            //target._pictures = source._pictures;
            target._serializedPictures = source._serializedPictures;
            target._projects = source._projects;
            target._skills = source._skills;
            target._teamMembers = source._teamMembers;
            //target._workingDirectory = _workingDirectory;

            target.Caracteristics = new Caracteristics();
            target.Caracteristics.Perception = source.Caracteristics.Perception;
            target.Caracteristics.Franchise = source.Caracteristics.Franchise;
            target.Caracteristics.Vivacite = source.Caracteristics.Vivacite;
            target.Caracteristics.Coordination = source.Caracteristics.Coordination;
            target.Caracteristics.Humilite = source.Caracteristics.Humilite;
            target.Caracteristics.Crualite = source.Caracteristics.Crualite;
            target.Caracteristics.Instinct_de_survie = source.Caracteristics.Instinct_de_survie;
            target.Caracteristics.Patience = source.Caracteristics.Patience;
            target.Caracteristics.Determination = source.Caracteristics.Determination;
            target.Caracteristics.Imagination = source.Caracteristics.Imagination;
            target.Caracteristics.Curiosite = source.Caracteristics.Curiosite;
            target.Caracteristics.Agressivite = source.Caracteristics.Agressivite;
            target.Caracteristics.Loyaute = source.Caracteristics.Loyaute;
            target.Caracteristics.Empathie = source.Caracteristics.Empathie;
            target.Caracteristics.Tenacite = source.Caracteristics.Tenacite;
            target.Caracteristics.Courage = source.Caracteristics.Courage;
            target.Caracteristics.Sensualite = source.Caracteristics.Sensualite;
            target.Caracteristics.Charme = source.Caracteristics.Charme;
            target.Caracteristics.Humour = source.Caracteristics.Humour;

            source = null;
        }
        private void LoadPerson(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                using (StreamReader sr = new StreamReader(pathFile))
                {
                    var json = sr.ReadToEnd();
                    var data = JsonConvert.DeserializeObject<Person>(json);
                    if (data != null) { Import(data, this); }
                }
            }
            else if (Directory.Exists(pathFile))
            {
                foreach (string file in Directory.GetFiles(pathFile))
                {
                    if (Path.GetFileName(file).StartsWith("people.") && Path.GetExtension(file).Equals(".xml"))
                    {
                        using (StreamReader sr = new StreamReader(file))
                        {
                            var json = sr.ReadToEnd();
                            var data = JsonConvert.DeserializeObject<Person>(json);
                            if (data != null)
                            {
                                Import(data, this);
                            }
                        }
                        break;
                    }
                }
            }
        }
        private void LoadAttributs(DataTable attributs)
        {
            foreach (DataRow row in attributs.Rows)
            {
                switch (row[0].ToString().ToUpper())
                {
                    case "PERCEPTION":
                        _caracteristics.Perception = int.Parse(row[1].ToString());
                        break;
                    case "FRANCHISE":
                        _caracteristics.Franchise = int.Parse(row[1].ToString());
                        break;
                    case "VIVACITE":
                        _caracteristics.Vivacite = int.Parse(row[1].ToString());
                        break;
                    case "COORDINATION":
                        _caracteristics.Coordination = int.Parse(row[1].ToString());
                        break;
                    case "HUMILITE":
                        _caracteristics.Humilite = int.Parse(row[1].ToString());
                        break;
                    case "CRUALITE":
                        _caracteristics.Crualite = int.Parse(row[1].ToString());
                        break;
                    case "INSTINCT_DE_SURVIE":
                        _caracteristics.Instinct_de_survie = int.Parse(row[1].ToString());
                        break;
                    case "PATIENCE":
                        _caracteristics.Patience = int.Parse(row[1].ToString());
                        break;
                    case "DETERMINATION":
                        _caracteristics.Determination = int.Parse(row[1].ToString());
                        break;
                    case "IMAGINATION":
                        _caracteristics.Imagination = int.Parse(row[1].ToString());
                        break;
                    case "CURIOSITE":
                        _caracteristics.Curiosite = int.Parse(row[1].ToString());
                        break;
                    case "AGRESSIVITE":
                        _caracteristics.Agressivite = int.Parse(row[1].ToString());
                        break;
                    case "LOYAUTE":
                        _caracteristics.Loyaute = int.Parse(row[1].ToString());
                        break;
                    case "EMPATHIE":
                        _caracteristics.Empathie = int.Parse(row[1].ToString());
                        break;
                    case "TENACITE":
                        _caracteristics.Tenacite = int.Parse(row[1].ToString());
                        break;
                    case "COURAGE":
                        _caracteristics.Courage = int.Parse(row[1].ToString());
                        break;
                    case "SENSUALITE":
                        _caracteristics.Sensualite = int.Parse(row[1].ToString());
                        break;
                    case "CHARME":
                        _caracteristics.Charme = int.Parse(row[1].ToString());
                        break;
                    case "HUMOUR":
                        _caracteristics.Perception = int.Parse(row[1].ToString());
                        break;
                }
            }
        }
        private void LoadInformation(DataTable info)
        {
            foreach (DataRow row in info.Rows)
            {
                switch (row[0].ToString().ToUpper())
                {
                    case "NOM":
                        _name = row[1].ToString();
                        break;
                    case "PRENOM":
                        _firstname.Value = row[1].ToString();
                        break;
                    case "NATIONALITE":
                        _nationality = row[1].ToString();
                        break;
                }
            }
        }
        private void LoadPersonXml(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                Person p;
                string serializedObject = string.Empty;
                string fileData = string.Empty;
                using (StreamReader sr = new StreamReader(pathFile))
                {
                    fileData = sr.ReadToEnd();
                }

                XmlSerializer xsSubmit = new XmlSerializer(typeof(Person));
                using (var sww = new StringReader(fileData))
                {
                    using (XmlReader reader = XmlReader.Create(sww))
                    {
                        p = (Person)xsSubmit.Deserialize(reader);
                    }
                }
                
                Import(p, this);
            }
        }
        private string GenerateXml()
        {
            string serializedObject = string.Empty;

            XmlSerializer xsSubmit = new XmlSerializer(typeof(Person));
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, this);
                    serializedObject = sww.ToString();
                }
            }
            return serializedObject;
        }
        private void SaveFileXml(string workingDirectory, string xmlObject)
        {
            if (!Directory.Exists(Path.Combine(workingDirectory, _id)))
            {
                Directory.CreateDirectory(Path.Combine(workingDirectory, _id));
            }
            string filePath = Path.Combine(workingDirectory, _id, string.Format("{0}.xml", _id));
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.Write(xmlObject);
            }
        }
        #endregion
    }
}
