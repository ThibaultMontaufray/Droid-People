using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Team
{
    public class Activities
    {
        #region Attribute
        private DateTime _start;
        private DateTime _end;
        private string _name;
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
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
        #endregion

        #region Constructor
        public Activities()
        {

        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion
    }
}
