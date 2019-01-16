using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.People
{
    public class Skill
    {
        #region Attribute
        private string _name;
        private int _level;
        #endregion

        #region Properties
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Constructor
        public Skill()
        {

        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion
    }
}
