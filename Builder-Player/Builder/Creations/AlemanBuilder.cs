using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_Player.Builder.Properties;

namespace Builder_Player.Builder.Creations
{
    public class AlemanBuilder : PlayerBuilder
    {

        public AlemanBuilder()
        {
            _descripcion = "Aleman Player";
        }
        public override Eyes BuildEyes()
        {
            return new Blue();
        }

        public override Body BuildBody()

        {
            return new Big();
        }

        public override Voice BuildVoice()
        {
            return new Deep();
        }
    }
}
