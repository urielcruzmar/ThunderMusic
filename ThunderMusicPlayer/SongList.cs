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
    /// <summary>
    /// Control that contains the songs lists and handles the click events
    /// </summary>
    public partial class SongList : UserControl
    {
        public ListBox list;

        public event EventHandler mouse_click;

        public SongList()
        {
            InitializeComponent();
            list = lv_songs;
        }

        private void click()
        {
            if (mouse_click != null)
            {
                mouse_click(this, EventArgs.Empty);
            }
        }

        private void song_list_click(object sender, MouseEventArgs e)
        {
            click();
        }

        private void SongList_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
