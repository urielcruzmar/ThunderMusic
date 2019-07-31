namespace ThunderMusicPlayer
{
    partial class WelcomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_top = new System.Windows.Forms.Panel();
            this.lb_thunder_music = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_close_win = new Bunifu.Framework.UI.BunifuImageButton();
            this.transition_onload = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btn_register = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.table_panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.picture_box_logo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_win)).BeginInit();
            this.panel_main.SuspendLayout();
            this.table_panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_logo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.lb_thunder_music);
            this.panel_top.Controls.Add(this.btn_close_win);
            this.transition_onload.SetDecoration(this.panel_top, BunifuAnimatorNS.DecorationType.None);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(708, 50);
            this.panel_top.TabIndex = 3;
            // 
            // lb_thunder_music
            // 
            this.lb_thunder_music.AutoSize = true;
            this.transition_onload.SetDecoration(this.lb_thunder_music, BunifuAnimatorNS.DecorationType.None);
            this.lb_thunder_music.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thunder_music.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_thunder_music.Location = new System.Drawing.Point(283, 9);
            this.lb_thunder_music.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thunder_music.Name = "lb_thunder_music";
            this.lb_thunder_music.Size = new System.Drawing.Size(150, 30);
            this.lb_thunder_music.TabIndex = 7;
            this.lb_thunder_music.Text = "Thunder Music";
            // 
            // btn_close_win
            // 
            this.transition_onload.SetDecoration(this.btn_close_win, BunifuAnimatorNS.DecorationType.None);
            this.btn_close_win.Image = global::ThunderMusicPlayer.Properties.Resources.outline_close_white_48dp;
            this.btn_close_win.ImageActive = null;
            this.btn_close_win.Location = new System.Drawing.Point(664, 9);
            this.btn_close_win.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close_win.Name = "btn_close_win";
            this.btn_close_win.Size = new System.Drawing.Size(33, 31);
            this.btn_close_win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close_win.TabIndex = 1;
            this.btn_close_win.TabStop = false;
            this.btn_close_win.Zoom = 10;
            this.btn_close_win.Click += new System.EventHandler(this.btn_close_win_Click);
            // 
            // transition_onload
            // 
            this.transition_onload.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transition_onload.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition_onload.DefaultAnimation = animation1;
            this.transition_onload.MaxAnimationTime = 2000;
            // 
            // btn_register
            // 
            this.btn_register.Active = false;
            this.btn_register.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_register.BorderRadius = 0;
            this.btn_register.ButtonText = "Register";
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_onload.SetDecoration(this.btn_register, BunifuAnimatorNS.DecorationType.None);
            this.btn_register.DisabledColor = System.Drawing.Color.Gray;
            this.btn_register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_register.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_register.Iconimage = null;
            this.btn_register.Iconimage_right = null;
            this.btn_register.Iconimage_right_Selected = null;
            this.btn_register.Iconimage_Selected = null;
            this.btn_register.IconMarginLeft = 0;
            this.btn_register.IconMarginRight = 0;
            this.btn_register.IconRightVisible = true;
            this.btn_register.IconRightZoom = 0D;
            this.btn_register.IconVisible = true;
            this.btn_register.IconZoom = 90D;
            this.btn_register.IsTab = false;
            this.btn_register.Location = new System.Drawing.Point(381, 20);
            this.btn_register.Margin = new System.Windows.Forms.Padding(20);
            this.btn_register.Name = "btn_register";
            this.btn_register.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_register.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_register.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_register.selected = false;
            this.btn_register.Size = new System.Drawing.Size(261, 48);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_register.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_register.TextFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.Active = false;
            this.btn_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderRadius = 0;
            this.btn_login.ButtonText = "Log In";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_onload.SetDecoration(this.btn_login, BunifuAnimatorNS.DecorationType.None);
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = null;
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(60, 20);
            this.btn_login.Margin = new System.Windows.Forms.Padding(20);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(261, 48);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Log In";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_login.TextFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.table_panel_main);
            this.transition_onload.SetDecoration(this.panel_main, BunifuAnimatorNS.DecorationType.None);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 50);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(708, 412);
            this.panel_main.TabIndex = 9;
            // 
            // table_panel_main
            // 
            this.table_panel_main.ColumnCount = 1;
            this.table_panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_panel_main.Controls.Add(this.picture_box_logo, 0, 0);
            this.table_panel_main.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.transition_onload.SetDecoration(this.table_panel_main, BunifuAnimatorNS.DecorationType.None);
            this.table_panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_panel_main.Location = new System.Drawing.Point(0, 0);
            this.table_panel_main.Name = "table_panel_main";
            this.table_panel_main.RowCount = 2;
            this.table_panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.table_panel_main.Size = new System.Drawing.Size(708, 412);
            this.table_panel_main.TabIndex = 9;
            // 
            // picture_box_logo
            // 
            this.transition_onload.SetDecoration(this.picture_box_logo, BunifuAnimatorNS.DecorationType.None);
            this.picture_box_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_box_logo.Image = global::ThunderMusicPlayer.Properties.Resources.thunder_music;
            this.picture_box_logo.Location = new System.Drawing.Point(2, 2);
            this.picture_box_logo.Margin = new System.Windows.Forms.Padding(2);
            this.picture_box_logo.Name = "picture_box_logo";
            this.picture_box_logo.Size = new System.Drawing.Size(704, 290);
            this.picture_box_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_logo.TabIndex = 2;
            this.picture_box_logo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.btn_login, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_register, 3, 0);
            this.transition_onload.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 297);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(702, 112);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel_top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lb_thunder_music;
            this.bunifuDragControl2.Vertical = true;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(708, 462);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.transition_onload.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_win)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.table_panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_logo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btn_close_win;
        private System.Windows.Forms.PictureBox picture_box_logo;
        private System.Windows.Forms.Panel panel_top;
        private BunifuAnimatorNS.BunifuTransition transition_onload;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_thunder_music;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;
        private Bunifu.Framework.UI.BunifuFlatButton btn_register;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel table_panel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}