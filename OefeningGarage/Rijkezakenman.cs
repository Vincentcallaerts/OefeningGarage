using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningGarage
{
    class Rijkezakenman
    {
        public int Krediet { get; set; }
        public List<Wagenpark> Wagenparken { get; set; }
        public Rijkezakenman() 
        {

            Krediet = 1000000;
            Wagenparken = new List<Wagenpark>();

        }
        public void VerkoopWagen(int wagenpark, int garage,int auto)
        {
            Krediet += Wagenparken[wagenpark].GraragesInParken[garage].GarageOpslag[auto].Prijs;
            Wagenparken[wagenpark].GraragesInParken[garage].GarageOpslag.RemoveAt(auto);
        }
        public void KoopWagen(int wagenpark, int garage, Auto auto)
        {          
            Wagenparken[wagenpark].GraragesInParken[garage].GarageOpslag.Add(auto);
            Krediet -= Wagenparken[wagenpark].GraragesInParken[garage].GarageOpslag[Wagenparken[wagenpark].GraragesInParken[garage].GarageOpslag.Count-1].Prijs;
        }
        public void ToonAlles() 
        {

            for (int i = 0; i < Wagenparken.Count; i++)
            {
                for (int j = 0; j < Wagenparken[i].GraragesInParken.Count; j++)
                {
                    for (int k = 0; k < Wagenparken[i].GraragesInParken[j].GarageOpslag.Count; k++)
                    {
                        Console.WriteLine(Wagenparken[i].GraragesInParken[j].GarageOpslag[k].Beschrijf() + $" Deze wagen bevind zich in wagenpark {i} in garage {j}");
                    }
                }
            }

        }
    }
}
