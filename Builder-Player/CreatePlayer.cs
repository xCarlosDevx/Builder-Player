using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Builder_Player.Builder;
using Builder_Player.Builder.Creations;
using Builder_Player.Builder.Properties;

namespace Builder_Player
{
    public partial class CreatePlayer : Form
    {
        List<PlayerBuilder> _build;
        public CreatePlayer()
        {
            InitializeComponent();

            _build = new List<PlayerBuilder>();
            _build.Add(new NormalBuilder());
            _build.Add(new AlemanBuilder());
            _build.Add(new LatinBuilder());

            this.cbText.DataSource = _build;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PlayerBuilder builder = (PlayerBuilder)cbText.SelectedItem;
            Player player = builder.BuildPlayer(); 
            this.lsText.Items.Add(player);
        }
    }
}
