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
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the text of the info panel
        /// </summary>
        private void Info_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            tb.Text = "Welcome to ThunderMusic" +
                "\nHere we give you some small tips to understand the operation of our application" +
                "\nThe start tab shows you how to start having your own songs in the application so you can listen to it" +
                "\nThe browse tab shows all the songs you have in the application, with the addition that you can filter the songs" +
                "\nIn this tab you can click on the song you are looking for to play it" +
                "\nThe favorites tab shows the songs you have on your favorites list" +
                "\nIn this tab you can click on one of your favorite songs to listen to it" +
                "\nThe upload tab lets you choose between your music to enter it in the application" +
                "\nBoth the play button and the button next to the volume can be viewed and interacted with the general playlist";
        }
    }
}
