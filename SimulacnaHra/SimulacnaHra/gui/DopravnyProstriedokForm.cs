using System;
using System.Linq;
using System.Windows.Forms;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;

namespace SimulacnaHra.gui
{
    /// <summary>
    /// Rozhranie dopravných prostriedkov, umožnuje potrebnú manipuláciu
    /// </summary>
    public partial class DopravnyProstriedokForm : Form
    {
        private DopravnyProstriedok aDopravProst;

        /// <summary>
        /// Konštruktor slúži na inicializáciu
        /// </summary>
        /// <param name="paDopPros">Ktorý dopravný peostriedok sa ovláda</param>
        public DopravnyProstriedokForm(DopravnyProstriedok paDopPros)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            aDopravProst = paDopPros;
            aLabelNadpis.Text = aDopravProst.ToString();
            aTextBoxPodrobneInfo.Text = aDopravProst.PodrobneInfo();
            AktualizujZoznamCielov();
            aTimer1.Start();
        }

        /// <summary>
        /// Pridanie cieľa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aButtonProdajCiel_Click(object sender, EventArgs e)
        {
            SpravcaOkien.AktDopProst = this;
            OknoAplikacie.DajInstanciu().Activate();
            Hra.DajInstanciu().Spolocnost.UpravovanyDP = aDopravProst;
            OknoAplikacie.DajInstanciu().HorneMenu.VyberCielov();
            AktualizujZoznamCielov();
        }

        /// <summary>
        /// Aktualizácia informácií v rozhraní
        /// </summary>
        private void AktualizujZoznamCielov()
        {
            aListBoxZoznamCielov.Items.Clear();
            foreach (var item in aDopravProst.Ciele)
            {
                aListBoxZoznamCielov.Items.Add(item.ToString());
            }
        }

        /// <summary>
        /// Aktualizácia informácií v rozhraní
        /// </summary>
        private void AktualizujNaklad()
        {
            aListBoxNaklad.Items.Clear();
            foreach (var item in aDopravProst.PoctyNakladu.Where(item => item.Value > 0))
            {
                aListBoxNaklad.Items.Add(item.Key + " {" + item.Value + "}");
            }
        }

        /// <summary>
        /// Časovať spúšta obnovu rozhrania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aTimer1_Tick(object sender, EventArgs e)
        {
            AktualizujZoznamCielov();
            AktualizujNaklad();

            if (aDopravProst.Ciele.Count >= 2 && !aDopravProst.JeVPohybe)
            {
                aButtonStart.Enabled = true;
            }
            else
            {
                aButtonStart.Enabled = false;
            }
            aButtonStop.Enabled = aDopravProst.JeVPohybe;
            aButtonVymazCiele.Enabled = aDopravProst.JeVCieli;
            aButtonChodDoDepa.Enabled = !aDopravProst.JeVCieli;
        }

        
        private void aButtonStart_Click(object sender, EventArgs e)
        {
            aDopravProst.Start();
        }

        private void aButtonVymazCiele_Click(object sender, EventArgs e)
        {
            aDopravProst.VymazCiele();
        }

        private void aButtonStop_Click(object sender, EventArgs e)
        {
            aDopravProst.Zastav();
        }

        private void aButtonChodDoDepa_Click(object sender, EventArgs e)
        {
            aDopravProst.ChodDoDepa();
        }

        private void DopravnyProstriedokForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            aDopravProst.ZmazOkno();
        }
    }
}
