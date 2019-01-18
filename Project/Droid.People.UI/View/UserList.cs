using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utilities;
using Tools.Utilities.UI;

namespace Droid.People.UI
{
    public delegate void UserListEventHandler(Person p);
    public partial class UserList : UserControl
    {
        #region Attribute
        public event UserListEventHandler PersonDetailRequested;

        private PanelScrollableCustom _panelScrollable;
        private const int NBTILE = 9;
        private List<Person> _persons;
        private int _currentOffset = 0;
        #endregion

        #region Properties
        public int CurrentOffset
        {
            get { return _currentOffset; }
            set { _currentOffset = value; }
        }
        public List<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }
        #endregion

        #region Constructor
        public UserList()
        {
            _persons = new List<Person>();
            InitializeComponent();
            Init();
        }
        public UserList(List<Person> lstPerson)
        {
            _persons = lstPerson;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void RefreshData()
        {
            this.SuspendLayout();
            UpdateDisplayList();
            this.ResumeLayout();
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _panelScrollable.ScrollMouseWheel += _panelScrollable_ScrollMouseWheel;
            _panelScrollable.Scroll += _panelScrollable_Scroll;
            _panelScrollable.ScrollVertical += _panelScrollable_ScrollVertical;
            RefreshData();
        }
        private void UpdateDisplayList()
        {
            if (_persons.Count > NBTILE)
            {
                if (_currentOffset < 0) _currentOffset = 0;
            }

            UserTile userTile;
            _panelScrollable.Controls.Clear();
            foreach (Person p in _persons)
            {
                userTile = new UserTile();
                userTile.LoadPerson(p);
                userTile.Dock = DockStyle.Top;
                userTile.MouseDoubleClick += UserTile_MouseDoubleClick;
                userTile.UserDetailRequested += UserTile_UserDetailRequested;
                _panelScrollable.Controls.Add(userTile);
            }
            sliderTrackBar.Maximum = _persons.Count - 7;
        }
        #endregion

        #region Event
        private void UserTile_UserDetailRequested(Person p)
        {
            if (PersonDetailRequested != null) PersonDetailRequested(p);
        }
        private void UserTile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PersonDetailRequested != null) PersonDetailRequested((sender as UserTile).CurrentPerson);
        }
        private void _panelScrollable_ScrollVertical(object sender, ScrollEventArgs e)
        {
            sliderTrackBar.Value = _panelScrollable.AutoScrollVPos;
        }
        private void _panelScrollable_Scroll(object sender, ScrollEventArgs e)
        {
            sliderTrackBar.Value = _panelScrollable.AutoScrollVPos;
        }
        private void _panelScrollable_ScrollMouseWheel(object sender, MouseEventArgs e)
        {
            sliderTrackBar.Value = _panelScrollable.AutoScrollVPos;
        }
        private void sliderTrackBar_ValueChanged(object sender, Tools.Slider.SliderTrackBarValueChangedEventArgs e)
        {
            float val = (sliderTrackBar.Maximum - sliderTrackBar.Value) * 60;
            if (val < 0) { val = 0; }
            _panelScrollable.VerticalScroll.Value = System.Convert.ToInt32(val);
        }
        #endregion
    }
}
