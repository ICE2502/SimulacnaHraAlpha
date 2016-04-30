using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;
using SimulacnaHra.prvkyHry.mapa;
using SimulacnaHra.prvkyHry.ovladanie;
using SimulacnaHra.spravaZvuku;

namespace SimulacnaHra.gui
{
    /// <summary>
    /// Hlavné okno programu. Vykresľuje všetko potrebné a ovláda hlavnú časovú slučku.
    /// </summary>
    public partial class OknoAplikacie : Form
    {
        private Kamera aKamera;
        private Hra aHra;
        private Policko[,] aMatica;
        private PozadieMenu aPozMen;
        private static OknoAplikacie aInstancia = null;
        private bool aJePauza;
        private BocneMenu aBocneMenu;
        private HorneMenu aHorneMenu;
        public const int cFPS = 20;

        /// <summary>
        /// Poskytuje triedu horného menu
        /// </summary>
        public HorneMenu HorneMenu {
            get { return aHorneMenu; }
        }

        /// <summary>
        /// Konštruktor inicializuje potrebné atribúty a nastavienia
        /// </summary>
        private OknoAplikacie()
        {
            aJePauza = false;
            aPozMen = new PozadieMenu();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            InitializeComponent();
            casovac.Start();
        }

        /// <summary>
        /// Singleton
        /// </summary>
        /// <returns>Inštancia okna</returns>
        public static OknoAplikacie DajInstanciu() {
            if (aInstancia == null)
            {
                aInstancia = new OknoAplikacie();
            }
            return aInstancia;
        }

        /// <summary>
        /// Metóda vykonávaná pri každom prekreslení
        /// </summary>
        /// <param name="paE"></param>
        protected override void OnPaint(PaintEventArgs paE)
        {
            Graphics zariadenie = paE.Graphics;

            aMatica = aHra.DajHernuPlochu().DajMaticu();

            if (aKamera == null) return;

            for (int i = aKamera.OdsadenieY; i < aKamera.OdsadenieY + Kamera.cPocetOkienRiadky - PozadieMenu.cPosunZVrchu; i++)
            {
                for (int j = aKamera.OdsadenieX; j < aKamera.OdsadenieX + Kamera.cPocetOkienStplce - PozadieMenu.cPosunZBoku; j++)
                {
                    aMatica[i, j].DrawImage(zariadenie);
                }
            }

            List<DopravnyProstriedok> dopravnyProstriedok = aHra.Spolocnost.DopravneProstriedky;

            foreach (var item in dopravnyProstriedok)
            {
                item.DrawImage(zariadenie);
            }


            aPozMen.DrawImage(zariadenie);

            TextFormatFlags umiestnenie = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font pismo = new System.Drawing.Font("Comic Sans MS", 12, FontStyle.Regular);
            TextRenderer.DrawText(zariadenie, "Herný deň: " + aHra.Den, pismo,
                new Rectangle(650, 10, 250, 20), SystemColors.ControlText, umiestnenie);
            TextRenderer.DrawText(zariadenie, "Financie spoločnosti: " + aHra.Spolocnost.Financie + "€", pismo,
                new Rectangle(900, 10, 300, 20), SystemColors.ControlText, umiestnenie);

            if (aBocneMenu != null)
            {
                aBocneMenu.DrawImage(zariadenie);
                TextRenderer.DrawText(zariadenie, aBocneMenu.Nadpis, pismo,
                    new Rectangle(5, 50, 155, 300), SystemColors.ControlText, umiestnenie);

            }
            /*
            Pen pero = new Pen(Color.Red, 5);
            List<Vrchol> vrchol = aHra.DajHernuPlochu().ZoznamVrcholov;
            List<Hrana> hrany = aHra.DajHernuPlochu().ZoznamHran;

            foreach (Vrchol item in vrchol)
            {
                zariadenie.DrawEllipse(pero, (item.Policko.Poloha.Stlpec + 4 - aKamera.OdsadenieX) * Policko.cVelkostPolicka + 10,
                    (item.Policko.Poloha.Riadok + 1 - aKamera.OdsadenieY) * Policko.cVelkostPolicka + 10, 20, 20);
            }

            pero = new Pen(Color.Blue, 5);
            int stlpecPrvy;
            int riadokPrvy;
            int stlpecDruhy;
            int riadokDruhy;


            foreach (Hrana item in hrany)
            {
                if (item.Vrchol1 != null && item.Vrchol2 != null) {
                    stlpecPrvy = item.Vrchol1.Policko.Poloha.Stlpec;
                    riadokPrvy = item.Vrchol1.Policko.Poloha.Riadok;

                    stlpecDruhy = item.Vrchol2.Policko.Poloha.Stlpec;
                    riadokDruhy = item.Vrchol2.Policko.Poloha.Riadok;

                    zariadenie.DrawLine(pero, new Point((stlpecPrvy + 4 - aKamera.OdsadenieX) * Policko.cVelkostPolicka + 19,
                        (riadokPrvy + 1 - aKamera.OdsadenieY) * Policko.cVelkostPolicka + 19),
                        new Point((stlpecDruhy + 4 - aKamera.OdsadenieX) * Policko.cVelkostPolicka + 19,
                            (riadokDruhy + 1 - aKamera.OdsadenieY) * Policko.cVelkostPolicka + 19));
                }
            }*/
            
            base.OnPaint(paE);
        }

        /// <summary>
        /// Metóda, ktorá sa vykoná pri spustení časovcača
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void casovac_Tick(object sender, EventArgs e)
        {
            aHra = Hra.DajInstanciu();

            if (HernaPlocha.PocetStlpcov < 50)
            {
                aHra.Nacitaj();
                return;
            }

            aKamera = Kamera.DajInstanciu();

            aHra.Tik();
            Vykreslene.Tik();
            this.Refresh();
        }

        /// <summary>
        /// Pozastaví hru
        /// </summary>
        public void Pauza() {
            casovac.Stop();
            aJePauza = true;
        }

        /// <summary>
        /// Spustí hru
        /// </summary>
        public void Start() {
            casovac.Start();
            aJePauza = false;
        }

        /// <summary>
        /// Sníma stlačenie klávesy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="paE"></param>
        private void OknoAplikacie_KeyDown(object sender, KeyEventArgs paE)
        {
            if (!aJePauza)
            {
                this.PosunKamery(paE);
            }
        }

        /// <summary>
        /// posúva kameru
        /// </summary>
        /// <param name="paE"></param>
        private void PosunKamery(KeyEventArgs paE)
        {
            switch (paE.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    aKamera.Hore();
                    break;

                case Keys.S:
                case Keys.Down:
                    aKamera.Dole();
                    break;

                case Keys.A:
                case Keys.Left:
                    aKamera.VLavo();
                    break;

                case Keys.D:
                case Keys.Right:
                    aKamera.VPravo();
                    break;
                case Keys.Escape:
                case Keys.Space:
                    this.InicializujMenu();
                    aHorneMenu.RestartCinnosti();
                    if (SpravcaOkien.AktDopProst != null)
                    {
                        SpravcaOkien.AktDopProst.Activate();
                        SpravcaOkien.AktDopProst = null;
                    }

                    break;
            }
        }

        /// <summary>
        /// dotvorenie menu
        /// </summary>
        private void InicializujMenu() {

            if (aHorneMenu == null)
            {
            aBocneMenu = new BocneMenu();
            aHorneMenu = new HorneMenu(aBocneMenu);
            }
        }

        /// <summary>
        /// Spracovanie kliknutia myšou na okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="paE"></param>
        private void OknoAplikacie_MouseClick(object sender, MouseEventArgs paE)
        {
            this.InicializujMenu();
            TlacitkaNaPloche tnp = new TlacitkaNaPloche(aBocneMenu);
            aHorneMenu.Klik(paE);
            if(!aJePauza){
                aBocneMenu.Klik(paE);
                tnp.Klik(paE);
            }
        }

        /// <summary>
        /// Pri ukončení činnosti sa vypne hudba a samostatnom procese a ukončí sa aplikácia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OknoAplikacie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vlakno.Ukonci();
            Application.Exit();
        }
    }
}
