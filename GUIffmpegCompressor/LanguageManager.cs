using System;
using System.Globalization;
using System.Xml;

namespace GUIffmpeg
{
    public class LanguageManager
    {
        string languageName;

        string authorNameStr = "";
        string authorEmailStr = "";

        string folderInStr;
        string folderOutStr;
        string browseStr;

        string upButtonName;
        string downButtonName;

        string dateFormat1;
        string dateFormat2;
        string dateFormat3;

        string baseName;
        string useName;

        public LanguageManager()
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;
            languageName = ci.ThreeLetterISOLanguageName;

            // load defaul values ENG
            folderInStr = "Input folder:";
            folderOutStr = "Output folder:";
            browseStr = "Browse";

            // up and down buttons
            upButtonName = "up";
            downButtonName = "down";

            // load default dateFormat
            dateFormat1 = "DDMMYYYYHHMMSS";
            dateFormat2 = "YYYYMMDDHHMMSS";
            dateFormat3 = "DDMouthYYYYHHMMSS";

            baseName = "Base Name (empty)";
            useName = "User Name";

            // try to open xml and read information
            readXMLInformation();
        }

        public string getNameFolderIn()
        {
            return (string)folderInStr.Clone();
        }

        public string getNameFolderOut()
        {
            return (string)folderOutStr.Clone();
        }

        public string getBrowse()
        {
            return (string)browseStr.Clone();
        }

        public string getUpName()
        {
            return (string)upButtonName.Clone();
        }

        public string getDownName()
        {
            return (string)downButtonName.Clone();
        }

        public string getDateFormat1()
        {
            return (string)dateFormat1.Clone();
        }

        public string getDateFormat2()
        {
            return (string)dateFormat2.Clone();
        }

        public string getDateFormat3()
        {
            return (string)dateFormat3.Clone();
        }

        public string getBaseName()
        {
            return (string)baseName.Clone();
        }

        public string getUseName()
        {
            return (string)useName.Clone();
        }

        private void readXMLInformation()
        {
            XmlTextReader reader = null;

            try
            {
                reader = new XmlTextReader("Languages\\lang-" + languageName + ".xml");
            }
            catch
            {
                return;
            }

            bool readAuthorName = false;
            bool readAuthorEmail = false;

            bool folderIn = false;
            bool folderOut = false;
            bool browse = false;

            while (reader.Read())
            {
                if (readAuthorName)
                {
                    authorNameStr = reader.Value;
                    Console.WriteLine("Name: {0}", reader.Value);
                }

                if (readAuthorEmail)
                {
                    authorEmailStr = reader.Value;
                    Console.WriteLine("Email: {0}", reader.Value);
                }

                if (folderIn)
                {
                    folderInStr = reader.Value;
                    Console.WriteLine("Folder In: {0}", reader.Value);
                }

                if (folderOut)
                {
                    folderOutStr = reader.Value;
                    Console.WriteLine("Folder Out: {0}", reader.Value);
                }

                if (browse)
                {
                    browseStr = reader.Value;
                    Console.WriteLine("Browse: {0}", reader.Value);
                }

                readAuthorName = (reader.Name == "name" && reader.NodeType == XmlNodeType.Element);
                readAuthorEmail = (reader.Name == "mail" && reader.NodeType == XmlNodeType.Element);

                folderIn = (reader.Name == "folderIn" && reader.NodeType == XmlNodeType.Element);
                folderOut = (reader.Name == "folderOut" && reader.NodeType == XmlNodeType.Element);
                browse = (reader.Name == "browse" && reader.NodeType == XmlNodeType.Element);
            }

            reader.Close();
            reader.Dispose();
        }
    }
}
