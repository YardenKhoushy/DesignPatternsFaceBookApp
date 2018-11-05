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

        private void loginAndInit()
        {
            //LoginResult result = FacebookService.Login("805313746467364", "public_profile", "user_friends");
            LoginResult result = FacebookService.Login("1450160541956417", "public_profile", "user_friends");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                this.profilePic.LoadAsync(m_LoggedInUser.PictureNormalURL);
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
            this.profilePic.Visible = false;
        }

        private void fecthFriends_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }
        private void fetchFriends()
        {
            friendsList.Items.Clear();
            friendsList.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                friendsList.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }
    }

    
}
