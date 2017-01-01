using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Team
{
    public class Project
    {
        #region Attribute
        private string _name;
        private string _id;
        private DateTime _start;
        private DateTime _end;
        private List<KeyValuePair<Skill, bool>> _skills;
        #endregion

        #region Properties
        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }
        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Skill name and bool to design if the skill is mandatory for the project
        /// </summary>
        public List<KeyValuePair<Skill, bool>> Skills
        {
            get { return _skills; }
            set { _skills = value; }
        }
        #endregion

        #region Constructor
        public Project()
        {

        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion
    }
}
