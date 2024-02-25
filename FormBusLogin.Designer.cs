namespace GUI_CW
{
    partial class FormBusLogin
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
            this.panelLoginBus = new System.Windows.Forms.Panel();
            this.guna2HtmlLabelwarningMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.linkLabelRegiterAlert = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPWHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxPWShow = new System.Windows.Forms.PictureBox();
            this.buttonLoginBus = new System.Windows.Forms.Button();
            this.textBoxPasswordBusLogin = new System.Windows.Forms.TextBox();
            this.textBoxUserNameBusLogin = new System.Windows.Forms.TextBox();
            this.labelPasswordBusLogin = new System.Windows.Forms.Label();
            this.labelUserNameBusLogin = new System.Windows.Forms.Label();
            this.labelHomeIcon = new System.Windows.Forms.Label();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.labelBusLogin = new System.Windows.Forms.Label();
            this.labelMiniLogo1PassLogin = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBoxLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLogo2Mini = new System.Windows.Forms.Label();
            this.labelLogo1Mini = new System.Windows.Forms.Label();
            this.labelMiniLogo2PassLogin = new System.Windows.Forms.Label();
            this.errorProviderBusUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBusPW = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxHomeIcon = new System.Windows.Forms.PictureBox();
            this.panelLoginBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPWHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPWShow)).BeginInit();
            this.panelMenuBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBusUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBusPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoginBus
            // 
            this.panelLoginBus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoginBus.BackColor = System.Drawing.Color.LightYellow;
            this.panelLoginBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoginBus.Controls.Add(this.guna2HtmlLabelwarningMessage);
            this.panelLoginBus.Controls.Add(this.linkLabelRegiterAlert);
            this.panelLoginBus.Controls.Add(this.pictureBoxPWHide);
            this.panelLoginBus.Controls.Add(this.pictureBoxPWShow);
            this.panelLoginBus.Controls.Add(this.buttonLoginBus);
            this.panelLoginBus.Controls.Add(this.textBoxPasswordBusLogin);
            this.panelLoginBus.Controls.Add(this.textBoxUserNameBusLogin);
            this.panelLoginBus.Controls.Add(this.labelPasswordBusLogin);
            this.panelLoginBus.Controls.Add(this.labelUserNameBusLogin);
            this.panelLoginBus.Location = new System.Drawing.Point(392, 206);
            this.panelLoginBus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLoginBus.Name = "panelLoginBus";
            this.panelLoginBus.Size = new System.Drawing.Size(1011, 574);
            this.panelLoginBus.TabIndex = 25;
            // 
            // guna2HtmlLabelwarningMessage
            // 
            this.guna2HtmlLabelwarningMessage.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelwarningMessage.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelwarningMessage.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabelwarningMessage.Location = new System.Drawing.Point(213, 313);
            this.guna2HtmlLabelwarningMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabelwarningMessage.Name = "guna2HtmlLabelwarningMessage";
            this.guna2HtmlLabelwarningMessage.Size = new System.Drawing.Size(206, 31);
            this.guna2HtmlLabelwarningMessage.TabIndex = 33;
            this.guna2HtmlLabelwarningMessage.Text = "Invalid login! please try again";
            // 
            // linkLabelRegiterAlert
            // 
            this.linkLabelRegiterAlert.AutoSize = true;
            this.linkLabelRegiterAlert.Location = new System.Drawing.Point(620, 425);
            this.linkLabelRegiterAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelRegiterAlert.Name = "linkLabelRegiterAlert";
            this.linkLabelRegiterAlert.Size = new System.Drawing.Size(214, 16);
            this.linkLabelRegiterAlert.TabIndex = 29;
            this.linkLabelRegiterAlert.TabStop = true;
            this.linkLabelRegiterAlert.Text = "Not Registerd ? Please Click Here.";
            this.linkLabelRegiterAlert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegiterAlert_LinkClicked);
            // 
            // pictureBoxPWHide
            // 
            this.pictureBoxPWHide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPWHide.Image = global::GUI_CW.Properties.Resources.download1;
            this.pictureBoxPWHide.Location = new System.Drawing.Point(889, 223);
            this.pictureBoxPWHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPWHide.Name = "pictureBoxPWHide";
            this.pictureBoxPWHide.Size = new System.Drawing.Size(53, 38);
            this.pictureBoxPWHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPWHide.TabIndex = 27;
            this.pictureBoxPWHide.TabStop = false;
            this.pictureBoxPWHide.Click += new System.EventHandler(this.pictureBoxPWHide_Click);
            // 
            // pictureBoxPWShow
            // 
            this.pictureBoxPWShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPWShow.Image = global::GUI_CW.Properties.Resources.download;
            this.pictureBoxPWShow.Location = new System.Drawing.Point(889, 223);
            this.pictureBoxPWShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPWShow.Name = "pictureBoxPWShow";
            this.pictureBoxPWShow.Size = new System.Drawing.Size(53, 38);
            this.pictureBoxPWShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPWShow.TabIndex = 26;
            this.pictureBoxPWShow.TabStop = false;
            this.pictureBoxPWShow.Click += new System.EventHandler(this.pictureBoxPWShow_Click);
            // 
            // buttonLoginBus
            // 
            this.buttonLoginBus.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonLoginBus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLoginBus.FlatAppearance.BorderSize = 10;
            this.buttonLoginBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLoginBus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLoginBus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoginBus.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginBus.ForeColor = System.Drawing.Color.White;
            this.buttonLoginBus.Location = new System.Drawing.Point(244, 389);
            this.buttonLoginBus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoginBus.Name = "buttonLoginBus";
            this.buttonLoginBus.Size = new System.Drawing.Size(201, 52);
            this.buttonLoginBus.TabIndex = 24;
            this.buttonLoginBus.Text = "Log in";
            this.buttonLoginBus.UseVisualStyleBackColor = false;
            this.buttonLoginBus.Click += new System.EventHandler(this.buttonLoginBus_Click);
            // 
            // textBoxPasswordBusLogin
            // 
            this.textBoxPasswordBusLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswordBusLogin.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordBusLogin.Location = new System.Drawing.Point(389, 219);
            this.textBoxPasswordBusLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPasswordBusLogin.Name = "textBoxPasswordBusLogin";
            this.textBoxPasswordBusLogin.Size = new System.Drawing.Size(490, 38);
            this.textBoxPasswordBusLogin.TabIndex = 23;
            this.textBoxPasswordBusLogin.UseSystemPasswordChar = true;
            this.textBoxPasswordBusLogin.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPasswordBusLogin_Validating);
            // 
            // textBoxUserNameBusLogin
            // 
            this.textBoxUserNameBusLogin.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameBusLogin.Location = new System.Drawing.Point(389, 124);
            this.textBoxUserNameBusLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserNameBusLogin.Name = "textBoxUserNameBusLogin";
            this.textBoxUserNameBusLogin.Size = new System.Drawing.Size(489, 38);
            this.textBoxUserNameBusLogin.TabIndex = 22;
            this.textBoxUserNameBusLogin.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserNameBusLogin_Validating);
            // 
            // labelPasswordBusLogin
            // 
            this.labelPasswordBusLogin.AutoSize = true;
            this.labelPasswordBusLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelPasswordBusLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordBusLogin.ForeColor = System.Drawing.Color.Black;
            this.labelPasswordBusLogin.Location = new System.Drawing.Point(153, 225);
            this.labelPasswordBusLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswordBusLogin.Name = "labelPasswordBusLogin";
            this.labelPasswordBusLogin.Size = new System.Drawing.Size(136, 33);
            this.labelPasswordBusLogin.TabIndex = 21;
            this.labelPasswordBusLogin.Text = "Password";
            // 
            // labelUserNameBusLogin
            // 
            this.labelUserNameBusLogin.AutoSize = true;
            this.labelUserNameBusLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelUserNameBusLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameBusLogin.ForeColor = System.Drawing.Color.Black;
            this.labelUserNameBusLogin.Location = new System.Drawing.Point(136, 126);
            this.labelUserNameBusLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserNameBusLogin.Name = "labelUserNameBusLogin";
            this.labelUserNameBusLogin.Size = new System.Drawing.Size(150, 33);
            this.labelUserNameBusLogin.TabIndex = 20;
            this.labelUserNameBusLogin.Text = "User Name";
            // 
            // labelHomeIcon
            // 
            this.labelHomeIcon.AutoSize = true;
            this.labelHomeIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeIcon.Location = new System.Drawing.Point(29, 262);
            this.labelHomeIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHomeIcon.Name = "labelHomeIcon";
            this.labelHomeIcon.Size = new System.Drawing.Size(58, 18);
            this.labelHomeIcon.TabIndex = 29;
            this.labelHomeIcon.Text = "HOME";
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenuBar.Controls.Add(this.labelBusLogin);
            this.panelMenuBar.Controls.Add(this.labelMiniLogo1PassLogin);
            this.panelMenuBar.Controls.Add(this.panelLogo);
            this.panelMenuBar.Controls.Add(this.labelMiniLogo2PassLogin);
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(1827, 150);
            this.panelMenuBar.TabIndex = 31;
            // 
            // labelBusLogin
            // 
            this.labelBusLogin.AutoSize = true;
            this.labelBusLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelBusLogin.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusLogin.ForeColor = System.Drawing.Color.White;
            this.labelBusLogin.Location = new System.Drawing.Point(729, 50);
            this.labelBusLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBusLogin.Name = "labelBusLogin";
            this.labelBusLogin.Size = new System.Drawing.Size(350, 47);
            this.labelBusLogin.TabIndex = 1;
            this.labelBusLogin.Text = "Bus Login";
            // 
            // labelMiniLogo1PassLogin
            // 
            this.labelMiniLogo1PassLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMiniLogo1PassLogin.AutoSize = true;
            this.labelMiniLogo1PassLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelMiniLogo1PassLogin.Font = new System.Drawing.Font("Curlz MT", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiniLogo1PassLogin.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelMiniLogo1PassLogin.Location = new System.Drawing.Point(339, 11);
            this.labelMiniLogo1PassLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiniLogo1PassLogin.Name = "labelMiniLogo1PassLogin";
            this.labelMiniLogo1PassLogin.Size = new System.Drawing.Size(88, 49);
            this.labelMiniLogo1PassLogin.TabIndex = 7;
            this.labelMiniLogo1PassLogin.Text = "First";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Controls.Add(this.labelLogo2Mini);
            this.panelLogo.Controls.Add(this.labelLogo1Mini);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(328, 150);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.guna2CirclePictureBoxLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 150);
            this.panel1.TabIndex = 6;
            // 
            // guna2CirclePictureBoxLogo
            // 
            this.guna2CirclePictureBoxLogo.Image = global::GUI_CW.Properties.Resources._16853888690571;
            this.guna2CirclePictureBoxLogo.ImageRotate = 0F;
            this.guna2CirclePictureBoxLogo.Location = new System.Drawing.Point(123, 1);
            this.guna2CirclePictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CirclePictureBoxLogo.Name = "guna2CirclePictureBoxLogo";
            this.guna2CirclePictureBoxLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBoxLogo.Size = new System.Drawing.Size(127, 146);
            this.guna2CirclePictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBoxLogo.TabIndex = 19;
            this.guna2CirclePictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Curlz MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(233, -166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 66);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bus";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Curlz MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(223, -231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 66);
            this.label2.TabIndex = 4;
            this.label2.Text = "First";
            // 
            // labelLogo2Mini
            // 
            this.labelLogo2Mini.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogo2Mini.AutoSize = true;
            this.labelLogo2Mini.BackColor = System.Drawing.Color.White;
            this.labelLogo2Mini.Font = new System.Drawing.Font("Curlz MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo2Mini.ForeColor = System.Drawing.Color.Navy;
            this.labelLogo2Mini.Location = new System.Drawing.Point(208, -166);
            this.labelLogo2Mini.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogo2Mini.Name = "labelLogo2Mini";
            this.labelLogo2Mini.Size = new System.Drawing.Size(98, 66);
            this.labelLogo2Mini.TabIndex = 5;
            this.labelLogo2Mini.Text = "Bus";
            // 
            // labelLogo1Mini
            // 
            this.labelLogo1Mini.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogo1Mini.AutoSize = true;
            this.labelLogo1Mini.BackColor = System.Drawing.Color.White;
            this.labelLogo1Mini.Font = new System.Drawing.Font("Curlz MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo1Mini.ForeColor = System.Drawing.Color.Navy;
            this.labelLogo1Mini.Location = new System.Drawing.Point(197, -231);
            this.labelLogo1Mini.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogo1Mini.Name = "labelLogo1Mini";
            this.labelLogo1Mini.Size = new System.Drawing.Size(116, 66);
            this.labelLogo1Mini.TabIndex = 4;
            this.labelLogo1Mini.Text = "First";
            // 
            // labelMiniLogo2PassLogin
            // 
            this.labelMiniLogo2PassLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMiniLogo2PassLogin.AutoSize = true;
            this.labelMiniLogo2PassLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelMiniLogo2PassLogin.Font = new System.Drawing.Font("Curlz MT", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiniLogo2PassLogin.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelMiniLogo2PassLogin.Location = new System.Drawing.Point(339, 74);
            this.labelMiniLogo2PassLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiniLogo2PassLogin.Name = "labelMiniLogo2PassLogin";
            this.labelMiniLogo2PassLogin.Size = new System.Drawing.Size(75, 49);
            this.labelMiniLogo2PassLogin.TabIndex = 8;
            this.labelMiniLogo2PassLogin.Text = "Bus";
            // 
            // errorProviderBusUserName
            // 
            this.errorProviderBusUserName.ContainerControl = this;
            // 
            // errorProviderBusPW
            // 
            this.errorProviderBusPW.ContainerControl = this;
            // 
            // pictureBoxHomeIcon
            // 
            this.pictureBoxHomeIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHomeIcon.Image = global::GUI_CW.Properties.Resources._5973800__1_;
            this.pictureBoxHomeIcon.Location = new System.Drawing.Point(29, 206);
            this.pictureBoxHomeIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxHomeIcon.Name = "pictureBoxHomeIcon";
            this.pictureBoxHomeIcon.Size = new System.Drawing.Size(81, 52);
            this.pictureBoxHomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomeIcon.TabIndex = 28;
            this.pictureBoxHomeIcon.TabStop = false;
            this.pictureBoxHomeIcon.Click += new System.EventHandler(this.pictureBoxHomeIcon_Click);
            // 
            // FormBusLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(this.labelHomeIcon);
            this.Controls.Add(this.panelLoginBus);
            this.Controls.Add(this.pictureBoxHomeIcon);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBusLogin";
            this.Text = "Bus";
            this.panelLoginBus.ResumeLayout(false);
            this.panelLoginBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPWHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPWShow)).EndInit();
            this.panelMenuBar.ResumeLayout(false);
            this.panelMenuBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBusUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBusPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLoginBus;
        private System.Windows.Forms.PictureBox pictureBoxPWHide;
        private System.Windows.Forms.PictureBox pictureBoxPWShow;
        private System.Windows.Forms.Button buttonLoginBus;
        private System.Windows.Forms.TextBox textBoxPasswordBusLogin;
        private System.Windows.Forms.TextBox textBoxUserNameBusLogin;
        private System.Windows.Forms.Label labelHomeIcon;
        private System.Windows.Forms.PictureBox pictureBoxHomeIcon;
        private System.Windows.Forms.Label labelPasswordBusLogin;
        private System.Windows.Forms.Label labelUserNameBusLogin;
        private System.Windows.Forms.LinkLabel linkLabelRegiterAlert;
        private System.Windows.Forms.Panel panelMenuBar;
        private System.Windows.Forms.Label labelBusLogin;
        private System.Windows.Forms.Label labelMiniLogo1PassLogin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo2Mini;
        private System.Windows.Forms.Label labelLogo1Mini;
        private System.Windows.Forms.Label labelMiniLogo2PassLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelwarningMessage;
        private System.Windows.Forms.ErrorProvider errorProviderBusUserName;
        private System.Windows.Forms.ErrorProvider errorProviderBusPW;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}