using System;
using System.Windows.Forms;
using SimulacnaHra.prvkyHry.mapa;
using SimulacnaHra.spravaZvuku;

namespace SimulacnaHra.gui
{
    public partial class Uvod : Form
    {

        public event EventHandler OnClose;

        public Uvod()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            aNumericUpDownRiadky.Value = 100;
            aNumericUpDownStlpce.Value = 100;
        }

        private void aNumericUpDownRiadky_ValueChanged(object sender, EventArgs e)
        {
        }
        protected virtual void CloseWindow()
        {
            if (OnClose != null)
                OnClose(this, EventArgs.Empty);
        }

        private void aButton1_Click(object sender, EventArgs e)
        {
            HernaPlocha.PocetRiadkov = (int)aNumericUpDownRiadky.Value;
            HernaPlocha.PocetStlpcov = (int)aNumericUpDownStlpce.Value;
            CloseWindow();
        }

        private void Uvod_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vlakno.Ukonci();
            Application.Exit();
        }
    }
}
