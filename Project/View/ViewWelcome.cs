using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools4Libraries;
using Droid_Geography;

namespace Droid_People
{
    public delegate void ViewWelcomeEventHandler(object o);
    public partial class ViewWelcome : UserControlCustom
    {
        #region Attribute
        public event ViewUserEventHandler UserDetailRequested;

        private Dictionary<string, int> _nationalities;
        private Interface_people _intPeo;
        private int[] _ages = new int[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 999 };
        #endregion

        #region Properties
        public Interface_people InterfacePeople
        {
            get { return _intPeo; }
            set { _intPeo = value; }
        }
        #endregion

        #region Constructor
        public ViewWelcome()
        {
            InitializeComponent();
            Init();
        }
        public ViewWelcome(Interface_people intPeo)
        {
            _intPeo = intPeo;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void ChangeLanguage()
        {
            labelName.Text = GetText.Text("currentNationalities");
        }
        public override void RefreshData()
        {
            LoadNationalities();
            LoadPopulation();
            userList.RefreshData();
        }
        public void Init()
        {
            //GetUserMask();
            _nationalities = new Dictionary<string, int>();
            worldMapView.CurrentWorldMap.Mode = WorldMap.PresentationMode.CUSTOM;
            userList.Persons = _intPeo.Persons;
            userList.PersonDetailRequested += UserList_PersonDetailRequested;
            //_dataGridViewUser.Rows.Clear();
            //_dataGridViewUser.DataSource = _intPeo.Persons;
        }
        #endregion

        #region Methods private
        private void LoadNationalities()
        {
            if (_intPeo != null)
            {
                _nationalities.Clear();
                foreach (Person person in _intPeo.Persons)
                {
                    if (!_nationalities.ContainsKey(person.Nationality)) { _nationalities.Add(person.Nationality, _intPeo.Persons.Where(u => person.Nationality.Equals(u.Nationality)).Count()); }
                }

                worldMapView.CurrentWorldMap.ClearCustomValues();
                chartCountries.Series["Series1"].Points.Clear();
                foreach (var nat in _nationalities.OrderBy(n => n.Value))
                {
                    chartCountries.Series["Series1"].Points.AddXY(nat.Key, nat.Value);
                    if (!string.IsNullOrEmpty(nat.Key))
                    {
                        var country = worldMapView.CurrentWorldMap.Countries.Where(c => c.Name.Equals(nat.Key)).First();
                        if (country != null)
                        {
                            worldMapView.CurrentWorldMap.Countries.Where(c => c.Name.Equals(nat.Key)).First().CustomValue = nat.Value;
                        }
                    }
                }
            }
            worldMapView.UpdateMap();
        }
        private void LoadPopulation()
        {
            int age;
            int[] lstMale = new int[_ages.Length];
            int[] lstFemal = new int[_ages.Length];

            for (int i = 0; i < _ages.Length; i++)
            {
                lstMale[i] = 0;
                lstFemal[i] = 0;
            }
            if (_intPeo != null)
            {
                chartPyramidAge.Series["SeriesMale"].Points.Clear();
                chartPyramidAge.Series["SeriesFemal"].Points.Clear();
                foreach (Person person in _intPeo.Persons)
                {
                    age = Convert.ToInt16((DateTime.Now - person.Birthday).Days / 365.25);
                    if (person.Birthday != DateTime.MinValue)
                    {
                        if (person.Gender == Person.GENDER.MALE)
                        {
                            for (int i = 0; i < _ages.Length; i++)
                            {
                                if (age < _ages[i])
                                {
                                    lstMale[i - 1]++;
                                    break;
                                }
                            }
                        }
                        if (person.Gender == Person.GENDER.FEMAL)
                        {
                            for (int i = 0; i < _ages.Length; i++)
                            {
                                if (age < _ages[i])
                                {
                                    lstFemal[i - 1]++;
                                    break;
                                }
                            }
                        }
                    }
                }
                int max = 0;
                for (int i = 0; i < _ages.Length - 1; i++)
                {
                    if (lstMale[i] > max) max = lstMale[i];
                    if (lstFemal[i] > max) max = lstFemal[i];

                    if (i == 0)
                    {
                        chartPyramidAge.Series["SeriesMale"].Points.AddXY(string.Format("Under {0}", _ages[i + 1]), lstMale[i]);
                        chartPyramidAge.Series["SeriesFemal"].Points.AddXY(string.Format("under {0}", _ages[i + 1]), lstFemal[i]);
                    }
                    else if (i + 1 < _ages.Length && i != _ages.Length - 2)
                    {
                        chartPyramidAge.Series["SeriesMale"].Points.AddXY(string.Format("{0} - {1}", _ages[i], _ages[i + 1]), lstMale[i]);
                        chartPyramidAge.Series["SeriesFemal"].Points.AddXY(string.Format("{0} - {1}", _ages[i], _ages[i + 1]), lstFemal[i]);
                    }
                    else
                    {
                        chartPyramidAge.Series["SeriesMale"].Points.AddXY(string.Format("Over {0}", _ages[i]), lstMale[i]);
                        chartPyramidAge.Series["SeriesFemal"].Points.AddXY(string.Format("Over {0}", _ages[i]), lstFemal[i]);
                        break;
                    }
                }

                chartPyramidAge.ChartAreas["ChartAreaPyramidMale"].AxisY.Minimum = 0;
                chartPyramidAge.ChartAreas["ChartAreaPyramidMale"].AxisY.Maximum = max;
                chartPyramidAge.ChartAreas["ChartAreaPyramidFemal"].AxisY.Minimum = 0;
                chartPyramidAge.ChartAreas["ChartAreaPyramidFemal"].AxisY.Maximum = max;
            }
        }
        private void AdjustWindows()
        {
            this.Invalidate();
            this.SuspendLayout();
            panelCountries.Top = worldMapView.Top + worldMapView.Height + 25;
            this.Height = panelCountries.Height + worldMapView.Height  + 100;
            this.ResumeLayout();
            this.Invalidate();
        }
        private void GetUserMask()
        {
            //Image img = Droid_Image.Interface_image.ACTION_138_apply_mask(Image.FromFile(@"D:\Images\tmp\montagne.jpg"), Image.FromFile(@"D:\Images\tmp\mask.png"));
            //img.Save(@"D:\Images\tmp\montagneRound.jpg");
        }
        private void UserList_PersonDetailRequested(Person p)
        {
            if (UserDetailRequested != null) UserDetailRequested(p);
        }
        #endregion
    }
}
