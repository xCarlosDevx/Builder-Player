using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Player.Builder.Properties
{
    public abstract class Voice
    {
        protected string _description;
        public string description { get { return _description; } }
    }

    public class High : Voice
    {
        public High()
        {
            _description = "high";
        }
    }

    public class Normal : Voice
    {
        public Normal()
        {
            _description = "normal";
        }
    }

    public class Deep : Voice
    {
        public Deep()
        {
            _description = "deep";
        }
    }
}
