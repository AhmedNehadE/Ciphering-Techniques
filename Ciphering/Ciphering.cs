using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO; 

namespace Ciphering
{
    static class Ciphering
    {
        public static List<char> playfairKey = new List<char>();
        public static bool HaveNoDuplicates(string x)
        {
            x = x.ToLower();
            for (int i = 0; i < x.Length; i++)
            {
                if (x.IndexOf(x[i]) != i || x.LastIndexOf(x[i]) != i)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool GenerateMatrix(string key)
        {
            key = key.ToLower();
            if (HaveNoDuplicates(key))
            {
                int currentInKey = 0;
                char currentChar = 'a';
                bool foundIorJ = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (currentInKey < key.Length)
                        {
                            playfairKey.Add(key[currentInKey]);
                            if (key[currentInKey] == 'i' || key[currentInKey] == 'j')
                            {
                                currentInKey++;
                                foundIorJ = true;
                            }
                            else
                            {
                                currentInKey++;
                            }
                        }
                        else
                        {
                            if (key.IndexOf(currentChar) > key.Length || key.IndexOf(currentChar) < 0)
                            {
                                if ((currentChar == 'i' || currentChar == 'j') && !foundIorJ)
                                {
                                    playfairKey.Add(currentChar);
                                    currentChar = (char)((int)currentChar + 2);
                                }
                                else
                                {
                                    playfairKey.Add(currentChar);
                                    currentChar = (char)((int)currentChar + 1);
                                }
                            }
                            else
                            {
                                currentChar = (char)((int)currentChar + 1);
                                j--;
                            }
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string PlayFairEncrypt(string plainText)
        {
            plainText = plainText.ToLower();
            plainText = plainText.Replace(" ", "");
            plainText = plainText.Length % 2 != 0 ? plainText + 'x' : plainText;
            string cipherText = "";
            int i1, i2, j1, j2, c1i, c2i, temp;
            for (int i = 0; i < plainText.Length; i += 2)
            {
                c1i = playfairKey.IndexOf(plainText[i]);
                c2i = playfairKey.IndexOf(plainText[i + 1]);
                i1 = c1i / 5; i2 = c2i / 5; j1 = c1i % 5; j2 = c2i % 5;
                if (i1 == i2)
                {
                    j1 = (++j1) % 5;
                    j2 = (++j2) % 5;
                }
                else if (j1 == j2)
                {
                    i1 = (++i1) % 5;
                    i2 = (++i2) % 5;
                }
                else
                {
                    temp = j1; j1 = j2; j2 = temp;
                }
                cipherText += playfairKey[(i1 * 5) + j1];
                cipherText += playfairKey[(i2 * 5) + j2];
            }
            return cipherText;
        }
        public static string PlayFairDecrypt(string cipherText)
        {
            cipherText = cipherText.Replace(" ", "");
            cipherText = cipherText.ToLower();
            string plainText = "";
            int i1, i2, j1, j2, c1i, c2i, temp;
            for (int i = 0; i < cipherText.Length; i += 2)
            {
                c1i = playfairKey.IndexOf(cipherText[i]);
                c2i = playfairKey.IndexOf(cipherText[i + 1]);
                i1 = c1i / 5; i2 = c2i / 5; j1 = c1i % 5; j2 = c2i % 5;
                if (i1 == i2)
                {
                    j1 = j1 - 1 < 0 ? (--j1) + 5 : (--j1);
                    j2 = j2 - 1 < 0 ? (--j2) + 5 : (--j2);
                }
                else if (j1 == j2)
                {
                    i1 = i1 - 1 < 0 ? (--i1) + 5 : (--i1);
                    i2 = i2 - 1 < 0 ? (--i2) + 5 : (--i2);
                }
                else
                {
                    temp = j1; j1 = j2; j2 = temp;
                }
                plainText += playfairKey[(i1 * 5) + j1];
                plainText += playfairKey[(i2 * 5) + j2];
            }
            return plainText;
        }
        public static void ShowPlayFairKey()
        {
            Console.WriteLine("\nPlay fair key :");
            for (int i = 0; i < playfairKey.Count; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(playfairKey[i] + " ");
            }
            Console.WriteLine();
        }
        public static string VigenereEncrypt(string plainText, string key)
        {
            plainText = plainText.Replace(" ", "");
            plainText = plainText.ToLower();
            key = key.ToLower();
            string cipherText = "";
            int current = 0;
            for (int i = 0; i < plainText.Length; i++)
            {
                current = ((int)(plainText[i]) - 97) + ((int)(key[i % key.Length]) - 97);
                if (current >= 26)
                {
                    current -= 26;
                }
                current += 97;
                cipherText += (char)(current);
            }
            return cipherText;
        }
        public static string VigenereDecrypt(string cipherText, string key)
        {
            cipherText = cipherText.Replace(" ", "");
            cipherText = cipherText.ToLower();
            key = key.ToLower();
            string plainText = "";
            int current = 0;
            for (int i = 0; i < cipherText.Length; i++)
            {
                current = ((int)(cipherText[i]) - 97) - ((int)(key[i % key.Length]) - 97);
                if (current < 0)
                {
                    current+=26;
                }
                current += 97;
                plainText += (char)(current);
            }
            return plainText;
        }
        public static string CesarEncrypt(string plainText, int key)
        {
            plainText = plainText.ToLower();
            string cipherText = "";
            char current = ' ';
            for (int i = 0; i < plainText.Length; i++)
            {
                current = plainText[i];

                if (current == ' ')
                {
                    cipherText += ' ';
                }
                else if (((int)current + key) < 123)
                {
                    cipherText += (char)((int)current + key);
                }
                else
                {
                    cipherText += (char)(((int)current + key) - 26);
                }
            }
            return cipherText;
        }
        public static string CesarDecrypt(string cipherText, int key)
        {
            cipherText = cipherText.ToLower();
            string plainText = "";
            char current = ' ';
            for (int i = 0; i < cipherText.Length; i++)
            {
                current = cipherText[i];
                if (current == ' ')
                {
                    plainText += ' ';
                }
                else if (((int)current - key) >= 97)
                {
                    plainText += (char)((int)current - key);
                }
                else
                {
                    plainText += (char)(((int)current - key) + 26);
                }
            }
            return plainText;
        }
        public static string DesEncryption(string plainText, string key)
        {
            using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                ICryptoTransform encryptor = provider.CreateEncryptor(keyBytes, keyBytes);
                var ms = new MemoryStream();
                var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                byte[] cipherTextBytes = Encoding.UTF8.GetBytes(plainText);
                cs.Write(cipherTextBytes, 0, cipherTextBytes.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }

        }
        public static string DesDecryption(string cipherText, string key)
        {
            byte[] buffer = Convert.FromBase64String(cipherText);
            using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                ICryptoTransform encryptor = provider.CreateDecryptor(keyBytes, keyBytes);
                var ms = new MemoryStream();
                var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                cs.Write(buffer, 0, buffer.Length);
                cs.FlushFinalBlock();
                return Encoding.UTF8.GetString(ms.ToArray());
            }

        }
    }
}
