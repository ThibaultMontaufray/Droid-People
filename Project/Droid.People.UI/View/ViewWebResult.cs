﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utilities.UI;
using Tools.Utilities;

namespace Droid.People.UI
{
    public partial class ViewWebResult : UserControlCustom
    {
        #region Attribute
        private InterfacePeople _intPeo;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ViewWebResult(InterfacePeople intPeo)
        {
            _intPeo = intPeo;
            InitializeComponent();
            DisableGroupBox();
        }
        #endregion

        #region Methods public
        public override void ChangeLanguage()
        {
            labelSelectPerson.Text = GetText.Text("SelectPerson");
            labelTitleFirstName.Text = GetText.Text("FirstName");
            labelTitleCulture.Text = GetText.Text("Culture");
            labelTitleDescription.Text = GetText.Text("Description");
            labelTitleOrigine.Text = GetText.Text("Origine");
        }
        public override void RefreshData()
        {
            string persoText;
            comboBoxPersons.Items.Clear();
            foreach (Person person in _intPeo.Persons)
            {
                persoText = person.FirstName.Value + " " + person.Name;
                if (!comboBoxPersons.Items.Contains(persoText)) { comboBoxPersons.Items.Add(persoText); }
            }
        }
        #endregion

        #region Methods private
        private void EnableGroupBox()
        {
            groupBoxFacebook.Visible = true;
            groupBoxFirstName.Visible = true;
            groupBoxGoogle.Visible = true;
        }
        private void DisableGroupBox()
        {
            groupBoxFacebook.Visible = false;
            groupBoxFirstName.Visible = false;
            groupBoxGoogle.Visible = false;
        }
        private void SelectCurrentPerson()
        {
            string persoText;
            foreach (Person person in _intPeo.Persons)
            {
                persoText = person.FirstName.Value + " " + person.Name;
                if (comboBoxPersons.SelectedItem.Equals(persoText))
                {
                    _intPeo.CurrentPerson = person;
                    break;
                }
            }
        }
        private void Analyse()
        {
            SelectCurrentPerson();
            Person p = PeopleControler.Search(_intPeo.CurrentPerson.FirstName.Value, _intPeo.CurrentPerson.Name);

            if (p != null)
            {
                EnableGroupBox();
                AnalyseFirstName(p);
                AnalyseGoogle(p);
            }
            else
            {
                DisableGroupBox();
            }
        }
        private void AnalyseFirstName(Person p)
        {
            if (p.FirstName != null)
            { 
                labelFirstName.Text = p.FirstName.Value;
                labelCulture.Text = p.FirstName.Culture;
                labelDescription.Text = string.IsNullOrEmpty(p.FirstName.Description) ? string.Empty : p.FirstName.Description.Replace("|", ", ");
                labelOrigine.Text = p.FirstName.Origin;
            }
            else
            {
                labelFirstName.Text = "_______";
                labelCulture.Text = "_______";
                labelDescription.Text = "_______";
                labelOrigine.Text = "_______";
            }
        }
        private void AnalyseGoogle(Person p)
        {
            if (p.Pictures.Count > 0) pictureBox1.BackgroundImage = p.Pictures[0];
            if (p.Pictures.Count > 1) pictureBox2.BackgroundImage = p.Pictures[1];
            if (p.Pictures.Count > 2) pictureBox3.BackgroundImage = p.Pictures[2];
            if (p.Pictures.Count > 3) pictureBox4.BackgroundImage = p.Pictures[3];
            if (p.Pictures.Count > 4) pictureBox5.BackgroundImage = p.Pictures[4];
            if (p.Pictures.Count > 5) pictureBox6.BackgroundImage = p.Pictures[5];
            if (p.Pictures.Count > 6) pictureBox7.BackgroundImage = p.Pictures[6];
        }
        #endregion

        #region Event
        private void buttonAnalyse_Click(object sender, EventArgs e)
        {
            Analyse();
        }
        #endregion
    }
}
