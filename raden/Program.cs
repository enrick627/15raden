// 5ITN nr4 Enrick De Munter 5/11/2019
/*opgave
 *Ontwikkel een toepassing die de gebruiker vraagt om een willekeurig getal tussen 1 en 5 (grenzen inbegrepen).
    *Dit willekeurig getal wordt gegenereerd door de computer (en kan dus bij elke uitvoering verschillend zijn).
*
*Stel dat het te raden getal 3 is:
*
*- als de gebruiker 3 ingeeft, verschijnt de mededeling `Proficiat, we zochten inderdaad 3!`.
*- als de gebruiker 4 ingeeft, verschijnt de mededeling `Helaas, het te raden getal is niet 4, wel 3.`
 * 
 * Analyse
 * ======
 * BEREKEN   willekeuriggetal ([1-5])(https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number)
 * VRAAG     poging
 * ALS      poging=willekeuriggetal
 * DAN      antwoord := proficiat, we zochten inderdaad <willekeuriggetal>!
 * ANDERS   antwoord := Helaas, het te raden getal is niet <poging>, wel <willekeurigetal>.
 * TOON     antwoord
 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raden
{
    class Program
    {
        static void Main(string[] args)
        {   //DECLARATIES
            byte poging, willekeuriggetal;
            string antwoord;




            //  * BEREKEN   willekeuriggetal ([1-5])(https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number)
            Random rnd = new Random();
            willekeuriggetal =(byte) rnd.Next(1,6);

            //input
            //VRAAG     poging
            Console.WriteLine("raad het getal");
            poging = byte.Parse( Console.ReadLine());

            //processing
            // ALS      poging=willekeuriggetal
            if (poging==willekeuriggetal)
            {// DAN      antwoord := proficiat, we zochten inderdaad <willekeuriggetal>!
                antwoord = $"proficiat het getal dat we zochten is inderdaad juist";

            }
            else
            {// ANDERS   antwoord := Helaas, het te raden getal is niet <poging>, wel <willekeurigetal>.
                antwoord = $"helaas het getal dat we zochten is niet {poging} maar wel {willekeuriggetal}";
            }




            //output
            // TOON     antwoord
            Console.WriteLine();
            Console.WriteLine(antwoord);

            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
           
            
        }
    }
}
