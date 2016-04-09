using System;
using System.Collections.Generic;
using System.Drawing;
using SimulacnaHra.gui;
using SimulacnaHra.prvkyHry.mapa;
using SimulacnaHra.prvkyHry.ovladanie;

namespace SimulacnaHra.prvkyHry {

    /// <summary>
    /// Predok vöetkÈho, Ëo sa d· vykresliù na hlavnÈ okno
    /// rieöi vykrasæovanie obr·zkov a kliknutia na obrazovku
    /// </summary>
    public class ZakladObrazku : IDisposable
    {
        private bool aDisposed = false;
        private Bitmap aObrazok;
        private Kamera aKamera;
        private Rectangle aObdlznik;

        private int aX;
        private int aY;

        private int aSirkaPX;
        private int aVyskaPX;

        /// <summary>
        /// Nastavenie odsadenie
        /// </summary>
        public int OdsadenieZLava { get { return aX; } set { aX = value; } }

        /// <summary>
        /// Nastavenie Odsadenia
        /// </summary>
        public int OdsadenieZHora { get { return aY; } set { aY = value; } }

        /// <summary>
        /// poËet riadkov, ktorÈ zaber· prvok
        /// </summary>
        public int PocetRiadkov { get { return aVyskaPX / Policko.cVelkostPolicka;} }

        /// <summary>
        /// poËet stÂpcov, ktorÈ zaber· prvok
        /// </summary>
        public int PocetStlpcov { get { return aSirkaPX / Policko.cVelkostPolicka; } }

        /// <summary>
        /// Nastavenie, Ëi je obr·zok skryt˝
        /// </summary>
        public bool Skryte { get; set; }

        /// <summary>
        /// konötruktor
        /// </summary>
        public ZakladObrazku()
        {
            aKamera = Kamera.DajInstanciu();
            Skryte = false;
        }

        /// <summary>
        /// Nastavenie aktu·lneho obr·zku
        /// </summary>
        /// <param name="paObrazok"></param>
        public void NastavObrazok(Bitmap paObrazok, string paNazov)
        {
            aObrazok = SpravcaObrazkov.DajInstanciu().DajObrazok(paObrazok, paNazov);
            aSirkaPX = aObrazok.Width;
            aVyskaPX = aObrazok.Height;
        }

        /// <summary>
        /// Vykreslenie obr·zku s krontrolou, Ëi sa nach·dza na kamere
        /// </summary>
        /// <param name="paGafika"></param>
        public void DrawImage(Graphics paGafika)
        {
            if (Skryte) return;
            if (aX >= (aKamera.OdsadenieX - 2) * Policko.cVelkostPolicka && aX < (aKamera.OdsadenieX + Kamera.cPocetOkienStplce - PozadieMenu.cPosunZBoku) * Policko.cVelkostPolicka)
            {
                if (aY >= (aKamera.OdsadenieY - 2) * Policko.cVelkostPolicka && aY < (aKamera.OdsadenieY + Kamera.cPocetOkienRiadky - PozadieMenu.cPosunZVrchu) * Policko.cVelkostPolicka)
                {
                    int tempX = aX - aKamera.OdsadenieX * Policko.cVelkostPolicka + Policko.cVelkostPolicka * PozadieMenu.cPosunZBoku;
                    int tempY = aY - aKamera.OdsadenieY * Policko.cVelkostPolicka + Policko.cVelkostPolicka * PozadieMenu.cPosunZVrchu;
                    paGafika.DrawImage(aObrazok, tempX, tempY);
                    aObdlznik = new Rectangle(tempX, tempY, aSirkaPX, aVyskaPX);
                }
            }
        }

        /// <summary>
        /// Vymazanie, keÔ nie je treba
        /// </summary>
        public void Dispose()
        {
            aObdlznik = Rectangle.Empty;
            Dispose(true);
        }

        /// <summary>
        /// Vymazanie, keÔ nie je treba
        /// </summary>
        /// <param name="paDisp"></param>
        protected virtual void Dispose(bool paDisp)
        {
            if (aDisposed)
                return;
            if (paDisp)
            {
                aObrazok.Dispose();
            }
            aDisposed = true;
        }

        /// <summary>
        /// Zistenie, Ëi bolo kliknutÈ na obr·zok
        /// </summary>
        /// <param name="paX">poloha kurzoru X</param>
        /// <param name="paY">poloha kurzoru Y</param>
        /// <returns></returns>
        public bool Kliknutie(int paX, int paY)
        {
            Rectangle kurzor = new Rectangle(paX, paY, 1, 1);
            if (aObdlznik.Contains(kurzor))
            {
                return true;
            }
            return false;
        }
    }

}//end namespace prvkyHry