using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_Player.Builder.Properties;

namespace Builder_Player.Builder.Creations
{ 
    public class NormalBuilder : PlayerBuilder
    {

        public NormalBuilder()
        {
            _descripcion = "Normal Player";
        }
        public override Eyes BuildEyes()
        {
            return new Black();
        }

        public override Body BuildBody()
        
        {
            return new Medium();
        }

        public override Voice BuildVoice()
        {
            return new Normal();
        }
    }
}
