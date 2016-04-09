using gui;
using SimulacnaHra.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimulacnaHra.gui;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;

namespace SimulacnaHra.prvkyHry.ovladanie
{
    /// <summary>
    /// Trieda, ktorá spravuje kliknutia na horné menu
    /// </summary>
    public class HorneMenu
    {
        private List<Tlacitko> aTlacitkaMenu;
        private const int cRozmerPolozkyMenuX = 31;
        private const int cRozmerPolozkyMenuY = 32;
        private Hra aHra;
        private BocneMenu aBocneMenu;

        /// <summary>
        /// Vytváranie tlačítok
        /// </summary>
        /// <param name="paBocneMenu"></param>
        public HorneMenu(BocneMenu paBocneMenu) 
        {
            aBocneMenu = paBocneMenu;
            aHra = Hra.DajInstanciu();
            aTlacitkaMenu = new List<Tlacitko>();
            aTlacitkaMenu.Add(new Tlacitko(4, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.pauza));
            aTlacitkaMenu.Add(new Tlacitko(38, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.start));
            aTlacitkaMenu.Add(new Tlacitko(72, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.nacitaj));
            aTlacitkaMenu.Add(new Tlacitko(106, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.uloz));
            aTlacitkaMenu.Add(new Tlacitko(140, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.zoznamMiest));
            aTlacitkaMenu.Add(new Tlacitko(174, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.zoznamStanic));
            aTlacitkaMenu.Add(new Tlacitko(208, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.zoznamVyroby));
            aTlacitkaMenu.Add(new Tlacitko(242, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.zoznamVlakov));
            aTlacitkaMenu.Add(new Tlacitko(276, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.zoznamVozidiel));
            aTlacitkaMenu.Add(new Tlacitko(310, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.zoznamLodi));
            aTlacitkaMenu.Add(new Tlacitko(344, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.zozmanLietadiel));
            aTlacitkaMenu.Add(new Tlacitko(378, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.vystavbaZeleznic));
            aTlacitkaMenu.Add(new Tlacitko(412, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.vystavbaCiest));
            aTlacitkaMenu.Add(new Tlacitko(446, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.vystavbaVodnychCiest));
            aTlacitkaMenu.Add(new Tlacitko(480, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.vystavbaLetisk));
            aTlacitkaMenu.Add(new Tlacitko(514, 3, cRozmerPolozkyMenuX, cRozmerPolozkyMenuY, VykonavanaCinnost.upravaTerenu));
        }

        /// <summary>
        /// Spracovanie kliknutia
        /// </summary>
        /// <param name="paE">poloha kurzora</param>
        /// <returns></returns>
        public bool Klik(MouseEventArgs paE)
        {
            if(paE.X < 1200 && paE.Y < 40){
                this.SpracujKliknutie(paE);
                return true;
            }
            return false;
        }

        /// <summary>
        /// reštartovanie činnosti
        /// </summary>
        public void RestartCinnosti()
        {
            aBocneMenu.HlavnaCinnost = VykonavanaCinnost.bezna;
            aBocneMenu.Obrazok = null;
            aBocneMenu.Nadpis = "";
        }

        /// <summary>
        /// Váber cieľov pre vozidlá
        /// </summary>
        public void VyberCielov()
        {
            RestartCinnosti();
            aBocneMenu.HlavnaCinnost = VykonavanaCinnost.vyberCielov;
            aBocneMenu.Nadpis = "Vyber cielov";
        }

        /// <summary>
        /// Spracovanie kliknutia na plochu
        /// </summary>
        /// <param name="paE"></param>
        private void SpracujKliknutie(MouseEventArgs paE)
        {
            VykonavanaCinnost tl = VykonavanaCinnost.bezna;
            foreach (Tlacitko toto in aTlacitkaMenu)
            {
                if (toto.Kliknute(paE.X, paE.Y))
                {
                    Console.WriteLine(toto.ToString());
                    tl = toto.DajTyp();
                    break;
                }
            }

            RestartCinnosti();
            aBocneMenu.HlavnaCinnost = tl;
            switch (tl)
            {
                case VykonavanaCinnost.pauza:
                    aHra.Pauza();
                    Sprava.Info("Hra prerušená");
                    RestartCinnosti();
                    break;

                case VykonavanaCinnost.start:
                    aHra.Start();
                    Sprava.Info("Hra pokračuje");
                    RestartCinnosti();
                    break;

                case VykonavanaCinnost.vystavbaCiest:
                    aBocneMenu.Obrazok = Resources.MenuCesty;
                    aBocneMenu.HlavnaCinnost = tl;
                    aBocneMenu.Nadpis = "Výstavba ciest";
                    break;

                case VykonavanaCinnost.vystavbaZeleznic:
                    aBocneMenu.Obrazok = Resources.MenuZeleznice;
                    aBocneMenu.HlavnaCinnost = tl;
                    aBocneMenu.Nadpis = "Výstavba železníc";
                    break;

                case VykonavanaCinnost.upravaTerenu:
                    aBocneMenu.Obrazok = Resources.MenuTerenu;
                    aBocneMenu.HlavnaCinnost = tl;
                    aBocneMenu.Nadpis = "Úprava terénu";
                    break;

                case VykonavanaCinnost.vystavbaLetisk:
                    aBocneMenu.HlavnaCinnost = tl;
                    aBocneMenu.Nadpis = "Výstavba letísk";
                    break;

                case VykonavanaCinnost.vystavbaVodnychCiest:
                    aBocneMenu.Nadpis = "Výstavba vodných\nciest";
                    aBocneMenu.Obrazok = Resources.MenuVodnychStavieb;
                    aBocneMenu.HlavnaCinnost = tl;
                    break;

                case VykonavanaCinnost.zoznamMiest:
                    SpravcaOkien.ZoznamVyroby(true);
                    RestartCinnosti();
                    break;

                case VykonavanaCinnost.zoznamVyroby:
                    SpravcaOkien.ZoznamVyroby(false);
                    RestartCinnosti();
                    break;

                case VykonavanaCinnost.zoznamStanic:
                    SpravcaOkien.ZoznamStanic();
                    RestartCinnosti();
                    break;

                case VykonavanaCinnost.zozmanLietadiel:
                    SpravcaOkien.ZobrazZoznamDoprevProst(DruhVozidla.vzdusne);
                    break;

                case VykonavanaCinnost.uloz:
                    break;

                case VykonavanaCinnost.nacitaj:
                    break;

                case VykonavanaCinnost.zoznamVlakov:
                    SpravcaOkien.ZobrazZoznamDoprevProst(DruhVozidla.kolajove);
                    break;

                case VykonavanaCinnost.zoznamVozidiel:
                    SpravcaOkien.ZobrazZoznamDoprevProst(DruhVozidla.cestne);
                    break;

                case VykonavanaCinnost.zoznamLodi:
                    SpravcaOkien.ZobrazZoznamDoprevProst(DruhVozidla.vodne);
                    break;
            }
        }
    }
}
