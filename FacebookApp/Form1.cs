using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        User m_LoggedInUser;
        FacebookUtils m_FriendsList;

        private void loginAndInit()
        {
            //LoginResult result = FacebookService.Login("805313746467364", "public_profile", "user_friends");
            LoginResult result = FacebookService.Login("1450160541956417", "public_profile", "user_friends", "user_birthday", "user_photos");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                profilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
                controlsVisibility(true);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
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
            m_FriendsList = new FacebookUtils();
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
                pictureBoxMostLikedPhoto.Visible = true;
                labelPhotoLikes.Visible = true;
                pictureBoxMostLikedPhoto.LoadAsync(photoURL);
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
    }
}
