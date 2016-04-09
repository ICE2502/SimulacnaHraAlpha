using System.Collections.Generic;
using System.Drawing;

namespace SimulacnaHra.prvkyHry
{
    public class SpravcaObrazkov
    {
        private static SpravcaObrazkov aInstancia = null;
        private List<string> aPouzivaneObrazky;
        private List<Bitmap> aVytvoreneObrazky;

        private SpravcaObrazkov()
        {
            aPouzivaneObrazky = new List<string>();
            aVytvoreneObrazky = new List<Bitmap>();
        }

        public static SpravcaObrazkov DajInstanciu()
        {
            if (aInstancia == null)
            {
                aInstancia = new SpravcaObrazkov();
            }
            return aInstancia;
        }

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
