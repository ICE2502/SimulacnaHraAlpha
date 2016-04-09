using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimulacnaHra.prvkyHry.infrastruktura;
using SimulacnaHra.prvkyHry.vyroba;

namespace SimulacnaHra.gui
{
    /// <summary>
    /// Zobrazuje informácie o zoskupení staníc
    /// </summary>
    public partial class ZoskupenieForm : Form
    {
        private List<Stanica> aStanice;
        private List<Vyroba> aObsluhovanePodniky;
        private Dictionary<TypPrepravJednotky, int> aPoctyCakajucich;
        private ZoskupenieStanic aZoskupenie;

        /// <summary>
        /// Inicializácia
        /// </summary>
        /// <param name="paZoskupenie">Pre ktoré zoskupenie</param>
        public ZoskupenieForm(ZoskupenieStanic paZoskupenie)
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            aZoskupenie = paZoskupenie;
            aStanice = new List<Stanica>();
            aObsluhovanePodniky = new List<Vyroba>();
            
            Aktualizuj();
            aCasovacInfoZoskupenie.Start();
        }

        /// <summary>
        /// Aktualizácia informácií
        /// </summary>
        private void Aktualizuj()
        {
            aPoctyCakajucich = aZoskupenie.PoctyCakajucich;

            aLabelZoskupenieHlavny.Text = aZoskupenie.ToString();

            aListBoxZoskupenieCaka.Items.Clear();

            foreach (var item in aPoctyCakajucich)
            {
                if (item.Value > 0)
                {
                    aListBoxZoskupenieCaka.Items.Add("" + item.Key + " {" + item.Value + "}");
                }
            }

            aStanice.Clear();
            aListBoxZoskupenieStanice.Items.Clear();

            foreach (var stanica in aZoskupenie.Stanice)
            {
                aStanice.Add(stanica);
                aListBoxZoskupenieStanice.Items.Add(stanica.ToString());
            }

            aObsluhovanePodniky.Clear();
            aListBoxZoskupeniePripojene.Items.Clear();
            foreach (var vyroba in aZoskupenie.ObsluhovanePodniky)
            {
                aObsluhovanePodniky.Add(vyroba);
                aListBoxZoskupeniePripojene.Items.Add(vyroba.ToString());
            }

            aLabelZoskupeniePoskytuje.Text = aZoskupenie.Poskytuje();
            aLabelZoskupeniePrijma.Text = aZoskupenie.Prijma();
        }

        /// <summary>
        /// Zobrazí vybraný prvok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aListBoxZoskupenieStanice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = aListBoxZoskupenieStanice.SelectedIndex;
            if (i > -1)
            {
                aStanice[i].ZobrazForm();
            }
        }

        /// <summary>
        /// Casovač aktualizuje informácie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aCasovacInfoZoskupenie_Tick(object sender, EventArgs e)
        {
            this.Aktualizuj();
        }

        private void ZoskupenieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            aZoskupenie.ZmazOkno();
        }

        /// <summary>
        /// Zobrazí vybraný prvok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aListBoxZoskupeniePripojene_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = aListBoxZoskupeniePripojene.SelectedIndex;
            if (i > -1)
            {
                aObsluhovanePodniky[i].ZobrazForm();
            }
        }
    }
}
