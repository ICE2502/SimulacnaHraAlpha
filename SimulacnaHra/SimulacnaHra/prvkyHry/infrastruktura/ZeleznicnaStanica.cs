///////////////////////////////////////////////////////////
//  ZeleznicnaStanica.cs
//  Implementation of the Class ZeleznicnaStanica
//  Generated by Enterprise Architect
//  Created on:      17-2-2016 17:13:23
//  Original author: Dobroslav Grygar
///////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;
using SimulacnaHra.prvkyHry.vyroba;
using SimulacnaHra.Properties;

namespace SimulacnaHra.prvkyHry.infrastruktura {

    [Serializable]
	public class ZeleznicnaStanica : Stanica {

		private int aDlzkaNastupista;
		private int aPocetKolaji;

        public SmerZast SmerZastavky { get; set; }
        private List<PrototypDp> aMozneStroje;

        public override List<PrototypDp> MozneStroje
        {
            get { return aMozneStroje; }
        }

        public ZeleznicnaStanica(Poloha paPoloha, SmerZast paSmerZast)
        {
            Poloha = paPoloha;
            SmerZastavky = paSmerZast;
            aMozneStroje = new List<PrototypDp>();

            if (SmerZastavky == SmerZast.horizontalny)
            {
                NastavObrazok(Resources.zelStanicaVodor, "zelStanicaVodor");
            }
            else
            {
                NastavObrazok(Resources.zelStanicaZv, "zelStanicaZv");
            }

            ZburatelneAutomaticky = false;
            NakladyNaZburanie = 200;
            Cena = 650;
            Predlohy();
        }

        private void Predlohy()
        {
            aMozneStroje.Add(new Vlak(Poloha, TypPrepravJednotky.cestujuci, 120, 193, 601000, "Vlak pre cestuj�cich"));

            aMozneStroje.Add(new Vlak(Poloha, TypPrepravJednotky.posta, 105, 180, 556000, "Po�tov� vlak"));

            aMozneStroje.Add(new Vlak(Poloha, TypPrepravJednotky.tovar, 103, 180, 587000, "Vlak na tovar"));

            aMozneStroje.Add(new Vlak(Poloha, TypPrepravJednotky.obilie, 115, 180, 599000, "Vlak na obilie"));

            aMozneStroje.Add(new Vlak(Poloha, TypPrepravJednotky.dobytok, 118, 180, 603000, "Vlak na dobytok"));

            aMozneStroje.Add(new Vlak(Poloha, TypPrepravJednotky.drevo, 125, 180, 585000, "Vlak na drevo"));

            aMozneStroje.Add(new Vlak(Poloha, TypPrepravJednotky.uhlie, 130, 180, 585000, "Vlak na Uhlie"));

            aMozneStroje.Add(new Vlak(Poloha, TypPrepravJednotky.zeleznaRuda, 128, 180, 603000, "Vlak na �elezn� rudu"));

            aMozneStroje.Add(new Vlak(Poloha, TypPrepravJednotky.ocel, 108, 180, 587000, "Vlak na oce�"));

            MozePriat = DruhVozidla.kolajove;
        }

        public override String ToString()
        {
            return "�elezni�n� stanica";
        }

	    public override bool PostavStroj(int paPor)
	    {
            Spolocnost spol = Hra.DajInstanciu().Spolocnost;
            if (paPor >= 0 && paPor < aMozneStroje.Count)
            {
                Vlak autoStavane = new Vlak(aMozneStroje[paPor], SmerZastavky);
                if (spol.UpravFinancie(-autoStavane.Cena))
                {
                    DopravnyProstriedok dp = new DopravnyProstriedok(autoStavane);
                    spol.PridajDP(dp);
                    PridajOdstavene(dp);
                }
            }
            return false;
	    }
	}//end ZeleznicnaStanica

}//end namespace infrastruktura