// Log code 04 00

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Tools4Libraries;

namespace Droid_People
{
    public class Person : ICloneable
    {
        #region Enum
        public enum GENDER
        {
            MALE,
            FEMAL,
            OTHER,
            UNKNOW
        }
        #endregion

        #region Attribute
        private string _familyName;
        private FirstName _firstname;
        private string _nickName;
        private DateTime _birthday;
        private List<Person> _chiefs;
        private List<Person> _teamMembers;
        //private List<Image> _pictures;
        private List<Activities> _activities;
        private List<Project> _projects;
        private List<Skill> _skills;
        private string _nationality;        
        private string _id;
        private GENDER _gender;
        private string _comment;
        private string _mail;
        private List<string> _documents;
        private string _workingDirectory;
        private List<string> _serializedPictures;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "workingDirectory")]
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        [JsonProperty(PropertyName = "documents")]
        public List<string> Documents
        {
            get { return _documents; }
        }
        [JsonProperty(PropertyName = "firstname")]
        public FirstName FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        [JsonProperty(PropertyName = "familyname")]
        public string FamilyName
        {
            get { return _familyName; }
            set { _familyName = value; }
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
        public List<Image> Pictures
        {
            get
            {
                List<Image> li = new List<Image>();
                foreach (var item in _serializedPictures)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        try
                        {
                            byte[] array = Convert.FromBase64String(item);
                            li.Add(Image.FromStream(new MemoryStream(array)));
                        }
                        catch (Exception exp)
                        {
                            Log.Write("[ ERR : 0400 ] Error while converting image to string. \n\n" + exp.Message);
                        }

                        //li.Add(Droid_Image.Interface_image.ACTION_137_unserialize_image(item));
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

            //            //_serializedPictures.Add(Droid_Image.Interface_image.ACTION_136_serialize_image(item));
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
            //            li.Add(Droid_Image.Interface_image.ACTION_137_unserialize_image(item));
            //        }
            //    }
            //    _pictures = li;
            //}
        }
        [JsonProperty(PropertyName = "comment")]
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [JsonProperty(PropertyName = "gender")]
        public GENDER Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        [JsonProperty(PropertyName = "mail")]
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        #endregion

        #region Constructor
        public Person()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            _id = string.Format("people.{0}-{1}-{2}", rand.Next(), (int)DateTime.Now.Ticks, rand.Next());

            _gender = GENDER.UNKNOW;
            _chiefs = new List<Person>();
            _teamMembers = new List<Person>();
            //_pictures = new List<Image>();
            _serializedPictures = new List<string>();
            _activities = new List<Droid_People.Activities>();
            _projects = new List<Project>();
            _skills = new List<Skill>();
            _documents = new List<string>();
            _workingDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-People", _id);
        }
        public Person(string workingDirectory)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            _id = string.Format("people.{0}-{1}-{2}", rand.Next(), (int)DateTime.Now.Ticks, rand.Next());

            _gender = GENDER.UNKNOW;
            _chiefs = new List<Person>();
            _teamMembers = new List<Person>();
            //_pictures = new List<Image>();
            _serializedPictures = new List<string>();
            _activities = new List<Droid_People.Activities>();
            _projects = new List<Project>();
            _skills = new List<Skill>();
            _documents = new List<string>();
            _workingDirectory = Path.Combine(workingDirectory, _id);
        }
        public Person(string workingDirectory, string pathFile)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            _id = string.Format("people.{0}-{1}-{2}", rand.Next(), (int)DateTime.Now.Ticks, rand.Next());

            _gender = GENDER.UNKNOW;
            _chiefs = new List<Person>();
            _teamMembers = new List<Person>();
            //_pictures = new List<Image>();
            _serializedPictures = new List<string>();
            _activities = new List<Droid_People.Activities>();
            _projects = new List<Project>();
            _skills = new List<Skill>();
            _documents = new List<string>();
            _workingDirectory = Path.Combine(workingDirectory, _id);
            
            LoadPerson(pathFile);
        }
        #endregion

        #region Methods public
        public object Clone()
        {
            Person p = new Person();
            p._activities = _activities;
            p._birthday = _birthday;
            p._chiefs = _chiefs;
            p._comment = _comment;
            p._documents = _documents;
            p._familyName = _familyName;
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
            p._workingDirectory = _workingDirectory;
            return p;
        }
        public void Save()
        {
            //SaveFile(GenerateXml());
            SaveFile();
        }
        public void AddDocument(ref string document)
        {
            FileInfo documentFi = new FileInfo(document);

            if (Path.Combine(_workingDirectory, documentFi.Name) != documentFi.FullName)
            { 
                if (!Directory.Exists(_workingDirectory)) Directory.CreateDirectory(_workingDirectory);
                if (File.Exists(Path.Combine(_workingDirectory, documentFi.Name))) { File.Delete(Path.Combine(_workingDirectory, documentFi.Name)); }
                File.Copy(documentFi.FullName, Path.Combine(_workingDirectory, documentFi.Name));
                document = Path.Combine(_workingDirectory, documentFi.Name);
                _documents.Add(document);
            }
            Save();
        }
        public void RemoveDocument(string document)
        {
            File.Delete(document);
            _documents.Remove(document);
            Save();
        }
        private void Import(Person source, Person target)
        {
            target._activities = source._activities;
            target._birthday = source._birthday;
            target._chiefs = source._chiefs;
            target._comment = source._comment;
            target._documents = source._documents;
            target._familyName = source._familyName;
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
            target._workingDirectory = source._workingDirectory;
            
            source = null;
        }
        #endregion

        #region Methods private
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
        }
        private void SaveFile()
        {
            if (!Directory.Exists(_workingDirectory))
            {
                Directory.CreateDirectory(_workingDirectory);
            }
            string filePath = Path.Combine(_workingDirectory, string.Format("{0}.xml", _id));
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.Write(JsonConvert.SerializeObject(this));
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
        private void SaveFileXml(string xmlObject)
        {
            if (!Directory.Exists(_workingDirectory))
            {
                Directory.CreateDirectory(_workingDirectory);
            }
            string filePath = Path.Combine(_workingDirectory, string.Format("{0}.xml", _id));
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.Write(xmlObject);
            }
        }
        #endregion
    }
}
