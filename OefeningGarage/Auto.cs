using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningGarage
{
    class Auto
    {
        public Merk Merk { get; set; }
        public int Prijs { get; set; }
        public int Pk { get; set; }
        
        public Auto(Merk merk, int prijs)
        {
            Merk = merk;
            Prijs = prijs;
            Pk = 200;
        }
        public string Beschrijf()
        {
            return $"Deze auto is van het merk {Merk.Naam} heeft {Pk} Pk en kost {Prijs}";
            
        }
    }
}
