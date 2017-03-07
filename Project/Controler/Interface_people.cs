using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_People
{
    public delegate void InterfaceEventHandler();
    public class Interface_people : GPInterface
    {
        #region Attribute
        public readonly int TOP_OFFSET = 175;
        public event InterfaceEventHandler SheetDisplayRequested;

        private ToolStripMenuPeople _tsm;
        private Panel _sheet;
        private string _workingDirectory;
        
        private PersonView _viewDetail;
        private ViewUserSearch _viewSearch;
        private ViewWebResult _viewWebResult;

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
        public Panel Sheet
        {
            get { return _sheet; }
            set { _sheet = value; }
        }
        public ToolStripMenuPeople Tsm
        {
            get { return _tsm; }
            set { _tsm = value as ToolStripMenuPeople; }
        }
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        #endregion

        #region Constructor
        public Interface_people(string workingDirectory)
        {
            _workingDirectory = workingDirectory;

            Init();
        }
        #endregion

        #region Methods public
        #region Methods Public override
        public override void GlobalAction(object sender, EventArgs e)
        {
            ToolBarEventArgs tbea = e as ToolBarEventArgs;
            string action = tbea.EventText;
            GoAction(action);
        }
        public override void Resize()
        {
            foreach (Control ctrl in _sheet.Controls)
            {
                if (ctrl.Name.Equals("CurrentView"))
                {
                    ctrl.Left = (_sheet.Width / 2) - (ctrl.Width / 2);
                }
            }
        }
        #endregion

        public System.Windows.Forms.RibbonTab BuildToolBar()
        {
            _tsm = new ToolStripMenuPeople();
            _tsm.ActionAppened += GlobalAction;
            return _tsm;
        }

        #region ACTIONS
        //public static void ACTION_lancer_docker_130()
        //{
        //    ViewDocker ddp = new ViewDocker();
        //    //ddp.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        //    //ddp.ShowDialog();
        //}
        #endregion

        public void GoAction(string action)
        {
            switch (action)
            {
                case "Search":
                    LaunchSearch();
                    break;
                case "Web activity":
                    LaunchWeb();
                    break;
                case "Create":
                    LaunchCreate();
                    break;
                case "Open":
                    LaunchOpen();
                    break;
                case "RefreshContacts":
                    LaunchLoad();
                    break;
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _persons = new List<Person>();

            _sheet = new Panel();
            _sheet.BackgroundImage = Properties.Resources.ShieldTileBg;
            _sheet.BackgroundImageLayout = ImageLayout.Tile;
            _sheet.Dock = DockStyle.Fill;
            _sheet.Resize += _sheet_Resize;
            
            _viewDetail = new PersonView(this);
            _viewDetail.Name = "CurrentView";

            _viewWebResult = new ViewWebResult(this);
            _viewWebResult.Name = "CurrentView";

            _viewSearch = new ViewUserSearch(this);
            _viewSearch.Name = "CurrentView";
            _viewSearch.RequestUserDetail += _viewSearch_RequestUserDetail;
            _viewSearch.RequestUserEdition += _viewSearch_RequestUserEdition;

            BuildToolBar();
            LaunchLoad();
        }

        private void LaunchOpen()
        {
            _sheet.Controls.Clear();
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Xml files (.xml)|*.xml;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _currentPerson = new Person(_workingDirectory, ofd.FileName);
                //_currentPerson.WorkingDirectory = Path.Combine(_workingDirectory, _currentPerson.Id);

                _viewDetail.RefreshData();
                _viewDetail.Top = TOP_OFFSET;
                _viewDetail.Left = (_sheet.Width / 2) - (_viewDetail.Width / 2);
                _viewDetail.ChangeLanguage();
                _viewDetail.IsEditable = false;
                _sheet.Controls.Add(_viewDetail);
                if (SheetDisplayRequested != null) SheetDisplayRequested();
            }
        }
        private void LaunchCreate()
        {
            _sheet.Controls.Clear();

            _currentPerson = new Person(_workingDirectory);
            //_currentPerson.WorkingDirectory = Path.Combine(_workingDirectory, _currentPerson.Id);

            _viewDetail.Top = TOP_OFFSET;
            _viewDetail.RefreshData();
            _viewDetail.Left = (_sheet.Width / 2) - (_viewDetail.Width / 2);
            _viewDetail.ChangeLanguage();
            _viewDetail.IsEditable = true;
            _sheet.Controls.Add(_viewDetail);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        private void LaunchEdit()
        {
            if (_currentPerson != null)
            {
                _sheet.Controls.Clear();
                //_currentPerson.WorkingDirectory = Path.Combine(_workingDirectory, _currentPerson.Id);

                _viewDetail.Top = TOP_OFFSET;
                _viewDetail.RefreshData();
                _viewDetail.Left = (_sheet.Width / 2) - (_viewDetail.Width / 2);
                _viewDetail.ChangeLanguage();
                _viewDetail.IsEditable = true;
                _sheet.Controls.Add(_viewDetail);
                if (SheetDisplayRequested != null) SheetDisplayRequested();
            }
        }
        private void LaunchDetail()
        {
            if (_currentPerson != null)
            {
                _sheet.Controls.Clear();
                //_currentPerson.WorkingDirectory = Path.Combine(_workingDirectory, _currentPerson.Id);

                _viewDetail.Top = TOP_OFFSET;
                _viewDetail.RefreshData();
                _viewDetail.Left = (_sheet.Width / 2) - (_viewDetail.Width / 2);
                _viewDetail.ChangeLanguage();
                _viewDetail.IsEditable = false;
                _sheet.Controls.Add(_viewDetail);
                if (SheetDisplayRequested != null) SheetDisplayRequested();
            }
        }
        private void LaunchWeb()
        {
            _sheet.Controls.Clear();

            _viewWebResult.Top = TOP_OFFSET;
            _viewWebResult.RefreshData();
            _viewWebResult.Left = (_sheet.Width / 2) - (_viewWebResult.Width / 2);
            _viewWebResult.ChangeLanguage();
            _sheet.Controls.Add(_viewWebResult);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        private void LaunchSearch()
        {
            _sheet.Controls.Clear();
            
            _viewSearch.Top = TOP_OFFSET;
            _viewSearch.RefreshData();
            _viewSearch.Left = (_sheet.Width / 2) - (_viewSearch.Width / 2);
            _viewSearch.ChangeLanguage();
            _sheet.Controls.Add(_viewSearch);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        private void LaunchLoad()
        {
            Person p;

            _sheet.Controls.Clear();

            _tsm.StartRefreshLib();
            _persons.Clear();
            foreach (string dir in Directory.GetDirectories(_workingDirectory))
            {
                if (dir.Replace(Path.GetDirectoryName(dir) + "\\", string.Empty).StartsWith("people."))
                {
                    p = new Person(dir);
                    _persons.Add(p);
                }
            }
            _tsm.EndRefreshLib();
        }
        #endregion

        #region Event
        private void _sheet_Resize(object sender, EventArgs e)
        {
            Resize();
        }
        private void _viewSearch_RequestUserEdition(object o)
        {
            _currentPerson = o as Person;
            LaunchEdit();
        }
        private void _viewSearch_RequestUserDetail(object o)
        {
            _currentPerson = o as Person;
            LaunchDetail();
        }
        #endregion
    }
}
