using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderMusicPlayer
{
    /// <summary>
    /// Main Window of the music player
    /// </summary>
    /// <remarks>
    /// From here you can access to all the features
    /// </remarks>
    public partial class Main : Form
    {
        // User mail
        public string mail;

        // TABS
        Home home;

        // Song list
        List<string> paths;
        SongList songlistobj;
        ListBox songs_list;

        // Song list for the favorited songs
        List<string> favoritePaths;
        SongList songlistobjFav;
        ListBox songs_list_fav;

        // Song list for the browse songs
        List<string> browsePaths;
        ListBox song_list_browse;

        //This is the browse tab class
        Browse browse;

        // Song list shuffled
        List<string> paths_default;

        // Number of song in the list
        int songNumber;

        // Number of song in the list
        int songNumberFav;

        // Number of song in the list
        int songNumberBrowse;

        // Check if shuffle mode is on
        bool shuffleStatus;

        // Check if repeat mode is on
        bool repeatStatus;

        // Volume value when muted
        int savedVolume;

        // Check if volume is muted
        bool muted;

        // Connection
        private MySqlConnection connection;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="text">User mail</param>
        public Main(string text)
        {
            InitializeComponent();
            mail = text;
        }

        /// <summary>
        /// Load form
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            // Get the system's path for music
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            // Get all music filenames
            string[] filter = new[] { ".mp3", ".wav" };
            paths = Directory.EnumerateFiles(musicPath).Where(f => filter.Any(f.ToLower().EndsWith)).ToList();

            // Create lists
            favoritePaths = new List<String>();
            browsePaths = new List<String>();

            songlistobj = new SongList();
            songlistobjFav = new SongList();
            //songlistobjBrowse; = new Bro

            // Set inital values
            songNumber = 0;
            songNumberBrowse = 0;
            shuffleStatus = false;
            repeatStatus = false;
            muted = false;

            // Go to home
            hide_all();
            home = new Home();
            home.mouse_click += new EventHandler(btn_upload_Click);
            panel_main_inner.Controls.Add(home);
        }

        /// <summary>
        /// Loads home control in main panel
        /// </summary>
        private void btn_home_Click(object sender, EventArgs e)
        {
            hide_all();
            home = new Home();
            home.mouse_click += new EventHandler(btn_upload_Click);
            panel_main_inner.Controls.Add(home);
            lb_current_tab.Text = "Home";
        }

        /// <summary>
        /// Loads browse in main panel
        /// </summary>
        private void btn_browse_Click(object sender, EventArgs e)
        {
            hide_all();
            lb_current_tab.Text = "Browse";

            browse = new Browse();
            browsePaths = new List<String>(paths);
            browse.pmouse_click += new EventHandler(list_click_browse);
            browse.search_click += new EventHandler(searchButton);
            song_list_browse = browse.list;
            loadListBrowse();

        }

        // Playing button
        private void btn_playlists_Click(object sender, EventArgs e)
        {
            loadList();
            lb_current_tab.Text = "Playing";
        }

        // Load fav list
        private void btn_favourites_Click(object sender, EventArgs e)
        {
            songNumberFav = 0;
            loadListFavorite();
            lb_current_tab.Text = "Favorites";
        }

        /// <summary>
        /// Adds or remove a song from favorites
        /// </summary>
        private void btn_add_favorite_song_bar_Click(object sender, EventArgs e)
        {
            int index = favoritePaths.FindIndex(f => f.Equals(paths[songNumber]));
            if (index == -1)
            {
                favoritePaths.Add(paths[songNumber]);
                btn_add_favorite_song_bar.Image = ThunderMusicPlayer.Properties.Resources.baseline_favorite_white_48dp;
            }
            else
            {
                favoritePaths.Remove(paths[songNumber]);
                btn_add_favorite_song_bar.Image = ThunderMusicPlayer.Properties.Resources.baseline_favorite_border_white_48dp;
            }
        }

        /// <summary>
        /// Shows up a window to upload your songs, and it copies them into the music user folder
        /// </summary>
        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Audio|*.wav;*.mp3";
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string[] filter = new[] { ".mp3", ".wav" };

            if (open.ShowDialog() == DialogResult.OK)
            {
                String nombreCancion = null;
                String formato;
                List<string> playlistPaths = open.FileNames.ToList();
                for (int i = 0; i < playlistPaths.Count; i++)
                {
                    paths.Add(playlistPaths[i]);

                    if (playlistPaths[i].EndsWith(".mp3"))
                        formato = ".mp3";
                    else
                        formato = ".wav";

                    var tfile = TagLib.File.Create(playlistPaths[i]);

                    if (tfile.Tag.Title != null)
                        nombreCancion = tfile.Tag.Title;
                    else
                        nombreCancion = "Unknown";

                    string sourcePath = open.InitialDirectory;
                    string destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                    string sourceFileName = playlistPaths[i];
                    string destinationFileName = nombreCancion + formato;
                    string sourceFile = System.IO.Path.Combine(sourcePath, sourceFileName);
                    string destinationFile = System.IO.Path.Combine(destinationPath, destinationFileName);

                    if (!System.IO.Directory.Exists(destinationPath))
                    {
                        System.IO.Directory.CreateDirectory(destinationPath);
                    }
                    System.IO.File.Copy(sourceFile, destinationFile, true);
                }

                // Get the system's path for music
                // Get all music filenames
                string[] filtro = new[] { ".mp3", ".wav" };
                paths = Directory.EnumerateFiles(musicPath).Where(f => filtro.Any(f.ToLower().EndsWith)).ToList();
                btn_library_Click(new object(), new EventArgs());
            }
        }

        // CLOSE
        private void btn_close_win_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MINIMIZE
        private void btn_min_win_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Shows the profile with options
        /// </summary>
        /// <remarks>
        /// You can change name, image and password
        /// </remarks>
        private void btn_user_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(mail);
            hide_all();
            panel_main_inner.Controls.Add(profile);
        }

        // MORE INFO
        private void btn_info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            hide_all();
            panel_main_inner.Controls.Add(info);
        }

        /// <summary>
        /// Connecto to database
        /// </summary>
        private void connect()
        {
            //string connectionString = "datasource=192.168.2.160;port=3306;username=user;password=user;database=thunder_music;";
            string connectionString = "datasource=192.168.100.6;port=3306;username=user;password=user;database=thunder_music;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        /// <summary>
        /// Shows or hides left bar
        /// </summary>
        private void btn_hide_show_left_bar_Click(object sender, EventArgs e)
        {
            if (panel_left_inner.Width == 294)
            {
                panel_left_inner.Width = 82;
                show_left_bar_txt(false);
                btn_hide_show_left_bar.Image = ThunderMusicPlayer.Properties.Resources.baseline_chevron_right_white_48dp;
            }
            else
            {
                panel_left_inner.Width = 294;
                show_left_bar_txt(true);
                btn_hide_show_left_bar.Image = ThunderMusicPlayer.Properties.Resources.baseline_chevron_left_white_48dp;
            }
        }

        /// <summary>
        /// Shows/hides left bar text
        /// </summary>
        /// <param name="option">Show or hide</param>
        private void show_left_bar_txt(Boolean option)
        {
            if (option)
            {
                btn_home.Text = " Home";
                btn_favourites.Text = " Favourites";
                btn_browse.Text = " Browse";
                btn_playlists.Text = " Playlists";
                btn_upload.Text = " Upload";
            }
            else
            {
                btn_home.Text = null;
                btn_favourites.Text = null;
                btn_browse.Text = null;
                btn_playlists.Text = null;
                btn_upload.Text = null;
            }
        }

        /// <summary>
        /// If it is playing music, it pauses it, if not, it starts to play the songs
        /// </summary>
        private void btn_play_stop_Click(object sender, EventArgs e)
        {
            if (media_player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                media_player.Ctlcontrols.pause();
                timer.Stop();
                btn_play_stop.Image = ThunderMusicPlayer.Properties.Resources.outline_play_circle_filled_white_white_48dp;
            }
            else
            {
                btn_favourites.Visible = true;
                if (media_player.URL.Equals(""))
                {
                    media_player.URL = paths[0];
                    favourited(paths[0]);

                    SetTagsBottomBar();
                }
                else {
                    var tfile = TagLib.File.Create(@media_player.URL);
                    media_player.Ctlcontrols.play();
                    favourited(paths[songNumber]);

                    slider_song.MaximumValue = (int) media_player.currentMedia.duration;
                }
                btn_play_stop.Image = ThunderMusicPlayer.Properties.Resources.outline_pause_circle_outline_white_48dp;
                timer.Start();
            }

        }

        /// <summary>
        /// Set Title, Artist and Image to bottom bar
        /// </summary>
        public void SetTagsBottomBar() {

            var tfile = TagLib.File.Create(@media_player.URL);

            if (tfile.Tag.Title != null)
                lb_bottom_bar_song_title.Text = tfile.Tag.Title;
            else
                lb_bottom_bar_song_artist.Text = "Unknown";

            if (tfile.Tag.FirstAlbumArtist != null)
                lb_bottom_bar_song_artist.Text = tfile.Tag.FirstAlbumArtist;
            else
                lb_bottom_bar_song_artist.Text = "Unknown";

            if (tfile.Tag.Pictures.Length > 0)
                pb_song_image.Image = Image.FromStream(new MemoryStream(tfile.Tag.Pictures[0].Data.Data)).GetThumbnailImage(200, 200, null, IntPtr.Zero);
            else
                pb_song_image.Image = ThunderMusicPlayer.Properties.Resources.pika_meme;

            String artist = tfile.Tag.FirstAlbumArtist;
        }

        /// <summary>
        /// Starts to play the next song in the list
        /// </summary>
        private void btn_next_song_Click(object sender, EventArgs e)
        {
            if (songNumber < paths.Count-1)
            {
                songNumber++;
                favourited(paths[songNumber]);

                media_player.URL = paths[songNumber];
                SetTagsBottomBar();
                sincList();
                btn_favourites.Visible = true;
                btn_play_stop.Image = ThunderMusicPlayer.Properties.Resources.outline_pause_circle_outline_white_48dp;
                timer.Start();
            }
        }

        /// <summary>
        /// Starts to play the previous song in the list
        /// </summary>
        private void btn_previous_song_Click(object sender, EventArgs e)
        {
            if (songNumber > 0)
            {
                songNumber--;
                favourited(paths[songNumber]);

                media_player.URL = paths[songNumber];
                SetTagsBottomBar();
                sincList();
                btn_favourites.Visible = true;
                btn_play_stop.Image = ThunderMusicPlayer.Properties.Resources.outline_pause_circle_outline_white_48dp;
                timer.Start();
            }
        }

        /// <summary>
        /// Sets the play mode to repeat mode, and listen allways to the same song
        /// </summary>
        private void btn_repeat_Click(object sender, EventArgs e)
        {
            if (repeatStatus)
            {
                repeatStatus = false;
                btn_repeat.BackColor = Color.FromArgb(11, 11, 11);
            }
            else
            {
                repeatStatus = true;
                btn_repeat.BackColor = Color.FromArgb(44, 44, 44);
            }
        }

        /// <summary>
        /// Shufles the playlist array and creates a copy to change back to normal mode
        /// </summary>
        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            //If it is suffled, gets the non suffled
            if(shuffleStatus)
            {
                paths = paths_default;
                songNumber = 0;
                shuffleStatus = false;
                loadList();
                btn_shuffle.BackColor = Color.FromArgb(11,11,11);
            }
            else
            {
                //If it is going to shuffle the playlist, it saves the not suffled one
                paths_default = this.paths;
                Random random = new Random();
                paths = paths_default.OrderBy(i => random.Next()).ToList();
                songNumber = 0;
                shuffleStatus = true;
                loadList();
                btn_shuffle.BackColor = Color.FromArgb(44, 44, 44);
            }
        }

        /// <summary>
        /// Shows the current song and the nexts that will be played
        /// </summary>
        private void btn_library_Click(object sender, EventArgs e)
        {
            loadList();
        }

        /// <summary>
        /// Mute and save volume value to unmute
        /// </summary>
        private void btn_volume_mute_Click(object sender, EventArgs e)
        {
            if (muted)
            {
                media_player.settings.volume = savedVolume;
                slider_volume.Value = savedVolume;
                muted = false;
                btn_volume_mute.Image = ThunderMusicPlayer.Properties.Resources.outline_volume_up_white_48dp;
            }
            else
            {
                savedVolume = slider_volume.Value;
                media_player.settings.volume = 0;
                slider_volume.Value = 0;
                muted = true;
                btn_volume_mute.Image = ThunderMusicPlayer.Properties.Resources.outline_volume_off_white_48dp;
            }
        }

        /// <summary>
        /// It syncronizes the volume bar from the media player to ours
        /// </summary>
        private void volume_changed(object sender, EventArgs e)
        {
            media_player.settings.volume = slider_volume.Value;
            if(slider_volume.Value == 0)
            {
                btn_volume_mute.Image = ThunderMusicPlayer.Properties.Resources.outline_volume_off_white_48dp;
                muted = true;
            }
            else
            {
                btn_volume_mute.Image = ThunderMusicPlayer.Properties.Resources.outline_volume_up_white_48dp;
                muted = false;
            }
        }

        private void time_changed_bar(object sender, EventArgs e)
        {
            media_player.Ctlcontrols.currentPosition = slider_song.Value;
        }
        private void time_changed(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            time_changed_action();
        }

        /// <summary>
        /// This function syncronizes the media_player progress bar with ours and updates the text that shows how it goes
        /// </summary>
        private void time_changed_action()
        {
            lb_total_time.Text = media_player.currentMedia.durationString;
            lb_current_time.Text = media_player.Ctlcontrols.currentPositionString;

            slider_song.Value = (int) media_player.Ctlcontrols.currentPosition;
            slider_song.MaximumValue = (int)media_player.currentMedia.duration;
        }

        /// <summary>
        /// It ticks every second to update the progress bar that controls the current time on the song
        /// </summary>
        private void tick(object sender, EventArgs e)
        {
            time_changed_action();
        }

        /// <summary>
        /// Checks the current status of the player and performs diferent acctions based on the settings of the user
        /// </summary>
        private void play_state_changed(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Test the current state of the player and display a message for each state.
            switch (e.newState)
            {
                case 0:    // Undefined
                    break;

                case 1:    // Stopped
                    break;

                case 2:    // Paused
                    break;

                case 3:    // Playing
                    break;

                case 4:    // ScanForward
                    break;

                case 5:    // ScanReverse
                    break;

                case 6:    // Buffering
                    break;

                case 7:    // Waiting
                    break;

                case 8:    // MediaEnded
                    if(repeatStatus)
                    {
                        this.BeginInvoke(new Action(() => {
                            favourited(paths[songNumber]);

                            media_player.URL = paths[songNumber];
                            SetTagsBottomBar();
                            sincList();
                        }));
                    }
                    else
                    {
                        this.BeginInvoke(new Action(() => {

                        if (songNumber < paths.Count-1)
                        {
                            songNumber++;

                            favourited(paths[songNumber]);

                            media_player.URL = paths[songNumber];
                            SetTagsBottomBar();
                            sincList();
                            }
                        }));
                    }
                    break;

                case 9:    // Transitioning
                    break;

                case 10:   // Ready
                    break;

                case 11:   // Reconnecting
                    break;

                case 12:   // Last
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Sincronizes the current song with the list
        /// </summary>
        private void sincList()
        {
            if (songs_list != null)
            {
                songs_list.SetSelected(songNumber, true);
                SetTagsBottomBar();
            }
        }

        /// <summary>
        /// Sincronizes the current favorite song with the list
        /// </summary>
        private void sincListFav()
        {
            if (songs_list_fav != null)
            {
                songs_list_fav.SetSelected(songNumberFav, true);
                SetTagsBottomBar();
            }
        }

        /// <summary>
        /// Sincronizes the current browsed song with the list
        /// </summary>
        private void sincListBrowse()
        {
            if (song_list_browse != null)
            {
                song_list_browse.SetSelected(song_list_browse.SelectedIndex, true);
                SetTagsBottomBar();
            }
        }
        /// <summary>
        /// Plays the clicked song in the main panel
        /// </summary>
        public void list_click(object sender, EventArgs e)
        {
            if((songNumber = songs_list.SelectedIndex) != -1)
            {
                favourited(paths[songNumber]);

                media_player.URL = paths[songNumber];
                sincList();
                btn_play_stop.Image = ThunderMusicPlayer.Properties.Resources.outline_pause_circle_outline_white_48dp;
                timer.Start();
            }
        }

        /// <summary>
        /// Plays the clicked song in the main panel
        /// </summary>
        public void list_click_browse(object sender, EventArgs e)
        {
            if ((song_list_browse.SelectedIndex) != -1)
            {
                favourited(browsePaths[song_list_browse.SelectedIndex]);

                media_player.URL = browsePaths[song_list_browse.SelectedIndex];
                sincListBrowse();
                btn_play_stop.Image = ThunderMusicPlayer.Properties.Resources.outline_pause_circle_outline_white_48dp;
                timer.Start();
            }
        }

        /// <summary>
        /// Plays the clicked favorite song in the main panel
        /// </summary>
        public void list_click_fav(object sender, EventArgs e)
        {
            if ((songNumberFav = songs_list_fav.SelectedIndex) != -1)
            {
                favourited(favoritePaths[songNumberFav]);

                media_player.URL = favoritePaths[songNumberFav];
                sincListFav();
                btn_play_stop.Image = ThunderMusicPlayer.Properties.Resources.outline_pause_circle_outline_white_48dp;
                timer.Start();
            }
        }

        /// <summary>
        /// Hides all components of main panel
        /// </summary>
        private void hide_all()
        {
            panel_main_inner.Controls.Clear();
        }

        /// <summary>
        /// Load the current songs list and shows it 
        /// </summary>
        private void loadList()
        {
            hide_all();
            String name;
            String artist;
            songs_list = songlistobj.list;
            songlistobj.mouse_click += new EventHandler(list_click);
            panel_main_inner.Controls.Add(songlistobj);
            songs_list.Items.Clear();
            for (int i = 0; i < paths.Count; i++)
            {
                var tfile = TagLib.File.Create(paths[i]);

                if (tfile.Tag.Title != null)
                    name = tfile.Tag.Title;
                else
                    name = "Unknown";

                if (tfile.Tag.FirstAlbumArtist != null)
                    artist = tfile.Tag.FirstAlbumArtist;
                else
                    artist = "Unknown";

                if (name.Length > 40)
                    name = name.Substring(0, 40);

                if (name.Length == 40)
                    name += "...";

                while (name.Length < 45)
                    name += " ";

                songs_list.Items.Add(name + "" + artist);

            }
            if (songs_list.Items.Count > 0)
            {
                songs_list.SelectedIndex = songNumber;
            }
            
        }

        /// <summary>
        /// Loads the favorites song list and shows it
        /// </summary>
        private void loadListFavorite()
        {
            hide_all();
            String name;
            String artist;
            songs_list_fav = songlistobjFav.list;
            songlistobjFav.mouse_click += new EventHandler(list_click_fav);
            panel_main_inner.Controls.Add(songlistobjFav);
            songs_list_fav.Items.Clear();
            for (int i = 0; i < favoritePaths.Count; i++)
            {
                var tfile = TagLib.File.Create(favoritePaths[i]);

                if (tfile.Tag.Title != null)
                    name = tfile.Tag.Title;
                else
                    name = "Unknown";

                if (tfile.Tag.FirstAlbumArtist != null)
                    artist = tfile.Tag.FirstAlbumArtist;
                else
                    artist = "Unknown";

                if (name.Length > 40)
                    name = name.Substring(0, 40);

                if (name.Length == 40)
                    name += "...";

                while (name.Length < 45)
                    name += " ";

                songs_list_fav.Items.Add(name + "" + artist);
            }
            if (songs_list_fav.Items.Count > 0)
            {
                songs_list_fav.SelectedIndex = songNumberFav;
            }
        }

        /// <summary>
        /// Loads the browse song list and shows it
        /// </summary>
        private void loadListBrowse()
        {
            hide_all();
            String name;
            String artist;
            panel_main_inner.Controls.Add(browse);
            song_list_browse.Items.Clear();

            for (int i = 0; i < browsePaths.Count; i++)
            {
                var tfile = TagLib.File.Create(browsePaths[i]);

                if (tfile.Tag.Title != null)
                    name = tfile.Tag.Title;
                else
                    name = "Unknown";

                if (tfile.Tag.FirstAlbumArtist != null)
                    artist = tfile.Tag.FirstAlbumArtist;
                else
                    artist = "Unknown";

                if (name.Length > 40)
                    name = name.Substring(0, 40);

                if (name.Length == 40)
                    name += "...";

                while (name.Length < 45)
                    name += " ";

                song_list_browse.Items.Add(name + "" + artist);
            }
        }

        /// <summary>
        /// When the user wants to search abstract song, this reads the criteria and filters the list
        /// </summary>
        private void searchButton(Object sender, EventArgs args)
        {
            String search = browse.Criteria.ToLower();
            String name;
            String artist;
            //List<string> browseList = paths;
            Console.WriteLine(search);
            song_list_browse.Items.Clear();

            for (int i = 0; i < browsePaths.Count; i++)
            {
                if (!search.Equals(""))
                {
                    if (browsePaths[i].ToLower().Contains(search))
                    {
                        var tfile = TagLib.File.Create(browsePaths[i]);

                        if (tfile.Tag.Title != null)
                            name = tfile.Tag.Title;
                        else
                            name = "Unknown";

                        if (tfile.Tag.FirstAlbumArtist != null)
                            artist = tfile.Tag.FirstAlbumArtist;
                        else
                            artist = "Unknown";

                        if (name.Length > 40)
                            name = name.Substring(0, 40);

                        if (name.Length == 40)
                            name += "...";

                        while (name.Length < 45)
                            name += " ";

                        song_list_browse.Items.Add(name + "" + artist);
                    }
                    else
                    {
                        browsePaths.RemoveAt(i);
                    }
                }
                else
                {
                    browsePaths = new List<String>(paths);
                    loadListBrowse();
                }
            }
        }

        /// <summary>
        /// Checks if a song is in favourites list
        /// </summary>
        private void favourited(string path)
        {
            bool encontrada = false;

            for(int i = 0; i < favoritePaths.Count; i++)
            {
                if (favoritePaths[i].Equals(path))
                {
                    encontrada = true;
                }
            }
            
            if (encontrada)
            {
                btn_add_favorite_song_bar.Image = ThunderMusicPlayer.Properties.Resources.baseline_favorite_white_48dp;
            }
            else
            {
                btn_add_favorite_song_bar.Image = ThunderMusicPlayer.Properties.Resources.baseline_favorite_border_white_48dp;
            }
        }
    }
}