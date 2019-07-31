using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ThunderMusicPlayer
{

    /// <summary>
    /// Handles the login
    /// </summary>
    public partial class LogIn : UserControl
    {

        // Boolean to check the first entry
        private Boolean first_entry_mail = true;
        private Boolean first_entry_pass = true;

        // Connection
        private MySqlConnection connection;

        // Parent panel
        private TableLayoutPanel table_panel_main;
        private WelcomeScreen welcomeScreen;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="table_panel_main">Main panel of welcome screen</param>
        /// <param name="welcomeScreen">WelcomeScreen</param>
        public LogIn(TableLayoutPanel table_panel_main, WelcomeScreen welcomeScreen)
        {
            InitializeComponent();
            this.table_panel_main = table_panel_main;
            this.welcomeScreen = welcomeScreen;
            connect();
        }

        /// <summary>
        /// Tries to log in into the database
        /// </summary>
        /// <remarks>
        /// If the login fails, a popup shows to inform the user
        /// </remarks>
        private void btn_enter_Click(object sender, EventArgs e)
        {
            // Query and result
            MySqlCommand query;
            MySqlDataReader reader = null;

            try
            {
                // Creates the string for the sql call to the database
                query = connection.CreateCommand();
                query.CommandText = "SELECT * FROM users WHERE mail = @mail AND password = @password";
                query.Parameters.AddWithValue("@mail", tb_mail.Text);
                query.Parameters.AddWithValue("@password", tb_pass.Text);

                // Creates the reader that shows the result of the query
                reader = query.ExecuteReader();

                if (reader.Read())
                {
                    // Close connetion
                    reader.Close();
                    connection.Close();

                    // Show main window
                    this.Visible = false;
                    var main = new Main(tb_mail.Text);
                    main.FormClosed += (s, args) => welcomeScreen.Close();
                    main.Show();
                    welcomeScreen.Visible = false;
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("The mail or the password are not correct");
                }
            }
            catch (Exception ex)
            {
                if(reader != null)
                    reader.Close();
                MessageBox.Show("Error");
            }
        }

        /// <summary>
        /// Connect to database
        /// </summary>
        private void connect()
        {
            //string connectionString = "datasource=192.168.2.160;port=3306;username=user;password=user;database=thunder_music;";
            string connectionString = "datasource=192.168.100.6;port=3306;username=user;password=user;database=thunder_music;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        /// <summary>
        /// The email field clears when clicked on the first time
        /// </summary>
        private void email_click(object sender, EventArgs e)
        {
            if (first_entry_mail)
            {
                tb_mail.Text = "";
                first_entry_mail = false;
            }
        }

        /// <summary>
        /// The password field clears when clicked on the first time
        /// </summary>
        private void pass_click(object sender, EventArgs e)
        {
            if (first_entry_pass)
            {
                tb_pass.Text = "";
                first_entry_pass = false;
            }
        }

        /// <summary>
        /// Hides login and shows Welcome Screen
        /// </summary>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            table_panel_main.Visible = true;
        }
    }
}
