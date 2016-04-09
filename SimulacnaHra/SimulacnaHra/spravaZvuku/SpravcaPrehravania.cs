using System;
using System.Threading;
using System.Timers;
using SimulacnaHra.gui;
using Timer = System.Timers.Timer;

namespace SimulacnaHra.spravaZvuku
{

    /// <summary>
    /// Vlastná úprava pôvodného kódu na:
    /// https://msdn.microsoft.com/en-us/library/7a2f3ay4(v=vs.90).aspx
    /// </summary>
    public class SpravcaPrehravania
    {
        private Timer aCasovac;
        private PrehravacMidi aPrehravac;
        public SpravcaPrehravania()
        {
            aPrehravac = new PrehravacMidi();
            aCasovac = new Timer(4000);
        }

        public void DoWork()
        {
            aCasovac.Elapsed += TestniPesnicku;
            aPrehravac.Play();
            Thread.Sleep(10000);
            aCasovac.Start();
        }

        private void TestniPesnicku(Object source, ElapsedEventArgs e)
        {
            aPrehravac.Play();
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }
        // Volatile is used as hint to the compiler that this data 
        // member will be accessed by multiple threads. 
        private volatile bool _shouldStop;
    }
}
