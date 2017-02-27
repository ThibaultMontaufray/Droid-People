using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_People
{
    public partial class Demo : Form
    {
        #region Attribute
        private PersonView _personView;
        private readonly string WORKING_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-People";
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public Demo()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            Tools4Libraries.Log.ApplicationAppData = WORKING_DIRECTORY;

            createPerson = new View.CreatePerson(WORKING_DIRECTORY);
            createPerson.Dock = DockStyle.Fill;
            this.Controls.Add(createPerson);
            createPerson.ResearchCompleted += SearchPerson1_ResearchCompleted;

            _personView = new PersonView(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-People", createPerson.CurrentPerson);
        }
        private void SwithToPersonDetailView()
        {
            this.Width = 1053;
            this.Height = _personView.Height + 39;
            this.Controls.Clear();

            _personView.CurrentPerson = createPerson.CurrentPerson;
            this.Controls.Add(_personView);
        }
        #endregion

        #region Event
        private void SearchPerson1_ResearchCompleted()
        {
            SwithToPersonDetailView();
        }
        #endregion
    }
}
