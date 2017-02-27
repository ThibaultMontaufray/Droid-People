using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Droid_People
{
    public partial class PersonView : UserControl
    {
        #region Attribute
        private Person _currentPerson;
        private string _workingDirectory;
        private bool _editionMode = false;
        #endregion

        #region Properties
        public Person CurrentPerson
        {
            get { return _currentPerson; }
            set
            {
                _currentPerson = value;
                LoadPeople();
            }
        }
        #endregion

        #region Constructor
        public PersonView(string workingDirectory, Person person)
        {
            _workingDirectory = workingDirectory;

            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void LoadPeople()
        {
            if (_currentPerson != null)
            {
                if (_currentPerson.Pictures.Count > 0)
                {
                    pictureBox1.Tag = string.Empty;
                    pictureBox1.BackgroundImage = _currentPerson.Pictures[0];
                }
                else
                {
                    pictureBox1.Tag = "Default";
                    pictureBox1.BackgroundImage = _currentPerson.Gender == Person.GENDER.FEMAL ? imageList.Images[imageList.Images.IndexOfKey("shadow_woman")] : imageList.Images[imageList.Images.IndexOfKey("shadow_man")];
                }
                if (_currentPerson.Pictures.Count > 1)
                {
                    pictureBox2.Tag = string.Empty;
                    pictureBox2.BackgroundImage = _currentPerson.Pictures[1];
                }
                else
                {
                    pictureBox2.Tag = "Default";
                    pictureBox2.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
                }
                if (_currentPerson.Pictures.Count > 2)
                {
                    pictureBox3.Tag = string.Empty;
                    pictureBox3.BackgroundImage = _currentPerson.Pictures[2];
                }
                else
                {
                    pictureBox3.Tag = "Default";
                    pictureBox3.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
                }
                if (_currentPerson.Pictures.Count > 3)
                {
                    pictureBox4.Tag = string.Empty;
                    pictureBox4.BackgroundImage = _currentPerson.Pictures[3];
                }
                else
                {
                    pictureBox4.Tag = "Default";
                    pictureBox4.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
                }
                if (_currentPerson.Pictures.Count > 4)
                {
                    pictureBox5.Tag = string.Empty;
                    pictureBox5.BackgroundImage = _currentPerson.Pictures[4];
                }
                else
                {
                    pictureBox5.Tag = "Default";
                    pictureBox5.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
                }
                if (_currentPerson.Pictures.Count > 5)
                {
                    pictureBox6.Tag = string.Empty;
                    pictureBox6.BackgroundImage = _currentPerson.Pictures[5];
                }
                else
                {
                    pictureBox6.Tag = "Default";
                    pictureBox6.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
                }
                if (_currentPerson.Pictures.Count > 6)
                {
                    pictureBox7.Tag = string.Empty;
                    pictureBox7.BackgroundImage = _currentPerson.Pictures[6];
                }
                else
                {
                    pictureBox7.Tag = "Default";
                    pictureBox7.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
                }

                if (_currentPerson.Documents.Count > 0) { documentIcon1.CurrentDocument = _currentPerson.Documents[0]; }
                if (_currentPerson.Documents.Count > 1) { documentIcon2.CurrentDocument = _currentPerson.Documents[1]; }
                if (_currentPerson.Documents.Count > 2) { documentIcon3.CurrentDocument = _currentPerson.Documents[2]; }
                if (_currentPerson.Documents.Count > 3) { documentIcon4.CurrentDocument = _currentPerson.Documents[3]; }

                labelFamilyName.Text = string.IsNullOrEmpty(_currentPerson.FamilyName) ? "_______" : _currentPerson.FamilyName.ToUpper();
                labelFirstName.Text = (_currentPerson.FirstName == null || string.IsNullOrEmpty(_currentPerson.FirstName.Firstname)) ? "_______" : _currentPerson.FirstName.Firstname.Substring(0, 1).ToUpper() + _currentPerson.FirstName.Firstname.Substring(1, _currentPerson.FirstName.Firstname.Length - 1).ToLower();
                labelGender.Text = _currentPerson.Gender.ToString().ToLower();
                labelNationality.Text = _currentPerson.Nationality;
                labelBirthday.Text = _currentPerson.Birthday.ToString();
                labelMail.Text = _currentPerson.Mail;
                labelNickname.Text = _currentPerson.Nickname;
                textBoxComment.Text = _currentPerson.Comment;

                foreach (var item in comboBoxGender.Items)
                {
                    if (item.ToString().Equals(_currentPerson.Gender.ToString()))
                    {
                        comboBoxGender.SelectedItem = item;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(labelFamilyName.Text) && ! string.IsNullOrEmpty(labelFirstName.Text))
                {
                    labelFullName.Text = labelFirstName.Text + " " + labelFamilyName.Text;
                }
                else if (!string.IsNullOrEmpty(labelFamilyName.Text))
                {
                    labelFullName.Text = labelFamilyName.Text;
                }
                else if (!string.IsNullOrEmpty(labelFirstName.Text))
                {
                    labelFullName.Text = labelFirstName.Text;
                }
                else
                {
                    labelFullName.Text = "Person unknow";
                }
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            documentPreview.Text = "Document preview";
            documentPreviewComment.Text = "Comment";
            InitComboBox();
            LoadPeople();

            documentIcon1.PreviewRequested += DocumentIcon1_PreviewRequested;
            documentIcon2.PreviewRequested += DocumentIcon2_PreviewRequested;
            documentIcon3.PreviewRequested += DocumentIcon3_PreviewRequested;
            documentIcon4.PreviewRequested += DocumentIcon4_PreviewRequested;

            documentIcon1.DocumentChanged += DocumentIcon1_DocumentChanged;
            documentIcon2.DocumentChanged += DocumentIcon2_DocumentChanged;
            documentIcon3.DocumentChanged += DocumentIcon3_DocumentChanged;
            documentIcon4.DocumentChanged += DocumentIcon4_DocumentChanged;

            SwitchEditionViewControls();
        }
        private void InitComboBox()
        {
            comboBoxGender.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Person.GENDER)))
            {
                comboBoxGender.Items.Add(item.ToString());
            }
            comboBoxGender.Sorted = true;
            comboBoxGender.SelectedItem = comboBoxGender.Items[comboBoxGender.Items.Count - 1];
        }
        private void SwitchEditionViewControls()
        {
            this.SuspendLayout();
            if (_editionMode)
            {
                buttonEditCancel.BackgroundImage = imageList32.Images[imageList32.Images.IndexOfKey("cancel")];
                buttonSave.Visible = true;

                labelActivity.Visible = false;
                labelNationality.Visible = false;
                labelFirstName.Visible = false;
                labelFamilyName.Visible = false;
                labelGender.Visible = false;
                labelMail.Visible = false;
                labelNickname.Visible = false;
                labelBirthday.Visible = false;

                textBoxActivity.Visible = true;
                textBoxNationality.Visible = true;
                textBoxFirstname.Visible = true;
                textBoxName.Visible = true;
                comboBoxGender.Visible = true;
                textBoxMail.Visible = true;
                textBoxNickName.Visible = true;
                textBoxBirthday.Visible = true;

                buttonDelete1.Visible = !pictureBox1.Tag.Equals("Default");
                buttonDelete2.Visible = !pictureBox2.Tag.Equals("Default");
                buttonDelete3.Visible = !pictureBox3.Tag.Equals("Default");
                buttonDelete4.Visible = !pictureBox4.Tag.Equals("Default");
                buttonDelete5.Visible = !pictureBox5.Tag.Equals("Default");
                buttonDelete6.Visible = !pictureBox6.Tag.Equals("Default");
                buttonDelete7.Visible = !pictureBox7.Tag.Equals("Default");

                textBoxActivity.Text = labelActivity.Text;
                textBoxNationality.Text = labelNationality.Text;
                textBoxFirstname.Text = labelFirstName.Text;
                textBoxName.Text = labelFamilyName.Text;
                comboBoxGender.SelectedItem = labelGender.Text;
                textBoxMail.Text = labelMail.Text;
                textBoxNickName.Text = labelNickname.Text;
                textBoxBirthday.Text = labelBirthday.Text;
            }
            else
            {
                buttonEditCancel.BackgroundImage = imageList32.Images[imageList32.Images.IndexOfKey("userEdit")];
                buttonSave.Visible = false;

                labelActivity.Visible = true;
                labelNationality.Visible = true;
                labelFirstName.Visible = true;
                labelFamilyName.Visible = true;
                labelGender.Visible = true;
                labelMail.Visible = true;
                labelNickname.Visible = true;
                labelBirthday.Visible = true;

                textBoxActivity.Visible = false;
                textBoxNationality.Visible = false;
                textBoxFirstname.Visible = false;
                textBoxName.Visible = false;
                comboBoxGender.Visible = false;
                textBoxMail.Visible = false;
                textBoxNickName.Visible = false;
                textBoxBirthday.Visible = false;

                buttonDelete1.Visible = false;
                buttonDelete2.Visible = false;
                buttonDelete3.Visible = false;
                buttonDelete4.Visible = false;
                buttonDelete5.Visible = false;
                buttonDelete6.Visible = false;
                buttonDelete7.Visible = false;
            }
            this.ResumeLayout();
        }
        private void SavePerson()
        {
            DateTime date;
            _currentPerson.FirstName = PeopleControler.GetFirstName(textBoxFirstname.Text);
            _currentPerson.FamilyName = textBoxName.Text;
            //_currentPerson.Activities
            _currentPerson.Nationality = textBoxNationality.Text;
            _currentPerson.Gender = (Person.GENDER)Enum.Parse(typeof(Person.GENDER), comboBoxGender.Text.ToUpper());
            if (DateTime.TryParse(textBoxBirthday.Text, out date)) { _currentPerson.Birthday = date; }
            _currentPerson.Nickname = textBoxNickName.Text;
            _currentPerson.Mail = textBoxMail.Text;
            _currentPerson.Comment = textBoxComment.Text;
            _currentPerson.Pictures.Clear();
            _currentPerson.SerializedPicture.Clear();
            if (pictureBox1.BackgroundImage != null && !"Default".Equals(pictureBox1.Tag)) _currentPerson.Pictures.Add(pictureBox1.BackgroundImage);
            if (pictureBox2.BackgroundImage != null && !"Default".Equals(pictureBox2.Tag))
            {
                Image img = pictureBox2.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _currentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            } 
            if (pictureBox3.BackgroundImage != null && !"Default".Equals(pictureBox3.Tag))
            {
                Image img = pictureBox3.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _currentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            } 
            if (pictureBox4.BackgroundImage != null && !"Default".Equals(pictureBox4.Tag))
            {
                Image img = pictureBox4.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _currentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            } 
            if (pictureBox5.BackgroundImage != null && !"Default".Equals(pictureBox5.Tag))
            {
                Image img = pictureBox5.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _currentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            } 
            if (pictureBox6.BackgroundImage != null && !"Default".Equals(pictureBox6.Tag))
            {
                Image img = pictureBox6.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _currentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            }
            if (pictureBox7.BackgroundImage != null && !"Default".Equals(pictureBox7.Tag))
            {
                Image img = pictureBox7.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _currentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            }
            _currentPerson.Save();
        }
        #endregion

        #region Event
        private void DocumentIcon4_PreviewRequested()
        {
            documentPreview.CurrentDocument = documentIcon4.CurrentDocument;
        }
        private void DocumentIcon3_PreviewRequested()
        {
            documentPreview.CurrentDocument = documentIcon3.CurrentDocument;
        }
        private void DocumentIcon2_PreviewRequested()
        {
            documentPreview.CurrentDocument = documentIcon2.CurrentDocument;
        }
        private void DocumentIcon1_PreviewRequested()
        {
            documentPreview.CurrentDocument = documentIcon1.CurrentDocument;
        }
        private void DocumentIcon1_DocumentChanged()
        {
            string doc = documentIcon1.CurrentDocument;
            _currentPerson.AddDocument(ref doc);
            documentIcon1.CurrentDocument = doc;
            documentPreview.CurrentDocument = doc;
        }
        private void DocumentIcon2_DocumentChanged()
        {
            string doc = documentIcon2.CurrentDocument;
            _currentPerson.AddDocument(ref doc);
            documentIcon2.CurrentDocument = doc;
            documentPreview.CurrentDocument = doc;
        }
        private void DocumentIcon3_DocumentChanged()
        {
            string doc = documentIcon3.CurrentDocument;
            _currentPerson.AddDocument(ref doc);
            documentIcon3.CurrentDocument = doc;
            documentPreview.CurrentDocument = doc;
        }
        private void DocumentIcon4_DocumentChanged()
        {
            string doc = documentIcon4.CurrentDocument;
            _currentPerson.AddDocument(ref doc);
            documentIcon4.CurrentDocument = doc;
            documentPreview.CurrentDocument = doc;
        }
        private void buttonEditSave_Click(object sender, EventArgs e)
        {
            _editionMode = !_editionMode;
            SwitchEditionViewControls();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SavePerson();
            LoadPeople();

            _editionMode = !_editionMode;
            SwitchEditionViewControls();
        }
        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = _currentPerson.Gender == Person.GENDER.FEMAL ? imageList.Images[imageList.Images.IndexOfKey("shadow_woman")] : imageList.Images[imageList.Images.IndexOfKey("shadow_man")];
            pictureBox1.Tag = "Default";
            _currentPerson.Pictures.Remove(pictureBox1.BackgroundImage);
        }
        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
            pictureBox2.Tag = "Default";
            _currentPerson.Pictures.Remove(pictureBox2.BackgroundImage);
        }
        private void buttonDelete3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
            pictureBox3.Tag = "Default";
            _currentPerson.Pictures.Remove(pictureBox3.BackgroundImage);
        }
        private void buttonDelete4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
            pictureBox4.Tag = "Default";
            _currentPerson.Pictures.Remove(pictureBox4.BackgroundImage);
        }
        private void buttonDelete5_Click(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
            pictureBox5.Tag = "Default";
            _currentPerson.Pictures.Remove(pictureBox5.BackgroundImage);
        }
        private void buttonDelete6_Click(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
            pictureBox6.Tag = "Default";
            _currentPerson.Pictures.Remove(pictureBox6.BackgroundImage);
        }
        private void buttonDelete7_Click(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = imageList.Images[imageList.Images.IndexOfKey("backgrounPeople")];
            pictureBox7.Tag = "Default";
            _currentPerson.Pictures.Remove(pictureBox7.BackgroundImage);
        }
        #endregion
    }
}
