using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace ThunderMusicPlayer
{
    /// <summary>
    /// Class dedicated to update user info: username, password and image
    /// </summary>
    public partial class Profile : UserControl
    {
        private string mail;

        public Profile(string mail)
        {
            InitializeComponent();
            this.mail = mail;
        }

        /// <summary>
        /// Set the user's info when this usercontrol is open on the fields
        /// </summary>
        private void load_user_data()
        {
            Console.WriteLine(mail);

            string connectionString = "datasource=192.168.100.6;port=3306;username=user;password=user;database=thunder_music;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader reader = null;

            connection.Open();
            try
            {
                command.CommandText = "select mail, name, image from users where mail = @mail";
                command.Parameters.AddWithValue("@mail", mail);
                reader = command.ExecuteReader();

                if(reader.Read())
                {
                    string name;
                    byte[] image;

                    name = reader.GetString(1);
                    image = (byte[]) reader.GetValue(2);
                    MemoryStream memory = new MemoryStream(image, 0, image.Length);

                    profile_pic.Image = Image.FromStream(memory);
                    tb_name.Text = name;
                    tb_mail.Text = mail;
                    tb_pass.Text = "";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

            if(reader != null)
            {
                reader.Close();
            }

            connection.Close();
        }

        /// <summary>
        /// To set the user image when user clicks the pic
        /// </summary>
        private void profile_pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image|*.png;*.jpg;*.jpeg";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profile_pic.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// When the user clicks the 'UPDATE' button, the info they entered is inserted on the database
        /// If the user doesn't set a new pass, it will not be update
        /// As the 'mail' field is the primary key, we do not allow users to change it
        /// </summary>
        private void btn_yes_Click(object sender, EventArgs e)
        {
            // Convert the image to byte array to properly store it on the database
            MemoryStream memoryStream = new MemoryStream();
            byte[] photoBytes = null;
            profile_pic.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            photoBytes = memoryStream.ToArray();

            string query; 
            string connectionString = "datasource=192.168.100.6;port=3306;username=user;password=user;database=thunder_music;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();

            this.mail = tb_mail.Text;

            // Password will not be updated if the user doesn't set it
            if(tb_pass.Text != "")
            {
                command.CommandText = "update users set mail = @mail, name = @name, password = @pass, image = @image where mail = @current_mail";
                command.Parameters.AddWithValue("@mail", tb_mail.Text);
                command.Parameters.AddWithValue("@name", tb_name.Text);
                command.Parameters.AddWithValue("@pass", tb_pass.Text);
                command.Parameters.AddWithValue("@current_mail", mail);
            }
            else
            {
                command.CommandText = "update users set mail = @mail, name = @name, image = @image where mail = @current_mail";
                command.Parameters.AddWithValue("@mail", tb_mail.Text);
                command.Parameters.AddWithValue("@name", tb_name.Text);
                command.Parameters.AddWithValue("@current_mail", mail);
            }

            if(profile_pic.Image != null)
            {
                command.Parameters.AddWithValue("@image", photoBytes);
            }
            else
            {
                command.Parameters.AddWithValue("@image", null);
            }

            try
            {
                command.ExecuteReader().Close();
                MessageBox.Show("Information successfully updated");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Mail taken", "Error");
            }

            connection.Close();
        }

        /// <summary>
        /// Invoke load_user_data() method when this UserControl is called
        /// </summary>
        private void Profile_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            load_user_data();
        }
    }
}
