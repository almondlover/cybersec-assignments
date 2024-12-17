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
            //menu???
            //da namerq #2 kade e
            //#3
            //encode - dont reverse key for decoding
            //da sloja decode kato izleze uslovieto
            Console.WriteLine(Transposition.Transpos("СРЕЩИТЕ СА В МИЛАНО ЛОНДОН И БЕЛГРАД", 
                                                        Transposition.ReverseKey(new int[] { 4, 5, 3, 2, 1, 6 })));
            int[] key = new int[] { 1, 5, 3, 4, 2 };
            string encoded = Transposition.Transpos("ПРЕДПОЧИТАМ МАРКАТА АЛФА-РОМЕО",
                                                        Transposition.ReverseKey(key));
            Console.WriteLine(Transposition.ColTranspos(encoded, key.Length));
            
            Console.WriteLine(Combined.ZorgeCipher("MYVACATIONSTARTSON/5/APRIL."));

            Elgamal.FindKey();
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
