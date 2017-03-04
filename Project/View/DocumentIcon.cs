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
    public delegate void DocumentIconEventHandler();
    public partial class DocumentIcon : UserControl
    {
        #region Attribute
        public event DocumentIconEventHandler PreviewRequested;
        public event DocumentIconEventHandler DocumentChanged;

        private string _currentDocument;
        #endregion

        #region Properties
        public string CurrentDocument
        {
            get { return _currentDocument; }
            set
            {
                _currentDocument = value;
                LoadDocument();
            }
        }
        #endregion

        #region Constructor
        public DocumentIcon()
        {
            InitializeComponent();
            RefreshAvailable();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void LoadDocument()
        {
            if (_currentDocument != null)
            {
                FileInfo fi = new FileInfo(_currentDocument);
                labelNum.Text = string.IsNullOrEmpty(fi.Extension) ? "00" : fi.Extension.ToUpper().Replace(".", string.Empty);
                labelDocName.Text = fi.Name.Length > 19 ? fi.Name.Substring(0, 14) + "..." : fi.Name;
                labelSize.Text = LengthToString();
                labelType.Text = !string.IsNullOrEmpty(fi.Extension) ? fi.Extension.ToLower().Replace(".", string.Empty) + " file" : string.Empty;
            }
            else
            {
                labelNum.Text = "00";
                labelDocName.Text = "...";
                labelSize.Text = string.Empty;
                labelType.Text = string.Empty;
            }
            RefreshAvailable();
        }
        private string LengthToString()
        {
            if (_currentDocument != null)
            {
                if (_currentDocument.Length < 1000)
                {
                    return _currentDocument.Length.ToString() + " Oct";
                }
                else if (_currentDocument.Length < 1000000)
                {
                    return (_currentDocument.Length / 1000).ToString() + " Ko";
                }
                else if (_currentDocument.Length < 1000000000)
                {
                    return (_currentDocument.Length / 1000000).ToString() + " Mo";
                }
                else
                {
                    return (_currentDocument.Length / 1000000000).ToString() + " Go";
                }
            }
            else return string.Empty;
        }
        private void RefreshAvailable()
        {
            this.SuspendLayout();
            if (_currentDocument != null && File.Exists(_currentDocument))
            {
                BackgroundImage = imageListBackGround.Images[imageListBackGround.Images.IndexOfKey("folderActive")];
            }
            else
            {
                BackgroundImage = imageListBackGround.Images[imageListBackGround.Images.IndexOfKey("folderUnactive")];
            }
            this.ResumeLayout();
        }
        private void BrowseDocument()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _currentDocument = ofd.FileName;
                if (DocumentChanged != null) { DocumentChanged(); }
            }

            LoadDocument();
        }
        #endregion

        #region Event
        private void DocumentIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BrowseDocument();
        }
        private void DocumentIcon_Click(object sender, EventArgs e)
        {
            if (PreviewRequested != null) PreviewRequested();
        }
        private void labelDocName_MouseHover(object sender, EventArgs e)
        {
            this.SuspendLayout();
            BackgroundImage = imageListBackGround.Images[imageListBackGround.Images.IndexOfKey("folderHover")];
            this.ResumeLayout();
            Cursor = Cursors.Hand;
        }
        private void labelDocName_MouseLeave(object sender, EventArgs e)
        {
            RefreshAvailable();
            Cursor = Cursors.Arrow;
        }
        #endregion
    }
}
