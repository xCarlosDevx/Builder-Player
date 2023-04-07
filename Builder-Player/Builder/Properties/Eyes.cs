using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Player.Builder.Properties
{
    public abstract class Eyes
    {
        protected string _description;
        public string description { get { return _description; } }
    }

    public class Blue : Eyes
    {
        public Blue()
        {
            _description = "blue";
        }
    }

    public class Green : Eyes
    {
        public Green()
        {
            _description = "green";
        }
    }

    public class Black : Eyes
    {
        public Black()
        {
            _description = "black";
        }
    }
}
