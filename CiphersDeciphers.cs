using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherDecipher
{
    class CiphersDeciphers
    {
        public static string CaesarCipherDecipher(int step, string text)
        {
            string fullRusAlphabet = CipherForm.RUS_ALPHABET + CipherForm.RUS_ALPHABET.ToLower();
            string fullEngAlphabet = CipherForm.ENG_ALPHABET + CipherForm.ENG_ALPHABET.ToLower();
            string fullAlphabet = fullRusAlphabet + fullEngAlphabet;

            int letterRusQty = fullRusAlphabet.Length;
            int letterEngQty = fullEngAlphabet.Length;

            string retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (fullAlphabet.IndexOf(text[i]) < 0)
                    retVal += text[i].ToString();
                else
                {
                    if (fullAlphabet.IndexOf(text[i]) > 65)
                    {
                        int index = Math.Abs(fullAlphabet.Length - fullAlphabet.IndexOf(text[i]) - fullEngAlphabet.Length);
                        int codeIndex = (letterEngQty + index + step) % letterEngQty;
                        retVal += fullEngAlphabet[codeIndex];
                    }
                    else
                    {
                        int codeIndex = (letterRusQty + fullAlphabet.IndexOf(text[i]) + step) % letterRusQty;
                        retVal += fullRusAlphabet[codeIndex];
                    }
                }
            }

            return retVal;
        }
    }
}
