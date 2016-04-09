using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;

namespace SimulacnaHra.gui
{
    /// <summary>
    /// Rozhranie zoznamu dopravných prostriedkov
    /// </summary>
    public partial class ZoznamDopravProstForm : Form
    {
        private List<DopravnyProstriedok> aDoprProst;
        private DruhVozidla aDruhVozidla;

        /// <summary>
        /// Inicializácia
        /// </summary>
        /// <param name="paDruhVozidla"></param>
        public ZoznamDopravProstForm(DruhVozidla paDruhVozidla)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            aDruhVozidla = paDruhVozidla;
            Aktualizuj();
        }

        /// <summary>
        /// Aktualiácia informácií
        /// </summary>
        private void Aktualizuj()
        {
            aDoprProst = Hra.DajInstanciu().Spolocnost.DopravneProstriedky;
            foreach (var item in aDoprProst)
            {
                if (item.Druh == aDruhVozidla)
                {
                    aListBoxZozDoPr.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Zobrazí vybraný prvok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aListBoxZozDoPr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = aListBoxZozDoPr.SelectedIndex;
            if (i >= 0)
            {
                (aListBoxZozDoPr.SelectedItem as DopravnyProstriedok).ZobrazForm();
                Kamera.DajInstanciu().VycentrujPohlad((aListBoxZozDoPr.SelectedItem as DopravnyProstriedok).Poloha);
            }
        }

        /// <summary>
        /// Časovač pravideľne aktualizuje info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aTimer1_Tick(object sender, EventArgs e)
        {
            Aktualizuj();
        }

        private void ZoznamDopravProstForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpravcaOkien.VymazZoznam(aDruhVozidla);
        }
    }
}
