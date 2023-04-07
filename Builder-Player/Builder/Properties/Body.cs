using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Player.Builder.Properties
{
    public abstract class Body
    {
        protected string _description;
        public string description { get { return _description; } }
    }

    public class Big : Body
    {
        public Big()
        {
            _description = "big";
        }
    }

    public class Medium : Body
    {
        public Medium()
        {
            _description = "medium";
        }
    }

    public class Small : Body
    {
        public Small()
        {
            _description = "small";
        }
    }
}
