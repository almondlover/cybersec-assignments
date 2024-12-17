using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscryptographexc
{
    internal class Elgamal
    {
        public static void FindKey()
        {
            //p,g,x,y
            int[] nums = new int[] {23, 11, 0, 0 };
            //kakvo se sluchva
            //semantika veche nqma mai
            nums[2] = 6;
            nums[3] = DiffieHellman.PrivateKey(new int[] { nums[0], nums[1], nums[2] });

            int sessionKey = 3;
            int explicitMessage = 10;

            int[] ab = new int[] { DiffieHellman.PrivateKey(new int[] { nums[0], nums[1], sessionKey }),
                                 PrivateKey(new int[] { nums[0], nums[3], sessionKey }, explicitMessage)};
            Console.WriteLine($"{nums[3]}  {ab[0]}  {ab[1]}");

            //decrypt
            //sessionKey = (int)DiffieHellman.PrivateKey(new int[] { nums[0], ab[0], (nums[0] - 1 - nums[2]) }, ab[1]);
            //Console.WriteLine($"sesiiniqt e {sessionKey}");
        }
        public static int PrivateKey(int[] nums, int multiplyer)
        {
            //q^amodp
            return (int)Math.Pow(nums[1], nums[2]) * multiplyer % nums[0];
        }
    }
}
