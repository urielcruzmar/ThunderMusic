namespace ThunderMusicPlayer
{
    partial class LogIn
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
            this.panel_login = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tb_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.picture_mail = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_mail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.picture_pass = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_enter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_login.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_mail)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pass)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.tableLayoutPanel3);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Location = new System.Drawing.Point(3, 3);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(702, 288);
            this.panel_login.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17647F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.82353F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel3.Controls.Add(this.panel9, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.picture_mail, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.picture_pass, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(702, 288);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tb_pass);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(188, 147);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(343, 66);
            this.panel9.TabIndex = 28;
            // 
            // tb_pass
            // 
            this.tb_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_pass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_pass.ForeColor = System.Drawing.Color.Gray;
            this.tb_pass.HintForeColor = System.Drawing.Color.Empty;
            this.tb_pass.HintText = "";
            this.tb_pass.isPassword = true;
            this.tb_pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_pass.LineIdleColor = System.Drawing.Color.Silver;
            this.tb_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_pass.LineThickness = 2;
            this.tb_pass.Location = new System.Drawing.Point(30, 4);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pass.MaxLength = 32767;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(309, 47);
            this.tb_pass.TabIndex = 7;
            this.tb_pass.Text = "E-Mail";
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_pass.Enter += new System.EventHandler(this.pass_click);
            // 
            // picture_mail
            // 
            this.picture_mail.Image = global::ThunderMusicPlayer.Properties.Resources.baseline_alternate_email_white_48dp;
            this.picture_mail.Location = new System.Drawing.Point(123, 82);
            this.picture_mail.Margin = new System.Windows.Forms.Padding(10);
            this.picture_mail.Name = "picture_mail";
            this.picture_mail.Size = new System.Drawing.Size(52, 52);
            this.picture_mail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_mail.TabIndex = 18;
            this.picture_mail.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_mail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(188, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 66);
            this.panel1.TabIndex = 19;
            // 
            // tb_mail
            // 
            this.tb_mail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_mail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_mail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mail.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_mail.ForeColor = System.Drawing.Color.Gray;
            this.tb_mail.HintForeColor = System.Drawing.Color.Empty;
            this.tb_mail.HintText = "";
            this.tb_mail.isPassword = false;
            this.tb_mail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_mail.LineIdleColor = System.Drawing.Color.Silver;
            this.tb_mail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(138)))), ((int)(((byte)(197)))));
            this.tb_mail.LineThickness = 2;
            this.tb_mail.Location = new System.Drawing.Point(30, 4);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mail.MaxLength = 32767;
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(309, 48);
            this.tb_mail.TabIndex = 7;
            this.tb_mail.Text = "E-Mail";
            this.tb_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_mail.Enter += new System.EventHandler(this.email_click);
            // 
            // picture_pass
            // 
            this.picture_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_pass.Image = global::ThunderMusicPlayer.Properties.Resources.baseline_vpn_key_white_48dp;
            this.picture_pass.Location = new System.Drawing.Point(123, 154);
            this.picture_pass.Margin = new System.Windows.Forms.Padding(10);
            this.picture_pass.Name = "picture_pass";
            this.picture_pass.Size = new System.Drawing.Size(52, 52);
            this.picture_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_pass.TabIndex = 20;
            this.picture_pass.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.btn_cancel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_enter, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 297);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(702, 112);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Active = false;
            this.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.BorderRadius = 0;
            this.btn_cancel.ButtonText = "Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel.Iconimage = null;
            this.btn_cancel.Iconimage_right = null;
            this.btn_cancel.Iconimage_right_Selected = null;
            this.btn_cancel.Iconimage_Selected = null;
            this.btn_cancel.IconMarginLeft = 0;
            this.btn_cancel.IconMarginRight = 0;
            this.btn_cancel.IconRightVisible = true;
            this.btn_cancel.IconRightZoom = 0D;
            this.btn_cancel.IconVisible = true;
            this.btn_cancel.IconZoom = 90D;
            this.btn_cancel.IsTab = false;
            this.btn_cancel.Location = new System.Drawing.Point(60, 20);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(20);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel.selected = false;
            this.btn_cancel.Size = new System.Drawing.Size(261, 48);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancel.TextFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Active = false;
            this.btn_enter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enter.BorderRadius = 0;
            this.btn_enter.ButtonText = "Enter";
            this.btn_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enter.DisabledColor = System.Drawing.Color.Gray;
            this.btn_enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_enter.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_enter.Iconimage = null;
            this.btn_enter.Iconimage_right = null;
            this.btn_enter.Iconimage_right_Selected = null;
            this.btn_enter.Iconimage_Selected = null;
            this.btn_enter.IconMarginLeft = 0;
            this.btn_enter.IconMarginRight = 0;
            this.btn_enter.IconRightVisible = true;
            this.btn_enter.IconRightZoom = 0D;
            this.btn_enter.IconVisible = true;
            this.btn_enter.IconZoom = 90D;
            this.btn_enter.IsTab = false;
            this.btn_enter.Location = new System.Drawing.Point(381, 20);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(20);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_enter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn_enter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_enter.selected = false;
            this.btn_enter.Size = new System.Drawing.Size(261, 48);
            this.btn_enter.TabIndex = 7;
            this.btn_enter.Text = "Enter";
            this.btn_enter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_enter.TextFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_login, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 412);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(708, 412);
            this.panel_login.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_mail)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_pass)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_pass;
        private System.Windows.Forms.PictureBox picture_mail;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_mail;
        private System.Windows.Forms.PictureBox picture_pass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_enter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
