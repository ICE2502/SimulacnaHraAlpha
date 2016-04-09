using System.Collections.Generic;
using System.Drawing;

namespace SimulacnaHra.prvkyHry
{
    /// <summary>
    /// Správna obrázkov má na starosti uchovávanie už vykreslených obrázkov.
    /// Rapídne znižuje nároky na operačnú pamäť.
    /// </summary>
    public class SpravcaObrazkov
    {
        private static SpravcaObrazkov aInstancia = null;
        private List<string> aPouzivaneObrazky;
        private List<Bitmap> aVytvoreneObrazky;

        /// <summary>
        /// konštruktor
        /// </summary>
        private SpravcaObrazkov()
        {
            aPouzivaneObrazky = new List<string>();
            aVytvoreneObrazky = new List<Bitmap>();
        }

        /// <summary>
        /// Návrhový vzor jedináčik
        /// </summary>
        /// <returns></returns>
        public static SpravcaObrazkov DajInstanciu()
        {
            if (aInstancia == null)
            {
                aInstancia = new SpravcaObrazkov();
            }
            return aInstancia;
        }

        /// <summary>
        /// Vráti odkaz na obrázok. Ak je obrázok už vytvorený použije ten, 
        /// ak nie, tak vytovrí obrázok
        /// </summary>
        /// <param name="paObrazok">obrázok</param>
        /// <param name="paNazov">jeho názov</param>
        /// <returns>referencia na obrázok</returns>
        public Bitmap DajObrazok(Bitmap paObrazok, string paNazov)
        {
            int pozicia = -1;

            bool uzJe = false;
            foreach (var item in aPouzivaneObrazky)
            {
                pozicia++;
                if (item.Equals(paNazov))
                {
                    uzJe = true;
                    break;
                }
            }

            if (uzJe)
            {
                return aVytvoreneObrazky[pozicia];
            }
            aPouzivaneObrazky.Add(paNazov);
            Bitmap temp = new Bitmap(paObrazok);
            aVytvoreneObrazky.Add(temp);
                
            return temp;
        }
    }

}
