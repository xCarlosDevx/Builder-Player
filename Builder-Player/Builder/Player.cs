using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Player.Builder
{
    public class Player
    {
        Properties.Eyes _eyes;
        Properties.Body _body;
        Properties.Voice _voice;
        string _tipe;

        public override string ToString()
        {
            return $"{_tipe}, Ojos: {_eyes.description}, Cuerpo: {_body.description}, Voz: {_voice.description}";
        }


        public Player(Properties.Eyes eyes, Properties.Body body, Properties.Voice voice, string tipe)
        {
            _eyes = eyes;
            _body = body;
            _voice = voice;
            _tipe = tipe;
        }
    }
}
