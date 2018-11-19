using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }
        public User m_LoggedInUser;
        public FacebookUtils m_FriendsList;
        public AppSettings m_AppSettings;
        public LoginResult m_Result;


        private void loginAndInit()
        {
            //LoginResult result = FacebookService.Login("805313746467364", "public_profile", "user_friends");
            if (!m_AppSettings.RememberUser)
            {
                m_Result = FacebookService.Login("1450160541956417", "public_profile", "user_friends", "user_birthday", "user_photos");
            }
            else
            {
                m_Result = FacebookService.Connect(m_AppSettings.LastAccessToken);
            }
            if (!string.IsNullOrEmpty(m_Result.AccessToken))
            {
                m_LoggedInUser = m_Result.LoggedInUser;
                profilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
                controlsVisibility(true);
                tabControl1.Controls.Add(this.tabPage2);
                tabPage1.Text = "Profile";
                m_FriendsList = new FacebookUtils();
            }
            else
            {
                MessageBox.Show(m_Result.ErrorMessage);
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_AppSettings = new AppSettings();
            if (File.Exists(@"C:\Users\Yarden\Desktop\appSettings.xml"))
            {
                m_AppSettings = AppSettings.loadFromFile();
                if(m_AppSettings.RememberUser)
                {
                    loginAndInit();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSettings.RememberUser = checkBoxRememberMe.Checked;
            if(m_AppSettings.RememberUser)
            {
                m_AppSettings.LastAccessToken = m_Result.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }
            tabControl1.Controls.Remove(tabPage2);
            m_AppSettings.saveToFile();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(null);
            controlsVisibility(false);
            listBoxFriendsList.Items.Clear();
        }

        private void fetchFriends_Click(object sender, EventArgs e)
        {
            getFriends();
            buttonBirthdaySort.Enabled = true;
        }
        private void getFriends()
        {
            listBoxFriendsList.Items.Clear();
            listBoxFriendsList.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                listBoxFriendsList.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                UserNode user = new UserNode(friend);
                m_FriendsList.AddFriend(user);
            }
            buttonBirthdaySort.Enabled = true;
            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
                buttonBirthdaySort.Enabled = false;
            }
        }
        private void controlsVisibility(bool visibilty)
        {
            buttonLogin.Visible = !visibilty;
            checkBoxRememberMe.Visible = !visibilty;
            listBoxFriendsList.Visible = visibilty;
            profilePic.Visible = visibilty;
            buttonFetchFriends.Visible = visibilty;
            buttonBirthdaySort.Visible = visibilty;
            listBoxFetchPosts.Visible = visibilty;
            buttonFetchPosts.Visible = visibilty;
            buttonLogout.Enabled = visibilty;
            labelGetPhoto.Visible = visibilty;
            buttonGetMostLikedPhoto.Visible = visibilty; 
        }

        private void buttonBirthdaySort_Click(object sender, EventArgs e)
        {
            m_FriendsList.sortFriendsByDate();
            GetFriendsListAfterSort();
        }

        private void GetFriendsListAfterSort()
        {
            listBoxFriendsList.Items.Clear();
            listBoxFriendsList.DisplayMember = "Name";
            foreach (UserNode user in m_FriendsList.UserList)
            {
                listBoxFriendsList.Items.Add(user.Name);
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            getPosts();
        }

        private void getPosts()
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxFetchPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxFetchPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxFetchPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (m_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve");
            }
        }

        private void buttonGetMostLikedPhoto_Click(object sender, EventArgs e)
        {
            if (listBoxFriendsList.SelectedItem != null)
            {
                User selectedUser = (User)listBoxFriendsList.Items[listBoxFriendsList.SelectedIndex];
                string photoURL= getMostLikedPhoto(selectedUser);
                try
                {
                    pictureBoxMostLikedPhoto.LoadAsync(photoURL);
                    pictureBoxMostLikedPhoto.Visible = true;
                    labelPhotoLikes.Visible = true;
                }
                catch(Exception)
                {
                    MessageBox.Show("Because of Facebook permissions not able to get photo");
                }
            }
            else
            {
                MessageBox.Show("Please choose a friend from your friends list");
            }    
            
        }

        private string getMostLikedPhoto(User i_SelectedUser)
        {
            int maxLikes = 0;
            string photoURL = "";
            foreach(Album album in i_SelectedUser.Albums)
            {
                foreach(Photo photo in album.Photos)
                {
                    int temp = photo.LikedBy.Count;
                    if(temp > maxLikes)
                    {
                        maxLikes = temp;
                        photoURL = photo.PictureNormalURL;
                    }
                }
            }
            labelPhotoLikes.Text = String.Format("Number of Likes: {0}", maxLikes);
            return photoURL;
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           

        }

        private void buttonShowFriendsBirthday_Click(object sender, EventArgs e)
        {
            DateTime date = monthCalendar1.SelectionRange.Start;
            List<UserNode> friendsBirthdayList = m_FriendsList.FindFriendsByBirthday(date);
        }
    }
}
