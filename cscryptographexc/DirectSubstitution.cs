using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscryptographexc
{
	internal static class DirectSubstitution
	{
		public static string PolybiusDec(string encrypted)
		{
			string decrypted = "";

			for (int i = 0; i < encrypted.Length; i++)
			{
				int charidx = (encrypted[i++] - '1') * 5 + encrypted[i] - '1';
				decrypted += (char)('A' + charidx + (charidx < 9 ? 0 : 1));
			}
			return decrypted;
		}
		public static string PolybiusEnc(string input)
		{
			string output = "";

            for (int i = 0; i < input.Length; i++)
            {
				int charidx = input[i] - 'A';
				//only works w/ the example given that doesnt incl. i/j
				if (charidx > 8) charidx--;
				output += ""+(char)(charidx/5 + '1') + (char)(charidx%5 + '1');
            }
            return output;
		}
		static string CaesarCipher(string input, int padding)
		{
            string output = "";

            for (int i = 0; i < input.Length; i++)
                output += (char)('A' + (input[i] - 'A' + padding) % 26);
            return output;
        }
		public static string CaesarEncrypt(string input)
		{
			return CaesarCipher(input, 3);
		}
        public static string CaesarDecrypt(string input)
        {
            //decreases the symbol's index therefore adds 26-3mod26 
			return CaesarCipher(input, 23);
        }
        public static string Trithemius(string input, string key)
		{
			string output = "";

			for (int i = 0; i < input.Length; i++)
				output += (char)('A' + (input[i] - 'A' + key[i % key.Length] - 'A'+1) % 26);
			return output;
		}
		//should add delegate arg instead
        public static string VijenerEncrypt(string input, string key)
        {
            string output = "";
			//adds key idx to the original symbol
            for (int i = 0; i < input.Length; i++)
                output += (char)('A' + (input[i] - 'A' + key[i % key.Length] - 'A') % 26);
            return output;
        }
        public static string VijenerDecrypt(string input, string key)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
                output += (char)('A' + (input[i] - 'A' + 26 -  (key[i % key.Length] - 'A')) % 26);
            return output;
        }
    }
}
