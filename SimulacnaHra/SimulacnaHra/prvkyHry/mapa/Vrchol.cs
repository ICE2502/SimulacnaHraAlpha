using System;

namespace SimulacnaHra.prvkyHry.mapa
{
    /// <summary>
    /// Vrchol digrafu, pre účely hľadania trás
    /// </summary>
    [Serializable]
    public class Vrchol
    {
        public Policko Policko { get; set; }
        public bool Docastnost { get; set; }
        public Vrchol Predchodca { get; set; }
        public int NajkratciaVzdialenost { get; set; }

        public Vrchol(Policko paPolicko) {
            Policko = paPolicko;
            ZaciatocnyStav();
        }

        /// <summary>
        /// návrat na začiatočný stav
        /// </summary>
        public void ZaciatocnyStav()
        {
            Docastnost = true;
            Predchodca = null;
            NajkratciaVzdialenost = int.MaxValue;
        }

    }

}
