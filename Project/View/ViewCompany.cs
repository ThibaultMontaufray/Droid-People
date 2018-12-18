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

namespace Droid.People
{
    public partial class ViewCompany : UserControlCustom
    {
        #region Attributes
        public event UserControlCustomEventHandler OnSave;
        public event UserControlCustomEventHandler OnCancel;

        private Company _company;
        #endregion

        #region Properties
        public Company Company
        {
            get { return _company; }
            set
            {
                _company = value;
                RefreshData();
            }
        }
        #endregion

        #region Constructor
        public ViewCompany()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void ChangeLanguage()
        {
            base.ChangeLanguage();
        }
        public override void RefreshData()
        {
            textBoxName.Text = _company != null ? _company.Name : string.Empty;
            textBoxSiret.Text = _company != null ? _company.SIRET.ToString() : string.Empty;
            textBoxAddress.Text = _company != null ? _company.Address : string.Empty;
            textBoxPostCode.Text = _company != null ? _company.PostCode : string.Empty;
            textBoxCity.Text = _company != null ? _company.City : string.Empty;
            textBoxCountry.Text = _company != null ? _company.Country : string.Empty;
            textBoxPhone.Text = _company != null ? _company.Phone : string.Empty;
            textBoxMail.Text = _company != null ? _company.Mail : string.Empty;
            textBoxComment.Text = _company != null ? _company.Comment : string.Empty;
            pictureBoxLogo.BackgroundImage = _company != null ? _company.Logo : null;
        }
        #endregion

        #region Methods private
        private void Save()
        {
            if (_company == null) { _company = new Company(); }
            _company.Name = textBoxName.Text;
            _company.SIRET = double.Parse(textBoxSiret.Text.Replace(" ", string.Empty));
            _company.Address = textBoxAddress.Text;
            _company.PostCode = textBoxPostCode.Text;
            _company.City = textBoxCity.Text;
            _company.Country = textBoxCountry.Text;
            _company.Phone = textBoxPhone.Text;
            _company.Mail = textBoxMail.Text;
            _company.Comment = textBoxComment.Text;
            _company.Logo = pictureBoxLogo.BackgroundImage;
            _company.Save();
            OnSave?.Invoke(null);
        }
        #endregion

        #region Event
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            OnCancel?.Invoke(null);
        }
        private void buttonUploadLogo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Pictures (*.jpg, *.jpeg, *.png, *.gif)| *.jpg, *.jpeg, *.png, *.gif|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxLogo.BackgroundImage = System.Drawing.Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}
