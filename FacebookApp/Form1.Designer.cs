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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.buttonBirthdaySort = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxFetchPosts = new System.Windows.Forms.ListBox();
            this.labelGetPhoto = new System.Windows.Forms.Label();
            this.buttonGetMostLikedPhoto = new System.Windows.Forms.Button();
            this.pictureBoxMostLikedPhoto = new System.Windows.Forms.PictureBox();
            this.labelPhotoLikes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Location = new System.Drawing.Point(12, 21);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(212, 96);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(12, 168);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(388, 326);
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            this.profilePic.Visible = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogout.Location = new System.Drawing.Point(1674, 752);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(240, 80);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFetchFriends.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchFriends.Location = new System.Drawing.Point(520, 168);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(259, 63);
            this.buttonFetchFriends.TabIndex = 3;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = false;
            this.buttonFetchFriends.Visible = false;
            this.buttonFetchFriends.Click += new System.EventHandler(this.fetchFriends_Click);
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxFriendsList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.ItemHeight = 25;
            this.listBoxFriendsList.Location = new System.Drawing.Point(520, 270);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(259, 304);
            this.listBoxFriendsList.TabIndex = 4;
            this.listBoxFriendsList.Visible = false;
            // 
            // buttonBirthdaySort
            // 
            this.buttonBirthdaySort.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBirthdaySort.Enabled = false;
            this.buttonBirthdaySort.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBirthdaySort.Location = new System.Drawing.Point(520, 626);
            this.buttonBirthdaySort.Name = "buttonBirthdaySort";
            this.buttonBirthdaySort.Size = new System.Drawing.Size(259, 45);
            this.buttonBirthdaySort.TabIndex = 5;
            this.buttonBirthdaySort.Text = "Sort Friends By Birthday";
            this.buttonBirthdaySort.UseVisualStyleBackColor = false;
            this.buttonBirthdaySort.Visible = false;
            this.buttonBirthdaySort.Click += new System.EventHandler(this.buttonBirthdaySort_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFetchPosts.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchPosts.Location = new System.Drawing.Point(915, 168);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(259, 63);
            this.buttonFetchPosts.TabIndex = 8;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = false;
            this.buttonFetchPosts.Visible = false;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxFetchPosts
            // 
            this.listBoxFetchPosts.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxFetchPosts.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxFetchPosts.FormattingEnabled = true;
            this.listBoxFetchPosts.HorizontalScrollbar = true;
            this.listBoxFetchPosts.ItemHeight = 25;
            this.listBoxFetchPosts.Location = new System.Drawing.Point(915, 271);
            this.listBoxFetchPosts.Name = "listBoxFetchPosts";
            this.listBoxFetchPosts.Size = new System.Drawing.Size(259, 304);
            this.listBoxFetchPosts.TabIndex = 9;
            this.listBoxFetchPosts.Visible = false;
            // 
            // labelGetPhoto
            // 
            this.labelGetPhoto.AutoSize = true;
            this.labelGetPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelGetPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetPhoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGetPhoto.Location = new System.Drawing.Point(1275, 168);
            this.labelGetPhoto.Name = "labelGetPhoto";
            this.labelGetPhoto.Size = new System.Drawing.Size(592, 99);
            this.labelGetPhoto.TabIndex = 10;
            this.labelGetPhoto.Text = "To get your friends most liked photo,\r\nPlease choose a friend from your friends l" +
    "ist.\r\nThen press \'Get Photo\'";
            this.labelGetPhoto.Visible = false;
            // 
            // buttonGetMostLikedPhoto
            // 
            this.buttonGetMostLikedPhoto.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGetMostLikedPhoto.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGetMostLikedPhoto.Location = new System.Drawing.Point(1280, 291);
            this.buttonGetMostLikedPhoto.Name = "buttonGetMostLikedPhoto";
            this.buttonGetMostLikedPhoto.Size = new System.Drawing.Size(259, 63);
            this.buttonGetMostLikedPhoto.TabIndex = 12;
            this.buttonGetMostLikedPhoto.Text = "Get photo";
            this.buttonGetMostLikedPhoto.UseVisualStyleBackColor = false;
            this.buttonGetMostLikedPhoto.Visible = false;
            this.buttonGetMostLikedPhoto.Click += new System.EventHandler(this.buttonGetMostLikedPhoto_Click);
            // 
            // pictureBoxMostLikedPhoto
            // 
            this.pictureBoxMostLikedPhoto.Location = new System.Drawing.Point(1280, 372);
            this.pictureBoxMostLikedPhoto.Name = "pictureBoxMostLikedPhoto";
            this.pictureBoxMostLikedPhoto.Size = new System.Drawing.Size(388, 326);
            this.pictureBoxMostLikedPhoto.TabIndex = 13;
            this.pictureBoxMostLikedPhoto.TabStop = false;
            this.pictureBoxMostLikedPhoto.Visible = false;
            // 
            // labelPhotoLikes
            // 
            this.labelPhotoLikes.AutoSize = true;
            this.labelPhotoLikes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPhotoLikes.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPhotoLikes.Location = new System.Drawing.Point(1275, 734);
            this.labelPhotoLikes.Name = "labelPhotoLikes";
            this.labelPhotoLikes.Size = new System.Drawing.Size(180, 25);
            this.labelPhotoLikes.TabIndex = 14;
            this.labelPhotoLikes.Text = "Number of Likes: ";
            this.labelPhotoLikes.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::FacebookApp.Properties.Resources.facebookBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1942, 857);
            this.Controls.Add(this.labelPhotoLikes);
            this.Controls.Add(this.pictureBoxMostLikedPhoto);
            this.Controls.Add(this.buttonGetMostLikedPhoto);
            this.Controls.Add(this.labelGetPhoto);
            this.Controls.Add(this.listBoxFetchPosts);
            this.Controls.Add(this.buttonFetchPosts);
            this.Controls.Add(this.buttonBirthdaySort);
            this.Controls.Add(this.listBoxFriendsList);
            this.Controls.Add(this.buttonFetchFriends);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Application";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.Button buttonBirthdaySort;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxFetchPosts;
        private System.Windows.Forms.Label labelGetPhoto;
        private System.Windows.Forms.Button buttonGetMostLikedPhoto;
        private System.Windows.Forms.PictureBox pictureBoxMostLikedPhoto;
        private System.Windows.Forms.Label labelPhotoLikes;
        //This is a test.
    }
}

