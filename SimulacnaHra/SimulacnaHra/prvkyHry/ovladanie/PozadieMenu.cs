using System.Drawing;
using SimulacnaHra.Properties;

namespace SimulacnaHra.prvkyHry.ovladanie
{
    /// <summary>
    /// Pozadie menu - trieda, ktorá sa stará o vykresľovanie obrázku
    /// </summary>
    public class PozadieMenu : ZakladObrazku
    {
        private Bitmap aObrazok = Resources.pozadieMenu;
        public const int cPosunZVrchu = 1;
        public const int cPosunZBoku = 4;

        public void DrawImage(Graphics paGafika) {
            paGafika.DrawImage(aObrazok, 0, 0); 
        }

    }
}
