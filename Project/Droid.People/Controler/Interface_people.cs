using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Tools.Utilities;

namespace Droid.People
{
    public class InterfacePeople : GPInterface
    {
        #region Attribute
        public static string WORKING_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-People\";
        public readonly int TOP_OFFSET = 150;

        public event InterfaceEventHandler SheetDisplayRequested;
        public event InterfaceEventHandler PeopleChanged;
        public event InterfaceEventHandler PeopleDetailRequested;

        private string _workingDirectory;
        
        private Person _currentPerson;
        private List<Person> _persons;
        #endregion

        #region Properties
        public List<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }
        public Person CurrentPerson
        {
            get { return _currentPerson; }
            set { _currentPerson = value; }
        }
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        #endregion

        #region Constructor
        public InterfacePeople(string workingDirectory = null)
        {
            _workingDirectory = workingDirectory;

            Init();
        }
        #endregion

        #region Methods public
        #region ACTIONS
        //public static void ACTION_lancer_docker_130()
        //{
        //    ViewDocker ddp = new ViewDocker();
        //    //ddp.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        //    //ddp.ShowDialog();
        //}
        #endregion

        public override void GoAction(string action)
        {
            switch (action)
            {
                case "RefreshContacts":
                    LaunchLoad();
                    break;
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            if (!Directory.Exists(WORKING_DIRECTORY)) { Directory.CreateDirectory(WORKING_DIRECTORY); }
            _persons = new List<Person>();
            LaunchLoad();
        }
        private void LaunchLoad()
        {
            Person p;
            
            _persons.Clear();
            if (!string.IsNullOrEmpty(_workingDirectory) && Directory.Exists(_workingDirectory))
            { 
                foreach (string dir in Directory.GetDirectories(_workingDirectory))
                {
                    if (dir.Replace(Path.GetDirectoryName(dir) + "\\", string.Empty).StartsWith("people."))
                    {
                        p = new Person(dir);
                        _persons.Add(p);
                    }
                }
            }
        }
        #endregion

        #region Event
        private void _viewWelcome_UserDetailRequested(object o)
        {
            _currentPerson = o as Person;
        }
        private void _viewSearch_RequestUserEdition(object o)
        {
            _currentPerson = o as Person;
        }
        private void _viewSearch_RequestUserDetail(object o)
        {
            _currentPerson = o as Person;
        }
        private void _viewDetail_PersonChanged(object o)
        {
            if (PeopleChanged != null) { PeopleChanged(o); }
        }
        #endregion
    }
}
