using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid.People
{
    public class ToolStripMenuPeople : RibbonTab
    {
        #region Attribute
        public event EventHandlerAction ActionAppened;

        private RibbonPanel _panelUser;
        private RibbonButton _rbWelcome;
        private RibbonButton _search;
        private RibbonButton _load;
        private RibbonButton _create;
        private RibbonButton _open;
        private RibbonButton _webActivity;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ToolStripMenuPeople()
        {
            Init();
        }
        #endregion

        #region Methods public
        public void ChangeLanguage()
        {
            _rbWelcome.Text = GetText.Text("Menu");
            _open.Text = GetText.Text("Open");
            _load.Text = GetText.Text("LoadRepertory");
            _search.Text = GetText.Text("Search");
            _create.Text = GetText.Text("Create");
            _webActivity.Text = GetText.Text("WebActivity");
            this.Text = GetText.Text("People");
        }
        public void EndRefreshLib()
        {
            _load.Image = Tools4Libraries.Resources.ResourceIconSet32Default.arrow_refresh;
            _load.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.arrow_refresh;
            _load.FlashEnabled = false;
        }
        public void StartRefreshLib()
        {
            _load.Image = Tools4Libraries.Resources.ResourceIconSet32Default.zoom_refresh;
            _load.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.zoom_refresh;
            _load.FlashImage = Tools4Libraries.Resources.ResourceIconSet32Default.arrow_refresh;
            _load.FlashEnabled = true;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            BuildPanelUser();
        }
        private void BuildPanelUser()
        {
            _rbWelcome = new RibbonButton("Menu");
            _rbWelcome.Name = "Menu";
            _rbWelcome.Image = Tools4Libraries.Resources.ResourceIconSet32Default.home_page;
            _rbWelcome.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.home_page;
            _rbWelcome.Click += _buttonClick;

            _open = new RibbonButton(GetText.Text("Open"));
            _open.Name = "Open";
            _open.Image = Tools4Libraries.Resources.ResourceIconSet32Default.folder_user;
            _open.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.folder_user;
            _open.Click += _buttonClick;

            _load = new RibbonButton(GetText.Text("RefreshContacts"));
            _load.Name = "RefreshContacts";
            _load.Image = Tools4Libraries.Resources.ResourceIconSet32Default.arrow_refresh;
            _load.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.arrow_refresh;
            _load.FlashImage = Tools4Libraries.Resources.ResourceIconSet32Default.arrow_refresh_small;
            _load.FlashEnabled = false;
            _load.Click += _buttonClick;

            _search = new RibbonButton(GetText.Text("Search"));
            _search.Name = "Search";
            _search.Image = Tools4Libraries.Resources.ResourceIconSet32Default.filter;
            _search.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.filter;
            _search.Click += _buttonClick;
            
            _create = new RibbonButton(GetText.Text("Create"));
            _create.Name = "Create";
            _create.Image = Tools4Libraries.Resources.ResourceIconSet32Default.user_edit;
            _create.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.user_edit;
            _create.Click += _buttonClick;

            _webActivity = new RibbonButton(GetText.Text("WebActivity"));
            _webActivity.Name = "Web activity";
            _webActivity.Image = Tools4Libraries.Resources.ResourceIconSet32Default.spider_web;
            _webActivity.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.spider_web;
            _webActivity.Click += _buttonClick;

            _panelUser = new RibbonPanel("Person");
            _panelUser.Items.Add(_rbWelcome);
            _panelUser.Items.Add(_open);
            _panelUser.Items.Add(_load);
            _panelUser.Items.Add(_search);
            _panelUser.Items.Add(_create);
            _panelUser.Items.Add(_webActivity);
            this.Panels.Add(_panelUser);
            this.Text = GetText.Text("People");
        }
        #endregion

        #region Event
        private void _buttonClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                string command = ((RibbonButton)sender).Name;
                if (command.Equals("Refresh repertory")) { _load.FlashEnabled = true; }
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs(command));
            }
        }
        #endregion
    }
}
