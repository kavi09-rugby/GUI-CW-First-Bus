namespace GUI_CW
{
    partial class FormRouteDetailsPassenger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.tpun = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPassengerDashbordName = new System.Windows.Forms.Label();
            this.labelMiniLogo1PassLogin = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBoxLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLogo2Mini = new System.Windows.Forms.Label();
            this.labelLogo1Mini = new System.Windows.Forms.Label();
            this.labelMiniLogo2PassLogin = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelBusRouteViwe = new System.Windows.Forms.Label();
            this.panelSideMenuBar = new System.Windows.Forms.Panel();
            this.panelYourDetails = new System.Windows.Forms.Panel();
            this.guna2GradientButtonBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.firstBusDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.first_BusDataSet5 = new GUI_CW.First_BusDataSet5();
            this.first_BusDataSet6 = new GUI_CW.First_BusDataSet6();
            this.busRoutesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bus_RoutesTableAdapter = new GUI_CW.First_BusDataSet6TableAdapters.Bus_RoutesTableAdapter();
            this.routeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenuBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.panelSideMenuBar.SuspendLayout();
            this.panelYourDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstBusDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_BusDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_BusDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busRoutesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelMenuBar.Controls.Add(this.tpun);
            this.panelMenuBar.Controls.Add(this.labelPassengerDashbordName);
            this.panelMenuBar.Controls.Add(this.labelMiniLogo1PassLogin);
            this.panelMenuBar.Controls.Add(this.panelLogo);
            this.panelMenuBar.Controls.Add(this.labelMiniLogo2PassLogin);
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(1827, 150);
            this.panelMenuBar.TabIndex = 12;
            // 
            // tpun
            // 
            this.tpun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tpun.DefaultText = "";
            this.tpun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tpun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tpun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tpun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tpun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tpun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tpun.Location = new System.Drawing.Point(571, 96);
            this.tpun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpun.Name = "tpun";
            this.tpun.PasswordChar = '\0';
            this.tpun.PlaceholderText = "";
            this.tpun.SelectedText = "";
            this.tpun.Size = new System.Drawing.Size(267, 44);
            this.tpun.TabIndex = 9;
            // 
            // labelPassengerDashbordName
            // 
            this.labelPassengerDashbordName.AutoSize = true;
            this.labelPassengerDashbordName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelPassengerDashbordName.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassengerDashbordName.ForeColor = System.Drawing.Color.White;
            this.labelPassengerDashbordName.Location = new System.Drawing.Point(753, 50);
            this.labelPassengerDashbordName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassengerDashbordName.Name = "labelPassengerDashbordName";
            this.labelPassengerDashbordName.Size = new System.Drawing.Size(772, 47);
            this.labelPassengerDashbordName.TabIndex = 1;
            this.labelPassengerDashbordName.Text = "Passenger Dashboard";
            // 
            // labelMiniLogo1PassLogin
            // 
            this.labelMiniLogo1PassLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMiniLogo1PassLogin.AutoSize = true;
            this.labelMiniLogo1PassLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelMiniLogo1PassLogin.Font = new System.Drawing.Font("Curlz MT", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiniLogo1PassLogin.ForeColor = System.Drawing.Color.Navy;
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 150);
            this.panel1.TabIndex = 6;
            // 
            // guna2CirclePictureBoxLogo
            // 
            this.guna2CirclePictureBoxLogo.Image = global::GUI_CW.Properties.Resources._16853888690571;
            this.guna2CirclePictureBoxLogo.ImageRotate = 0F;
            this.guna2CirclePictureBoxLogo.Location = new System.Drawing.Point(123, 1);
            this.guna2CirclePictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
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
            this.labelMiniLogo2PassLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelMiniLogo2PassLogin.Font = new System.Drawing.Font("Curlz MT", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiniLogo2PassLogin.ForeColor = System.Drawing.Color.Navy;
            this.labelMiniLogo2PassLogin.Location = new System.Drawing.Point(339, 74);
            this.labelMiniLogo2PassLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiniLogo2PassLogin.Name = "labelMiniLogo2PassLogin";
            this.labelMiniLogo2PassLogin.Size = new System.Drawing.Size(75, 49);
            this.labelMiniLogo2PassLogin.TabIndex = 8;
            this.labelMiniLogo2PassLogin.Text = "Bus";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Crimson;
            this.guna2GradientPanel1.Controls.Add(this.labelBusRouteViwe);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 150);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1827, 65);
            this.guna2GradientPanel1.TabIndex = 13;
            // 
            // labelBusRouteViwe
            // 
            this.labelBusRouteViwe.AutoSize = true;
            this.labelBusRouteViwe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelBusRouteViwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusRouteViwe.ForeColor = System.Drawing.Color.White;
            this.labelBusRouteViwe.Location = new System.Drawing.Point(931, 18);
            this.labelBusRouteViwe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBusRouteViwe.Name = "labelBusRouteViwe";
            this.labelBusRouteViwe.Size = new System.Drawing.Size(224, 36);
            this.labelBusRouteViwe.TabIndex = 2;
            this.labelBusRouteViwe.Text = "Bus Route List";
            // 
            // panelSideMenuBar
            // 
            this.panelSideMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelSideMenuBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSideMenuBar.Controls.Add(this.panelYourDetails);
            this.panelSideMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenuBar.Location = new System.Drawing.Point(0, 215);
            this.panelSideMenuBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenuBar.Name = "panelSideMenuBar";
            this.panelSideMenuBar.Size = new System.Drawing.Size(329, 707);
            this.panelSideMenuBar.TabIndex = 25;
            // 
            // panelYourDetails
            // 
            this.panelYourDetails.Controls.Add(this.guna2GradientButtonBack);
            this.panelYourDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelYourDetails.Location = new System.Drawing.Point(0, 0);
            this.panelYourDetails.Margin = new System.Windows.Forms.Padding(4);
            this.panelYourDetails.Name = "panelYourDetails";
            this.panelYourDetails.Size = new System.Drawing.Size(325, 98);
            this.panelYourDetails.TabIndex = 0;
            // 
            // guna2GradientButtonBack
            // 
            this.guna2GradientButtonBack.AutoRoundedCorners = true;
            this.guna2GradientButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButtonBack.BorderColor = System.Drawing.Color.Silver;
            this.guna2GradientButtonBack.BorderRadius = 29;
            this.guna2GradientButtonBack.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GradientButtonBack.BorderThickness = 1;
            this.guna2GradientButtonBack.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2GradientButtonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButtonBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButtonBack.FillColor2 = System.Drawing.Color.Crimson;
            this.guna2GradientButtonBack.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButtonBack.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButtonBack.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButtonBack.Location = new System.Drawing.Point(52, 21);
            this.guna2GradientButtonBack.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButtonBack.Name = "guna2GradientButtonBack";
            this.guna2GradientButtonBack.Size = new System.Drawing.Size(219, 60);
            this.guna2GradientButtonBack.TabIndex = 8;
            this.guna2GradientButtonBack.Text = "Back";
            this.guna2GradientButtonBack.Click += new System.EventHandler(this.guna2GradientButtonBack_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeNumberDataGridViewTextBoxColumn,
            this.routeNameDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.travelTimeDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.busRoutesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(329, 215);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1498, 707);
            this.guna2DataGridView1.TabIndex = 26;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // firstBusDataSet5BindingSource
            // 
            this.firstBusDataSet5BindingSource.DataSource = this.first_BusDataSet5;
            this.firstBusDataSet5BindingSource.Position = 0;
            // 
            // first_BusDataSet5
            // 
            this.first_BusDataSet5.DataSetName = "First_BusDataSet5";
            this.first_BusDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // first_BusDataSet6
            // 
            this.first_BusDataSet6.DataSetName = "First_BusDataSet6";
            this.first_BusDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busRoutesBindingSource
            // 
            this.busRoutesBindingSource.DataMember = "Bus_Routes";
            this.busRoutesBindingSource.DataSource = this.first_BusDataSet6;
            // 
            // bus_RoutesTableAdapter
            // 
            this.bus_RoutesTableAdapter.ClearBeforeFill = true;
            // 
            // routeNumberDataGridViewTextBoxColumn
            // 
            this.routeNumberDataGridViewTextBoxColumn.DataPropertyName = "RouteNumber";
            this.routeNumberDataGridViewTextBoxColumn.HeaderText = "RouteNumber";
            this.routeNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeNumberDataGridViewTextBoxColumn.Name = "routeNumberDataGridViewTextBoxColumn";
            this.routeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routeNameDataGridViewTextBoxColumn
            // 
            this.routeNameDataGridViewTextBoxColumn.DataPropertyName = "RouteName";
            this.routeNameDataGridViewTextBoxColumn.HeaderText = "RouteName";
            this.routeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeNameDataGridViewTextBoxColumn.Name = "routeNameDataGridViewTextBoxColumn";
            this.routeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // travelTimeDataGridViewTextBoxColumn
            // 
            this.travelTimeDataGridViewTextBoxColumn.DataPropertyName = "TravelTime";
            this.travelTimeDataGridViewTextBoxColumn.HeaderText = "TravelTime";
            this.travelTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.travelTimeDataGridViewTextBoxColumn.Name = "travelTimeDataGridViewTextBoxColumn";
            this.travelTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormRouteDetailsPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.panelSideMenuBar);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panelMenuBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRouteDetailsPassenger";
            this.Text = "FormRouteDetailsPassenger";
            this.Load += new System.EventHandler(this.FormRouteDetailsPassenger_Load);
            this.panelMenuBar.ResumeLayout(false);
            this.panelMenuBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBoxLogo)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.panelSideMenuBar.ResumeLayout(false);
            this.panelYourDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstBusDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_BusDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_BusDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busRoutesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuBar;
        private System.Windows.Forms.Label labelPassengerDashbordName;
        private System.Windows.Forms.Label labelMiniLogo1PassLogin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo2Mini;
        private System.Windows.Forms.Label labelLogo1Mini;
        private System.Windows.Forms.Label labelMiniLogo2PassLogin;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label labelBusRouteViwe;
        private System.Windows.Forms.Panel panelSideMenuBar;
        private System.Windows.Forms.Panel panelYourDetails;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonBack;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox tpun;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource firstBusDataSet5BindingSource;
        private First_BusDataSet5 first_BusDataSet5;
        private First_BusDataSet6 first_BusDataSet6;
        private System.Windows.Forms.BindingSource busRoutesBindingSource;
        private First_BusDataSet6TableAdapters.Bus_RoutesTableAdapter bus_RoutesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelTimeDataGridViewTextBoxColumn;
    }
}