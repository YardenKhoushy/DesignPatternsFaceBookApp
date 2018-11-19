using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    public class FacebookUtils
    {
        private List<UserNode> m_UserList;

        public List<UserNode> UserList { get { return m_UserList; } }

        public FacebookUtils()
        {
            m_UserList = new List<UserNode>();
        }

        public void AddFriend(UserNode user)
        {
            m_UserList.Add(user);
        }

       public void sortFriendsByDate()
        {
            m_UserList.Sort((user1, user2) => Comparer<DateTime?>.Default.Compare(user1.Birthday, user2.Birthday));
        }
        public List<UserNode> FindFriendsByBirthday(DateTime date)
        {
            List<UserNode> dateToFriends = new List<UserNode>();
            string dateAsString = dateToString(date);
            foreach(UserNode user in m_UserList)
            {
                string userBirthday = dateToString(user.Birthday);
                if (userBirthday.Equals(dateAsString))
                {
                    dateToFriends.Add(user);
                }
            }
            return dateToFriends;
        }
        private string dateToString(DateTime i_date)
        {
            string date = i_date.Day.ToString() + "/" + i_date.Month.ToString();
            return date;
        }
    }
}
