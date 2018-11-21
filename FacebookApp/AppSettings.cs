using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace FacebookApp
{
    public class AppSettings
    {
        public static AppSettings LoadFromFile()
        {
            AppSettings obj = null;
            using (Stream stream = new FileStream(m_fullPath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                try
                {
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
                catch (Exception)
                {
                    // Something happened along the way and file is either empty(null) or corrupted
                    obj = new AppSettings();
                }
            }

            return obj;
        }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public string FullPath { get { return m_fullPath; } }

        private static string m_filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private const string m_fileName = "appSettings.xml";
        private static string m_fullPath;

        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
            m_fullPath = string.Format("{0}\\{1}", m_filePath, m_fileName);
        }

        public void SaveToFile()
        {
            if (!File.Exists(m_fullPath))
            {
                File.Create(m_fullPath).Close();
            }

            using (Stream stream = new FileStream(m_fullPath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
