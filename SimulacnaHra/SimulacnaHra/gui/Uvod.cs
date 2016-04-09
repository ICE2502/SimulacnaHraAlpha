using System;
using System.Windows.Forms;
using SimulacnaHra.prvkyHry.mapa;
using SimulacnaHra.spravaZvuku;

namespace SimulacnaHra.gui
{
    /// <summary>
    /// Úvodné okno aplikácie
    /// </summary>
    public partial class Uvod : Form
    {

        /// <summary>
        /// Event pri uzavretí
        /// </summary>
        public event EventHandler OnClose;

        /// <summary>
        /// Konštruktor
        /// </summary>
        public Uvod()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            aNumericUpDownRiadky.Value = 100;
            aNumericUpDownStlpce.Value = 100;
        }

        /// <summary>
        /// Pri uzatvorení okna
        /// </summary>
        protected virtual void CloseWindow()
        {
            if (OnClose != null)
                OnClose(this, EventArgs.Empty);
        }

        /// <summary>
        /// Okno sa uzavrie a zobrazí sa hlavné okno hry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aButton1_Click(object sender, EventArgs e)
        {
            HernaPlocha.PocetRiadkov = (int)aNumericUpDownRiadky.Value;
            HernaPlocha.PocetStlpcov = (int)aNumericUpDownStlpce.Value;
            CloseWindow();
        }

        /// <summary>
        /// Ak sa užívateľ rozhodne zavrieť toto okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Uvod_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vlakno.Ukonci();
            Application.Exit();
        }
    }
}
