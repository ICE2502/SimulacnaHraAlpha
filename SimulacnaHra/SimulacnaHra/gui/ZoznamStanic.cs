using System.Collections.Generic;
using System.Windows.Forms;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.infrastruktura;
using SimulacnaHra.prvkyHry.vyroba;

namespace SimulacnaHra.gui
{
    /// <summary>
    /// Rozhranie zoznamu staníc
    /// </summary>
    public partial class ZoznamStanic : Form
    {
        private List<ZoskupenieStanic> aZoznam;
        private List<ZoskupenieStanic> aZoznamPrirodzenych; 

        /// <summary>
        /// Inicializácia
        /// </summary>
        public ZoznamStanic()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            Aktualizuj();
        }

        /// <summary>
        /// Zobrazí vybraný prvok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = aListBoxZoznamStanic.SelectedIndex;
            if (i >= aZoznam.Count)
            {
                i = i - aZoznam.Count;
                Kamera.DajInstanciu().VycentrujPohlad(aZoznamPrirodzenych[i].Poloha);
                aZoznamPrirodzenych[i].ZobrazForm();
            }
            else if(i > -1)
            {
                Kamera.DajInstanciu().VycentrujPohlad(aZoznam[i].Poloha);
                aZoznam[i].ZobrazForm();
                
            }
        }

        /// <summary>
        /// Časovač pravideľne aktualizuje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aTimer1_Tick(object sender, System.EventArgs e)
        {
            Aktualizuj();
        }

        /// <summary>
        /// Aktualizácia informácií
        /// </summary>
        private void Aktualizuj()
        {
            aZoznam = Hra.DajInstanciu().Spolocnost.Stanice;
            aZoznamPrirodzenych = Hra.DajInstanciu().DajHernuPlochu().ZoznamPrirodzenychStanic;
            foreach (var toto in aZoznam)
            {
                aListBoxZoznamStanic.Items.Add(toto.ToString());
            }

            foreach (var toto in aZoznamPrirodzenych)
            {
                aListBoxZoznamStanic.Items.Add(toto.ToString());
            }
        }

        private void ZoznamStanic_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpravcaOkien.VymazStanice();
        }
    }
}
