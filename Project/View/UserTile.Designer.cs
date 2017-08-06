namespace Droid_People
{
    partial class UserTile
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTile));
            this.pictureBoxProfil = new System.Windows.Forms.PictureBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.pictureBoxGender = new System.Windows.Forms.PictureBox();
            this.panelMask = new System.Windows.Forms.Panel();
            this.panelHover = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.imageListGender = new System.Windows.Forms.ImageList(this.components);
            this.imageListHover = new System.Windows.Forms.ImageList(this.components);
            this.labelActivity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).BeginInit();
            this.panelMask.SuspendLayout();
            this.panelHover.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxProfil
            // 
            this.pictureBoxProfil.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxProfil.Name = "pictureBoxProfil";
            this.pictureBoxProfil.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxProfil.TabIndex = 0;
            this.pictureBoxProfil.TabStop = false;
            // 
            // labelGender
            // 
            this.labelGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.DarkKhaki;
            this.labelGender.Location = new System.Drawing.Point(212, 76);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(100, 19);
            this.labelGender.TabIndex = 4;
            // 
            // pictureBoxGender
            // 
            this.pictureBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGender.Location = new System.Drawing.Point(281, 3);
            this.pictureBoxGender.Name = "pictureBoxGender";
            this.pictureBoxGender.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxGender.TabIndex = 5;
            this.pictureBoxGender.TabStop = false;
            // 
            // panelMask
            // 
            this.panelMask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMask.BackgroundImage")));
            this.panelMask.Controls.Add(this.panelHover);
            this.panelMask.Controls.Add(this.pictureBoxGender);
            this.panelMask.Controls.Add(this.labelGender);
            this.panelMask.Location = new System.Drawing.Point(5, 5);
            this.panelMask.Name = "panelMask";
            this.panelMask.Size = new System.Drawing.Size(300, 60);
            this.panelMask.TabIndex = 1;
            this.panelMask.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UT_MouseDoubleClick);
            this.panelMask.MouseLeave += new System.EventHandler(this.UT_MouseLeave);
            this.panelMask.MouseHover += new System.EventHandler(this.UT_MouseHover);
            // 
            // panelHover
            // 
            this.panelHover.Controls.Add(this.labelActivity);
            this.panelHover.Controls.Add(this.labelDescription);
            this.panelHover.Controls.Add(this.labelAge);
            this.panelHover.Controls.Add(this.labelNationality);
            this.panelHover.Controls.Add(this.labelName);
            this.panelHover.Location = new System.Drawing.Point(0, 0);
            this.panelHover.Name = "panelHover";
            this.panelHover.Size = new System.Drawing.Size(300, 60);
            this.panelHover.TabIndex = 7;
            this.panelHover.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UT_MouseDoubleClick);
            this.panelHover.MouseLeave += new System.EventHandler(this.UT_MouseLeave);
            this.panelHover.MouseHover += new System.EventHandler(this.UT_MouseHover);
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.Beige;
            this.labelDescription.Location = new System.Drawing.Point(60, 34);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(231, 30);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = " bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla";
            this.labelDescription.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UT_MouseDoubleClick);
            this.labelDescription.MouseLeave += new System.EventHandler(this.UT_MouseLeave);
            this.labelDescription.MouseHover += new System.EventHandler(this.UT_MouseHover);
            // 
            // labelAge
            // 
            this.labelAge.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.Color.DarkKhaki;
            this.labelAge.Location = new System.Drawing.Point(158, 18);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(65, 19);
            this.labelAge.TabIndex = 9;
            this.labelAge.Text = "Age : ";
            this.labelAge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UT_MouseDoubleClick);
            this.labelAge.MouseLeave += new System.EventHandler(this.UT_MouseLeave);
            this.labelAge.MouseHover += new System.EventHandler(this.UT_MouseHover);
            // 
            // labelNationality
            // 
            this.labelNationality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNationality.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.ForeColor = System.Drawing.Color.Khaki;
            this.labelNationality.Location = new System.Drawing.Point(60, 18);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(126, 15);
            this.labelNationality.TabIndex = 8;
            this.labelNationality.Text = "NATIONALITY";
            this.labelNationality.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UT_MouseDoubleClick);
            this.labelNationality.MouseLeave += new System.EventHandler(this.UT_MouseLeave);
            this.labelNationality.MouseHover += new System.EventHandler(this.UT_MouseHover);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(58, -1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(220, 19);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "NAME";
            this.labelName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UT_MouseDoubleClick);
            this.labelName.MouseLeave += new System.EventHandler(this.UT_MouseLeave);
            this.labelName.MouseHover += new System.EventHandler(this.UT_MouseHover);
            // 
            // imageListGender
            // 
            this.imageListGender.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGender.ImageStream")));
            this.imageListGender.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGender.Images.SetKeyName(0, "indeterminate");
            this.imageListGender.Images.SetKeyName(1, "male");
            this.imageListGender.Images.SetKeyName(2, "femal");
            // 
            // imageListHover
            // 
            this.imageListHover.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListHover.ImageStream")));
            this.imageListHover.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListHover.Images.SetKeyName(0, "transparent1");
            this.imageListHover.Images.SetKeyName(1, "transparent2");
            this.imageListHover.Images.SetKeyName(2, "transparent3");
            this.imageListHover.Images.SetKeyName(3, "transparent4");
            this.imageListHover.Images.SetKeyName(4, "transparent5");
            this.imageListHover.Images.SetKeyName(5, "transparent6");
            this.imageListHover.Images.SetKeyName(6, "transparent7");
            this.imageListHover.Images.SetKeyName(7, "transparent8");
            // 
            // labelActivity
            // 
            this.labelActivity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivity.ForeColor = System.Drawing.Color.DarkKhaki;
            this.labelActivity.Location = new System.Drawing.Point(213, 18);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(84, 19);
            this.labelActivity.TabIndex = 11;
            this.labelActivity.Text = "ACTIVITY";
            // 
            // UserTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Droid_People.Properties.Resources.transparent2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelMask);
            this.Controls.Add(this.pictureBoxProfil);
            this.DoubleBuffered = true;
            this.Name = "UserTile";
            this.Size = new System.Drawing.Size(310, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).EndInit();
            this.panelMask.ResumeLayout(false);
            this.panelHover.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfil;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.PictureBox pictureBoxGender;
        private System.Windows.Forms.Panel panelMask;
        private System.Windows.Forms.ImageList imageListGender;
        private System.Windows.Forms.ImageList imageListHover;
        private System.Windows.Forms.Panel panelHover;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelActivity;
    }
}
