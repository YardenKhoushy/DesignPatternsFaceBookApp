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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.fecthFriends = new System.Windows.Forms.Button();
            this.friendsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 21);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(132, 55);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(260, 21);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(361, 229);
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1201, 608);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(188, 55);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "buttonLogout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // fecthFriends
            // 
            this.fecthFriends.Location = new System.Drawing.Point(808, 21);
            this.fecthFriends.Name = "fecthFriends";
            this.fecthFriends.Size = new System.Drawing.Size(188, 37);
            this.fecthFriends.TabIndex = 3;
            this.fecthFriends.Text = "fetchFriends";
            this.fecthFriends.UseVisualStyleBackColor = true;
            this.fecthFriends.Click += new System.EventHandler(this.fecthFriends_Click);
            // 
            // friendsList
            // 
            this.friendsList.FormattingEnabled = true;
            this.friendsList.ItemHeight = 25;
            this.friendsList.Location = new System.Drawing.Point(808, 121);
            this.friendsList.Name = "friendsList";
            this.friendsList.Size = new System.Drawing.Size(308, 129);
            this.friendsList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 686);
            this.Controls.Add(this.friendsList);
            this.Controls.Add(this.fecthFriends);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button fecthFriends;
        private System.Windows.Forms.ListBox friendsList;
    }
}

