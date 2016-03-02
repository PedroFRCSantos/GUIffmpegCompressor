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

        public LanguageManager()
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;
            languageName = ci.ThreeLetterISOLanguageName;

            // load defaul values ENG
            folderInStr = "Input folder:";
            folderOutStr = "Output folder:";
            browseStr = "Browse";

            // try to open xml and read information
            readXMLInformation();
        }

        public string getNameFolderIn()
        {
            return folderInStr;
        }

        public string getNameFolderOut()
        {
            return folderOutStr;
        }

        public string getBrowse()
        {
            return browseStr;
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
