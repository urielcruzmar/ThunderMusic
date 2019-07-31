using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderMusicPlayer
{
    /// <summary>
    /// First screen with login and register options
    /// </summary>
    /// <remarks>
    /// This class handles the login and register calling to login and register usercontrols
    /// </remarks>
    public partial class WelcomeScreen : Form
    {
        // Constructor
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the welcome screen
        /// </summary>
        private void btn_close_win_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Shows and handles the login options
        /// </summary>
        private void btn_login_Click(object sender, EventArgs e)
        {
            // Transition
            if (picture_box_logo.Visible == true)
                transition_onload.HideSync(picture_box_logo);

            // Wait to be completed
            while (!transition_onload.IsCompleted) ;

            // Hide WelcomeScreen
            table_panel_main.Visible = false;

            // Show login screen
            LogIn log = new LogIn(table_panel_main, this);
            panel_main.Controls.Add(log);
            picture_box_logo.Visible = true;
        }

        /// <summary>
        /// Shows and handles the register options
        /// </summary>
        private void btn_register_Click(object sender, EventArgs e)
        {
            // Transition
            if (picture_box_logo.Visible == true)
                transition_onload.HideSync(picture_box_logo);

            // Wait to be completed
            while (!transition_onload.IsCompleted) ;

            // Hide WelcomeScreen
            table_panel_main.Visible = false;

            // Show register screen
            Register register = new Register(table_panel_main, this);
            panel_main.Controls.Add(register);
            picture_box_logo.Visible = true;
        }
    }
}
