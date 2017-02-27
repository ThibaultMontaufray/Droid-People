﻿using System;
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
    public partial class DocumentPreview : UserControl
    {
        #region Attribute
        private string _currentDocument;
        private readonly List<string> _extentionImages = new List<string>() { "bpm", "png", "jpg", "jpeg", "gif" };
        #endregion

        #region Properties
        public override string Text
        {
            get { return labelText.Text; }
            set { labelText.Text = value; }
        }
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
        public DocumentPreview()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public void LoadDocument()
        {
            if (_currentDocument == null)
            {
                pictureBoxPreview.Visible = false;
            }
            else if (Path.GetExtension(_currentDocument) != null && _extentionImages.Contains(Path.GetExtension(_currentDocument).ToLower().Replace(".", string.Empty)))
            {
                pictureBoxPreview.Visible = true;
                pictureBoxPreview.BackgroundImage = Image.FromFile(_currentDocument);
            }
            else
            {
                pictureBoxPreview.Visible = false;
            }
        }
        #endregion

        #region Methods private
        #endregion
    }
}