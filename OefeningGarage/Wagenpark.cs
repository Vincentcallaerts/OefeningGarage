using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningGarage
{
    class Wagenpark
    {
        public List<Garage> GraragesInParken { get; set; }
        public Wagenpark() 
        {
            GraragesInParken = new List<Garage>();
        }
    }
}
