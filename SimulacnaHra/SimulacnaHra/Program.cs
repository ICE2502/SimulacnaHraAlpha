using System;
using System.Windows.Forms;
using SimulacnaHra.gui;
using SimulacnaHra.spravaZvuku;

namespace SimulacnaHra
{
    static class Program
    {

        private static OknoAplikacie _okno2;

        /// <summary>
        /// The main entry point for the application.
        /// Na začiatku sa spustí úvodné okno. 
        /// Po jeho zatvorení sa spustí hlavné okno hry.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Vlakno.Pracuj();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var okno1 = new Uvod();
            okno1.OnClose += Okno1_OnClose;
            Application.Run(okno1);
        }

        private static void Okno1_OnClose(object sender, EventArgs e)
        {
            var form1 = (sender as Uvod);
            form1.Visible = false;
            _okno2 = OknoAplikacie.DajInstanciu();
            _okno2.Show();
        }
    }
}
