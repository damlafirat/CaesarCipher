using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Encryption
    {
        public static string decrypt(string v1, int v2)
        {
            string result = "";

            char[] arr = v1.ToLower().ToCharArray();

            char temp;

            foreach (var item in arr)
            {
                if (item >= 'a' && item <= 'z')
                {
                    temp = (char)(item - v2);

                    if (temp > 'z')
                        temp = (char)(temp - 26);

                    else if (temp < 'a')
                        temp = (char)(temp + 26);
                }

                else
                    temp = item;

                result += temp;
            }

            return result;
        }

        public static string encrypt(string v1, int v2)
        {
            string result = "";

            char[] arr = v1.ToLower().ToCharArray();

            char temp;

            foreach (var item in arr)
            {
                if (item >= 'a' && item <= 'z')
                {
                   temp  = (char)(item + v2);

                    if (temp > 'z')
                        temp = (char)(temp - 26);

                    else if (temp < 'a')
                        temp = (char)(temp + 26);
                }

                else
                    temp = item;

                result += temp;
            }
            

            return result;
        }
    }
}
