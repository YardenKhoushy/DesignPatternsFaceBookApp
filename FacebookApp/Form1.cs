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
            LoginResult result = FacebookService.Login("1450160541956417", "public_profile", "user_friends", "user_birthday");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                profilePic.LoadAsync(m_LoggedInUser.PictureNormalURL);
                controlsVisibility(true);
                //fetchUserInfo();
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
            friendsList.Items.Clear();
        }

        private void fetchFriends_Click(object sender, EventArgs e)
        {
            getFriends();
            buttonBirthdaySort.Enabled = true;
        }
        private void getFriends()
        {
            friendsList.Items.Clear();
            friendsList.DisplayMember = "Name";
            m_FriendsList = new FacebookUtils();
            foreach (User friend in m_LoggedInUser.Friends)
            {
                //string birthday = friend.Birthday;
                //string email = friend.Email;
                friendsList.Items.Add(friend);
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
            friendsList.Visible = visibilty;
            profilePic.Visible = visibilty;
            fetchFriends.Visible = visibilty;
            buttonBirthdaySort.Visible = visibilty;
        }

        private void buttonBirthdaySort_Click(object sender, EventArgs e)
        {
            m_FriendsList.sortFriendsByDate();
            GetFriendsListAfterSort();
        }

        private void GetFriendsListAfterSort()
        {
            friendsList.Items.Clear();
            friendsList.DisplayMember = "Name";

            foreach (UserNode user in m_FriendsList.UserList)
            {
                friendsList.Items.Add(user.Name);
            }
        }
    }

    
}
