using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                    int keywordKey = (Constants.ENG_ALPHABET.IndexOf(key[keyword_index]) >= 0)
                        ? Constants.ENG_ALPHABET.IndexOf(key[keyword_index])
                        : Constants.RUS_ALPHABET.IndexOf(key[keyword_index]);

                    int c = (alphabet.IndexOf(symbol) + keywordKey) % alphabet.Length;
                    Console.WriteLine(alphabet.IndexOf(symbol));
                    Console.WriteLine(alphabet.IndexOf(key[keyword_index]));
                    Console.WriteLine(alphabet.Length);

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

                    int keywordKey = (Constants.ENG_ALPHABET.IndexOf(key[keyword_index]) >= 0)
                        ? Constants.ENG_ALPHABET.IndexOf(key[keyword_index])
                        : Constants.RUS_ALPHABET.IndexOf(key[keyword_index]);

                    int p = (alphabet.IndexOf(symbol) + alphabet.Length - keywordKey) % alphabet.Length;

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

        public static void SetDictionaryOfPublicKeys(int number)
        {
            if(CipherForm.DiffieOpenKeysDictionary.Count > 0)
                CipherForm.DiffieOpenKeysDictionary.Clear();

            CipherForm.DiffieOpenKeysDictionary.Add(2, 1);
            CipherForm.DiffieOpenKeysDictionary.Add(3, 2);

            int buff = -1;
            for (int i = 7; i <= number; i++)
            {
                if(isPrime(i))
                {
                    //GetDivid(i);
                    buff = GetPrimitiveRoot(i);
                    if (buff != -1)
                        CipherForm.DiffieOpenKeysDictionary.Add(i, buff);  
                }
            }

            foreach (KeyValuePair<int, int> kvp in CipherForm.DiffieOpenKeysDictionary)
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }

        private static bool isPrime(int number)
        {
            bool result = true;

            for (int i = 2; i < number; i++)
                if (number % i == 0) return false;

            return result;
        }
        
        private static int GetPrimitiveRoot(int p)
        {
            double buff;
            var set = new HashSet<double>();
            for (int i = 2; i < p; i++)
            {
                for (int j = 1; j < p; j++)
                {
                    buff = Math.Pow(i, j) % p;
                    if (buff != 0)
                    {
                        if (set.Contains(buff))
                        {
                            break;
                        }
                        else
                        {
                            set.Add(buff);
                        }
                    }
                }
                if (set.Count == p - 1)
                    return i;
                set.Clear();
            }

            return -1;
        }

        /*private static void GetDivid(int p)
        {
            var divid = new List<int>();
            var minusP = p - 1;
            for (int i = 2; i <= minusP; i++)
            {
                var relat = minusP % i;
                if (relat == 0 && i != minusP)
                    divid.Add(i);
            }
            CalcG(divid, p, minusP);
        }*/

        /*private static void CalcG(List<int> divid, int p, int minusP)
        {
            List<int> g = new List<int>();
            int plus = 0;
            if (p == 2)
                g.Add(2);
            if (p == 3)
                g.Add(2);
            else
            {
                for (int i = 2; i < p; i++)
                {
                    plus = 0;

                    for (int l = 0; l < divid.Count; l++)
                    {
                        var degree = Math.Pow(i, divid[l]);
                        var minusDegree = degree - 1;
                        var divDegree = minusDegree % p;

                        if (divDegree != 0)
                            plus++;
                        else if (divDegree == 0)
                            plus = 0;
                        if (plus == divid.Count)
                        {
                            g.Add(i);
                            plus = 0;
                        }
                    }
                }
                
                foreach (int a in g)
                {
                    Console.WriteLine(a);
                }
            }
        }*/
    }
}
