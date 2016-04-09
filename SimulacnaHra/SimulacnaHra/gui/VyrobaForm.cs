using System;
using System.Windows.Forms;
using SimulacnaHra.prvkyHry.vyroba;

namespace SimulacnaHra.gui
{
    /// <summary>
    /// Rozhranie výrobného podniku
    /// </summary>
    public partial class VyrobaForm : Form
    {

        private Vyroba aVyroba;

        /// <summary>
        /// Konštruktor inicializuje potrebné
        /// </summary>
        /// <param name="paVyroba">Pre ktorú výrobu zobrazuje</param>
        public VyrobaForm(Vyroba paVyroba)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            aVyroba = paVyroba;
            aLabelFlekDruhVyroby.Text = aVyroba.ToString();
            aLabelFlekVyrobaPrijma.Text = aVyroba.CoPrijmas();
            aLabelFlekVyrobaProdukuje.Text = aVyroba.CoVyrabas();
            Kamera.DajInstanciu().VycentrujPohlad(aVyroba.Poloha);
            if (paVyroba is Mesto)
            {
                Text = "Imformácie o meste";
                aLabelDruh.Text = "Názov:";
            }
        }

        /// <summary>
        /// Zobrazenie pridanej stanice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (aVyroba.Zoskupenie != null)
            {
                aVyroba.Zoskupenie.ZobrazForm();
            }
        }

        private void VyrobaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            aVyroba.ZmazOkno();
        }
    }
}
