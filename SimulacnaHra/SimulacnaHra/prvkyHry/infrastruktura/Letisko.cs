///////////////////////////////////////////////////////////
//  Letisko.cs
//  Implementation of the Class Letisko
//  Generated by Enterprise Architect
//  Created on:      17-2-2016 17:13:21
//  Original author: Dobroslav Grygar
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;
using SimulacnaHra.prvkyHry.vyroba;
using SimulacnaHra.Properties;

namespace SimulacnaHra.prvkyHry.infrastruktura {

    /// <summary>
    /// M��u tu zastavova� lietadl�
    /// </summary>
	public class Letisko : Stanica
	{
	    private List<PrototypDp> aMozneStroje;
        public override List<PrototypDp> MozneStroje
        {
	        get { return aMozneStroje; }
	    }

        /// <summary>
        /// Kon�truktor inicializuje v�etko potrebn�
        /// </summary>
        /// <param name="paPoloha"></param>
	    public Letisko(Poloha paPoloha)

	    {
            Poloha = paPoloha;

            base.ZburatelneAutomaticky = false;
            base.NastavObrazok(Resources.letisko, "letisko");
            Cena = 10000;
            NakladyNaZburanie = 2000;
            aMozneStroje = new List<PrototypDp>();
            Predlohy();
		}

        /// <summary>
        /// Vytvorenie predl�h toho, �o bude mo�n� stava�
        /// </summary>
	    private void Predlohy()
	    {
            aMozneStroje.Add(new Lietadlo(Poloha, TypPrepravJednotky.cestujuci, 40, 320, 200000, "Junkers Ju 90A-1"));
            aMozneStroje.Add(new Lietadlo(Poloha, TypPrepravJednotky.posta, 35, 300, 180000, "Lisunov Li-2"));
            aMozneStroje.Add(new Lietadlo(Poloha, TypPrepravJednotky.cestujuci, 75, 350, 323000, "Boeing 314 Clipper"));
            aMozneStroje.Add(new Lietadlo(Poloha, TypPrepravJednotky.posta, 220, 780, 1256000, "Airbus A400M"));
            aMozneStroje.Add(new Lietadlo(Poloha, TypPrepravJednotky.cestujuci, 412, 893, 2005000, "Boeing 747-300"));
            MozePriat = DruhVozidla.vzdusne;
	    }

	    public override string ToString()
        {
            return "Letisko";
        }

	    public override bool PostavStroj(int paPor)
	    {
            if (paPor >= 0 && paPor < aMozneStroje.Count)
	        {
                Lietadlo liet = new Lietadlo(aMozneStroje[paPor]);
                if (Spolocnost.UpravFinancie(-liet.Cena))
                {
                    DopravnyProstriedok dp = new DopravnyProstriedok(liet);
                    Hra.DajInstanciu().Spolocnost.PridajDP(dp);
                    PridajOdstavene(dp);
                }
	        }
	        return false;
	    }

	}//end Letisko

}//end namespace infrastruktura