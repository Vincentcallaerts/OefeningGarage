using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningGarage
{
    class Garage
    {
        public List<Auto> GarageOpslag { get; set; }
        public Garage() 
        {

            GarageOpslag = new List<Auto>();

        }
    }
}
