using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApprendreFacilement
{
    class Apprendre
    {
        static void Main(string[] arg)
        {
            // Toutes les bonnes réponses seront stockés ici :
            string title = "Trouve les dates";
            Console.Title = title;
            string anneeWWI = "1914";
            string anneeFinWWI = "1918";
            string pH = "7 décembre 1941";
            string electionHitler = "1933";
            string anneeWWII = "1939";
            string anneeFinWWII = "1945";
            string reponseUne = "0";
            Console.WriteLine("Trouve la date de début de la première guerre mondiale !");
            string reponseUneUser = Console.ReadLine();
            reponseUne = reponseUneUser;
                if (reponseUne == anneeWWI)
            {
                Console.WriteLine();
                Console.WriteLine("Bravo !");
            } else
            {
                Console.WriteLine("Dommage pour toi !");
            }
            string reponseDeux = "0";
            Console.WriteLine();
            Console.WriteLine("Et maintenant la date de fin !");
            string reponseDeuxUser = Console.ReadLine();
            reponseDeux = reponseDeuxUser;
            if (reponseDeux == anneeFinWWI)
            {
                Console.WriteLine();
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine("Dommage pour toi !");
            }
            string reponseTrois = "0";
            string reponseQuatre = "0";
            string reponseCinq = "0";
            string reponseSix = "0";
            Console.WriteLine("Quel est la date de l'attaque de Pearl Harboor");
            string reponseTroisUser = Console.ReadLine();
            reponseTrois = reponseTroisUser;
            if (reponseTrois == pH)
            {
                Console.WriteLine();
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine("Dommage pour toi !");
            }
            Console.WriteLine("En quelle année à été élu Adolf Hitler ?");
            string reponseQuatreUser = Console.ReadLine();
            reponseQuatre = reponseQuatreUser;
            if (reponseQuatre == electionHitler)
            {
                Console.WriteLine();
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine("Dommage pour toi !");
            }
            Console.WriteLine("En quelle année à débuté la seconde guerre mondiale ?");
            string reponseCinqUser = Console.ReadLine();
            reponseCinq = reponseCinqUser;
            if (reponseCinq == anneeWWII)
            {
                Console.WriteLine();
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine("Dommage pour toi !");
            }
            Console.WriteLine("En quelle année s'est t'elle fini ?");
            string reponseSixUser = Console.ReadLine();
            reponseSix = reponseSixUser;
            if (reponseSix == anneeFinWWII)
            {
                Console.WriteLine();
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine("Dommage pour toi !");
            }
            Console.WriteLine();
            Console.WriteLine("🥐 Et voilà tu as fini toutes les questions basiques de cette année de troisièmpe");
        }
    }
}