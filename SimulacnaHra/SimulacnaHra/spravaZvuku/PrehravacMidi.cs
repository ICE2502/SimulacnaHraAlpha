using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace SimulacnaHra.spravaZvuku
{
    /// <summary>
    /// Prehrávač MIDI súborov - na hudbu v pozadí
    /// Kód pochádza z: http://stackoverflow.com/questions/3884251/no-sound-heard-while-playing-a-midi-file-in-c-net
    /// Pôvodná aplikácia: https://sourceforge.net/projects/tea-timer/
    /// </summary>
    public class PrehravacMidi
    {
        private readonly string sAlias = "TeaTimerAudio";
        private int aPrehravaneCislo;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        [DllImport("Winmm.dll")]
        private static extern long PlaySound(byte[] data, IntPtr hMod, UInt32 dwFlags);

        public PrehravacMidi()
        {
            aPrehravaneCislo = 0;
        }


        private void Play(string sFile)
        {
            _Open(sFile);
            _Play();
        }

        private void Stop()
        {
            _Close();
        }

        private void _Open(string sFileName)
        {
            if (_Status() != "")
                _Close();

            string sCommand = "open \"" + sFileName + "\" alias " + sAlias;
            mciSendString(sCommand, null, 0, IntPtr.Zero);
        }

        private void _Close()
        {
            string sCommand = "close " + sAlias;
            mciSendString(sCommand, null, 0, IntPtr.Zero);
        }

        private void _Play()
        {
            string sCommand = "play " + sAlias;
            mciSendString(sCommand, null, 0, IntPtr.Zero);
        }

        private string _Status()
        {
            StringBuilder sBuffer = new StringBuilder(128);
            mciSendString("status " + sAlias + " mode", sBuffer, sBuffer.Capacity, IntPtr.Zero);
            return sBuffer.ToString();
        }


        /// <summary>
        /// Metóda prehráva sesničky, po dokončení jednej sa spustí iná
        /// Volám ju pri každom cykle časovača
        /// </summary>
        public void Play()
        {

            if (_Status().Equals("") || _Status().Contains("stopped"))
            {
                if (aPrehravaneCislo < 31)
                {
                    aPrehravaneCislo++;
                    String cesta = "../Zvuky/hudba(" + aPrehravaneCislo + ").mid";
                    Play(cesta);
                }
                else
                {
                    aPrehravaneCislo = 0;
                }
            }
        }
    }

}
