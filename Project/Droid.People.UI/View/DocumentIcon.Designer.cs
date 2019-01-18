namespace Droid.People.UI
{
    partial class DocumentIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentIcon));
            this.labelSize = new System.Windows.Forms.Label();
            this.imageListBackGround = new System.Windows.Forms.ImageList(this.components);
            this.labelType = new System.Windows.Forms.Label();
            this.labelDocName = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.ForeColor = System.Drawing.Color.Black;
            this.labelSize.Location = new System.Drawing.Point(55, 5);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(35, 15);
            this.labelSize.TabIndex = 2;
            this.labelSize.Click += new System.EventHandler(this.DocumentIcon_Click);
            this.labelSize.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DocumentIcon_MouseDoubleClick);
            this.labelSize.MouseLeave += new System.EventHandler(this.labelDocName_MouseLeave);
            this.labelSize.MouseHover += new System.EventHandler(this.labelDocName_MouseHover);
            // 
            // imageListBackGround
            // 
            this.imageListBackGround.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBackGround.ImageStream")));
            this.imageListBackGround.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBackGround.Images.SetKeyName(0, "folderActive");
            this.imageListBackGround.Images.SetKeyName(1, "folderUnactive");
            this.imageListBackGround.Images.SetKeyName(2, "folderHover");
            // 
            // labelType
            // 
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(97, 31);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(50, 13);
            this.labelType.TabIndex = 3;
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelType.Click += new System.EventHandler(this.DocumentIcon_Click);
            this.labelType.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DocumentIcon_MouseDoubleClick);
            // 
            // labelDocName
            // 
            this.labelDocName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocName.ForeColor = System.Drawing.Color.White;
            this.labelDocName.Location = new System.Drawing.Point(36, 19);
            this.labelDocName.Name = "labelDocName";
            this.labelDocName.Size = new System.Drawing.Size(100, 16);
            this.labelDocName.TabIndex = 4;
            this.labelDocName.Text = "File ";
            this.labelDocName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDocName.Click += new System.EventHandler(this.DocumentIcon_Click);
            this.labelDocName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DocumentIcon_MouseDoubleClick);
            this.labelDocName.MouseLeave += new System.EventHandler(this.labelDocName_MouseLeave);
            this.labelDocName.MouseHover += new System.EventHandler(this.labelDocName_MouseHover);
            // 
            // labelNum
            // 
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.ForeColor = System.Drawing.Color.White;
            this.labelNum.Location = new System.Drawing.Point(5, 7);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(38, 23);
            this.labelNum.TabIndex = 5;
            this.labelNum.Text = "00";
            this.labelNum.Click += new System.EventHandler(this.DocumentIcon_Click);
            this.labelNum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DocumentIcon_MouseDoubleClick);
            this.labelNum.MouseLeave += new System.EventHandler(this.labelDocName_MouseLeave);
            this.labelNum.MouseHover += new System.EventHandler(this.labelDocName_MouseHover);
            // 
            // DocumentIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelDocName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSize);
            this.Name = "DocumentIcon";
            this.Size = new System.Drawing.Size(149, 55);
            this.Click += new System.EventHandler(this.DocumentIcon_Click);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DocumentIcon_MouseDoubleClick);
            this.MouseLeave += new System.EventHandler(this.labelDocName_MouseLeave);
            this.MouseHover += new System.EventHandler(this.labelDocName_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ImageList imageListBackGround;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDocName;
        private System.Windows.Forms.Label labelNum;
    }
}
