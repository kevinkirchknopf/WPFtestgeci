using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_quiz.Models;

namespace WPF_quiz.Services
{
    
    public static class KerdesService
    {
        public static Context context = new Context();

        public static void Kerdesfeltoltes(string szoveg, string kategoria, int pontszam, string helyesvalasz, string valasz2, string valasz3, string valasz4)
        {
            context.kerdesek.Add(new Kerdes { Szoveg = szoveg, Kategoria = kategoria, Pontszam = pontszam, Valaszok = new Valaszok { Helyesvalasz = helyesvalasz, Valasz2 = valasz2, Valasz3 = valasz3, Valasz4 = valasz4} });
            context.SaveChanges();
        }

        

    }
}
