namespace ThunderMusicPlayer
{
    partial class Welcome
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
            this.table_panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.picture_box_logo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_register = new Bunifu.Framework.UI.BunifuFlatButton();
            this.table_panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_logo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_panel_main
            // 
            this.table_panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.table_panel_main.ColumnCount = 1;
            this.table_panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_panel_main.Controls.Add(this.picture_box_logo, 0, 0);
            this.table_panel_main.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.table_panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_panel_main.Location = new System.Drawing.Point(0, 0);
            this.table_panel_main.Name = "table_panel_main";
            this.table_panel_main.RowCount = 2;
            this.table_panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.table_panel_main.Size = new System.Drawing.Size(708, 412);
            this.table_panel_main.TabIndex = 10;
            // 
            // picture_box_logo
            // 
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 297);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(702, 112);
            this.tableLayoutPanel2.TabIndex = 3;
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
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_panel_main);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(708, 412);
            this.table_panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_logo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table_panel_main;
        private System.Windows.Forms.PictureBox picture_box_logo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;
        private Bunifu.Framework.UI.BunifuFlatButton btn_register;
    }
}
