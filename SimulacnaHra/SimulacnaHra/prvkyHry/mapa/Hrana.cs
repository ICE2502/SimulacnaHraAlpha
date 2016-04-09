
using System.Collections.Generic;

namespace SimulacnaHra.prvkyHry.mapa
{
    /// <summary>
    /// Hrana v digrafe, má dva vrcholy a zoznam políčok po ktorých vedie
    /// </summary>
    public class Hrana
    {
        public Vrchol Vrchol1 { get; set; }
        public Vrchol Vrchol2 { get; set; }
        private List<Policko> aPolicka;

        /// <summary>
        /// vytvorenie
        /// </summary>
        public Hrana()
        {
            aPolicka = new List<Policko>();
        }

        /// <summary>
        /// Pridanie políčka
        /// </summary>
        /// <param name="paPolicko">pridávané políčko</param>
        public void PridajPolicko(Policko paPolicko) 
        {
            aPolicka.Add(paPolicko);
        }

        /// <summary>
        /// Vráti hodnotu hrany
        /// </summary>
        /// <returns>hodnoty hrany</returns>
        public int DajHodnotu() {
            return aPolicka.Count +1;
        }

        /// <summary>
        /// Vráti políčko na zadanom indexe
        /// </summary>
        /// <param name="paIndex">index políčka</param>
        /// <returns>políčko</returns>
        public Policko DajPolicko(int paIndex) 
        {
            return aPolicka[paIndex];
        }

    }
}
