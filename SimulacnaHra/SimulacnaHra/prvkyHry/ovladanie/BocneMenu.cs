using System.Drawing;
using System.Windows.Forms;

namespace SimulacnaHra.prvkyHry.ovladanie
{
    /// <summary>
    /// Trieda ktorá spravuje tlačítka na bočnom menu
    /// </summary>
    public class BocneMenu : ZakladObrazku
    {
        private int aSlot;
        public Bitmap Obrazok { get; set; }
        public VykonavanaCinnost HlavnaCinnost { get; set; }
        public string Nadpis;


        public BocneMenu() 
        {
            HlavnaCinnost = VykonavanaCinnost.bezna;
            aSlot = 0;
        }
 
        /// <summary>
        /// Spracovanie kliknutia na polchu, ktorá patrí bočnému menu
        /// </summary>
        /// <param name="paE">poloha kurzory</param>
        /// <returns></returns>
        public bool Klik(MouseEventArgs paE)
        {
            if (paE.X < 160 && paE.Y < 640)
            {
                this.SpracujKliknutie(paE);
            }
            return false;
        }

        /// <summary>
        /// Rozhodnutie na ktorý za slotov na tlačítko bolo kliknuté
        /// </summary>
        /// <param name="paE">poloha kurzora</param>
        private void SpracujKliknutie(MouseEventArgs paE)
        {
            if(paE.X >10 && paE.X < 50 && paE.Y > 125 && paE.Y < 165){
                aSlot = 1;
            }
            else if (paE.X > 57 && paE.X < 97 && paE.Y > 125 && paE.Y < 165)
            {
                aSlot = 2;
            }
            else if (paE.X > 104 && paE.X < 144 && paE.Y > 125 && paE.Y < 165)
            {
                aSlot = 3;
            }
            else if (paE.X > 10 && paE.X < 50 && paE.Y > 172 && paE.Y < 212)
            {
                aSlot = 4;
            }
            else if (paE.X > 57 && paE.X < 97 && paE.Y > 172 && paE.Y < 212)
            {
                aSlot = 5;
            }
            else if (paE.X > 104 && paE.X < 144 && paE.Y > 172 && paE.Y < 212)
            {
                aSlot = 6;
            }
            else if (paE.X > 10 && paE.X < 50 && paE.Y > 219 && paE.Y < 259)
            {
                aSlot = 7;
            }
            else if (paE.X > 57 && paE.X < 97 && paE.Y > 219 && paE.Y < 259)
            {
                aSlot = 8;
            }
            else if (paE.X > 104 && paE.X < 144 && paE.Y > 219 && paE.Y < 259)
            {
                aSlot = 9;
            }
            else if (paE.X > 10 && paE.X < 50 && paE.Y > 266 && paE.Y < 306)
            {
                aSlot = 10;
            }
            else if (paE.X > 57 && paE.X < 97 && paE.Y > 266 && paE.Y < 306)
            {
                aSlot = 11;
            }
            else if (paE.X > 104 && paE.X < 144 && paE.Y > 266 && paE.Y < 306)
            {
                aSlot = 12;
            }
            else if (paE.X > 10 && paE.X < 50 && paE.Y > 313 && paE.Y < 353)
            {
                aSlot = 13;
            }
            else if (paE.X > 57 && paE.X < 97 && paE.Y > 313 && paE.Y < 353)
            {
                aSlot = 14;
            }
            else if (paE.X > 104 && paE.X < 144 && paE.Y > 313 && paE.Y < 353)
            {
                aSlot = 15;
            }

        }

        /// <summary>
        /// Vykreslenie
        /// </summary>
        /// <param name="paGafika">grafické zariadenie</param>
        public void DrawImage(Graphics paGafika) {
            if (Obrazok != null)
            {
                paGafika.DrawImage(Obrazok, 3, 42); 
            }
        }

        /// <summary>
        /// Vráti zvolený slot, ak bol nejaký zvolený
        /// </summary>
        /// <returns></returns>
        public int DajZvolene() {
            return aSlot;
        }

    }
}
