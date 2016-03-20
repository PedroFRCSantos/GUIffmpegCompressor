using System.Globalization;

namespace GUIffmpeg
{
    public partial class LanguageManager
    {
        private string languageName;

        #region translation's author
        private string authorNameStr = "";
        private string authorEmailStr = "";
        #endregion

        #region folder in out translation
        private string folderInStr;
        private string folderOutStr;
        private string browseStr;
        #endregion

        #region up down translation name
        private string upButtonName;
        private string downButtonName;
        #endregion

        private string dateName;

        #region variables date format
        private string dateFormat1;
        private string dateFormat2;
        private string dateFormat3;
        #endregion

        #region variables month tranlation name
        private string nameJanuary;
        private string nameFebruary;
        private string nameMarch;
        private string nameApril;
        private string nameMay;
        private string nameJune;
        private string nameJuly;
        private string nameAugust;
        private string nameSeptember;
        private string nameOctober;
        private string nameNovember;
        private string nameDecember;
        #endregion

        private string baseName;
        private string userName;

        private string convertName;

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
            dateName = "File Date";

            dateFormat1 = "DDMMYYYYHHMMSS";
            dateFormat2 = "YYYYMMDDHHMMSS";
            dateFormat3 = "DDMouthYYYYHHMMSS";

            nameJanuary = "January";
            nameFebruary = "February";
            nameMarch = "March";
            nameApril = "Abril";
            nameMay = "May";
            nameJune = "June";
            nameJuly = "July";
            nameAugust = "August";
            nameSeptember = "September";
            nameOctober = "October";
            nameNovember = "November";
            nameDecember = "December";

            baseName = "Base Name (empty)";
            userName = "User Name";

            convertName = "Convert";

            // try to open xml and read information
            readXMLInformation();
        }
    }
}
