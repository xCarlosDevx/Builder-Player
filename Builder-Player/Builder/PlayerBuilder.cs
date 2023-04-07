using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Player.Builder
{
    public abstract class PlayerBuilder
    {

        protected string _descripcion;
        public abstract Properties.Eyes BuildEyes();
        public abstract Properties.Body BuildBody();
        public abstract Properties.Voice BuildVoice();

        public override string ToString()
        {
            return _descripcion;
        }
        public Player BuildPlayer()
        {
            Properties.Eyes eyes = BuildEyes();
            Properties.Body body = BuildBody();
            Properties.Voice voice = BuildVoice();

            return new Player(eyes,body,voice, _descripcion);
        }
    }
}
