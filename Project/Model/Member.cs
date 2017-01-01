using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Team
{
    public class Member
    {
        #region Attribute
        private string _name;
        private string _firstname;
        private string _nickName;
        private DateTime _birthday;
        private List<Member> _chiefs;
        private List<Member> _teamMembers;
        private List<Image> _pictures;
        private List<Activities> _activities;
        private List<Project> _projects;
        private List<Skill> _skills;
        #endregion

        #region Properties
        //[JsonProperty(PropertyName = "prenom")]
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public string Nickname
        {
            get { return _nickName; }
            set { _nickName = value; }
        }
        public List<Member> Chiefs
        {
            get { return _chiefs; }
            set { _chiefs = value; }
        }
        public List<Member> TeamMembers
        {
            get { return _teamMembers; }
            set { _teamMembers = value; }
        }
        public List<Image> Pictures
        {
            get { return _pictures; }
            set { _pictures = value; }
        }
        public List<Activities> Activities
        {
            get { return _activities; }
            set { _activities = value; }
        }
        public List<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }
        public List<Skill> Skills
        {
            get { return _skills; }
            set { _skills = value; }
        }
        #endregion

        #region Constructor
        public Member()
        {
            _chiefs = new List<Member>();
            _teamMembers = new List<Member>();
            _pictures = new List<Image>();
            _activities = new List<Droid_Team.Activities>();
            _projects = new List<Project>();
            _skills = new List<Skill>();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion
    }
}
