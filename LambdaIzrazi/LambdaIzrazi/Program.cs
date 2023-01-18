using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaIzrazi
{
    internal class Program
    {
        //delegate bool FunkcijaZaNize(string s);
        static void Main(string[] args)
        {
            string[] imena = {"David","Blaž","Ivan","Neža","Alen","Saša","Erik","Simon",
            "Mitja","Kristjan"};
            List<string> a = DelajOperacijeNadNizi(imena, ZačneSS);

            

           // List<string> b = DelajOperacijeNadNizi(imena, delegate (string s) { return s.EndsWith("n"); });
            List<string> b = DelajOperacijeNadNizi(imena, s=> s.EndsWith("n"));
            foreach (string x in b)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
        static List<string> DelajOperacijeNadNizi(string[] mojiNizi, Func<string,bool> mojaFuncija)
        {
            List<string> rezultat = new List<string>();
            foreach (string x in mojiNizi)
            {
                if (mojaFuncija(x))
                    rezultat.Add(x);
            }
            return rezultat;
        }
        static bool ZačneSS(string a)
        {
            return a.StartsWith("S");
        }
        //static bool KončaZN(string a)
        //{
        //    return a.EndsWith("n");
        //}
    }
}
