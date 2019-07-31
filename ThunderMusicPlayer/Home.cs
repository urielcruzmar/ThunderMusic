using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderMusicPlayer
{
    public partial class Home : UserControl
    {
        public event EventHandler mouse_click;

        public Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open the file selecctión to get abstract file in the app
        /// </summary>
        private void add_song_Click(object sender, EventArgs e)
        {
            click();
        }

        /// <summary>
        /// this function is called when the add song button is pressed
        /// </summary>
        private void click()
        {
            if (mouse_click != null)
            {
                mouse_click(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Loads the main filling the gaps to make it look better
        /// </summary>
        private void Home_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
