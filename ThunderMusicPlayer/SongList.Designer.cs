namespace ThunderMusicPlayer
{
    partial class SongList
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_songs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lv_songs
            // 
            this.lv_songs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lv_songs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_songs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_songs.Font = new System.Drawing.Font("Noto Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_songs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lv_songs.FormattingEnabled = true;
            this.lv_songs.ItemHeight = 28;
            this.lv_songs.Location = new System.Drawing.Point(0, 0);
            this.lv_songs.Margin = new System.Windows.Forms.Padding(10);
            this.lv_songs.Name = "lv_songs";
            this.lv_songs.Size = new System.Drawing.Size(830, 513);
            this.lv_songs.TabIndex = 1;
            this.lv_songs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.song_list_click);
            // 
            // SongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.lv_songs);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SongList";
            this.Size = new System.Drawing.Size(830, 513);
            this.Load += new System.EventHandler(this.SongList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lv_songs;
    }
}
