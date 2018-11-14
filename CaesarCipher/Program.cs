using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encryption.encrypt("ABCDEFGHIKLMNOPQRSTVXYZ", 2));

            Console.WriteLine(Encryption.decrypt("CDEFGHIKLMNOPQRSTVXYZAB", 2));

            Console.ReadLine();
        }
    }
}
