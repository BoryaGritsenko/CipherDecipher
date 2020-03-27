using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

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

        public static string VigenereEncodeDecode(string text, string key, bool isToCipher)
        {
            string result = "";
            int keywordIndex = 0;

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

                    int p;

                    if (isToCipher)
                        p = (alphabet.IndexOf(symbol) + Math.Abs(alphabet.IndexOf(key[keywordIndex]))) % alphabet.Length;
                    else
                        p = (alphabet.IndexOf(symbol) + alphabet.Length - Math.Abs(alphabet.IndexOf(key[keywordIndex]))) % alphabet.Length;

                    result += alphabet[p];

                    keywordIndex++;

                    if ((keywordIndex + 1) == key.Length)
                        keywordIndex = 0;
                }
            }
            return result;
        }

        public static KeyValuePair<int, int>? SetDictionaryOfPublicKeys(int number)
        {
            if(CipherForm.DiffieOpenKeysDictionary.Count > 0)
                CipherForm.DiffieOpenKeysDictionary.Clear();

            CipherForm.DiffieOpenKeysDictionary.Add(2, 1);
            CipherForm.DiffieOpenKeysDictionary.Add(3, 2);

            int buff;
            for (int i = 5; i <= number; i++)
            {
                if(IsPrime(i))
                {
                    buff = GetPrimitiveRoot(i);
                    if (buff != -1)
                        CipherForm.DiffieOpenKeysDictionary.Add(i, buff);  
                }
            }

            return GetRandomPublicKey();
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
                if (number % i == 0) return false;

            return true;
        }
        
        private static int GetPrimitiveRoot(int prime)
        {
            for (int gen = 2; gen < prime; gen++)
                if (IsPrimitiveRoot(gen, prime))
                    return gen;

            return -1;
        }

        public static bool IsPrimitiveRoot(int gen, int prime)
        {
            double buff;
            var set = new HashSet<double>();

            for (int j = 1; j < prime; j++)
            {
                buff = Math.Pow(gen, j) % prime;

                if (buff != 0 && set.Contains(buff))
                    break;
                else
                    set.Add(buff);
            }
            if (set.Count == prime - 1)
                return true;
            
            return false;
        }

        private static KeyValuePair<int, int>? GetRandomPublicKey()
        {
            int count = CipherForm.DiffieOpenKeysDictionary.Count;

            if (count > 0)
                return CipherForm.DiffieOpenKeysDictionary.ElementAt(new Random().Next(0, count));

            MessageBox.Show(
                "Сначала введите число в поле",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            return null;
        }

        public static BigInteger DiffieHellmanCalcKey(int key, BigInteger gen, BigInteger prime)
        {
            return BigInteger.Remainder(BigInteger.Pow(gen, key), prime);
        }

        public static string TransformKeyString(string text, int key)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                bool isEnglish = Constants.ENG_ALPHABET.IndexOf(text[i]) >= 0;
                bool isRussian = Constants.RUS_ALPHABET.IndexOf(text[i]) >= 0;

                if (!isEnglish && !isRussian)
                    result += text[i];
                else
                {
                    string alphabet = (isEnglish)
                    ? Constants.ENG_ALPHABET
                    : Constants.RUS_ALPHABET;

                    if (i % 2 == 0)
                        result += alphabet.ElementAt(Math.Abs(alphabet.IndexOf(text[i]) - key) % alphabet.Length);
                    else
                        result += alphabet.ElementAt(Math.Abs(alphabet.IndexOf(text[i]) + key) % alphabet.Length);
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}