namespace ThunderMusicPlayer
{
    partial class Browse
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lv_songs = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.action_search = new Bunifu.Framework.UI.BunifuImageButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.action_search)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lv_songs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.45713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.54288F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 513);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Enter += new System.EventHandler(this.search_criteria_click);
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
            this.lv_songs.Location = new System.Drawing.Point(0, 74);
            this.lv_songs.Margin = new System.Windows.Forms.Padding(0);
            this.lv_songs.Name = "lv_songs";
            this.lv_songs.Size = new System.Drawing.Size(830, 439);
            this.lv_songs.TabIndex = 2;
            this.lv_songs.Click += new System.EventHandler(this.song_list_click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.action_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 68);
            this.panel1.TabIndex = 1;
            // 
            // tb_search
            // 
            this.tb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_search.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_search.ForeColor = System.Drawing.Color.Gray;
            this.tb_search.HintForeColor = System.Drawing.Color.Empty;
            this.tb_search.HintText = "";
            this.tb_search.isPassword = false;
            this.tb_search.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_search.LineIdleColor = System.Drawing.Color.Silver;
            this.tb_search.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_search.LineThickness = 2;
            this.tb_search.Location = new System.Drawing.Point(268, 5);
            this.tb_search.Margin = new System.Windows.Forms.Padding(20, 4, 10, 4);
            this.tb_search.MaxLength = 32767;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(210, 36);
            this.tb_search.TabIndex = 7;
            this.tb_search.Text = "Search";
            this.tb_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_search.OnValueChanged += new System.EventHandler(this.key_typed);
            // 
            // action_search
            // 
            this.action_search.Image = global::ThunderMusicPlayer.Properties.Resources.outline_search_white_48dp;
            this.action_search.ImageActive = null;
            this.action_search.Location = new System.Drawing.Point(485, 7);
            this.action_search.Margin = new System.Windows.Forms.Padding(2);
            this.action_search.Name = "action_search";
            this.action_search.Size = new System.Drawing.Size(27, 36);
            this.action_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.action_search.TabIndex = 8;
            this.action_search.TabStop = false;
            this.action_search.Zoom = 10;
            this.action_search.Click += new System.EventHandler(this.action_search_click);
            // 
            // Browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Browse";
            this.Size = new System.Drawing.Size(830, 513);
            this.Load += new System.EventHandler(this.Browse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.action_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_search;
        private Bunifu.Framework.UI.BunifuImageButton action_search;
        private System.Windows.Forms.ListBox lv_songs;
    }
}
