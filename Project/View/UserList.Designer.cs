namespace Droid_People
{
    partial class UserList
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
            this._panelScrollable = new Tools4Libraries.PanelScrollable();
            this.sliderTrackBar = new Tools4Libraries.Slider.SliderTrackBar();
            this.SuspendLayout();
            // 
            // _panelScrollable
            // 
            this._panelScrollable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelScrollable.AutoScroll = true;
            this._panelScrollable.AutoScrollHorizontalMaximum = 100;
            this._panelScrollable.AutoScrollHorizontalMinimum = 0;
            this._panelScrollable.AutoScrollHPos = 0;
            this._panelScrollable.AutoScrollVerticalMaximum = 100;
            this._panelScrollable.AutoScrollVerticalMinimum = 0;
            this._panelScrollable.AutoScrollVPos = 0;
            this._panelScrollable.EnableAutoScrollHorizontal = true;
            this._panelScrollable.EnableAutoScrollVertical = true;
            this._panelScrollable.Location = new System.Drawing.Point(0, 0);
            this._panelScrollable.Name = "_panelScrollable";
            this._panelScrollable.Size = new System.Drawing.Size(335, 680);
            this._panelScrollable.TabIndex = 0;
            this._panelScrollable.VisibleAutoScrollHorizontal = false;
            this._panelScrollable.VisibleAutoScrollVertical = false;
            // 
            // sliderTrackBar
            // 
            this.sliderTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.sliderTrackBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sliderTrackBar.EmptyTrackColor = System.Drawing.Color.Black;
            this.sliderTrackBar.Location = new System.Drawing.Point(318, 0);
            this.sliderTrackBar.Maximum = 300;
            this.sliderTrackBar.Name = "sliderTrackBar";
            this.sliderTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderTrackBar.ScaleType = Tools4Libraries.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sliderTrackBar.Size = new System.Drawing.Size(16, 683);
            this.sliderTrackBar.SmallChange = 1;
            this.sliderTrackBar.TabIndex = 0;
            this.sliderTrackBar.TickHeight = 10;
            this.sliderTrackBar.TickSpacing = 10;
            this.sliderTrackBar.TickWidth = 10;
            this.sliderTrackBar.UseSeeking = false;
            this.sliderTrackBar.ValueChanged += new Tools4Libraries.Slider.SliderTrackBar.ValueChangedDelegate(this.sliderTrackBar_ValueChanged);
            // 
            // UserList
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.sliderTrackBar);
            this.Controls.Add(this._panelScrollable);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(334, 683);
            this.ResumeLayout(false);

        }
        #endregion

        private Tools4Libraries.Slider.SliderTrackBar sliderTrackBar;
    }
}
