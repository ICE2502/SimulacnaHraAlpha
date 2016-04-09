///////////////////////////////////////////////////////////
//  Boja.cs
//  Implementation of the Class Boja
//  Generated by Enterprise Architect
//  Created on:      17-2-2016 17:13:21
//  Original author: Dobroslav Grygar
///////////////////////////////////////////////////////////

using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;
using SimulacnaHra.Properties;

namespace SimulacnaHra.prvkyHry.infrastruktura {

    /// <summary>
    /// Boja sl��i na orient�ciu lod�.
    /// </summary>
	public class Boja : MiestoZastavenia {

        /// <summary>
        /// Inicializ�cia potrebn�ch vec�
        /// </summary>
        /// <param name="paPoloha"></param>
		public Boja(Poloha paPoloha){

            Poloha = paPoloha;
            NastavObrazok(Resources.boja, "boja");
            ZburatelneAutomaticky = false;
            NakladyNaZburanie = 50;
            Cena = 100;
            MozePriat = DruhVozidla.vodne;
		}

	    public override string ToString()
	    {
	        return "B�ja";
	    }
	}//end Boja

}//end namespace infrastruktura