namespace GUIffmpeg
{
    public static class AuxiliaryFunctions
    {
        public static string numberNDigits(int number, int nDigits)
        {
            string valOut = number.ToString();

            int initialNumberOfValues = valOut.Length;

            for (int i = 0; i < nDigits - initialNumberOfValues; i++)
                valOut = "0" + valOut;

            return valOut;
        }
    }
}
