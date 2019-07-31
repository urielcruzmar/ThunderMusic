namespace ThunderMusicPlayer
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_left = new System.Windows.Forms.Panel();
            this.lb_total_time = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_current_time = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.slider_volume = new Bunifu.Framework.UI.BunifuSlider();
            this.slider_song = new Bunifu.Framework.UI.BunifuSlider();
            this.lb_bottom_bar_song_artist = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_bottom_bar_song_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drag_control_left_bar = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_top_main_control = new System.Windows.Forms.Panel();
            this.btn_info = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_thunder_music = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picture_box_logo = new System.Windows.Forms.PictureBox();
            this.btn_user = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_min_win = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close_win = new Bunifu.Framework.UI.BunifuImageButton();
            this.drag_control_left_pane = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.drag_control_main = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_left_inner = new System.Windows.Forms.Panel();
            this.media_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_upload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_favourites = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_playlists = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_browse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_left_inner_top = new System.Windows.Forms.Panel();
            this.btn_hide_show_left_bar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_main_table = new System.Windows.Forms.TableLayoutPanel();
            this.panel_main_inner = new System.Windows.Forms.Panel();
            this.panel_current_menu = new System.Windows.Forms.Panel();
            this.lb_current_tab = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drag_control_tittle = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bottom_mid = new System.Windows.Forms.Panel();
            this.btn_play_stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_repeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_previous_song = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_next_song = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_shuffle = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_bottom_left_img = new System.Windows.Forms.Panel();
            this.btn_add_favorite_song_bar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pb_song_image = new System.Windows.Forms.PictureBox();
            this.panel_bottom_right = new System.Windows.Forms.Panel();
            this.btn_volume_mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_library = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel_top_main_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min_win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_win)).BeginInit();
            this.panel_left_inner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.media_player)).BeginInit();
            this.panel_left_inner_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide_show_left_bar)).BeginInit();
            this.panel_main_table.SuspendLayout();
            this.panel_current_menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_bottom_mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_repeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous_song)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_song)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shuffle)).BeginInit();
            this.panel_bottom_left_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_favorite_song_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_song_image)).BeginInit();
            this.panel_bottom_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_volume_mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_library)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 5;
            this.elipse.TargetControl = this;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(132)))), ((int)(((byte)(192)))));
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Margin = new System.Windows.Forms.Padding(2);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(10, 731);
            this.panel_left.TabIndex = 0;
            // 
            // lb_total_time
            // 
            this.lb_total_time.AutoSize = true;
            this.lb_total_time.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_total_time.Location = new System.Drawing.Point(547, 52);
            this.lb_total_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total_time.Name = "lb_total_time";
            this.lb_total_time.Size = new System.Drawing.Size(39, 17);
            this.lb_total_time.TabIndex = 16;
            this.lb_total_time.Text = "00:00";
            // 
            // lb_current_time
            // 
            this.lb_current_time.AutoSize = true;
            this.lb_current_time.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_current_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_current_time.Location = new System.Drawing.Point(6, 52);
            this.lb_current_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_current_time.Name = "lb_current_time";
            this.lb_current_time.Size = new System.Drawing.Size(39, 17);
            this.lb_current_time.TabIndex = 15;
            this.lb_current_time.Text = "00:00";
            // 
            // slider_volume
            // 
            this.slider_volume.BackColor = System.Drawing.Color.Transparent;
            this.slider_volume.BackgroudColor = System.Drawing.Color.DarkGray;
            this.slider_volume.BorderRadius = 10;
            this.slider_volume.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.slider_volume.Location = new System.Drawing.Point(135, 29);
            this.slider_volume.MaximumValue = 100;
            this.slider_volume.Name = "slider_volume";
            this.slider_volume.Size = new System.Drawing.Size(123, 30);
            this.slider_volume.TabIndex = 11;
            this.slider_volume.Value = 50;
            this.slider_volume.ValueChanged += new System.EventHandler(this.volume_changed);
            // 
            // slider_song
            // 
            this.slider_song.BackColor = System.Drawing.Color.Transparent;
            this.slider_song.BackgroudColor = System.Drawing.Color.DarkGray;
            this.slider_song.BorderRadius = 10;
            this.slider_song.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.slider_song.Location = new System.Drawing.Point(50, 50);
            this.slider_song.MaximumValue = 100;
            this.slider_song.Name = "slider_song";
            this.slider_song.Size = new System.Drawing.Size(492, 30);
            this.slider_song.TabIndex = 6;
            this.slider_song.Value = 0;
            this.slider_song.ValueChanged += new System.EventHandler(this.time_changed_bar);
            // 
            // lb_bottom_bar_song_artist
            // 
            this.lb_bottom_bar_song_artist.AutoSize = true;
            this.lb_bottom_bar_song_artist.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bottom_bar_song_artist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_bottom_bar_song_artist.Location = new System.Drawing.Point(95, 47);
            this.lb_bottom_bar_song_artist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_bottom_bar_song_artist.Name = "lb_bottom_bar_song_artist";
            this.lb_bottom_bar_song_artist.Size = new System.Drawing.Size(0, 17);
            this.lb_bottom_bar_song_artist.TabIndex = 5;
            // 
            // lb_bottom_bar_song_title
            // 
            this.lb_bottom_bar_song_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bottom_bar_song_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_bottom_bar_song_title.Location = new System.Drawing.Point(95, 18);
            this.lb_bottom_bar_song_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_bottom_bar_song_title.Name = "lb_bottom_bar_song_title";
            this.lb_bottom_bar_song_title.Size = new System.Drawing.Size(130, 21);
            this.lb_bottom_bar_song_title.TabIndex = 4;
            // 
            // drag_control_left_bar
            // 
            this.drag_control_left_bar.Fixed = true;
            this.drag_control_left_bar.Horizontal = true;
            this.drag_control_left_bar.TargetControl = null;
            this.drag_control_left_bar.Vertical = true;
            // 
            // panel_top_main_control
            // 
            this.panel_top_main_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.panel_top_main_control.Controls.Add(this.btn_info);
            this.panel_top_main_control.Controls.Add(this.lb_thunder_music);
            this.panel_top_main_control.Controls.Add(this.picture_box_logo);
            this.panel_top_main_control.Controls.Add(this.btn_user);
            this.panel_top_main_control.Controls.Add(this.btn_min_win);
            this.panel_top_main_control.Controls.Add(this.btn_close_win);
            this.panel_top_main_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_main_control.Location = new System.Drawing.Point(10, 0);
            this.panel_top_main_control.Margin = new System.Windows.Forms.Padding(2);
            this.panel_top_main_control.Name = "panel_top_main_control";
            this.panel_top_main_control.Size = new System.Drawing.Size(1190, 43);
            this.panel_top_main_control.TabIndex = 3;
            // 
            // btn_info
            // 
            this.btn_info.Image = global::ThunderMusicPlayer.Properties.Resources.baseline_info_white_48dp;
            this.btn_info.ImageActive = null;
            this.btn_info.Location = new System.Drawing.Point(78, 8);
            this.btn_info.Margin = new System.Windows.Forms.Padding(2);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(26, 29);
            this.btn_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_info.TabIndex = 3;
            this.btn_info.TabStop = false;
            this.btn_info.Zoom = 10;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // lb_thunder_music
            // 
            this.lb_thunder_music.AutoSize = true;
            this.lb_thunder_music.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thunder_music.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_thunder_music.Location = new System.Drawing.Point(538, 7);
            this.lb_thunder_music.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thunder_music.Name = "lb_thunder_music";
            this.lb_thunder_music.Size = new System.Drawing.Size(150, 30);
            this.lb_thunder_music.TabIndex = 0;
            this.lb_thunder_music.Text = "Thunder Music";
            // 
            // picture_box_logo
            // 
            this.picture_box_logo.Image = global::ThunderMusicPlayer.Properties.Resources.thunder_music;
            this.picture_box_logo.Location = new System.Drawing.Point(5, 6);
            this.picture_box_logo.Margin = new System.Windows.Forms.Padding(2);
            this.picture_box_logo.Name = "picture_box_logo";
            this.picture_box_logo.Size = new System.Drawing.Size(39, 32);
            this.picture_box_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_logo.TabIndex = 0;
            this.picture_box_logo.TabStop = false;
            // 
            // btn_user
            // 
            this.btn_user.Image = global::ThunderMusicPlayer.Properties.Resources.baseline_person_white_48dp;
            this.btn_user.ImageActive = null;
            this.btn_user.Location = new System.Drawing.Point(48, 8);
            this.btn_user.Margin = new System.Windows.Forms.Padding(2);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(26, 29);
            this.btn_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_user.TabIndex = 2;
            this.btn_user.TabStop = false;
            this.btn_user.Zoom = 10;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_min_win
            // 
            this.btn_min_win.Image = global::ThunderMusicPlayer.Properties.Resources.outline_minimize_white_48dp;
            this.btn_min_win.ImageActive = null;
            this.btn_min_win.Location = new System.Drawing.Point(1108, 5);
            this.btn_min_win.Margin = new System.Windows.Forms.Padding(2);
            this.btn_min_win.Name = "btn_min_win";
            this.btn_min_win.Size = new System.Drawing.Size(34, 31);
            this.btn_min_win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_min_win.TabIndex = 1;
            this.btn_min_win.TabStop = false;
            this.btn_min_win.Zoom = 10;
            this.btn_min_win.Click += new System.EventHandler(this.btn_min_win_Click);
            // 
            // btn_close_win
            // 
            this.btn_close_win.Image = global::ThunderMusicPlayer.Properties.Resources.outline_close_white_48dp;
            this.btn_close_win.ImageActive = null;
            this.btn_close_win.Location = new System.Drawing.Point(1146, 6);
            this.btn_close_win.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close_win.Name = "btn_close_win";
            this.btn_close_win.Size = new System.Drawing.Size(33, 31);
            this.btn_close_win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close_win.TabIndex = 0;
            this.btn_close_win.TabStop = false;
            this.btn_close_win.Zoom = 10;
            this.btn_close_win.Click += new System.EventHandler(this.btn_close_win_Click);
            // 
            // drag_control_left_pane
            // 
            this.drag_control_left_pane.Fixed = true;
            this.drag_control_left_pane.Horizontal = true;
            this.drag_control_left_pane.TargetControl = null;
            this.drag_control_left_pane.Vertical = true;
            // 
            // drag_control_main
            // 
            this.drag_control_main.Fixed = true;
            this.drag_control_main.Horizontal = true;
            this.drag_control_main.TargetControl = this.panel_top_main_control;
            this.drag_control_main.Vertical = true;
            // 
            // panel_left_inner
            // 
            this.panel_left_inner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel_left_inner.Controls.Add(this.media_player);
            this.panel_left_inner.Controls.Add(this.btn_upload);
            this.panel_left_inner.Controls.Add(this.btn_favourites);
            this.panel_left_inner.Controls.Add(this.btn_playlists);
            this.panel_left_inner.Controls.Add(this.btn_browse);
            this.panel_left_inner.Controls.Add(this.btn_home);
            this.panel_left_inner.Controls.Add(this.panel_left_inner_top);
            this.panel_left_inner.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left_inner.Location = new System.Drawing.Point(10, 43);
            this.panel_left_inner.Margin = new System.Windows.Forms.Padding(2);
            this.panel_left_inner.Name = "panel_left_inner";
            this.panel_left_inner.Size = new System.Drawing.Size(294, 599);
            this.panel_left_inner.TabIndex = 2;
            // 
            // media_player
            // 
            this.media_player.Enabled = true;
            this.media_player.Location = new System.Drawing.Point(5, 545);
            this.media_player.Name = "media_player";
            this.media_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media_player.OcxState")));
            this.media_player.Size = new System.Drawing.Size(283, 48);
            this.media_player.TabIndex = 6;
            this.media_player.Visible = false;
            this.media_player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.play_state_changed);
            this.media_player.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.time_changed);
            // 
            // btn_upload
            // 
            this.btn_upload.Active = false;
            this.btn_upload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_upload.BorderRadius = 0;
            this.btn_upload.ButtonText = " Upload";
            this.btn_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_upload.DisabledColor = System.Drawing.Color.Gray;
            this.btn_upload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_upload.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_upload.Iconimage = global::ThunderMusicPlayer.Properties.Resources.baseline_unarchive_white_48dp;
            this.btn_upload.Iconimage_right = null;
            this.btn_upload.Iconimage_right_Selected = null;
            this.btn_upload.Iconimage_Selected = null;
            this.btn_upload.IconMarginLeft = 20;
            this.btn_upload.IconMarginRight = 0;
            this.btn_upload.IconRightVisible = true;
            this.btn_upload.IconRightZoom = 0D;
            this.btn_upload.IconVisible = true;
            this.btn_upload.IconZoom = 90D;
            this.btn_upload.IsTab = true;
            this.btn_upload.Location = new System.Drawing.Point(0, 319);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_upload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_upload.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_upload.selected = false;
            this.btn_upload.Size = new System.Drawing.Size(294, 56);
            this.btn_upload.TabIndex = 5;
            this.btn_upload.Text = " Upload";
            this.btn_upload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_upload.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_upload.TextFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_favourites
            // 
            this.btn_favourites.Active = false;
            this.btn_favourites.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_favourites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_favourites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_favourites.BorderRadius = 0;
            this.btn_favourites.ButtonText = " Favorites";
            this.btn_favourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_favourites.DisabledColor = System.Drawing.Color.Gray;
            this.btn_favourites.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_favourites.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_favourites.Iconimage = global::ThunderMusicPlayer.Properties.Resources.baseline_favorite_white_48dp;
            this.btn_favourites.Iconimage_right = null;
            this.btn_favourites.Iconimage_right_Selected = null;
            this.btn_favourites.Iconimage_Selected = null;
            this.btn_favourites.IconMarginLeft = 20;
            this.btn_favourites.IconMarginRight = 0;
            this.btn_favourites.IconRightVisible = true;
            this.btn_favourites.IconRightZoom = 0D;
            this.btn_favourites.IconVisible = true;
            this.btn_favourites.IconZoom = 90D;
            this.btn_favourites.IsTab = true;
            this.btn_favourites.Location = new System.Drawing.Point(0, 263);
            this.btn_favourites.Name = "btn_favourites";
            this.btn_favourites.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_favourites.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_favourites.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_favourites.selected = false;
            this.btn_favourites.Size = new System.Drawing.Size(294, 56);
            this.btn_favourites.TabIndex = 4;
            this.btn_favourites.Text = " Favorites";
            this.btn_favourites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_favourites.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_favourites.TextFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_favourites.Click += new System.EventHandler(this.btn_favourites_Click);
            // 
            // btn_playlists
            // 
            this.btn_playlists.Active = false;
            this.btn_playlists.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_playlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_playlists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_playlists.BorderRadius = 0;
            this.btn_playlists.ButtonText = " Playing";
            this.btn_playlists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_playlists.DisabledColor = System.Drawing.Color.Gray;
            this.btn_playlists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_playlists.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_playlists.Iconimage = global::ThunderMusicPlayer.Properties.Resources.baseline_queue_music_white_48dp;
            this.btn_playlists.Iconimage_right = null;
            this.btn_playlists.Iconimage_right_Selected = null;
            this.btn_playlists.Iconimage_Selected = null;
            this.btn_playlists.IconMarginLeft = 20;
            this.btn_playlists.IconMarginRight = 0;
            this.btn_playlists.IconRightVisible = true;
            this.btn_playlists.IconRightZoom = 0D;
            this.btn_playlists.IconVisible = true;
            this.btn_playlists.IconZoom = 90D;
            this.btn_playlists.IsTab = true;
            this.btn_playlists.Location = new System.Drawing.Point(0, 207);
            this.btn_playlists.Name = "btn_playlists";
            this.btn_playlists.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_playlists.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_playlists.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_playlists.selected = false;
            this.btn_playlists.Size = new System.Drawing.Size(294, 56);
            this.btn_playlists.TabIndex = 3;
            this.btn_playlists.Text = " Playing";
            this.btn_playlists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_playlists.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_playlists.TextFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playlists.Click += new System.EventHandler(this.btn_playlists_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Active = false;
            this.btn_browse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_browse.BorderRadius = 0;
            this.btn_browse.ButtonText = " Browse";
            this.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browse.DisabledColor = System.Drawing.Color.Gray;
            this.btn_browse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_browse.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_browse.Iconimage = global::ThunderMusicPlayer.Properties.Resources.baseline_explore_white_48dp;
            this.btn_browse.Iconimage_right = null;
            this.btn_browse.Iconimage_right_Selected = null;
            this.btn_browse.Iconimage_Selected = null;
            this.btn_browse.IconMarginLeft = 20;
            this.btn_browse.IconMarginRight = 0;
            this.btn_browse.IconRightVisible = true;
            this.btn_browse.IconRightZoom = 0D;
            this.btn_browse.IconVisible = true;
            this.btn_browse.IconZoom = 90D;
            this.btn_browse.IsTab = true;
            this.btn_browse.Location = new System.Drawing.Point(0, 151);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_browse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_browse.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_browse.selected = false;
            this.btn_browse.Size = new System.Drawing.Size(294, 56);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = " Browse";
            this.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_browse.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_browse.TextFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_home
            // 
            this.btn_home.Active = true;
            this.btn_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.BorderRadius = 0;
            this.btn_home.ButtonText = " Home";
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_home.Iconimage = global::ThunderMusicPlayer.Properties.Resources.baseline_home_white_48dp;
            this.btn_home.Iconimage_right = null;
            this.btn_home.Iconimage_right_Selected = null;
            this.btn_home.Iconimage_Selected = null;
            this.btn_home.IconMarginLeft = 20;
            this.btn_home.IconMarginRight = 0;
            this.btn_home.IconRightVisible = true;
            this.btn_home.IconRightZoom = 0D;
            this.btn_home.IconVisible = true;
            this.btn_home.IconZoom = 90D;
            this.btn_home.IsTab = true;
            this.btn_home.Location = new System.Drawing.Point(0, 95);
            this.btn_home.Name = "btn_home";
            this.btn_home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_home.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_home.selected = true;
            this.btn_home.Size = new System.Drawing.Size(294, 56);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = " Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_home.TextFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_left_inner_top
            // 
            this.panel_left_inner_top.Controls.Add(this.btn_hide_show_left_bar);
            this.panel_left_inner_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_left_inner_top.Location = new System.Drawing.Point(0, 0);
            this.panel_left_inner_top.Margin = new System.Windows.Forms.Padding(2);
            this.panel_left_inner_top.Name = "panel_left_inner_top";
            this.panel_left_inner_top.Size = new System.Drawing.Size(294, 95);
            this.panel_left_inner_top.TabIndex = 1;
            // 
            // btn_hide_show_left_bar
            // 
            this.btn_hide_show_left_bar.Image = global::ThunderMusicPlayer.Properties.Resources.baseline_chevron_left_white_48dp;
            this.btn_hide_show_left_bar.ImageActive = null;
            this.btn_hide_show_left_bar.Location = new System.Drawing.Point(15, 28);
            this.btn_hide_show_left_bar.Name = "btn_hide_show_left_bar";
            this.btn_hide_show_left_bar.Size = new System.Drawing.Size(52, 46);
            this.btn_hide_show_left_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_hide_show_left_bar.TabIndex = 7;
            this.btn_hide_show_left_bar.TabStop = false;
            this.btn_hide_show_left_bar.Zoom = 10;
            this.btn_hide_show_left_bar.Click += new System.EventHandler(this.btn_hide_show_left_bar_Click);
            // 
            // panel_main_table
            // 
            this.panel_main_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel_main_table.ColumnCount = 3;
            this.panel_main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_main_table.Controls.Add(this.panel_main_inner, 1, 2);
            this.panel_main_table.Controls.Add(this.panel_current_menu, 1, 1);
            this.panel_main_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main_table.Location = new System.Drawing.Point(304, 43);
            this.panel_main_table.Name = "panel_main_table";
            this.panel_main_table.RowCount = 3;
            this.panel_main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel_main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main_table.Size = new System.Drawing.Size(896, 599);
            this.panel_main_table.TabIndex = 4;
            // 
            // panel_main_inner
            // 
            this.panel_main_inner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main_inner.AutoScroll = true;
            this.panel_main_inner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel_main_inner.Location = new System.Drawing.Point(33, 83);
            this.panel_main_inner.Name = "panel_main_inner";
            this.panel_main_inner.Size = new System.Drawing.Size(830, 513);
            this.panel_main_inner.TabIndex = 4;
            // 
            // panel_current_menu
            // 
            this.panel_current_menu.Controls.Add(this.lb_current_tab);
            this.panel_current_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_current_menu.Location = new System.Drawing.Point(33, 33);
            this.panel_current_menu.Name = "panel_current_menu";
            this.panel_current_menu.Size = new System.Drawing.Size(830, 44);
            this.panel_current_menu.TabIndex = 5;
            // 
            // lb_current_tab
            // 
            this.lb_current_tab.AutoSize = true;
            this.lb_current_tab.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_current_tab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_current_tab.Location = new System.Drawing.Point(2, 4);
            this.lb_current_tab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_current_tab.Name = "lb_current_tab";
            this.lb_current_tab.Size = new System.Drawing.Size(0, 37);
            this.lb_current_tab.TabIndex = 2;
            // 
            // drag_control_tittle
            // 
            this.drag_control_tittle.Fixed = true;
            this.drag_control_tittle.Horizontal = true;
            this.drag_control_tittle.TargetControl = this.lb_thunder_music;
            this.drag_control_tittle.Vertical = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel_bottom_mid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_bottom_left_img, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_bottom_right, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 642);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1190, 89);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel_bottom_mid
            // 
            this.panel_bottom_mid.Controls.Add(this.btn_play_stop);
            this.panel_bottom_mid.Controls.Add(this.lb_total_time);
            this.panel_bottom_mid.Controls.Add(this.btn_repeat);
            this.panel_bottom_mid.Controls.Add(this.btn_previous_song);
            this.panel_bottom_mid.Controls.Add(this.lb_current_time);
            this.panel_bottom_mid.Controls.Add(this.btn_next_song);
            this.panel_bottom_mid.Controls.Add(this.slider_song);
            this.panel_bottom_mid.Controls.Add(this.btn_shuffle);
            this.panel_bottom_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom_mid.Location = new System.Drawing.Point(300, 3);
            this.panel_bottom_mid.Name = "panel_bottom_mid";
            this.panel_bottom_mid.Size = new System.Drawing.Size(589, 83);
            this.panel_bottom_mid.TabIndex = 1;
            // 
            // btn_play_stop
            // 
            this.btn_play_stop.Image = global::ThunderMusicPlayer.Properties.Resources.outline_play_circle_filled_white_white_48dp;
            this.btn_play_stop.ImageActive = null;
            this.btn_play_stop.Location = new System.Drawing.Point(279, 8);
            this.btn_play_stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_play_stop.Name = "btn_play_stop";
            this.btn_play_stop.Size = new System.Drawing.Size(35, 37);
            this.btn_play_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play_stop.TabIndex = 7;
            this.btn_play_stop.TabStop = false;
            this.btn_play_stop.Zoom = 10;
            this.btn_play_stop.Click += new System.EventHandler(this.btn_play_stop_Click);
            // 
            // btn_repeat
            // 
            this.btn_repeat.Image = global::ThunderMusicPlayer.Properties.Resources.outline_repeat_white_48dp;
            this.btn_repeat.ImageActive = null;
            this.btn_repeat.Location = new System.Drawing.Point(357, 11);
            this.btn_repeat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(27, 29);
            this.btn_repeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_repeat.TabIndex = 8;
            this.btn_repeat.TabStop = false;
            this.btn_repeat.Zoom = 10;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // btn_previous_song
            // 
            this.btn_previous_song.Image = global::ThunderMusicPlayer.Properties.Resources.outline_skip_previous_white_48dp;
            this.btn_previous_song.ImageActive = null;
            this.btn_previous_song.Location = new System.Drawing.Point(243, 11);
            this.btn_previous_song.Margin = new System.Windows.Forms.Padding(2);
            this.btn_previous_song.Name = "btn_previous_song";
            this.btn_previous_song.Size = new System.Drawing.Size(27, 29);
            this.btn_previous_song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_previous_song.TabIndex = 4;
            this.btn_previous_song.TabStop = false;
            this.btn_previous_song.Zoom = 10;
            this.btn_previous_song.Click += new System.EventHandler(this.btn_previous_song_Click);
            // 
            // btn_next_song
            // 
            this.btn_next_song.Image = global::ThunderMusicPlayer.Properties.Resources.outline_skip_next_white_48dp;
            this.btn_next_song.ImageActive = null;
            this.btn_next_song.Location = new System.Drawing.Point(322, 11);
            this.btn_next_song.Margin = new System.Windows.Forms.Padding(2);
            this.btn_next_song.Name = "btn_next_song";
            this.btn_next_song.Size = new System.Drawing.Size(27, 29);
            this.btn_next_song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next_song.TabIndex = 9;
            this.btn_next_song.TabStop = false;
            this.btn_next_song.Zoom = 10;
            this.btn_next_song.Click += new System.EventHandler(this.btn_next_song_Click);
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.Image = global::ThunderMusicPlayer.Properties.Resources.outline_shuffle_white_48dp;
            this.btn_shuffle.ImageActive = null;
            this.btn_shuffle.Location = new System.Drawing.Point(208, 11);
            this.btn_shuffle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(27, 29);
            this.btn_shuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_shuffle.TabIndex = 10;
            this.btn_shuffle.TabStop = false;
            this.btn_shuffle.Zoom = 10;
            this.btn_shuffle.Click += new System.EventHandler(this.btn_shuffle_Click);
            // 
            // panel_bottom_left_img
            // 
            this.panel_bottom_left_img.Controls.Add(this.btn_add_favorite_song_bar);
            this.panel_bottom_left_img.Controls.Add(this.pb_song_image);
            this.panel_bottom_left_img.Controls.Add(this.lb_bottom_bar_song_title);
            this.panel_bottom_left_img.Controls.Add(this.lb_bottom_bar_song_artist);
            this.panel_bottom_left_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom_left_img.Location = new System.Drawing.Point(3, 3);
            this.panel_bottom_left_img.Name = "panel_bottom_left_img";
            this.panel_bottom_left_img.Size = new System.Drawing.Size(291, 83);
            this.panel_bottom_left_img.TabIndex = 0;
            // 
            // btn_add_favorite_song_bar
            // 
            this.btn_add_favorite_song_bar.Image = global::ThunderMusicPlayer.Properties.Resources.baseline_favorite_border_white_48dp;
            this.btn_add_favorite_song_bar.ImageActive = null;
            this.btn_add_favorite_song_bar.Location = new System.Drawing.Point(236, 16);
            this.btn_add_favorite_song_bar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_favorite_song_bar.Name = "btn_add_favorite_song_bar";
            this.btn_add_favorite_song_bar.Size = new System.Drawing.Size(27, 26);
            this.btn_add_favorite_song_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_add_favorite_song_bar.TabIndex = 14;
            this.btn_add_favorite_song_bar.TabStop = false;
            this.btn_add_favorite_song_bar.Zoom = 10;
            this.btn_add_favorite_song_bar.Click += new System.EventHandler(this.btn_add_favorite_song_bar_Click);
            // 
            // pb_song_image
            // 
            this.pb_song_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_song_image.Image = global::ThunderMusicPlayer.Properties.Resources.pika_meme;
            this.pb_song_image.Location = new System.Drawing.Point(0, 0);
            this.pb_song_image.Margin = new System.Windows.Forms.Padding(0);
            this.pb_song_image.Name = "pb_song_image";
            this.pb_song_image.Size = new System.Drawing.Size(83, 83);
            this.pb_song_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_song_image.TabIndex = 0;
            this.pb_song_image.TabStop = false;
            // 
            // panel_bottom_right
            // 
            this.panel_bottom_right.Controls.Add(this.btn_volume_mute);
            this.panel_bottom_right.Controls.Add(this.slider_volume);
            this.panel_bottom_right.Controls.Add(this.btn_library);
            this.panel_bottom_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom_right.Location = new System.Drawing.Point(895, 3);
            this.panel_bottom_right.Name = "panel_bottom_right";
            this.panel_bottom_right.Size = new System.Drawing.Size(292, 83);
            this.panel_bottom_right.TabIndex = 2;
            // 
            // btn_volume_mute
            // 
            this.btn_volume_mute.Image = global::ThunderMusicPlayer.Properties.Resources.outline_volume_down_white_48dp;
            this.btn_volume_mute.ImageActive = null;
            this.btn_volume_mute.Location = new System.Drawing.Point(103, 28);
            this.btn_volume_mute.Margin = new System.Windows.Forms.Padding(2);
            this.btn_volume_mute.Name = "btn_volume_mute";
            this.btn_volume_mute.Size = new System.Drawing.Size(27, 29);
            this.btn_volume_mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_volume_mute.TabIndex = 12;
            this.btn_volume_mute.TabStop = false;
            this.btn_volume_mute.Zoom = 10;
            this.btn_volume_mute.Click += new System.EventHandler(this.btn_volume_mute_Click);
            // 
            // btn_library
            // 
            this.btn_library.Image = global::ThunderMusicPlayer.Properties.Resources.outline_playlist_play_white_48dp;
            this.btn_library.ImageActive = null;
            this.btn_library.Location = new System.Drawing.Point(66, 28);
            this.btn_library.Margin = new System.Windows.Forms.Padding(2);
            this.btn_library.Name = "btn_library";
            this.btn_library.Size = new System.Drawing.Size(27, 29);
            this.btn_library.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_library.TabIndex = 13;
            this.btn_library.TabStop = false;
            this.btn_library.Zoom = 10;
            this.btn_library.Click += new System.EventHandler(this.btn_library_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1200, 731);
            this.Controls.Add(this.panel_main_table);
            this.Controls.Add(this.panel_left_inner);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel_top_main_control);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_top_main_control.ResumeLayout(false);
            this.panel_top_main_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min_win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_win)).EndInit();
            this.panel_left_inner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.media_player)).EndInit();
            this.panel_left_inner_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide_show_left_bar)).EndInit();
            this.panel_main_table.ResumeLayout(false);
            this.panel_current_menu.ResumeLayout(false);
            this.panel_current_menu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_bottom_mid.ResumeLayout(false);
            this.panel_bottom_mid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_repeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous_song)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_song)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shuffle)).EndInit();
            this.panel_bottom_left_img.ResumeLayout(false);
            this.panel_bottom_left_img.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_favorite_song_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_song_image)).EndInit();
            this.panel_bottom_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_volume_mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_library)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse;
        private System.Windows.Forms.Panel panel_left_inner;
        private Bunifu.Framework.UI.BunifuFlatButton btn_upload;
        private Bunifu.Framework.UI.BunifuFlatButton btn_favourites;
        private Bunifu.Framework.UI.BunifuFlatButton btn_playlists;
        private Bunifu.Framework.UI.BunifuFlatButton btn_browse;
        private Bunifu.Framework.UI.BunifuFlatButton btn_home;
        private System.Windows.Forms.Panel panel_left_inner_top;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.PictureBox picture_box_logo;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_thunder_music;
        private Bunifu.Framework.UI.BunifuImageButton btn_user;
        private Bunifu.Framework.UI.BunifuDragControl drag_control_left_bar;
        private System.Windows.Forms.Panel panel_top_main_control;
        private Bunifu.Framework.UI.BunifuImageButton btn_min_win;
        private Bunifu.Framework.UI.BunifuImageButton btn_close_win;
        private Bunifu.Framework.UI.BunifuDragControl drag_control_left_pane;
        private Bunifu.Framework.UI.BunifuDragControl drag_control_main;
        private System.Windows.Forms.PictureBox pb_song_image;
        private Bunifu.Framework.UI.BunifuImageButton btn_library;
        private Bunifu.Framework.UI.BunifuImageButton btn_volume_mute;
        private Bunifu.Framework.UI.BunifuSlider slider_volume;
        private Bunifu.Framework.UI.BunifuImageButton btn_shuffle;
        private Bunifu.Framework.UI.BunifuImageButton btn_next_song;
        private Bunifu.Framework.UI.BunifuImageButton btn_repeat;
        private Bunifu.Framework.UI.BunifuImageButton btn_play_stop;
        private Bunifu.Framework.UI.BunifuImageButton btn_previous_song;
        private Bunifu.Framework.UI.BunifuSlider slider_song;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_bottom_bar_song_artist;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_bottom_bar_song_title;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_total_time;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_current_time;
        private Bunifu.Framework.UI.BunifuImageButton btn_add_favorite_song_bar;
        private Bunifu.Framework.UI.BunifuImageButton btn_info;
        private System.Windows.Forms.TableLayoutPanel panel_main_table;
        private System.Windows.Forms.Panel panel_current_menu;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_current_tab;
        private Bunifu.Framework.UI.BunifuDragControl drag_control_tittle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_bottom_left_img;
        private System.Windows.Forms.Panel panel_bottom_mid;
        private System.Windows.Forms.Panel panel_bottom_right;
        private System.Windows.Forms.Panel panel_main_inner;
        private Bunifu.Framework.UI.BunifuImageButton btn_hide_show_left_bar;
        private AxWMPLib.AxWindowsMediaPlayer media_player;
        private System.Windows.Forms.Timer timer;
    }
}

