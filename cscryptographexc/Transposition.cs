using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace cscryptographexc
{
	internal static class Transposition
	{
		//remaps the key so that it can be used for the opposite funtion
		public static int[] ReverseKey(int[] key)
		{
			int[] opkey = new int[key.Length];
			for (int i = 0; i < key.Length; i++)
				opkey[key[i] - 1] = i + 1;
			return opkey;
		}
		//kato izleze uslovieto trq opravq imenata ⚠️
		public static string Transpos(string input, int[] key)
		{
			string output = "";
			//int[] opkey = ReverseKey(key);

			for (int i = 0; i < input.Length; i++)
			{
				//idx of the current block
				int bidx = i % key.Length;
				//rearranges the symbols according to the key
				output += input[i - bidx + key[bidx] - 1];
			}

			return output;
		}
		public static string ColTranspos(string input, int n)
		{
			string output = "";
			for (int i = 0; i < input.Length; i++)
			{
                //row idx
				int bidx = i % (input.Length / n);
				//gets the curr transposed symbol in the mtx
				output += input[bidx * n + i / (input.Length / n)];
            }
			return output;
		}
	}
}
