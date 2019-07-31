namespace ThunderMusicPlayer
{
    partial class Profile
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
            this.profile_pic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_mail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_yes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.profile_pic, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_yes, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // profile_pic
            // 
            this.profile_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile_pic.Image = global::ThunderMusicPlayer.Properties.Resources.pika_meme;
            this.profile_pic.Location = new System.Drawing.Point(210, 53);
            this.profile_pic.Name = "profile_pic";
            this.profile_pic.Size = new System.Drawing.Size(409, 180);
            this.profile_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_pic.TabIndex = 0;
            this.profile_pic.TabStop = false;
            this.profile_pic.Click += new System.EventHandler(this.profile_pic_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(210, 239);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(409, 180);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_mail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 54);
            this.panel1.TabIndex = 0;
            // 
            // tb_mail
            // 
            this.tb_mail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_mail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_mail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_mail.Enabled = false;
            this.tb_mail.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tb_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tb_mail.HintForeColor = System.Drawing.Color.Empty;
            this.tb_mail.HintText = "";
            this.tb_mail.isPassword = false;
            this.tb_mail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tb_mail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tb_mail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tb_mail.LineThickness = 5;
            this.tb_mail.Location = new System.Drawing.Point(0, 2);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_mail.MaxLength = 32767;
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(403, 52);
            this.tb_mail.TabIndex = 0;
            this.tb_mail.Text = "E-Mail";
            this.tb_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 54);
            this.panel2.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_name.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tb_name.HintForeColor = System.Drawing.Color.White;
            this.tb_name.HintText = "";
            this.tb_name.isPassword = false;
            this.tb_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tb_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_name.LineThickness = 5;
            this.tb_name.Location = new System.Drawing.Point(0, 2);
            this.tb_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_name.MaxLength = 32767;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(403, 52);
            this.tb_name.TabIndex = 0;
            this.tb_name.Text = "Name";
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_pass);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 54);
            this.panel3.TabIndex = 2;
            // 
            // tb_pass
            // 
            this.tb_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_pass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tb_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tb_pass.HintForeColor = System.Drawing.Color.White;
            this.tb_pass.HintText = "Password";
            this.tb_pass.isPassword = true;
            this.tb_pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_pass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tb_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_pass.LineThickness = 5;
            this.tb_pass.Location = new System.Drawing.Point(0, 2);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_pass.MaxLength = 32767;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(403, 52);
            this.tb_pass.TabIndex = 0;
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_yes
            // 
            this.btn_yes.Active = false;
            this.btn_yes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yes.BorderRadius = 0;
            this.btn_yes.ButtonText = "UPDATE";
            this.btn_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_yes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_yes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_yes.Iconimage = null;
            this.btn_yes.Iconimage_right = null;
            this.btn_yes.Iconimage_right_Selected = null;
            this.btn_yes.Iconimage_Selected = null;
            this.btn_yes.IconMarginLeft = 0;
            this.btn_yes.IconMarginRight = 0;
            this.btn_yes.IconRightVisible = true;
            this.btn_yes.IconRightZoom = 0D;
            this.btn_yes.IconVisible = true;
            this.btn_yes.IconZoom = 90D;
            this.btn_yes.IsTab = false;
            this.btn_yes.Location = new System.Drawing.Point(267, 445);
            this.btn_yes.Margin = new System.Windows.Forms.Padding(60, 3, 60, 3);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_yes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_yes.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_yes.selected = false;
            this.btn_yes.Size = new System.Drawing.Size(295, 44);
            this.btn_yes.TabIndex = 2;
            this.btn_yes.Text = "UPDATE";
            this.btn_yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_yes.Textcolor = System.Drawing.Color.White;
            this.btn_yes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(830, 513);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox profile_pic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_name;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_mail;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_pass;
        private Bunifu.Framework.UI.BunifuFlatButton btn_yes;
    }
}
