using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsihroniTaski
{
    class Coffee
    { }
    class Egg { }
    class Bacon { }
    class Toast { }
    class Juice { }

    internal class Program
    {
        static async  Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("kava je pripravljena");
            Task<Egg> eggs =  FryEggs(2);
            //Console.WriteLine("jajca so cvrta");
            Task<Bacon> bacon =FryBacon(3);
            //Console.WriteLine("slanina je crvta");
            Toast toast = await ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast je pečen");
            Juice oj = PourOJ();
            Console.WriteLine("sok je pripravljen");
            ////Egg jajca = await eggs;
            ////Console.WriteLine("jajca so cvrta");
            ////Bacon salam = await bacon;
            ////Console.WriteLine("slanina je crvta");
            await Task.WhenAll(eggs, bacon);
            Console.WriteLine("Zajtrk je pripravljen!");
            Console.ReadLine();

        }
        private static Juice PourOJ()
        {
            Console.WriteLine("Stiskanje soka iz pomaranč");
            return new Juice();
        }
        private static void ApplyJam(Toast toast) => Console.WriteLine("Dodajanje džema na toast");
        private static void ApplyButter(Toast toast) => Console.WriteLine("Dodajanje masla na toast");

        private static async Task<Toast> ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
                Console.WriteLine("Dodajam košček toasta v toaster");
            Console.WriteLine("Začenjam peči...");
            await Task.Delay(3000);
            Console.WriteLine("Ostrani toast iz toasterja");
            return new Toast();
        }
        private static async Task<Bacon> FryBacon(int slices)
        {
            Console.WriteLine($"dodajanje {slices} kosov slanine v ponev");
            Console.WriteLine("pečenje ene strani slanine...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
                Console.WriteLine("Obračanje slanine");
            Console.WriteLine("pečenje druge strani slanine...");
            await Task.Delay(3000);
            Console.WriteLine("Daj slanino na krožnik");
            return new Bacon();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Kuhanje kave");
            return new Coffee();
        }
        private static async Task<Egg> FryEggs(int howMany)
        {
            Console.WriteLine("Segrevanje ponve...");
            await Task.Delay(3000);
            Console.WriteLine($"razbijanje {howMany} jajc");
            Console.WriteLine("cvretje jajc ...");
            await Task.Delay(3000);
            Console.WriteLine("Daj jajca na krožnik");
            return new Egg();
        }

    }
}
