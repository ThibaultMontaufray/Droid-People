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
using Droid.Geography;
using Tools.Utilities;
using Tools.Utilities.UI;

namespace Droid.People
{
    public delegate void PersonViewEventHandler(object o);
    public partial class PersonView : UserControlCustom
    {
        #region Attribute
        public event PersonViewEventHandler PersonChanged;

        private bool _editionMode = false;
        private InterfacePeople _intPeo;
        private WorldMap _worldMap;
        #endregion

        #region Properties
        public Person CurrentPerson
        {
            get { return _intPeo.CurrentPerson; }
            set
            {
                _intPeo.CurrentPerson = value;
                RefreshData();
            }
        }
        public WorldMap WorldMap
        {
            get { return _worldMap; }
            set { _worldMap = value; }
        }
        public bool IsEditable
        {
            get { return _editionMode; }
            set
            {
                _editionMode = value;
                SwitchEditionViewControls();
            }
        }
        #endregion

        #region Constructor
        public PersonView(InterfacePeople intPeo)
        {
            _intPeo = intPeo;

            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_intPeo.CurrentPerson != null)
            {
                if (_intPeo.CurrentPerson.Pictures.Count > 0)
                {
                    pictureBox1.Tag = string.Empty;
                    pictureBox1.BackgroundImage = _intPeo.CurrentPerson.Pictures[0];
                }
                else
                {
                    pictureBox1.Tag = "Default";
                    switch (_intPeo.CurrentPerson.Gender)
                    {
                        case Gender.MALE:
                            pictureBox1.BackgroundImage = Properties.Resources.shadow_man;
                            break;
                        case Gender.FEMAL:
                            pictureBox1.BackgroundImage = Properties.Resources.shadow_woman;
                            break;
                        case Gender.OTHER:
                        case Gender.UNKNOW:
                        default:
                            pictureBox1.BackgroundImage = Properties.Resources.shadow_backpacker;
                            break;
                    }
                }
                if (_intPeo.CurrentPerson.Pictures.Count > 1)
                {
                    pictureBox2.Tag = string.Empty;
                    pictureBox2.BackgroundImage = _intPeo.CurrentPerson.Pictures[1];
                }
                else
                {
                    pictureBox2.Tag = "Default";
                    pictureBox2.BackgroundImage = Properties.Resources.backgrounPerson;
                }
                if (_intPeo.CurrentPerson.Pictures.Count > 2)
                {
                    pictureBox3.Tag = string.Empty;
                    pictureBox3.BackgroundImage = _intPeo.CurrentPerson.Pictures[2];
                }
                else
                {
                    pictureBox3.Tag = "Default";
                    pictureBox3.BackgroundImage = Properties.Resources.backgrounPerson;
                }
                if (_intPeo.CurrentPerson.Pictures.Count > 3)
                {
                    pictureBox4.Tag = string.Empty;
                    pictureBox4.BackgroundImage = _intPeo.CurrentPerson.Pictures[3];
                }
                else
                {
                    pictureBox4.Tag = "Default";
                    pictureBox4.BackgroundImage = Properties.Resources.backgrounPerson;
                }
                if (_intPeo.CurrentPerson.Pictures.Count > 4)
                {
                    pictureBox5.Tag = string.Empty;
                    pictureBox5.BackgroundImage = _intPeo.CurrentPerson.Pictures[4];
                }
                else
                {
                    pictureBox5.Tag = "Default";
                    pictureBox5.BackgroundImage = Properties.Resources.backgrounPerson;
                }
                if (_intPeo.CurrentPerson.Pictures.Count > 5)
                {
                    pictureBox6.Tag = string.Empty;
                    pictureBox6.BackgroundImage = _intPeo.CurrentPerson.Pictures[5];
                }
                else
                {
                    pictureBox6.Tag = "Default";
                    pictureBox6.BackgroundImage = Properties.Resources.backgrounPerson;
                }
                if (_intPeo.CurrentPerson.Pictures.Count > 6)
                {
                    pictureBox7.Tag = string.Empty;
                    pictureBox7.BackgroundImage = _intPeo.CurrentPerson.Pictures[6];
                }
                else
                {
                    pictureBox7.Tag = "Default";
                    pictureBox7.BackgroundImage = Properties.Resources.backgrounPerson;
                }

                if (_intPeo.CurrentPerson.Documents.Count > 0) { documentIcon1.CurrentDocument = Path.Combine(_intPeo.WorkingDirectory, _intPeo.CurrentPerson.Id, _intPeo.CurrentPerson.Documents[0]); }
                else documentIcon1.CurrentDocument = null;
                if (_intPeo.CurrentPerson.Documents.Count > 1) { documentIcon2.CurrentDocument = Path.Combine(_intPeo.WorkingDirectory, _intPeo.CurrentPerson.Id, _intPeo.CurrentPerson.Documents[1]); }
                else documentIcon2.CurrentDocument = null;
                if (_intPeo.CurrentPerson.Documents.Count > 2) { documentIcon3.CurrentDocument = Path.Combine(_intPeo.WorkingDirectory, _intPeo.CurrentPerson.Id, _intPeo.CurrentPerson.Documents[2]); }
                else documentIcon3.CurrentDocument = null;
                if (_intPeo.CurrentPerson.Documents.Count > 3) { documentIcon4.CurrentDocument = Path.Combine(_intPeo.WorkingDirectory, _intPeo.CurrentPerson.Id, _intPeo.CurrentPerson.Documents[3]); }
                else documentIcon4.CurrentDocument = null;

                labelFamilyName.Text = string.IsNullOrEmpty(_intPeo.CurrentPerson.Name) ? "_______" : _intPeo.CurrentPerson.Name.ToUpper();
                labelFirstName.Text = (_intPeo.CurrentPerson.FirstName == null || string.IsNullOrEmpty(_intPeo.CurrentPerson.FirstName.Value)) ? "_______" : _intPeo.CurrentPerson.FirstName.Value.Substring(0, 1).ToUpper() + _intPeo.CurrentPerson.FirstName.Value.Substring(1, _intPeo.CurrentPerson.FirstName.Value.Length - 1).ToLower();
                labelGender.Text = _intPeo.CurrentPerson.Gender.ToString().ToLower();
                labelNationality.Text = _intPeo.CurrentPerson.Nationality;
                labelBirthday.Text = _intPeo.CurrentPerson.Birthday.Date.ToShortDateString();
                labelMail.Text = _intPeo.CurrentPerson.Mail;
                labelNickname.Text = _intPeo.CurrentPerson.Nickname;
                textBoxComment.Text = _intPeo.CurrentPerson.Comment;
                textBoxActivity.Text = _intPeo.CurrentPerson.Activities.Count > 0 ? _intPeo.CurrentPerson.Activities[0].Name : string.Empty;
                labelActivity.Text = _intPeo.CurrentPerson.Activities.Count > 0 ? _intPeo.CurrentPerson.Activities[0].Name : string.Empty;
                dateTimePickerBirthday.Value = _intPeo.CurrentPerson.Birthday == DateTime.MinValue ? DateTime.Now.AddYears(-100) : _intPeo.CurrentPerson.Birthday;

                foreach (var item in comboBoxGender.Items)
                {
                    if (item.ToString().Equals(_intPeo.CurrentPerson.Gender.ToString()))
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
        public void ChangeLanguage(string language = null)
        {
            if (!string.IsNullOrEmpty(language))
            {
                Properties.Settings.Default.Language = language;
                Properties.Settings.Default.Save();
            }
            
            labelTitleActivity.Text = GetText.Text("Activity");
            labelTitleBirthday.Text = GetText.Text("Birthday");
            labelTitleNickName.Text = GetText.Text("Nickname");
            labelTitleGender.Text = GetText.Text("Gender");
            labelTitleLastName.Text = GetText.Text("FirstName");
            labelTitleMail.Text = GetText.Text("Mail");
            labelTitleName.Text = GetText.Text("FamilyName");
            labelTitleNationality.Text = GetText.Text("Nationality");
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _worldMap = new WorldMap();

            documentPreview.Text = "Document preview";
            documentPreviewComment.Text = "Comment";
            InitComboBox();
            RefreshData();

            documentIcon1.PreviewRequested += DocumentIcon1_PreviewRequested;
            documentIcon2.PreviewRequested += DocumentIcon2_PreviewRequested;
            documentIcon3.PreviewRequested += DocumentIcon3_PreviewRequested;
            documentIcon4.PreviewRequested += DocumentIcon4_PreviewRequested;

            documentIcon1.DocumentChanged += DocumentIcon1_DocumentChanged;
            documentIcon2.DocumentChanged += DocumentIcon2_DocumentChanged;
            documentIcon3.DocumentChanged += DocumentIcon3_DocumentChanged;
            documentIcon4.DocumentChanged += DocumentIcon4_DocumentChanged;

            SwitchEditionViewControls();
            ChangeLanguage();
        }
        private void InitComboBox()
        {
            comboBoxGender.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                comboBoxGender.Items.Add(item.ToString());
            }
            comboBoxGender.Sorted = true;
            comboBoxGender.SelectedItem = comboBoxGender.Items[comboBoxGender.Items.Count - 1];

            comboBoxNationality.Items.Clear();
            foreach (var item in _worldMap.Countries)
            {
                comboBoxNationality.Items.Add(item.Name);
            }
            comboBoxNationality.Sorted = true;
            comboBoxNationality.SelectedItem = comboBoxGender.Items[0];

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
                comboBoxNationality.Visible = true;
                textBoxFirstname.Visible = true;
                textBoxName.Visible = true;
                comboBoxGender.Visible = true;
                textBoxMail.Visible = true;
                textBoxNickName.Visible = true;
                dateTimePickerBirthday.Visible = true;

                buttonDelete1.Visible = !pictureBox1.Tag.Equals("Default");
                buttonDelete2.Visible = !pictureBox2.Tag.Equals("Default");
                buttonDelete3.Visible = !pictureBox3.Tag.Equals("Default");
                buttonDelete4.Visible = !pictureBox4.Tag.Equals("Default");
                buttonDelete5.Visible = !pictureBox5.Tag.Equals("Default");
                buttonDelete6.Visible = !pictureBox6.Tag.Equals("Default");
                buttonDelete7.Visible = !pictureBox7.Tag.Equals("Default");

                textBoxActivity.Text = labelActivity.Text;
                comboBoxNationality.SelectedItem = labelNationality.Text;
                textBoxFirstname.Text = labelFirstName.Text;
                textBoxName.Text = labelFamilyName.Text;
                comboBoxGender.SelectedItem = labelGender.Text;
                textBoxMail.Text = labelMail.Text;
                textBoxNickName.Text = labelNickname.Text;
                if (!DateTime.MinValue.ToShortDateString().Equals(labelBirthday.Text)) dateTimePickerBirthday.Text = labelBirthday.Text;
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
                comboBoxNationality.Visible = false;
                textBoxFirstname.Visible = false;
                textBoxName.Visible = false;
                comboBoxGender.Visible = false;
                textBoxMail.Visible = false;
                textBoxNickName.Visible = false;
                dateTimePickerBirthday.Visible = false;

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
            _intPeo.CurrentPerson.FirstName = PeopleControler.GetFirstName(textBoxFirstname.Text);
            _intPeo.CurrentPerson.Name = textBoxName.Text;
            //_intPeo.CurrentPerson.Activities
            _intPeo.CurrentPerson.Nationality = comboBoxNationality.Text;
            _intPeo.CurrentPerson.Gender = (Gender)Enum.Parse(typeof(Gender), comboBoxGender.Text.ToUpper());
            _intPeo.CurrentPerson.Birthday = dateTimePickerBirthday.Value;
            _intPeo.CurrentPerson.Nickname = textBoxNickName.Text;
            _intPeo.CurrentPerson.Mail = textBoxMail.Text;
            _intPeo.CurrentPerson.Comment = textBoxComment.Text;
            _intPeo.CurrentPerson.Pictures.Clear();
            _intPeo.CurrentPerson.SerializedPicture.Clear();
            if (_intPeo.CurrentPerson.Activities.Where(a => a.Name.Equals(textBoxActivity.Text)).Count() == 0) _intPeo.CurrentPerson.Activities.Add(new Activities(textBoxActivity.Text));
            if (pictureBox1.BackgroundImage != null && !"Default".Equals(pictureBox1.Tag)) _intPeo.CurrentPerson.Pictures.Add(pictureBox1.BackgroundImage);
            if (pictureBox2.BackgroundImage != null && !"Default".Equals(pictureBox2.Tag))
            {
                System.Drawing.Image img = pictureBox2.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _intPeo.CurrentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            } 
            if (pictureBox3.BackgroundImage != null && !"Default".Equals(pictureBox3.Tag))
            {
                System.Drawing.Image img = pictureBox3.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _intPeo.CurrentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            } 
            if (pictureBox4.BackgroundImage != null && !"Default".Equals(pictureBox4.Tag))
            {
                System.Drawing.Image img = pictureBox4.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _intPeo.CurrentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            } 
            if (pictureBox5.BackgroundImage != null && !"Default".Equals(pictureBox5.Tag))
            {
                System.Drawing.Image img = pictureBox5.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _intPeo.CurrentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            } 
            if (pictureBox6.BackgroundImage != null && !"Default".Equals(pictureBox6.Tag))
            {
                System.Drawing.Image img = pictureBox6.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _intPeo.CurrentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            }
            if (pictureBox7.BackgroundImage != null && !"Default".Equals(pictureBox7.Tag))
            {
                System.Drawing.Image img = pictureBox7.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] array = ms.ToArray();
                _intPeo.CurrentPerson.SerializedPicture.Add(Convert.ToBase64String(array));
            }
            _intPeo.CurrentPerson.Save(_intPeo.WorkingDirectory);
            if (!_intPeo.Persons.Contains(_intPeo.CurrentPerson)) _intPeo.Persons.Add(_intPeo.CurrentPerson);

            if (PersonChanged != null) { PersonChanged(_intPeo.CurrentPerson); }
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
            //if (_intPeo.CurrentPerson.WorkingDirectory == null) _intPeo.CurrentPerson.WorkingDirectory = _intPeo.WorkingDirectory;
            _intPeo.CurrentPerson.AddDocument(_intPeo.WorkingDirectory, ref doc);
            documentIcon1.CurrentDocument = doc;
            documentPreview.CurrentDocument = doc;
        }
        private void DocumentIcon2_DocumentChanged()
        {
            string doc = documentIcon2.CurrentDocument;
            //if (_intPeo.CurrentPerson.WorkingDirectory == null) _intPeo.CurrentPerson.WorkingDirectory = _intPeo.WorkingDirectory;
            _intPeo.CurrentPerson.AddDocument(_intPeo.WorkingDirectory, ref doc);
            documentIcon2.CurrentDocument = doc;
            documentPreview.CurrentDocument = doc;
        }
        private void DocumentIcon3_DocumentChanged()
        {
            string doc = documentIcon3.CurrentDocument;
            //if (_intPeo.CurrentPerson.WorkingDirectory == null) _intPeo.CurrentPerson.WorkingDirectory = _intPeo.WorkingDirectory;
            _intPeo.CurrentPerson.AddDocument(_intPeo.WorkingDirectory, ref doc);
            documentIcon3.CurrentDocument = doc;
            documentPreview.CurrentDocument = doc;
        }
        private void DocumentIcon4_DocumentChanged()
        {
            string doc = documentIcon4.CurrentDocument;
            //if (_intPeo.CurrentPerson.WorkingDirectory == null) _intPeo.CurrentPerson.WorkingDirectory = _intPeo.WorkingDirectory;
            _intPeo.CurrentPerson.AddDocument(_intPeo.WorkingDirectory, ref doc);
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
            RefreshData();

            _editionMode = !_editionMode;
            SwitchEditionViewControls();
        }
        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            switch (_intPeo.CurrentPerson.Gender)
            {
                case Gender.MALE:
                    pictureBox1.BackgroundImage = Properties.Resources.shadow_man;
                    break;
                case Gender.FEMAL:
                    pictureBox1.BackgroundImage = Properties.Resources.shadow_woman;
                    break;
                case Gender.OTHER:
                case Gender.UNKNOW:
                default:
                    pictureBox1.BackgroundImage = Properties.Resources.shadow_backpacker;
                    break;
            }
            pictureBox1.Tag = "Default";
            _intPeo.CurrentPerson.Pictures.Remove(pictureBox1.BackgroundImage);
        }
        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.backgrounPerson;
            pictureBox2.Tag = "Default";
            _intPeo.CurrentPerson.Pictures.Remove(pictureBox2.BackgroundImage);
        }
        private void buttonDelete3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.backgrounPerson;
            pictureBox3.Tag = "Default";
            _intPeo.CurrentPerson.Pictures.Remove(pictureBox3.BackgroundImage);
        }
        private void buttonDelete4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Properties.Resources.backgrounPerson;
            pictureBox4.Tag = "Default";
            _intPeo.CurrentPerson.Pictures.Remove(pictureBox4.BackgroundImage);
        }
        private void buttonDelete5_Click(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Properties.Resources.backgrounPerson;
            pictureBox5.Tag = "Default";
            _intPeo.CurrentPerson.Pictures.Remove(pictureBox5.BackgroundImage);
        }
        private void buttonDelete6_Click(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Properties.Resources.backgrounPerson;
            pictureBox6.Tag = "Default";
            _intPeo.CurrentPerson.Pictures.Remove(pictureBox6.BackgroundImage);
        }
        private void buttonDelete7_Click(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.backgrounPerson;
            pictureBox7.Tag = "Default";
            _intPeo.CurrentPerson.Pictures.Remove(pictureBox7.BackgroundImage);
        }
        #endregion
    }
}
