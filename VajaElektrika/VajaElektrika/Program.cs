using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaElektrika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElektrikaEntities1 en=new ElektrikaEntities1();
            //1. izberi čas meritve in skupno moč
            //ista poizvedba z lambda izrazom
            var x1 = en.Meritve.Select(a => new { a.ZapisČas, moč = a.kW1 + a.kW2 + a.kW3 }).Take(10);
            foreach (var y in x1)
            {
                Console.WriteLine(y.ZapisČas+" "+y.moč);
            }

            //2. izberi čas meritve in skupno moč za datum 18.8.2013
            DateTime d1 = DateTime.Parse("18.8.2013");
            DateTime d2 = DateTime.Parse("19.8.2013");
            var x2 = en.Meritve.Where(a => a.ZapisČas>=d1 && a.ZapisČas<d2);
            //foreach (var y in x2)
            //{
            //    Console.WriteLine(y.ZapisČas );
            //}
            //3. izračunaj povprečno moč za datum 18.8.2013
            var x3 = x2.Average(e => e.kW1 + e.kW2 + e.kW3);
            Console.WriteLine("Povprečje je "+x3);
            //4. izračunaj maximalno moč za ta datum
            var x4 = x2.Max(e => e.kW1 + e.kW2 + e.kW3);
            Console.WriteLine("Maximum je " + x4);
            //5. izračunaj minimalno moč za ta datum
            var x5 = x2.Min(e => e.kW1 + e.kW2 + e.kW3);
            Console.WriteLine("Minimum je " + x5);
            //6. izračunaj povprečno moč po urah za dan 18.8.2013
            var x6 = x2.GroupBy(e => e.ZapisČas.Value.Hour).OrderBy(e=>e.Key).
                Select(e=>new { Ura=e.Key,Moč=e.Average(a=>a.kW1+a.kW2+a.kW3)});
            Console.WriteLine("****************************");
            foreach (var y in x6)
            {
                Console.WriteLine(y.Ura+"\t"+y.Moč);
            }
            //7. izračunaj 15 minutna povprečja za 18.8.2013
            var x7 = x2.GroupBy(e => new { ura = e.ZapisČas.Value.Hour, četrt = e.ZapisČas.Value.Minute / 15 }).
                OrderBy(e => e.Key.ura).
                Select(e => new { Ura = e.Key.ura, Četrt = e.Key.četrt, Moč = e.Average(a => a.kW1 + a.kW2 + a.kW3) });
            foreach (var y in x7)
            {
                Console.WriteLine(y.Ura + "\t" +y.Četrt+"\t"+ y.Moč);
            }
            Console.ReadLine();
        }
    }
}
