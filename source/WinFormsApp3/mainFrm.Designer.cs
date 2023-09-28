using System.Windows.Forms;

namespace LogInDemo
{
    partial class mainFrm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            pro4Tab = new TabPage();
            changePasswordBttn = new Button();
            genderF = new RadioButton();
            genderM = new RadioButton();
            label13 = new Label();
            appSignOut = new Button();
            appExit = new Button();
            saveChangeBttn = new Button();
            pro4BirthDay = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            pro4Name = new TextBox();
            pro4Phone = new TextBox();
            pro4Id = new TextBox();
            pro4Email = new TextBox();
            pro4Password = new TextBox();
            pro4Username = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            ticketTab = new TabPage();
            sessionFlw = new FlowLayoutPanel();
            panel1 = new Panel();
            label11 = new Label();
            searchBttn = new Button();
            label12 = new Label();
            cbCinema = new ComboBox();
            timePick = new DateTimePicker();
            cbArea = new ComboBox();
            cbMovie = new ComboBox();
            label1 = new Label();
            label10 = new Label();
            settingTab = new TabControl();
            tabHis = new TabPage();
            hisFlw = new FlowLayoutPanel();
            tabUsers = new TabPage();
            dataGridView1 = new DataGridView();
            label14 = new Label();
            tabFoods = new TabPage();
            dataGridView2 = new DataGridView();
            label15 = new Label();
            tabRevenue = new TabPage();
            cbMonth1 = new ComboBox();
            cbYear1 = new ComboBox();
            cbDay1 = new ComboBox();
            btnExportCSV = new Button();
            btnExportPDF = new Button();
            btnExportExcel = new Button();
            label17 = new Label();
            label16 = new Label();
            dataGridView3 = new DataGridView();
            userDAOBindingSource = new BindingSource(components);
            userDAOBindingSource1 = new BindingSource(components);
            pro4Tab.SuspendLayout();
            panel2.SuspendLayout();
            ticketTab.SuspendLayout();
            panel1.SuspendLayout();
            settingTab.SuspendLayout();
            tabHis.SuspendLayout();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userDAOBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pro4Tab
            // 
            pro4Tab.Controls.Add(changePasswordBttn);
            pro4Tab.Controls.Add(genderF);
            pro4Tab.Controls.Add(genderM);
            pro4Tab.Controls.Add(label13);
            pro4Tab.Controls.Add(appSignOut);
            pro4Tab.Controls.Add(appExit);
            pro4Tab.Controls.Add(saveChangeBttn);
            pro4Tab.Controls.Add(pro4BirthDay);
            pro4Tab.Controls.Add(label9);
            pro4Tab.Controls.Add(label8);
            pro4Tab.Controls.Add(pro4Name);
            pro4Tab.Controls.Add(pro4Phone);
            pro4Tab.Controls.Add(pro4Id);
            pro4Tab.Controls.Add(pro4Email);
            pro4Tab.Controls.Add(pro4Password);
            pro4Tab.Controls.Add(pro4Username);
            pro4Tab.Controls.Add(label6);
            pro4Tab.Controls.Add(label5);
            pro4Tab.Controls.Add(label4);
            pro4Tab.Controls.Add(label3);
            pro4Tab.Controls.Add(label2);
            pro4Tab.Controls.Add(panel2);
            pro4Tab.Location = new Point(4, 32);
            pro4Tab.Name = "pro4Tab";
            pro4Tab.Padding = new Padding(3);
            pro4Tab.Size = new Size(1052, 673);
            pro4Tab.TabIndex = 1;
            pro4Tab.Text = "Profile";
            pro4Tab.UseVisualStyleBackColor = true;
            pro4Tab.Click += pro4Tab_Click;
            // 
            // changePasswordBttn
            // 
            changePasswordBttn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            changePasswordBttn.BackColor = Color.DarkCyan;
            changePasswordBttn.FlatAppearance.BorderSize = 0;
            changePasswordBttn.FlatStyle = FlatStyle.Flat;
            changePasswordBttn.ForeColor = Color.White;
            changePasswordBttn.Location = new Point(740, 567);
            changePasswordBttn.Name = "changePasswordBttn";
            changePasswordBttn.Size = new Size(226, 45);
            changePasswordBttn.TabIndex = 41;
            changePasswordBttn.Text = "Change Password";
            changePasswordBttn.UseVisualStyleBackColor = false;
            changePasswordBttn.Click += button1_Click;
            // 
            // genderF
            // 
            genderF.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            genderF.AutoSize = true;
            genderF.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            genderF.Location = new Point(771, 402);
            genderF.Name = "genderF";
            genderF.Size = new Size(118, 31);
            genderF.TabIndex = 38;
            genderF.TabStop = true;
            genderF.Text = "Female";
            genderF.UseVisualStyleBackColor = true;
            // 
            // genderM
            // 
            genderM.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            genderM.AutoSize = true;
            genderM.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            genderM.Location = new Point(501, 402);
            genderM.Name = "genderM";
            genderM.Size = new Size(93, 31);
            genderM.TabIndex = 39;
            genderM.TabStop = true;
            genderM.Text = "Male";
            genderM.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(66, 407);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(99, 27);
            label13.TabIndex = 40;
            label13.Text = "Gender";
            // 
            // appSignOut
            // 
            appSignOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            appSignOut.BackColor = SystemColors.ControlDark;
            appSignOut.FlatAppearance.BorderSize = 0;
            appSignOut.FlatStyle = FlatStyle.Flat;
            appSignOut.ForeColor = Color.White;
            appSignOut.Location = new Point(67, 514);
            appSignOut.Name = "appSignOut";
            appSignOut.Size = new Size(191, 45);
            appSignOut.TabIndex = 37;
            appSignOut.Text = "Sign Out";
            appSignOut.UseVisualStyleBackColor = false;
            appSignOut.Click += appSignOut_Click;
            // 
            // appExit
            // 
            appExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            appExit.BackColor = Color.DarkCyan;
            appExit.FlatAppearance.BorderSize = 0;
            appExit.FlatStyle = FlatStyle.Flat;
            appExit.ForeColor = Color.White;
            appExit.Location = new Point(67, 567);
            appExit.Name = "appExit";
            appExit.Size = new Size(191, 45);
            appExit.TabIndex = 36;
            appExit.Text = "Exit";
            appExit.UseVisualStyleBackColor = false;
            appExit.Click += appExit_Click;
            // 
            // saveChangeBttn
            // 
            saveChangeBttn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveChangeBttn.BackColor = Color.DarkCyan;
            saveChangeBttn.FlatAppearance.BorderSize = 0;
            saveChangeBttn.FlatStyle = FlatStyle.Flat;
            saveChangeBttn.ForeColor = Color.White;
            saveChangeBttn.Location = new Point(777, 514);
            saveChangeBttn.Name = "saveChangeBttn";
            saveChangeBttn.Size = new Size(191, 45);
            saveChangeBttn.TabIndex = 7;
            saveChangeBttn.Text = "Save Change";
            saveChangeBttn.UseVisualStyleBackColor = false;
            saveChangeBttn.Click += saveChangeBttn_Click;
            // 
            // pro4BirthDay
            // 
            pro4BirthDay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pro4BirthDay.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pro4BirthDay.Format = DateTimePickerFormat.Short;
            pro4BirthDay.Location = new Point(501, 232);
            pro4BirthDay.Name = "pro4BirthDay";
            pro4BirthDay.Size = new Size(464, 36);
            pro4BirthDay.TabIndex = 3;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(65, 234);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(150, 27);
            label9.TabIndex = 35;
            label9.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(66, 190);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 27);
            label8.TabIndex = 34;
            label8.Text = "Full Name";
            // 
            // pro4Name
            // 
            pro4Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pro4Name.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pro4Name.Location = new Point(501, 189);
            pro4Name.Margin = new Padding(5, 4, 5, 4);
            pro4Name.Name = "pro4Name";
            pro4Name.Size = new Size(465, 36);
            pro4Name.TabIndex = 2;
            // 
            // pro4Phone
            // 
            pro4Phone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pro4Phone.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pro4Phone.Location = new Point(501, 363);
            pro4Phone.Margin = new Padding(5, 4, 5, 4);
            pro4Phone.Name = "pro4Phone";
            pro4Phone.Size = new Size(465, 36);
            pro4Phone.TabIndex = 6;
            // 
            // pro4Id
            // 
            pro4Id.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pro4Id.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pro4Id.Location = new Point(502, 319);
            pro4Id.Margin = new Padding(5, 4, 5, 4);
            pro4Id.Name = "pro4Id";
            pro4Id.Size = new Size(465, 36);
            pro4Id.TabIndex = 5;
            // 
            // pro4Email
            // 
            pro4Email.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pro4Email.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pro4Email.Location = new Point(502, 275);
            pro4Email.Margin = new Padding(5, 4, 5, 4);
            pro4Email.Name = "pro4Email";
            pro4Email.Size = new Size(465, 36);
            pro4Email.TabIndex = 4;
            // 
            // pro4Password
            // 
            pro4Password.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pro4Password.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pro4Password.Location = new Point(546, 460);
            pro4Password.Margin = new Padding(5, 4, 5, 4);
            pro4Password.Name = "pro4Password";
            pro4Password.PasswordChar = '*';
            pro4Password.Size = new Size(420, 36);
            pro4Password.TabIndex = 1;
            // 
            // pro4Username
            // 
            pro4Username.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pro4Username.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pro4Username.Location = new Point(501, 145);
            pro4Username.Margin = new Padding(5, 4, 5, 4);
            pro4Username.Name = "pro4Username";
            pro4Username.ReadOnly = true;
            pro4Username.Size = new Size(465, 36);
            pro4Username.TabIndex = 0;
            pro4Username.TextChanged += pro4Username_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(65, 364);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(181, 27);
            label6.TabIndex = 32;
            label6.Text = "Phone Number";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(65, 320);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(365, 27);
            label5.TabIndex = 31;
            label5.Text = "National Identification Number";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 276);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 27);
            label4.TabIndex = 30;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 146);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 27);
            label3.TabIndex = 27;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 463);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(408, 27);
            label2.TabIndex = 25;
            label2.Text = "Enter the Password to save change";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1046, 667);
            panel2.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(220, 47, 2);
            label7.Location = new Point(62, 19);
            label7.Name = "label7";
            label7.Size = new Size(155, 55);
            label7.TabIndex = 33;
            label7.Text = "Profile";
            label7.Click += label7_Click;
            // 
            // ticketTab
            // 
            ticketTab.Controls.Add(sessionFlw);
            ticketTab.Controls.Add(panel1);
            ticketTab.Location = new Point(4, 32);
            ticketTab.Name = "ticketTab";
            ticketTab.Padding = new Padding(3);
            ticketTab.Size = new Size(1052, 673);
            ticketTab.TabIndex = 0;
            ticketTab.Text = "Purchase Ticket";
            ticketTab.UseVisualStyleBackColor = true;
            // 
            // sessionFlw
            // 
            sessionFlw.AutoScroll = true;
            sessionFlw.BackColor = Color.Gainsboro;
            sessionFlw.Dock = DockStyle.Fill;
            sessionFlw.Location = new Point(3, 109);
            sessionFlw.Name = "sessionFlw";
            sessionFlw.RightToLeft = RightToLeft.No;
            sessionFlw.Size = new Size(1046, 561);
            sessionFlw.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(searchBttn);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cbCinema);
            panel1.Controls.Add(timePick);
            panel1.Controls.Add(cbArea);
            panel1.Controls.Add(cbMovie);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 106);
            panel1.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(451, 26);
            label11.Name = "label11";
            label11.Size = new Size(92, 23);
            label11.TabIndex = 11;
            label11.Text = "Cinema:";
            // 
            // searchBttn
            // 
            searchBttn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBttn.BackColor = Color.DarkCyan;
            searchBttn.FlatAppearance.BorderSize = 0;
            searchBttn.FlatStyle = FlatStyle.Flat;
            searchBttn.ForeColor = Color.White;
            searchBttn.Location = new Point(901, 21);
            searchBttn.Name = "searchBttn";
            searchBttn.Size = new Size(111, 61);
            searchBttn.TabIndex = 14;
            searchBttn.Text = "Search";
            searchBttn.UseVisualStyleBackColor = false;
            searchBttn.Click += searchBttn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(451, 61);
            label12.Name = "label12";
            label12.Size = new Size(64, 23);
            label12.TabIndex = 12;
            label12.Text = "Date:";
            // 
            // cbCinema
            // 
            cbCinema.BackColor = SystemColors.MenuBar;
            cbCinema.FormattingEnabled = true;
            cbCinema.Location = new Point(549, 23);
            cbCinema.Name = "cbCinema";
            cbCinema.Size = new Size(257, 31);
            cbCinema.TabIndex = 13;
            cbCinema.SelectedIndexChanged += cbCinema_SelectedIndexChanged;
            // 
            // timePick
            // 
            timePick.Format = DateTimePickerFormat.Short;
            timePick.Location = new Point(549, 56);
            timePick.Name = "timePick";
            timePick.Size = new Size(257, 32);
            timePick.TabIndex = 10;
            timePick.ValueChanged += timePick_ValueChanged;
            // 
            // cbArea
            // 
            cbArea.BackColor = SystemColors.MenuBar;
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(106, 21);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(252, 31);
            cbArea.TabIndex = 6;
            cbArea.SelectedIndexChanged += cbArea_SelectedIndexChanged;
            // 
            // cbMovie
            // 
            cbMovie.BackColor = SystemColors.MenuBar;
            cbMovie.FormattingEnabled = true;
            cbMovie.Location = new Point(106, 58);
            cbMovie.Name = "cbMovie";
            cbMovie.Size = new Size(252, 31);
            cbMovie.TabIndex = 7;
            cbMovie.SelectedIndexChanged += cbMovie_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 8;
            label1.Text = "Area:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 61);
            label10.Name = "label10";
            label10.Size = new Size(74, 23);
            label10.TabIndex = 9;
            label10.Text = "Movie:";
            // 
            // settingTab
            // 
            settingTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingTab.Controls.Add(ticketTab);
            settingTab.Controls.Add(pro4Tab);
            settingTab.Controls.Add(tabHis);
            settingTab.Controls.Add(tabUsers);
            settingTab.Controls.Add(tabFoods);
            settingTab.Controls.Add(tabRevenue);
            settingTab.Location = new Point(20, 20);
            settingTab.Margin = new Padding(10);
            settingTab.Name = "settingTab";
            settingTab.SelectedIndex = 0;
            settingTab.Size = new Size(1060, 709);
            settingTab.TabIndex = 0;
            // 
            // tabHis
            // 
            tabHis.Controls.Add(hisFlw);
            tabHis.Location = new Point(4, 32);
            tabHis.Name = "tabHis";
            tabHis.Padding = new Padding(3);
            tabHis.Size = new Size(1052, 673);
            tabHis.TabIndex = 2;
            tabHis.Text = "History";
            tabHis.UseVisualStyleBackColor = true;
            tabHis.Click += tabHis_Click;
            // 
            // hisFlw
            // 
            hisFlw.AutoScroll = true;
            hisFlw.BorderStyle = BorderStyle.FixedSingle;
            hisFlw.Dock = DockStyle.Fill;
            hisFlw.Location = new Point(3, 3);
            hisFlw.Name = "hisFlw";
            hisFlw.Size = new Size(1046, 667);
            hisFlw.TabIndex = 0;
            hisFlw.SizeChanged += hisFlw_SizeChanged;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(dataGridView1);
            tabUsers.Controls.Add(label14);
            tabUsers.Location = new Point(4, 32);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(1052, 673);
            tabUsers.TabIndex = 3;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1043, 590);
            dataGridView1.TabIndex = 6;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Century Gothic", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(220, 47, 2);
            label14.Location = new Point(41, 17);
            label14.Name = "label14";
            label14.Size = new Size(294, 36);
            label14.TabIndex = 5;
            label14.Text = "Users Management";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabFoods
            // 
            tabFoods.Controls.Add(dataGridView2);
            tabFoods.Controls.Add(label15);
            tabFoods.Location = new Point(4, 29);
            tabFoods.Name = "tabFoods";
            tabFoods.Padding = new Padding(3);
            tabFoods.Size = new Size(1052, 676);
            tabFoods.TabIndex = 4;
            tabFoods.Text = "Foods";
            tabFoods.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 71);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1043, 590);
            dataGridView2.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(220, 47, 2);
            label15.Location = new Point(41, 17);
            label15.Name = "label15";
            label15.Size = new Size(307, 36);
            label15.TabIndex = 1;
            label15.Text = "Foods Management";
            // 
            // tabRevenue
            // 
            tabRevenue.Controls.Add(cbMonth1);
            tabRevenue.Controls.Add(cbYear1);
            tabRevenue.Controls.Add(cbDay1);
            tabRevenue.Controls.Add(btnExportCSV);
            tabRevenue.Controls.Add(btnExportPDF);
            tabRevenue.Controls.Add(btnExportExcel);
            tabRevenue.Controls.Add(label17);
            tabRevenue.Controls.Add(label16);
            tabRevenue.Controls.Add(dataGridView3);
            tabRevenue.Location = new Point(4, 29);
            tabRevenue.Name = "tabRevenue";
            tabRevenue.Padding = new Padding(3);
            tabRevenue.Size = new Size(1052, 676);
            tabRevenue.TabIndex = 5;
            tabRevenue.Text = "Revenue";
            tabRevenue.UseVisualStyleBackColor = true;
            tabRevenue.Click += tabRevenue_Click;
            // 
            // cbMonth1
            // 
            cbMonth1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbMonth1.FormattingEnabled = true;
            cbMonth1.Location = new Point(738, 6);
            cbMonth1.Name = "cbMonth1";
            cbMonth1.Size = new Size(151, 31);
            cbMonth1.TabIndex = 15;
            cbMonth1.SelectedIndexChanged += cbMonth1_SelectedIndexChanged;
            // 
            // cbYear1
            // 
            cbYear1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbYear1.FormattingEnabled = true;
            cbYear1.Location = new Point(895, 6);
            cbYear1.Name = "cbYear1";
            cbYear1.Size = new Size(151, 31);
            cbYear1.TabIndex = 14;
            cbYear1.SelectedIndexChanged += cbYear1_SelectedIndexChanged;
            // 
            // cbDay1
            // 
            cbDay1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbDay1.FormattingEnabled = true;
            cbDay1.Location = new Point(581, 6);
            cbDay1.Name = "cbDay1";
            cbDay1.Size = new Size(151, 31);
            cbDay1.TabIndex = 13;
            cbDay1.SelectedIndexChanged += cbDay1_SelectedIndexChanged;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Anchor = AnchorStyles.Bottom;
            btnExportCSV.Location = new Point(629, 611);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(173, 35);
            btnExportCSV.TabIndex = 11;
            btnExportCSV.Text = "Export CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Anchor = AnchorStyles.Bottom;
            btnExportPDF.Location = new Point(450, 611);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(173, 35);
            btnExportPDF.TabIndex = 10;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Bottom;
            btnExportExcel.Location = new Point(271, 611);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(173, 35);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Yellow;
            label17.Location = new Point(6, 53);
            label17.Name = "label17";
            label17.Size = new Size(198, 23);
            label17.TabIndex = 5;
            label17.Text = "Revenue by month";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(220, 47, 2);
            label16.Location = new Point(73, 12);
            label16.Name = "label16";
            label16.Size = new Size(352, 36);
            label16.TabIndex = 3;
            label16.Text = "Revenue Management";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 104);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(1043, 501);
            dataGridView3.TabIndex = 2;
            // 
            // userDAOBindingSource
            // 
            userDAOBindingSource.DataSource = typeof(DAO.UserDAO);
            // 
            // userDAOBindingSource1
            // 
            userDAOBindingSource1.DataSource = typeof(DAO.UserDAO);
            // 
            // mainFrm
            // 
            AcceptButton = saveChangeBttn;
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1100, 749);
            Controls.Add(settingTab);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "mainFrm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galaxy Cinema";
            Load += mainFrm_Load;
            SizeChanged += mainFrm_SizeChanged;
            pro4Tab.ResumeLayout(false);
            pro4Tab.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ticketTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            settingTab.ResumeLayout(false);
            tabHis.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabFoods.ResumeLayout(false);
            tabFoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabRevenue.ResumeLayout(false);
            tabRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)userDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userDAOBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage pro4Tab;
        private Button appSignOut;
        private Button appExit;
        private Button saveChangeBttn;
        private DateTimePicker pro4BirthDay;
        private Label label9;
        private Label label8;
        private TextBox pro4Name;
        private TextBox pro4Phone;
        private TextBox pro4Id;
        private TextBox pro4Email;
        private TextBox pro4Password;
        private TextBox pro4Username;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage ticketTab;
        private FlowLayoutPanel sessionFlw;
        private TabControl settingTab;
        private RadioButton genderF;
        private RadioButton genderM;
        private Label label13;
        private Button changePasswordBttn;
        private Panel panel1;
        private Label label11;
        private Button searchBttn;
        private Label label12;
        private ComboBox cbCinema;
        private DateTimePicker timePick;
        private ComboBox cbArea;
        private ComboBox cbMovie;
        private Label label1;
        private Label label10;
        private TabPage tabHis;
        private FlowLayoutPanel hisFlw;
        private TabPage tabUsers;
        private TabPage tabFoods;
        private BindingSource userDAOBindingSource;
        private BindingSource userDAOBindingSource1;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private TabPage tabRevenue;
        private Button btnExportCSV;
        private Button btnExportPDF;
        private Button btnExportExcel;
        private Label label17;
        private Label label16;
        private DataGridView dataGridView3;
        private Panel panel2;
        private Label label14;
        private Label label15;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private ComboBox cbMonth1;
        private ComboBox cbYear1;
        private ComboBox cbDay1;
    }
}