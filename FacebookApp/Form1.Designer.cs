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
            this.fetchFriends = new System.Windows.Forms.Button();
            this.friendsList = new System.Windows.Forms.ListBox();
            this.buttonBirthdaySort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
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
            this.profilePic.Location = new System.Drawing.Point(260, 21);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(361, 229);
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            this.profilePic.Visible = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1201, 608);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(188, 55);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // fetchFriends
            // 
            this.fetchFriends.Location = new System.Drawing.Point(808, 21);
            this.fetchFriends.Name = "fetchFriends";
            this.fetchFriends.Size = new System.Drawing.Size(188, 37);
            this.fetchFriends.TabIndex = 3;
            this.fetchFriends.Text = "Fetch Friends";
            this.fetchFriends.UseVisualStyleBackColor = true;
            this.fetchFriends.Visible = false;
            this.fetchFriends.Click += new System.EventHandler(this.fetchFriends_Click);
            // 
            // friendsList
            // 
            this.friendsList.FormattingEnabled = true;
            this.friendsList.ItemHeight = 25;
            this.friendsList.Location = new System.Drawing.Point(808, 121);
            this.friendsList.Name = "friendsList";
            this.friendsList.Size = new System.Drawing.Size(308, 129);
            this.friendsList.TabIndex = 4;
            this.friendsList.Visible = false;
            // 
            // buttonBirthdaySort
            // 
            this.buttonBirthdaySort.Enabled = false;
            this.buttonBirthdaySort.Location = new System.Drawing.Point(808, 294);
            this.buttonBirthdaySort.Name = "buttonBirthdaySort";
            this.buttonBirthdaySort.Size = new System.Drawing.Size(314, 45);
            this.buttonBirthdaySort.TabIndex = 5;
            this.buttonBirthdaySort.Text = "Sort By Birthday";
            this.buttonBirthdaySort.UseVisualStyleBackColor = true;
            this.buttonBirthdaySort.Visible = false;
            this.buttonBirthdaySort.Click += new System.EventHandler(this.buttonBirthdaySort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookApp.Properties.Resources.facebookBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1412, 686);
            this.Controls.Add(this.buttonBirthdaySort);
            this.Controls.Add(this.friendsList);
            this.Controls.Add(this.fetchFriends);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.buttonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Facebook Application";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button fetchFriends;
        private System.Windows.Forms.ListBox friendsList;
        private System.Windows.Forms.Button buttonBirthdaySort;
        //This is a test.
    }
}

