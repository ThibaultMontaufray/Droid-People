namespace Droid.People.UI
{
    partial class ViewWelcome
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
            //Droid.Geography.WorldMap worldMap1 = new Droid.Geography.WorldMap();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewWelcome));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.worldMapView = new Droid.Geography.UI.WorldMapView();
            this.panelCountries = new System.Windows.Forms.Panel();
            this.chartCountries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelName = new System.Windows.Forms.Label();
            this.panelAgePyramid = new System.Windows.Forms.Panel();
            this.chartPyramidAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAgePyramid = new System.Windows.Forms.Label();
            this.labelPyramid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartAgePyramid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.userList = new Droid.People.UI.UserList();
            this.panelCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountries)).BeginInit();
            this.panelAgePyramid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPyramidAge)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAgePyramid)).BeginInit();
            this.SuspendLayout();
            // 
            // worldMapView
            // 
            //this.worldMapView.BackColor = System.Drawing.Color.DimGray;
            //worldMap1.Countries = ((System.Collections.Generic.List<Droid.Geography.Country>)(resources.GetObject("worldMap1.Countries")));
            //worldMap1.CurrentCountry = null;
            //worldMap1.Mode = Droid.Geography.WorldMap.PresentationMode.POPULATION;
            //worldMap1.RunAnimation = true;
            //worldMap1.WorkingDirectory = "C:\\Users\\amost\\AppData\\Roaming\\Servodroid\\Droid-Geography";
            //worldMap1.Zoom = 1;
            //this.worldMapView.CurrentWorldMap = worldMap1;
            //this.worldMapView.Location = new System.Drawing.Point(3, 0);
            //this.worldMapView.Name = "worldMapView";
            //this.worldMapView.Size = new System.Drawing.Size(600, 400);
            //this.worldMapView.TabIndex = 0;
            //this.worldMapView.Zoom = 0;
            // 
            // panelCountries
            // 
            this.panelCountries.BackColor = System.Drawing.Color.Transparent;
            this.panelCountries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCountries.BackgroundImage")));
            this.panelCountries.Controls.Add(this.chartCountries);
            this.panelCountries.Controls.Add(this.labelName);
            this.panelCountries.Location = new System.Drawing.Point(3, 406);
            this.panelCountries.Name = "panelCountries";
            this.panelCountries.Size = new System.Drawing.Size(194, 200);
            this.panelCountries.TabIndex = 1;
            // 
            // chartCountries
            // 
            this.chartCountries.BackColor = System.Drawing.Color.Transparent;
            this.chartCountries.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            this.chartCountries.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 10;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.TruncatedLabels = true;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.LabelAutoFitMinFontSize = 10;
            chartArea1.AxisX2.MaximumAutoSize = 100F;
            chartArea1.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 10;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY2.LabelAutoFitMinFontSize = 10;
            chartArea1.AxisY2.MaximumAutoSize = 100F;
            chartArea1.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Maroon;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 75F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.chartCountries.ChartAreas.Add(chartArea1);
            this.chartCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountries.Location = new System.Drawing.Point(0, 27);
            this.chartCountries.Name = "chartCountries";
            this.chartCountries.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.Gainsboro;
            series1.Name = "Series1";
            this.chartCountries.Series.Add(series1);
            this.chartCountries.Size = new System.Drawing.Size(194, 173);
            this.chartCountries.TabIndex = 7;
            this.chartCountries.Text = "Expense completed";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.labelName.Size = new System.Drawing.Size(154, 27);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Current nationalities";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAgePyramid
            // 
            this.panelAgePyramid.BackColor = System.Drawing.Color.Transparent;
            this.panelAgePyramid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAgePyramid.BackgroundImage")));
            this.panelAgePyramid.Controls.Add(this.chartPyramidAge);
            this.panelAgePyramid.Controls.Add(this.labelAgePyramid);
            this.panelAgePyramid.Location = new System.Drawing.Point(203, 406);
            this.panelAgePyramid.Name = "panelAgePyramid";
            this.panelAgePyramid.Size = new System.Drawing.Size(400, 200);
            this.panelAgePyramid.TabIndex = 8;
            // 
            // chartPyramidAge
            // 
            this.chartPyramidAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chartPyramidAge.BackColor = System.Drawing.Color.Transparent;
            this.chartPyramidAge.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            this.chartPyramidAge.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea2.Area3DStyle.Inclination = 10;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.Rotation = 20;
            chartArea2.Area3DStyle.WallWidth = 10;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalOffset = 1D;
            chartArea2.AxisX.LabelAutoFitMinFontSize = 10;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LabelStyle.TruncatedLabels = true;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.LogarithmBase = 2D;
            chartArea2.AxisX.MaximumAutoSize = 0F;
            chartArea2.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea2.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea2.AxisX.ScaleBreakStyle.Spacing = 0D;
            chartArea2.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.Interval = 1D;
            chartArea2.AxisX2.IntervalOffset = 1D;
            chartArea2.AxisX2.LabelAutoFitMaxFontSize = 100;
            chartArea2.AxisX2.LabelAutoFitMinFontSize = 10;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX2.LineWidth = 0;
            chartArea2.AxisX2.MaximumAutoSize = 100F;
            chartArea2.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY.IntervalOffset = 1D;
            chartArea2.AxisY.IsReversed = true;
            chartArea2.AxisY.LabelAutoFitMinFontSize = 10;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MaximumAutoSize = 0F;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY2.CustomLabels.Add(customLabel1);
            chartArea2.AxisY2.CustomLabels.Add(customLabel2);
            chartArea2.AxisY2.CustomLabels.Add(customLabel3);
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea2.AxisY2.IsReversed = true;
            chartArea2.AxisY2.LabelAutoFitMinFontSize = 5;
            chartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.Maroon;
            chartArea2.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY2.LineWidth = 0;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY2.MaximumAutoSize = 0F;
            chartArea2.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight;
            chartArea2.AxisY2.Title = "Male";
            chartArea2.AxisY2.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Maroon;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartAreaPyramidMale";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 40F;
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea3.AlignWithChartArea = "ChartAreaPyramidMale";
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IntervalOffset = 1D;
            chartArea3.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LabelStyle.Interval = 1D;
            chartArea3.AxisX.LabelStyle.IntervalOffset = 1D;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LogarithmBase = 2D;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MaximumAutoSize = 100F;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.Interval = 1D;
            chartArea3.AxisY.IntervalOffset = 1D;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY2.LabelStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.TitleFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.Maroon;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "ChartAreaPyramidFemal";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 100F;
            chartArea3.Position.Width = 40F;
            chartArea3.Position.X = 40F;
            this.chartPyramidAge.ChartAreas.Add(chartArea2);
            this.chartPyramidAge.ChartAreas.Add(chartArea3);
            this.chartPyramidAge.Location = new System.Drawing.Point(0, 27);
            this.chartPyramidAge.Name = "chartPyramidAge";
            this.chartPyramidAge.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartAreaPyramidMale";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.CustomProperties = "BarLabelStyle=Center";
            series2.EmptyPointStyle.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series2.IsValueShownAsLabel = true;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series2.LabelForeColor = System.Drawing.Color.Maroon;
            series2.Name = "SeriesMale";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.ChartArea = "ChartAreaPyramidFemal";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series3.CustomProperties = "BarLabelStyle=Center";
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.Maroon;
            series3.Name = "SeriesFemal";
            this.chartPyramidAge.Series.Add(series2);
            this.chartPyramidAge.Series.Add(series3);
            this.chartPyramidAge.Size = new System.Drawing.Size(400, 173);
            this.chartPyramidAge.TabIndex = 12;
            this.chartPyramidAge.Text = "Expense completed";
            // 
            // labelAgePyramid
            // 
            this.labelAgePyramid.AutoSize = true;
            this.labelAgePyramid.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAgePyramid.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgePyramid.ForeColor = System.Drawing.Color.White;
            this.labelAgePyramid.Location = new System.Drawing.Point(0, 0);
            this.labelAgePyramid.Name = "labelAgePyramid";
            this.labelAgePyramid.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.labelAgePyramid.Size = new System.Drawing.Size(107, 27);
            this.labelAgePyramid.TabIndex = 7;
            this.labelAgePyramid.Text = "Age pyramid";
            this.labelAgePyramid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPyramid
            // 
            this.labelPyramid.AutoSize = true;
            this.labelPyramid.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPyramid.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPyramid.ForeColor = System.Drawing.Color.White;
            this.labelPyramid.Location = new System.Drawing.Point(0, 0);
            this.labelPyramid.Name = "labelPyramid";
            this.labelPyramid.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.labelPyramid.Size = new System.Drawing.Size(107, 27);
            this.labelPyramid.TabIndex = 6;
            this.labelPyramid.Text = "Age pyramid";
            this.labelPyramid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.labelPyramid);
            this.panel1.Location = new System.Drawing.Point(308, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 271);
            this.panel1.TabIndex = 8;
            // 
            // chartAgePyramid
            // 
            this.chartAgePyramid.BackColor = System.Drawing.Color.Transparent;
            this.chartAgePyramid.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            this.chartAgePyramid.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.AxisX.LabelAutoFitMinFontSize = 10;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX.LabelStyle.Interval = 0D;
            chartArea4.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea4.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisX.LabelStyle.TruncatedLabels = true;
            chartArea4.AxisX.MaximumAutoSize = 100F;
            chartArea4.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX2.LabelAutoFitMinFontSize = 10;
            chartArea4.AxisX2.MaximumAutoSize = 100F;
            chartArea4.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisX2.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY.LabelAutoFitMinFontSize = 10;
            chartArea4.AxisY.MaximumAutoSize = 100F;
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY2.LabelAutoFitMinFontSize = 10;
            chartArea4.AxisY2.MaximumAutoSize = 100F;
            chartArea4.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY2.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            chartArea4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea4.BorderColor = System.Drawing.Color.Maroon;
            chartArea4.IsSameFontSizeForAllAxes = true;
            chartArea4.Name = "ChartAreaPyramid";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 94F;
            chartArea4.Position.Width = 75F;
            chartArea4.Position.X = 3F;
            chartArea4.Position.Y = 3F;
            this.chartAgePyramid.ChartAreas.Add(chartArea4);
            this.chartAgePyramid.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartAgePyramid.Location = new System.Drawing.Point(0, 27);
            this.chartAgePyramid.Name = "chartAgePyramid";
            this.chartAgePyramid.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartAreaPyramid";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.Gainsboro;
            series4.Name = "Series1";
            series4.YValuesPerPoint = 6;
            this.chartAgePyramid.Series.Add(series4);
            this.chartAgePyramid.Size = new System.Drawing.Size(145, 173);
            this.chartAgePyramid.TabIndex = 8;
            this.chartAgePyramid.Text = "Expense completed";
            // 
            // userList
            // 
            this.userList.AutoScroll = true;
            this.userList.BackColor = System.Drawing.Color.Black;
            this.userList.CurrentOffset = 0;
            this.userList.Location = new System.Drawing.Point(609, 0);
            this.userList.Name = "userList";
            this.userList.Persons = null;
            this.userList.Size = new System.Drawing.Size(335, 606);
            this.userList.TabIndex = 9;
            // 
            // ViewWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.userList);
            this.Controls.Add(this.panelAgePyramid);
            this.Controls.Add(this.panelCountries);
            this.Controls.Add(this.worldMapView);
            this.Name = "ViewWelcome";
            this.Size = new System.Drawing.Size(957, 611);
            this.panelCountries.ResumeLayout(false);
            this.panelCountries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountries)).EndInit();
            this.panelAgePyramid.ResumeLayout(false);
            this.panelAgePyramid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPyramidAge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAgePyramid)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panelCountries;
        private Droid.Geography.UI.WorldMapView worldMapView;
        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountries;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelAgePyramid;
        private System.Windows.Forms.Label labelPyramid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAgePyramid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAgePyramid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPyramidAge;
        private UserList userList;
    }
}
