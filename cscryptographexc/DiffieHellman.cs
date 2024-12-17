using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscryptographexc
{
    internal static class DiffieHellman
    {
        static string Encrypted(string input, int[,] nums)
        {
            //the final key to be used with the transpos mthd
            int[] key = new int[nums.GetLength(0)];
            //fetches all public keys and assembles the final key
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                int aliceKey = Key(new int[] { nums[i, 0], nums[i, 1], nums[i, 2] });
                int bobKey = Key(new int[] { nums[i, 0], nums[i, 1], nums[i, 3] });
                if (aliceKey == bobKey) Console.WriteLine("nice ヾ(⌐■_■)ノ♪");
                else return "l";
                key[i] = aliceKey;
            }
            return Transposition.Transpos(input, key);
        }
        //semantics ig
        public static int PrivateKey(int[] nums)
        {
            //q^amodp
            return (int)Math.Pow(nums[1], nums[2]) % nums[0];
        }
        static int Key(int[] nums)
        {
            return (int)Math.Pow(PrivateKey(nums), nums[2]) % nums[0];
        }
    }
}
