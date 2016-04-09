///////////////////////////////////////////////////////////
//  Cesta.cs
//  Implementation of the Class Cesta
//  Generated by Enterprise Architect
//  Created on:      17-2-2016 17:13:21
//  Original author: Dobroslav Grygar
///////////////////////////////////////////////////////////

using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;
using SimulacnaHra.Properties;

namespace SimulacnaHra.prvkyHry.infrastruktura {

    /// <summary>
    /// Po ceste jazdia cestn� vozidl�. 
    /// Je mo�n� stava� r�zne cestn� prvky, napr�klad rovn� cestu, 
    /// kri�ovatky, alebo viac druhov odbo�iek
    /// </summary>
	public class Cesta : Infrastruktura {

		private SmerCesty aOrientacia;

        public SmerCesty Orientacia { get { return aOrientacia; } }

        /// <summary>
        /// Cesta + priradenie spr�vnych obr�zkov a s�m, 
        /// pod�a jednotiliv�ch druhov
        /// </summary>
        /// <param name="paSmer"></param>
        /// <param name="paPoloha"></param>
		public Cesta(SmerCesty paSmer, Poloha paPoloha){

            base.ZburatelneAutomaticky = false;
            aOrientacia = paSmer;
            Poloha = paPoloha;

            switch (aOrientacia)
            { 
                case SmerCesty.krizovatka :
                    NastavObrazok(Resources.cestaKri�ovatka, "cestaKri�ovatka");
                    Cena = 300;
                    break;

                case SmerCesty.odbVodorovneDole:
                    NastavObrazok(Resources.cestaOdbVodorovneDole, "cestaOdbVodorovneDole");
                    Cena = 250;
                    break;

                case SmerCesty.odbVodorovneHore:
                    NastavObrazok(Resources.cestaOdbVodorovneHore, "cestaOdbVodorovneHore");
                    Cena = 250;
                    break;

                case SmerCesty.odbZvysleVlavo:
                    NastavObrazok(Resources.cestaOdbZvysleVlavo, "cestaOdbZvysleVlavo");
                    Cena = 250;
                    break;

                case SmerCesty.odbZvysleVpravo:
                    NastavObrazok(Resources.cestaOdbZvysleVpravo, "cestaOdbZvysleVpravo");
                    Cena = 250;
                    break;

                case SmerCesty.vodorovne:
                    NastavObrazok(Resources.cestaVodorovne, "cestaVodorovne");
                    Cena = 200;
                    break;

                case SmerCesty.zakDoleVlavo:
                    NastavObrazok(Resources.cestaZakDoleVlavo, "cestaZakDoleVlavo");
                    Cena = 220;
                    break;

                case SmerCesty.zakDoleVpravo:
                    NastavObrazok(Resources.cestaZakDoleVpravo, "cestaZakDoleVpravo");
                    Cena = 220;
                    break;

                case SmerCesty.zakHoreVpravo:
                    NastavObrazok(Resources.cestaZakHoleVpravo, "cestaZakHoleVpravo");
                    Cena = 220;
                    break;

                case SmerCesty.zakHoreVlavo:
                    NastavObrazok(Resources.cestaZakHoreVlavo, "cestaZakHoreVlavo");
                    Cena = 220;
                    break;

                case SmerCesty.zvisle:
                    NastavObrazok(Resources.cestaZvisle, "cestaZvisle");
                    Cena = 200;
                    break;

            }

            NakladyNaZburanie = 100;
            Povolene = DruhVozidla.cestne;

		}

	}//end Cesta

}//end namespace infrastruktura