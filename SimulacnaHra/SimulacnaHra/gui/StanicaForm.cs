using System;
using System.Linq;
using System.Windows.Forms;
using SimulacnaHra.prvkyHry.infrastruktura;

namespace SimulacnaHra.gui
{
    /// <summary>
    /// Rozhranie ztanice
    /// </summary>
    public partial class StanicaForm : Form
    {
        private Stanica aStanica;

        /// <summary>
        /// Inicializácia premenných, naplnenie listu
        /// </summary>
        /// <param name="paStanica">Pre ktorú stanicu zobrazuje</param>
        public StanicaForm(Stanica paStanica)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            aStanica = paStanica;

            aLabelTyp.Text = aStanica.ToString();

            foreach (var item in aStanica.MozneStroje)
            {
                aComboBoxMozne.Items.Add(item.ToString());
            }
            AktualizujOdstavaneDp();
            aTimer1.Start();
        }

        /// <summary>
        /// Aktualizácia informácií o odstavených prostriedkoch
        /// </summary>
        public void AktualizujOdstavaneDp()
        {
            aListBoxAktualne.Items.Clear();
            foreach (var item in aStanica.Odstavene)
            {
                aListBoxAktualne.Items.Add(item.ToString());
            }
        }

        /// <summary>
        /// Predaj vozidla, ktoré je uvedené ako prvé v zozname
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPredaj_Click(object sender, EventArgs e)
        {
            int i = aListBoxAktualne.SelectedIndex;
            if (i >= 0)
            {
                aStanica.Odstavene[i].ZmazSa();
                aStanica.OdstranOdstavene(aStanica.Odstavene[i]);
            }
            AktualizujOdstavaneDp();
        }

        /// <summary>
        /// Nákup vybraného vozidla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNakup_Click(object sender, EventArgs e)
        {
            aStanica.PostavStroj(aComboBoxMozne.SelectedIndex);
            AktualizujOdstavaneDp();
        }

        /// <summary>
        /// Ak sa zmení index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aComboBoxMozne_SelectedIndexChanged(object sender, EventArgs e)
        {
            aTextBoxInfo.Text = aStanica.PodrobneInfo(aComboBoxMozne.SelectedIndex);
        }

        /// <summary>
        /// Pri zavretí okna sa uvolní inštancia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StanicaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            aStanica.ZmazOkno();
        }

        /// <summary>
        /// Zmena indexu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aListBoxAktualne_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = aListBoxAktualne.SelectedIndex;
            if (i >= 0)
            {
                aStanica.Odstavene[i].ZobrazForm();
            }
        }

        /// <summary>
        /// časovaš aktualizuje informácie a funkčnosť okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aTimer1_Tick(object sender, EventArgs e)
        {
            aButtonNakup.Enabled = aComboBoxMozne.SelectedIndex != -1;

            if (aStanica.Odstavene.Any() && aListBoxAktualne.SelectedIndex >= 0)
            {
                aButtonPredaj.Enabled = true;
            }
            else
            {
                aButtonPredaj.Enabled = false;
            }
        }
    }
}
