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
            foreach (var y in x2)
            {
                Console.WriteLine(y.ZapisČas );
            }
            //3. izračunaj povprečno moč za datum 18.8.2013
            //4. izračunaj maximalno moč za ta datum
            //5. izračunaj minimalno moč za ta datum
            //6. izračunaj povprečno moč po urah za dan 18.8.2013
            //7. izračunaj 15 minutna povprečja za 18.8.2013
            Console.ReadLine();
        }
    }
}
