using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IWSK_RS232
{
    enum DataFormat { ASCII, HEX, DEC }

    class StringParser
    {
        static Dictionary<char, byte> spCHArray = new Dictionary<char, byte>();

        static StringParser()
        {
            spCHArray.Add('n', 10);
            spCHArray.Add('r', 13);
            spCHArray.Add('0', 9);
            spCHArray.Add('\\', 92);
        }

        public static byte? SpecialCharacter(char sign)
        {
            if (spCHArray.ContainsKey(sign))
                return spCHArray[sign];
            else
                return null;
        }

        public static string ByteToDisplay(byte[] byteArray, DataFormat p = DataFormat.ASCII)
        {
            StringBuilder text = new StringBuilder(byteArray.Length);

            for (int i = 0; i < byteArray.Length; i++)
            {
                switch (p)
                {
                    case DataFormat.HEX:
                        text.Append("{x" + byteArray[i].ToString("X2") + "}");
                        break;

                    case DataFormat.DEC:
                        text.Append("{d" + byteArray[i].ToString("D3") + "}");
                        break;

                    case DataFormat.ASCII:
                        text.Append(Convert.ToChar(byteArray[i]));
                        break;
                }
            }

            return text.ToString();
        }

        public static byte[] StrToByteArray(string str)
        {
            List<byte> conBytes = new List<byte>();
            int i;

            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == '\\')
                {
                    if (i + 1 == str.Length)
                        break;

                    switch (str[i + 1])
                    {
                        case 'x':
                            if (i + 3 == str.Length)
                                break;

                            conBytes.Add(Convert.ToByte(str.Substring(i + 2, 2), 16));
                            i += 3;
                            break;
                        case 'd':
                            if (i + 4 == str.Length)
                                break;

                            conBytes.Add(Convert.ToByte(str.Substring(i + 2, 3), 10));
                            i += 4;
                            break;

                        default:
                            byte? spec = SpecialCharacter(str[++i]);

                            if ( spec != null)
                                conBytes.Add(spec.Value);

                            break;
                    }
                }
                else
                    conBytes.Add(Convert.ToByte(str[i]));
            }

            if (i != str.Length)
                throw new Exception("Nie można sparsować stringa.");

            return conBytes.ToArray();
        }

    }
}
