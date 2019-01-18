using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Droid.People.UI
{
    public partial class UserDetail : UserControl
    {
        #region Attributes
        private Person _currentPerson;
        #endregion

        #region Properties
        public Person CurrentPerson
        {
            get { return _currentPerson; }
            set
            {
                _currentPerson = value;
                LoadPerson();
            }
        }
        #endregion

        #region Constructor
        public UserDetail()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void Refresh()
        {
            LoadPerson();
            base.Refresh();
        }
        #endregion

        #region Methods private
        private void Init()
        {

        }
        public void LoadPerson()
        {
            string fullName;
            chartCaracteristics.Series["Series1"].Points.Clear();
            if (_currentPerson != null)
            {
                foreach (FieldInfo field in typeof(Caracteristics).GetFields())
                {
                    chartCaracteristics.Series["Series1"].Points.AddXY(field.Name, field.GetValue(_currentPerson.Caracteristics));
                }
                foreach (FieldInfo field in typeof(Humors).GetFields())
                {
                    chartHumor.Series["Series1"].Points.AddXY(field.Name, field.GetValue(_currentPerson.Caracteristics));
                }

                labelFullName.Text = Person.GetFullName(_currentPerson);
                labelFamilyName.Text = string.IsNullOrEmpty(_currentPerson.Name) ? "_______" : _currentPerson.Name;
                labelFirstname.Text = _currentPerson.FirstName == null ? "_______" : _currentPerson.FirstName.Value;
                labelNationality.Text = _currentPerson.Nationality == null ? "_______" : _currentPerson.Nationality;
                labelGender.Text = _currentPerson.Gender.ToString();
                labelActivity.Text = _currentPerson.Activities.Count == 0 ? "_______" : _currentPerson.Activities[0].Name;
                labelMail.Text = string.IsNullOrEmpty(_currentPerson.Mail) ? "_______" : _currentPerson.Mail;
                labelBirthday.Text = _currentPerson.Birthday == DateTime.MinValue ? "_______" : _currentPerson.Birthday.Date.ToShortDateString();
            }
        }
        #endregion
    }
}
