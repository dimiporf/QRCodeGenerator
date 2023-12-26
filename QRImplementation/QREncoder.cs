namespace QRImplementation
{
    public enum QREncodingMode
    {
        Numeric,
        Alphanumeric,
        Byte,
        Kanji,
        Unknown
    }
    public class QREncoder
    {
        public QREncodingMode DetermineEncodingMode(string data)
        {
            if (IsNumeric(data))
            {
                return QREncodingMode.Numeric;
            }
            else if (IsAlphanumeric(data))
            {
                return QREncodingMode.Alphanumeric;
            }
            else if (IsByte(data))
            {
                return QREncodingMode.Byte;
            }
            else if (IsKanji(data))
            {
                return QREncodingMode.Kanji;
            }

            return QREncodingMode.Unknown;
        }

        private bool IsNumeric(string data)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(data, "^[0-9]+$");
        }

        private bool IsAlphanumeric(string data)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(data, "^[A-Z0-9 $%*+-./:]*$");
        }

        private bool IsByte(string data)
        {
            // For simplicity, we assume ISO-8859-1 character set
            return System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(data).Length == data.Length;
        }

        private bool IsKanji(string data)
        {
            // For simplicity, we don't implement a real check for Kanji characters
            // You may need to implement a more sophisticated check based on the Shift JIS character set
            return false;
        }
    }
}
