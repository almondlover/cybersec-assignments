using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscryptographexc
{
	internal static class Combined
	{
		public static string ZorgeCipher(string input)
		{
			string key = "SUNDAY";
			string output = "";
			//💀☠️☠️☠️☠️☠️
			string letters = "ETAONRIS";
			string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ./  ";
			//sum mtx
			int[,] abmtx = new int[5, 6];
			for (int i = 0; i < 5; i++)
				for (int j = 0; j < 6; j++)
					abmtx[i, j]--;
			//trq se opravi
			for (int i = 0; i < key.Length; i++)
				alphabet=alphabet.Remove(alphabet.IndexOf(key[i]), 1);
			alphabet=alphabet.Insert(0, key);

			for (int i = 0; i < letters.Length; i++)
			{
				int idx = alphabet.IndexOf(letters[i]);
				abmtx[idx/6, idx%6]=i; 
			}
			//for (int i = 0; i < 6; i++)
			//	abmtx[0, i] = letters.IndexOf(key[i]);
			for (int i = 0, num = 80; i < 6; i++)
				for (int j = 0; j < 5; j++)
					if (abmtx[j,i] < 0) abmtx[j, i] = num++;
			//fuck kakvo kriptirsm ☠️⚠️
			//use dict?
			for (int i=0; i<input.Length;  i++)
			{
				int abidx = alphabet.IndexOf(input[i]);
				//should check for / instead
				output += abidx < 0?"" + input[i]+ input[i]:abmtx[abidx / abmtx.GetLength(1), abidx % abmtx.GetLength(1)].ToString();
			}
			while (output.Length%5!=0) 
				output+='0';
			//454 16 4
			//TODO: the rest of the alg
			return output;
		}
	}
}
