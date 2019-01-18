using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid.People.UI
{
    public delegate void SearchPersonEventHandler();
    public partial class CreatePerson : UserControl
    {
        #region Attribute
        public event SearchPersonEventHandler ResearchCompleted;

        private Person _currentPerson;
        private string _workingDirectory;
        #endregion

        #region Properties
        public Person CurrentPerson
        {
            get { return _currentPerson; }
            set { _currentPerson = value; }
        }
        #endregion

        #region Constructor
        public CreatePerson(string workingDirectory)
        {
            _workingDirectory = workingDirectory;

            InitializeComponent();
        }
        #endregion

        #region Methods public
        public void ChangeLanguage()
        {

        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        private void button1_Click(object sender, EventArgs e)
        {
            //_currentPerson = PeopleControler.Search(textBoxKeyWords.Text, _workingDirectory);
            //_currentPerson.Save(_intPeo.);
            //if (ResearchCompleted != null) ResearchCompleted();
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Xml files (.xml)|*.xml;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _currentPerson = new Person(_workingDirectory, ofd.FileName);
                if (ResearchCompleted != null) ResearchCompleted();
            }
        }
        #endregion
    }
}
