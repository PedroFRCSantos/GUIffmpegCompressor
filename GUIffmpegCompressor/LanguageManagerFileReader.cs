using System;
using System.Xml;

namespace GUIffmpeg
{
    public partial class LanguageManager
    {
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

            bool readBaseName = false;
            bool readDateName = false;

            #region read Format
            bool dataFormat1 = false;
            bool dataFormat2 = false;
            bool dataFormat3 = false;
            #endregion

            #region Read month
            bool readJanuary = false;
            bool readFebruary = false;
            bool readMarch = false;
            bool readAbril = false;
            bool readMay = false;
            bool readJune = false;
            bool readJuly = false;
            bool readAugust = false;
            bool readSeptember = false;
            bool readOctober = false;
            bool readNovember = false;
            bool readDecember = false;
            #endregion

            #region read up down
            bool readUp = false;
            bool readDown = false;
            #endregion

            bool readConvertName = false;

            while (reader.Read())
            {
                #region atritute values
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
                
                if (readBaseName)
                {
                    baseName = reader.Value;
                    Console.WriteLine("Base name: {0}", reader.Value);
                }

                if (readDateName)
                {
                    dateName = reader.Value;
                    Console.WriteLine("Date name: {0}", reader.Value);
                }

                if (readUp)
                {
                    upButtonName = reader.Value;
                    Console.WriteLine("Up name: {0}", reader.Value);
                }

                if (readDown)
                {
                    downButtonName = reader.Value;
                    Console.WriteLine("Down name: {0}", reader.Value);
                }

                if (readConvertName)
                {
                    convertName = reader.Value;
                    Console.WriteLine("Convert name: {0}", reader.Value);
                }
                #endregion

                #region check element read
                readAuthorName = (reader.Name == "name" && reader.NodeType == XmlNodeType.Element);
                readAuthorEmail = (reader.Name == "mail" && reader.NodeType == XmlNodeType.Element);

                folderIn = (reader.Name == "folderIn" && reader.NodeType == XmlNodeType.Element);
                folderOut = (reader.Name == "folderOut" && reader.NodeType == XmlNodeType.Element);
                browse = (reader.Name == "browse" && reader.NodeType == XmlNodeType.Element);

                readBaseName = (reader.Name == "baseName" && reader.NodeType == XmlNodeType.Element);
                readDateName = (reader.Name == "dateName" && reader.NodeType == XmlNodeType.Element);

                readUp = (reader.Name == "up" && reader.NodeType == XmlNodeType.Element);
                readDown = (reader.Name == "down" && reader.NodeType == XmlNodeType.Element);

                readConvertName = (reader.Name == "convertName" && reader.NodeType == XmlNodeType.Element);
                #endregion
            }

            reader.Close();
            reader.Dispose();
        }
    }
}
