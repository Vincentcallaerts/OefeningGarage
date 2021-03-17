using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningGarage
{
    class Merk
    {
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public Merk(string naam, string beschrijving)
        {
            Naam = naam;
            Beschrijving = beschrijving;
        }
    }
}
