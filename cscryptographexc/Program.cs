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
            //upr1
            Console.WriteLine("Квадрат на Полибий\n\n"+DirectSubstitution.PolybiusDec("13231133221544231552344231141542241313311135443433"));
            Console.WriteLine(DirectSubstitution.PolybiusEnc("HELLOWORLD"));
            Console.WriteLine("\nШифър на Цезар\n\n" + DirectSubstitution.CaesarEncrypt("INFORMATICS"));
            Console.WriteLine(DirectSubstitution.CaesarDecrypt("KHOORZRUOG"));
            Console.WriteLine("\nМетод на абат Тритемиус\n\n" + DirectSubstitution.Trithemius("INTERNATIONALCONFERENCE", "INFO"));
            Console.WriteLine("\nШифър на Виженер\n\n" + DirectSubstitution.VijenerEncrypt("SECURITY", "ITALY"));
            Console.WriteLine(DirectSubstitution.VijenerDecrypt("KHMASBXR", "ITALY"));
            //#2
            Console.WriteLine("\nПросто едноазбучно заместване\n\n" + Substitution.SimpleEncrypt("СОФТУЕР", 3, 2));
            Console.WriteLine("\nДиректно заместване\n\n" + Substitution.DirectEncrypt("ЗАЩИТАНАЛИЧНИТЕДАННИ"));
            Console.WriteLine(Substitution.DirectDecrypt("621140895222113260525111"));
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
    }
}
