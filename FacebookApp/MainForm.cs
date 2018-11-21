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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
            m_CurrentSession = new Session();
        }

        private User m_LoggedInUser;
        private FacebookUtils m_FriendsList;
        private Session m_CurrentSession;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_CurrentSession.AppOpened();
            LoginWork();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_CurrentSession.AppSettings.RememberUser = checkBoxRememberMe.Checked;
            m_CurrentSession.CloseApp();
            tabControl1.Controls.Remove(TabPage2);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_CurrentSession.LoginAndInit();
            LoginWork();
        }

        private void LoginWork()
        {
            if (!string.IsNullOrEmpty(m_CurrentSession.Result.AccessToken))
            {
                m_LoggedInUser = m_CurrentSession.Result.LoggedInUser;
                profilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
                controlsVisibility(true);
                tabControl1.Controls.Add(this.TabPage2);
                tabPage1.Text = "Profile";
                m_FriendsList = new FacebookUtils();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(null);
            controlsVisibility(false);
            listBoxFriendsList.Items.Clear();
            m_CurrentSession.AppSettings.RememberUser = false;
            this.tabPage1.Text = "Login";
            this.checkBoxRememberMe.Checked = false;
            this.tabControl1.Controls.Remove(TabPage2);
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
            m_FriendsList.Clear();
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
            m_FriendsList.SortFriendsByDate();
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
                try
                {
                    User selectedUser = (User)listBoxFriendsList.Items[listBoxFriendsList.SelectedIndex];
                    string photoURL = getMostLikedPhoto(selectedUser);
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
            string photoURL = String.Empty;
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

            labelPhotoLikes.Text = string.Format("Number of Likes: {0}", maxLikes);
            return photoURL;
        }

        private void buttonShowFriendsBirthday_Click(object sender, EventArgs e)
        {
            DateTime date = monthCalendar1.SelectionRange.Start;
            List<UserNode> friendsBirthdayList = m_FriendsList.FindFriendsByBirthday(date);
            updateListBoxWithFriendsBirthdays(friendsBirthdayList);
        }

        private void updateListBoxWithFriendsBirthdays(List<UserNode> i_BirthdayList)
        {
            if(i_BirthdayList.Count != 0)
            {
                foreach(UserNode user in i_BirthdayList)
                {
                    listBoxShowFriendsBirthday.Items.Add(user);
                }
            }
            else
            {
                MessageBox.Show("No friends with birthdays on selected date");
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatusTry = m_LoggedInUser.PostStatus(postTextBox.Text);
            }
            catch (Exception)
            {
                postTextBox.Clear();
                MessageBox.Show("Cannot post status due to limited Facebook permisions");
            }

            Status postedStatus = m_LoggedInUser.PostStatus(postTextBox.Text);
            if (postedStatus.Id == null)
            {
                MessageBox.Show("Please write a post");
            }
            else
            {
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }

            postTextBox.Clear();
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            pictureBoxEvent.Visible = true;
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxFetchEvents.Items.Clear();
            listBoxFetchEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxFetchEvents.Items.Add(fbEvent);
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void listBoxFetchEvents_selectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFetchEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxFetchEvents.SelectedItem as Event;
                pictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
            }
        }
    }
}
