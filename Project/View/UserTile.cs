using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_People
{
    public delegate void UserTileEventHandler(Person p);
    public partial class UserTile : UserControl
    {
        #region Attribute
        public event UserTileEventHandler UserDetailRequested;

        private Person _currentPerson;
        #endregion

        #region Properties
        public int Opacity
        {
            set
            {
                switch (value)
                {
                    case 1:
                        panelHover.BackgroundImage = Properties.Resources.transparent1;
                        break;
                    case 2:
                        panelHover.BackgroundImage = Properties.Resources.transparent3;
                        break;
                    case 3:
                        panelHover.BackgroundImage = Properties.Resources.transparent5;
                        break;
                    case 4:
                        panelHover.BackgroundImage = Properties.Resources.transparent7;
                        break;
                    default:
                        panelHover.BackgroundImage = null;
                        break;
                }
                panelHover.BackgroundImageLayout = ImageLayout.Stretch;
                this.Invalidate();
            }
        }
        public Person CurrentPerson
        {
            get { return _currentPerson; }
            set { _currentPerson = value; }
        }
        #endregion

        #region Constructor
        public UserTile()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void LoadPerson(Person person)
        {
            _currentPerson = person;
            Image img = person.Pictures.Count != 0 ? person.Pictures[0] : Properties.Resources.shadow_backpacker;
            img = Droid_Image.Interface_image.ACTION_132_resize_picture(img, 60, 60);
            pictureBoxProfil.Image = Droid_Image.Interface_image.ACTION_138_apply_mask(img);
            labelName.Text = string.Format("{0} {1}", person.FirstName.ToString(), person.FamilyName.ToUpper());
            labelDescription.Text = person.Comment;
            labelNationality.Text = person.Nationality.ToString();
            labelAge.Text = string.Format("{0} : {1}", GetText.Text("Age"), (person.Birthday != null ? (((DateTime.Now - person.Birthday).TotalDays) / 365.25).ToString().Split(',')[0] : GetText.Text("Unknown")));
            labelActivity.Text = person.Activities.Count > 0 ? person.Activities[0].Name : string.Empty;

            if (person.Gender == Person.GENDER.MALE) { pictureBoxGender.Image = imageListGender.Images[imageListGender.Images.IndexOfKey("male")]; }
            else if (person.Gender == Person.GENDER.FEMAL) { pictureBoxGender.Image = imageListGender.Images[imageListGender.Images.IndexOfKey("femal")]; }
            else if (person.Gender == Person.GENDER.OTHER) { pictureBoxGender.Image = imageListGender.Images[imageListGender.Images.IndexOfKey("indeterminate")]; }
            else { pictureBoxGender.Image = null; }

            if (person.FirstName.ToString().Contains("_")) panelMask.BackgroundImage = Properties.Resources.userTileRed;
            else panelMask.BackgroundImage = Properties.Resources.userTileGreen;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            Opacity = 0;
        }
        #endregion

        #region Event
        private void UT_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
        private void UT_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }
        private void UT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (UserDetailRequested != null) UserDetailRequested(_currentPerson);
        }
        #endregion
    }
}
