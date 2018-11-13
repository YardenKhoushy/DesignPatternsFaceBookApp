using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FacebookApp
{
    public class UserNode
    {
        private string m_Name;
        private DateTime m_Birthday;

        public UserNode(User i_user)
        {
            m_Name = i_user.Name;
            //Because of Facebook permissions not able to get Friend Birthday so giving default value
            try
            {
                m_Birthday = DateTime.Parse(i_user.Birthday);
            }
            catch(Exception e)
            {
                m_Birthday = DateTime.Today;
            }
        }

        public string Name { get { return m_Name; } }
        public DateTime Birthday { get { return m_Birthday; } set { m_Birthday = value; } }
    }
}
