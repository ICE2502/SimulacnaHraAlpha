using System.Collections.Generic;
using SimulacnaHra.prvkyHry.vyroba;

namespace SimulacnaHra.prvkyHry.mapa
{
    /// <summary>
    /// Polocná trieda na určenie, čo je ešte potrebné vykresliť
    /// </summary>
    public static class Vykreslene
    {
        private static HashSet<Vyroba> aVykreslenaVyroba;

        /// <summary>
        /// Pri každom prekreslení sa reštartuje
        /// </summary>
        public static void Tik()
        {
            aVykreslenaVyroba = new HashSet<Vyroba>();
        }

        /// <summary>
        /// Pridanie výroby
        /// </summary>
        /// <param name="paVyroba">pridavana výroba</param>
        /// <returns>návratové hodnota</returns>
        public static bool PridajVyrobu(Vyroba paVyroba)
        {
            return aVykreslenaVyroba.Add(paVyroba);
        }
    }
}