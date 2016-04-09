using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimulacnaHra.prvkyHry.vyroba;

namespace SimulacnaHra.gui
{
    /// <summary>
    /// Rozhranie zozonamu výroby
    /// </summary>
    public partial class ZoznamVyrobyForm : Form
    {
        private List<Vyroba> aZoznamVyroba;
        private List<Mesto> aZoznamMiest;

        /// <summary>
        /// Inicializácia pre výrobu
        /// </summary>
        /// <param name="paList"></param>
        public ZoznamVyrobyForm(List<Vyroba> paList)
        {
            Text = "Zoznam výroby";
            aZoznamMiest = new List<Mesto>();
            aZoznamVyroba = paList;

            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            foreach (Vyroba tato in aZoznamVyroba)
            {
                aListBoxZoznamVyroby.Items.Add(tato.ToString());
            }
        }

        /// <summary>
        /// Inicializácia pre mestá
        /// </summary>
        /// <param name="paList"></param>
        public ZoznamVyrobyForm(List<Mesto> paList)
        {
            Text = "Zoznam miest";
            aZoznamVyroba = new List<Vyroba>();
            aZoznamMiest = paList;

            InitializeComponent();

            foreach (Mesto toto in aZoznamMiest)
            {
                aListBoxZoznamVyroby.Items.Add(toto.ToString());
            }
        }

        /// <summary>
        /// Zobrazí danú položku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aListBoxVyroba_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = aListBoxZoznamVyroby.SelectedIndex;
            if (i > -1)
            {
                if (aZoznamVyroba.Any())
                {
                    Kamera.DajInstanciu().VycentrujPohlad(aZoznamVyroba[i].Poloha);
                }
                else
                {
                    Kamera.DajInstanciu().VycentrujPohlad(aZoznamMiest[i].Poloha);
                }
            }

        }

        private void ZoznamVyrobyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (aZoznamVyroba.Any())
            {
                SpravcaOkien.VymazZoznamVyroba(false);
            }
            else
            {
               SpravcaOkien.VymazZoznamVyroba(true);
            }
        }
    }
}
