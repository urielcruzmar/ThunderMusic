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
using System.IO;

namespace ThunderMusicPlayer
{
    /// <summary>
    /// Handle register
    /// </summary>
    public partial class Register : UserControl
    {
        // Boolean to check the first entry
        private Boolean first_entry_mail = true;
        private Boolean first_entry_name = true;
        private Boolean first_entry_pass = true;

        // Parent panel
        private TableLayoutPanel table_panel_main;
        private WelcomeScreen welcomeScreen;

        // Connection
        private MySqlConnection connection;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="table_panel_main">Main panel of welcome screen</param>
        /// <param name="welcomeScreen">WelcomeScreen</param>
        public Register(TableLayoutPanel table_panel_main, WelcomeScreen welcomeScreen)
        {
            InitializeComponent();
            this.table_panel_main = table_panel_main;
            this.welcomeScreen = welcomeScreen;
            connect();
        }

        /// <summary>
        /// When register button is clicked, a new user is registered
        /// </summary>
        /// <remarks>
        /// If there is an error a pop up error message appears
        /// </remarks>
        private void btn_complete_register_Click(object sender, EventArgs e)
        {
            bool fail = false;

            if((tb_user.Text.Length == 0) || (tb_user.Text == "Username"))
            {
                fail = true;
                MessageBox.Show("You must enter a valid username");
            }

            if((tb_mail.Text.Length == 0) || (tb_mail.Text == "Username"))
            {
                fail = true;
                MessageBox.Show("You must enter a valid mail");
            }

            if((tb_pass.Text.Length == 0) || (tb_pass.Text == "Username"))
            {
                fail = true;
                MessageBox.Show("You must enter a valid password");
            }

            if(!fail)
            {
                MemoryStream memoryStream = new MemoryStream();
                byte[] photoBytes = null;
                Image image = ThunderMusicPlayer.Properties.Resources.pika_meme;
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                photoBytes = memoryStream.ToArray();

                // Creates the string for the sql call to the database
                MySqlCommand query = connection.CreateCommand();
                query.CommandText = "INSERT INTO users(mail,name,password,image) VALUES (@mail,@name,@password,@image)";
                query.Parameters.AddWithValue("@mail", tb_mail.Text);
                query.Parameters.AddWithValue("@name", tb_user.Text);
                query.Parameters.AddWithValue("@password", tb_pass.Text);
                query.Parameters.AddWithValue("@image", photoBytes);

                // Tries to register the user
                try
                {
                    // Try register
                    query.ExecuteReader().Close();

                    // Close connetion
                    connection.Close();

                    // Show main window
                    this.Visible = false;
                    var main = new Main(tb_mail.Text);
                    main.FormClosed += (s, args) => welcomeScreen.Close();
                    main.Show();
                    welcomeScreen.Visible = false;
                }
                catch(MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("El mail ya está en uso");
                }
                

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
        /// Hide the register and goes back to the main screen
        /// </summary>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            table_panel_main.Visible = true;
        }

        /// <summary>
        /// The username field clears when clicked on the first time
        /// </summary>
        private void username_click(object sender, EventArgs e)
        {
            if (first_entry_name)
            {
                tb_user.Text = "";
                first_entry_name = false;
            }
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
    }
}
