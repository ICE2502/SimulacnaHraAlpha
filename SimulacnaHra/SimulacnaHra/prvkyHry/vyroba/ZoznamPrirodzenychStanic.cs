using System.Collections.Generic;
using SimulacnaHra.prvkyHry.infrastruktura;

namespace SimulacnaHra.prvkyHry.vyroba
{
    /// <summary>
    /// Zoznam staníc, ktoré sú súčasťou ropných plošín
    /// </summary>
    public class ZoznamPrirodzenychStanic
    {

        private List<ZoskupenieStanic> aZoskupenia;
        private static ZoznamPrirodzenychStanic aInstancia = null;

        /// <summary>
        /// zoznam zospupení
        /// </summary>
        public List<ZoskupenieStanic> Zoskupenia {
            get { return aZoskupenia; }
        }

        private ZoznamPrirodzenychStanic()
        {
            aZoskupenia = new List<ZoskupenieStanic>();
        }

        public static ZoznamPrirodzenychStanic DajInstanciu()
        {
            return aInstancia ?? (aInstancia = new ZoznamPrirodzenychStanic());
        }

        /// <summary>
        /// pridanie do zoznamu
        /// </summary>
        /// <param name="paZosk"></param>
        public void Pridaj(ZoskupenieStanic paZosk)
        {
            aZoskupenia.Add(paZosk);
        }
    }
}
