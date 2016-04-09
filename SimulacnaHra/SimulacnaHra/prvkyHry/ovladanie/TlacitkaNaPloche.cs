using SimulacnaHra.prvkyHry.infrastruktura;
using System.Windows.Forms;
using SimulacnaHra.gui;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;
using SimulacnaHra.prvkyHry.mapa;

namespace SimulacnaHra.prvkyHry.ovladanie
{
    /// <summary>
    /// Tlačítka na ploche hry, každý vykreslený objekt je vzároveň tlačítkom
    /// </summary>
    public class TlacitkaNaPloche
    {
        private Kamera aKamera;
        private Policko[,] aMatica;
        private Hra aHra;
        private BocneMenu aBocneMenu;
        private bool aStav;

        /// <summary>
        /// Konštruktor inicializuje všetko potrebné
        /// </summary>
        /// <param name="paBocneMenu">trieda, ktorá spravuje bočné menu</param>
        public TlacitkaNaPloche(BocneMenu paBocneMenu) 
        {
            aHra = Hra.DajInstanciu();
            aKamera = Kamera.DajInstanciu();
            aBocneMenu = paBocneMenu;
            aStav = false;
        }

        /// <summary>
        /// Spracovanie kloknutia
        /// </summary>
        /// <param name="paE">kurzor</param>
        /// <returns></returns>
        public bool Klik(MouseEventArgs paE)
        {
            if (paE.X > 160 && paE.Y > 40)
            {
                this.SpracujKliknutie(paE);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Rozhodovanie, čo je potrebné vykonať
        /// </summary>
        /// <param name="paE"></param>
        private void SpracujKliknutie(MouseEventArgs paE)
        {
            aMatica = aHra.DajHernuPlochu().DajMaticu();
            aStav = false;

            for (int i = aKamera.OdsadenieY; i < aKamera.OdsadenieY + Kamera.cPocetOkienRiadky - PozadieMenu.cPosunZVrchu; i++)
            {
                for (int j = aKamera.OdsadenieX; j < aKamera.OdsadenieX + Kamera.cPocetOkienStplce - PozadieMenu.cPosunZBoku; j++)
                {
                    var aktPolicko = aMatica[i, j];
                    if (aStav != true && aktPolicko.BoloKliknute(paE.X, paE.Y))
                    {
                        aStav = true;
                        int upresnenieCinnosti = aBocneMenu.DajZvolene();
                        VykonavanaCinnost cinnost = aBocneMenu.HlavnaCinnost;
                        switch (cinnost)
                        {
                            case VykonavanaCinnost.vystavbaCiest:
                                if (upresnenieCinnosti <= 11)
                                {
                                    aktPolicko.PostavCestu(upresnenieCinnosti);
                                }
                                else if (upresnenieCinnosti <= 14)
                                {
                                    aktPolicko.PostavZastavku(upresnenieCinnosti);
                                }


                                break;

                            case VykonavanaCinnost.vystavbaZeleznic:
                                if (upresnenieCinnosti <= 6)
                                {
                                    aktPolicko.PostavZeleznicu(upresnenieCinnosti);
                                }
                                else if (upresnenieCinnosti <= 8)
                                {
                                    aktPolicko.PostavStanicu(upresnenieCinnosti + 6);
                                }
                                break;

                            case VykonavanaCinnost.upravaTerenu:
                                if (upresnenieCinnosti == 1)
                                {
                                    aktPolicko.Zburaj(true);
                                }
                                else if (upresnenieCinnosti == 2)
                                {
                                    aktPolicko.Konvertuj();
                                }
                                break;

                            case VykonavanaCinnost.vystavbaLetisk:

                                aktPolicko.PostavLetisko();

                                break;

                            case VykonavanaCinnost.vystavbaVodnychCiest:

                                switch (upresnenieCinnosti)
                                {
                                    case (int) SmerDoku.boja:
                                        aktPolicko.PostavBoju();
                                        break;
                                    default:
                                        aktPolicko.PostavDok(upresnenieCinnosti);
                                        break;
                                }
                                break;

                            case VykonavanaCinnost.vyberCielov:
                                if (aktPolicko.Zastavane is MiestoZastavenia)
                                {
                                    aHra.Spolocnost.UpravovanyDP.PridajCiel((MiestoZastavenia)aktPolicko.Zastavane);
                                }
                                else if (aktPolicko.Vyroba != null && aktPolicko.Vyroba.Dok != null)
                                {
                                    aHra.Spolocnost.UpravovanyDP.PridajCiel(aktPolicko.Vyroba.Dok);
                                }
                                break;

                            case VykonavanaCinnost.bezna:
                                if (aktPolicko.Prostriedky())
                                {
                                    aktPolicko.ZobrazFormProstriedkov();
                                }
                                if (aktPolicko.Vyroba != null)
                                {
                                    aktPolicko.Vyroba.ZobrazForm();
                                }
                                else if (aktPolicko.Zastavane is Stanica)
                                {
                                    (aktPolicko.Zastavane as Stanica).Zoskupenie.ZobrazForm();
                                    (aktPolicko.Zastavane as Stanica).ZobrazForm();
                                }
                                break;
                        }
                    }
                }
            }
        }

    }
}
