using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_quiz.Models
{
    public class Kerdes
    {
        public int Id { get; set; }
        public string Szoveg { get; set; }
        public string Kategoria { get; set; }
        public int Pontszam { get; set; }
        public Valaszok Valaszok { get; set; }
    }
}
