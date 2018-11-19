namespace FacebookApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.labelPhotoLikes = new System.Windows.Forms.Label();
            this.pictureBoxMostLikedPhoto = new System.Windows.Forms.PictureBox();
            this.buttonGetMostLikedPhoto = new System.Windows.Forms.Button();
            this.labelGetPhoto = new System.Windows.Forms.Label();
            this.listBoxFetchPosts = new System.Windows.Forms.ListBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.buttonBirthdaySort = new System.Windows.Forms.Button();
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxShowFriendsBirthday = new System.Windows.Forms.ListBox();
            this.buttonShowFriendsBirthday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            //this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1992, 853);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.BackgroundImage = global::FacebookApp.Properties.Resources.facebookBackground;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.checkBoxRememberMe);
            this.tabPage1.Controls.Add(this.labelPhotoLikes);
            this.tabPage1.Controls.Add(this.pictureBoxMostLikedPhoto);
            this.tabPage1.Controls.Add(this.buttonGetMostLikedPhoto);
            this.tabPage1.Controls.Add(this.labelGetPhoto);
            this.tabPage1.Controls.Add(this.listBoxFetchPosts);
            this.tabPage1.Controls.Add(this.buttonFetchPosts);
            this.tabPage1.Controls.Add(this.buttonBirthdaySort);
            this.tabPage1.Controls.Add(this.listBoxFriendsList);
            this.tabPage1.Controls.Add(this.buttonFetchFriends);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.profilePic);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1976, 806);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.BackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxRememberMe.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(301, 55);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(184, 29);
            this.checkBoxRememberMe.TabIndex = 28;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = false;
            // 
            // labelPhotoLikes
            // 
            this.labelPhotoLikes.AutoSize = true;
            this.labelPhotoLikes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPhotoLikes.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPhotoLikes.Location = new System.Drawing.Point(1300, 711);
            this.labelPhotoLikes.Name = "labelPhotoLikes";
            this.labelPhotoLikes.Size = new System.Drawing.Size(180, 25);
            this.labelPhotoLikes.TabIndex = 27;
            this.labelPhotoLikes.Text = "Number of Likes: ";
            this.labelPhotoLikes.Visible = false;
            // 
            // pictureBoxMostLikedPhoto
            // 
            this.pictureBoxMostLikedPhoto.Location = new System.Drawing.Point(1305, 349);
            this.pictureBoxMostLikedPhoto.Name = "pictureBoxMostLikedPhoto";
            this.pictureBoxMostLikedPhoto.Size = new System.Drawing.Size(388, 326);
            this.pictureBoxMostLikedPhoto.TabIndex = 26;
            this.pictureBoxMostLikedPhoto.TabStop = false;
            this.pictureBoxMostLikedPhoto.Visible = false;
            // 
            // buttonGetMostLikedPhoto
            // 
            this.buttonGetMostLikedPhoto.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGetMostLikedPhoto.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGetMostLikedPhoto.Location = new System.Drawing.Point(1305, 268);
            this.buttonGetMostLikedPhoto.Name = "buttonGetMostLikedPhoto";
            this.buttonGetMostLikedPhoto.Size = new System.Drawing.Size(259, 63);
            this.buttonGetMostLikedPhoto.TabIndex = 25;
            this.buttonGetMostLikedPhoto.Text = "Get photo";
            this.buttonGetMostLikedPhoto.UseVisualStyleBackColor = false;
            this.buttonGetMostLikedPhoto.Visible = false;
            this.buttonGetMostLikedPhoto.Click += new System.EventHandler(this.buttonGetMostLikedPhoto_Click);
            // 
            // labelGetPhoto
            // 
            this.labelGetPhoto.AutoSize = true;
            this.labelGetPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelGetPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetPhoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGetPhoto.Location = new System.Drawing.Point(1300, 145);
            this.labelGetPhoto.Name = "labelGetPhoto";
            this.labelGetPhoto.Size = new System.Drawing.Size(592, 99);
            this.labelGetPhoto.TabIndex = 24;
            this.labelGetPhoto.Text = "To get your friends most liked photo,\r\nPlease choose a friend from your friends l" +
    "ist.\r\nThen press \'Get Photo\'";
            this.labelGetPhoto.Visible = false;
            // 
            // listBoxFetchPosts
            // 
            this.listBoxFetchPosts.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxFetchPosts.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxFetchPosts.FormattingEnabled = true;
            this.listBoxFetchPosts.HorizontalScrollbar = true;
            this.listBoxFetchPosts.ItemHeight = 25;
            this.listBoxFetchPosts.Location = new System.Drawing.Point(940, 248);
            this.listBoxFetchPosts.Name = "listBoxFetchPosts";
            this.listBoxFetchPosts.Size = new System.Drawing.Size(259, 304);
            this.listBoxFetchPosts.TabIndex = 23;
            this.listBoxFetchPosts.Visible = false;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFetchPosts.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchPosts.Location = new System.Drawing.Point(940, 145);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(259, 63);
            this.buttonFetchPosts.TabIndex = 22;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = false;
            this.buttonFetchPosts.Visible = false;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // buttonBirthdaySort
            // 
            this.buttonBirthdaySort.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBirthdaySort.Enabled = false;
            this.buttonBirthdaySort.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBirthdaySort.Location = new System.Drawing.Point(545, 603);
            this.buttonBirthdaySort.Name = "buttonBirthdaySort";
            this.buttonBirthdaySort.Size = new System.Drawing.Size(259, 45);
            this.buttonBirthdaySort.TabIndex = 21;
            this.buttonBirthdaySort.Text = "Sort Friends By Birthday";
            this.buttonBirthdaySort.UseVisualStyleBackColor = false;
            this.buttonBirthdaySort.Visible = false;
            this.buttonBirthdaySort.Click += new System.EventHandler(this.buttonBirthdaySort_Click);
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxFriendsList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.ItemHeight = 25;
            this.listBoxFriendsList.Location = new System.Drawing.Point(545, 247);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(259, 304);
            this.listBoxFriendsList.TabIndex = 20;
            this.listBoxFriendsList.Visible = false;
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFetchFriends.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchFriends.Location = new System.Drawing.Point(545, 145);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(259, 63);
            this.buttonFetchFriends.TabIndex = 19;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = false;
            this.buttonFetchFriends.Visible = false;
            this.buttonFetchFriends.Click += new System.EventHandler(this.fetchFriends_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogout.Location = new System.Drawing.Point(1668, 711);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(240, 80);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(37, 145);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(388, 326);
            this.profilePic.TabIndex = 17;
            this.profilePic.TabStop = false;
            this.profilePic.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Location = new System.Drawing.Point(37, 14);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(212, 96);
            this.buttonLogin.TabIndex = 16;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxShowFriendsBirthday);
            this.tabPage2.Controls.Add(this.buttonShowFriendsBirthday);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1976, 806);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxShowFriendsBirthday
            // 
            this.listBoxShowFriendsBirthday.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxShowFriendsBirthday.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxShowFriendsBirthday.FormattingEnabled = true;
            this.listBoxShowFriendsBirthday.ItemHeight = 25;
            this.listBoxShowFriendsBirthday.Location = new System.Drawing.Point(523, 241);
            this.listBoxShowFriendsBirthday.Name = "listBoxShowFriendsBirthday";
            this.listBoxShowFriendsBirthday.Size = new System.Drawing.Size(218, 204);
            this.listBoxShowFriendsBirthday.TabIndex = 22;
            // 
            // buttonShowFriendsBirthday
            // 
            this.buttonShowFriendsBirthday.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonShowFriendsBirthday.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShowFriendsBirthday.Location = new System.Drawing.Point(523, 108);
            this.buttonShowFriendsBirthday.Name = "buttonShowFriendsBirthday";
            this.buttonShowFriendsBirthday.Size = new System.Drawing.Size(275, 63);
            this.buttonShowFriendsBirthday.TabIndex = 21;
            this.buttonShowFriendsBirthday.Text = "Show Friends Birthday";
            this.buttonShowFriendsBirthday.UseVisualStyleBackColor = false;
            this.buttonShowFriendsBirthday.Click += new System.EventHandler(this.buttonShowFriendsBirthday_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Date and see who\'s birthday it is";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(39, 108);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1942, 857);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Application";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label labelPhotoLikes;
        private System.Windows.Forms.PictureBox pictureBoxMostLikedPhoto;
        private System.Windows.Forms.Button buttonGetMostLikedPhoto;
        private System.Windows.Forms.Label labelGetPhoto;
        private System.Windows.Forms.ListBox listBoxFetchPosts;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Button buttonBirthdaySort;
        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxShowFriendsBirthday;
        private System.Windows.Forms.Button buttonShowFriendsBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;

        #endregion
        //This is a test.
    }
}

