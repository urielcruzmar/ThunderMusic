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
    /// Handles the browser of songs
    /// </summary>
    public partial class Browse : UserControl
    {
        //Listbox to show a list of songs 
        public ListBox list;
        //Event handler to communicate with the main
        public event EventHandler pmouse_click;
        public event EventHandler search_click;
        //Boolean to control the text
        bool firstClick = true;
        //String to get the text from the browsersearch
        private String criteria;

        //this function returns the criteria in the textfield
        public string Criteria
        {
            get { return criteria; }
        }

        /// <summary>
        /// loads the browse components and the list
        /// </summary>
        public Browse()
        {
            InitializeComponent();
            list = lv_songs;
        }

        /// <summary>
        /// the search button onclick
        /// </summary>
        private void search()
        {
            if (search_click != null)
            {
                search_click(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// the listbox onclick
        /// </summary>
        private void song_list_click(object sender, EventArgs e)
        {
            if (pmouse_click != null)
            {
                pmouse_click(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// everytime the user looks for abstract song, this executes
        /// </summary>
        private void action_search_click(object sender, EventArgs e)
        {
            criteria = tb_search.Text;
            search();
        }

        /// <summary>
        /// this event is called everytime the user types something in the text
        /// </summary>
        private void key_typed(object sender, EventArgs e)
        {
            criteria = tb_search.Text;
            search();
        }

        /// <summary>
        /// called when the user uses the text that is user to search
        /// </summary>
        private void search_criteria_click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                firstClick = false;
                tb_search.Text = "";
            } 
        }

        /// <summary>
        /// When the browser dock loads, it fill himself in the aplication space
        /// </summary>
        private void Browse_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
