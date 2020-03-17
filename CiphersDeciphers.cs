using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherDecipher
{
    class Constants
    {
        public const string RUS_ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public const string ENG_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    }

    class CiphersDeciphers
    {
        public static string CaesarEncodeDecode(int step, string text)
        {
            string result = "";
            foreach (char symbol in text)
            {
                bool isEnglish = Constants.ENG_ALPHABET.IndexOf(symbol) >= 0;
                bool isRussian = Constants.RUS_ALPHABET.IndexOf(symbol) >= 0;

                if (!isEnglish && !isRussian)
                    result += symbol.ToString();
                else
                {
                    string alphabet = (isEnglish)
                        ? Constants.ENG_ALPHABET
                        : Constants.RUS_ALPHABET;

                    int codeIndex = (alphabet.Length + alphabet.IndexOf(symbol) + step) % alphabet.Length;
                    result += alphabet[codeIndex];
                }
            }

            return result;
        }

        public static string VigenereEncode(string text, string key)
        {
            string result = "";
            int keyword_index = 0;



            foreach (char symbol in text)
            {
                bool isEnglish = Constants.ENG_ALPHABET.IndexOf(symbol) >= 0;
                bool isRussian = Constants.RUS_ALPHABET.IndexOf(symbol) >= 0;

                if (!isEnglish && !isRussian)
                    result += symbol.ToString();
                else
                {
                    string alphabet = (isEnglish)
                        ? Constants.ENG_ALPHABET
                        : Constants.RUS_ALPHABET;

                    int c = (alphabet.IndexOf(symbol) + alphabet.IndexOf(key[keyword_index])) % alphabet.Length;

                    if (alphabet.IndexOf(symbol) < 0)
                        result += symbol;
                    else
                        result += alphabet[c];

                    keyword_index++;

                    if ((keyword_index + 1) == key.Length)
                        keyword_index = 0;
                }
            }
            return result;
        }

        public static string VigenereDecode(string text, string key)
        {
            string result = "";
            int keyword_index = 0;

            foreach (char symbol in text)
            {
                bool isEnglish = Constants.ENG_ALPHABET.IndexOf(symbol) >= 0;
                bool isRussian = Constants.RUS_ALPHABET.IndexOf(symbol) >= 0;

                if (!isEnglish && !isRussian)
                    result += symbol.ToString();
                else
                {
                    string alphabet = (isEnglish)
                        ? Constants.ENG_ALPHABET
                        : Constants.RUS_ALPHABET;

                    int p = (alphabet.IndexOf(symbol) + alphabet.Length - alphabet.IndexOf(key[keyword_index])) % alphabet.Length;

                    if (alphabet.IndexOf(symbol) < 0)
                        result += symbol;
                    else
                        result += alphabet[p];

                    keyword_index++;

                    if ((keyword_index + 1) == key.Length)
                        keyword_index = 0;
                }
            }
            return result;
        }
    }
}
