using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscryptographexc
{
    internal class Substitution
    {
        public static string SimpleEncrypt(string input, int k1, int k2)
        {
            string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ";
            string output = "";
            //j=(k1*i+k2)%n
            foreach (var ch in input)
                output += alphabet[((alphabet.IndexOf(ch)+1) * k1 + k2) % alphabet.Length-1];
            return output;
        }
        public static string DirectEncrypt(string input)
        {
            string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ";
            int[] substitutionMap = new int[] { 30, 20, 10, 40, 50, 60, 31, 21, 11, 41, 51, 61, 32, 22, 12, 42, 52, 62, 80, 89, 76 ,99 ,13, 68, 78, 45, 56, 35, 66, 58};
            
            string output = "";
            foreach (var ch in input)
                output += substitutionMap[alphabet.IndexOf(ch)].ToString();
            return output;
        }
        public static string DirectDecrypt(string input)
        {
            string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ";
            int[] substitutionMap = new int[] { 30, 20, 10, 40, 50, 60, 31, 21, 11, 41, 51, 61, 32, 22, 12, 42, 52, 62, 80, 89, 76, 99, 13, 68, 78, 45, 56, 35, 66, 58 };

            string output = "";
            for (int i = 0; i < input.Length; i +=2)
            {
                int num;
                if (!int.TryParse(input.Substring(i, 2), out num)) return null;
                output += "" + alphabet[Array.IndexOf(substitutionMap,num)];
            }
            return output;
        }
    }
}
