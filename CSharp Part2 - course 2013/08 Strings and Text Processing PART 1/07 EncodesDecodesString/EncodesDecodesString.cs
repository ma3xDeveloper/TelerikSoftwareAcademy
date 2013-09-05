using System;
using System.Text;

/*
07 Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. 
 The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
 the second – with the second, etc. When the last key character is reached, the next is the first.

ОБЯСНЕНИЕ: 
*/

namespace _07_EncodesDecodesString
{
    class EncodesDecodesString
    {
        static void Main()
        {

            string cipher = Console.ReadLine();
            string str = Console.ReadLine();


            EncoderDecoder(EncoderDecoder(str, cipher), cipher);
        }

        static string EncoderDecoder(string message, string key)
        {
            var strBuilder = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                strBuilder.Append((char)(message[i] ^ key[i % key.Length]));
            }
            Console.WriteLine(strBuilder.ToString());
            return strBuilder.ToString();
        }
    }
}