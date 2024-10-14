using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscryptographexc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Polybius("13231133221544231552344231141542241313311135443433"));
            Console.WriteLine(Vijener("SECURITY", "ITALY"));
        }
        static string Polybius(string encrypted)
        {
            string decrypted = "";

            for (int i = 0; i < encrypted.Length; i++)
            {
                int charidx = (encrypted[i++] - '1') * 5 + encrypted[i] - '1';
                decrypted += (char)('A' + charidx + (charidx < 9 ? 0 : 1));
            }
            return decrypted;
        }
        static string Vijener(string input, string key)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output += (char)('A' + (input[i] - 'A' + key[i % key.Length] - 'A') % 26);
            }
            return output;
        }
    }
}
