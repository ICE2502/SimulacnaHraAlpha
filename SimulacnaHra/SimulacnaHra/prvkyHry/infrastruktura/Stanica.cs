///////////////////////////////////////////////////////////
//  Stanica.cs
//  Implementation of the Class Stanica
//  Generated by Enterprise Architect
//  Created on:      17-2-2016 17:13:22
//  Original author: Dobroslav Grygar
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using SimulacnaHra.gui;
using SimulacnaHra.prvkyHry.dopravneProstriedky;

namespace SimulacnaHra.prvkyHry.infrastruktura {
    
    /// <summary>
    /// Abstraktn� predok v�etk�ch stan�c, rie�i pr�jem tovarov a spr�vu vozidiel
    /// </summary>
	public abstract class Stanica : MiestoZastavenia, IMaRozhranie
    {

        private StanicaForm aOkno = null;
		private List<DopravnyProstriedok> aOdstavene;
        public ZoskupenieStanic Zoskupenie { get; set; }

        /// <summary>
        /// Vr�ti zoznam pr�ve odstaven�ch dopravn�ch prostriedkov na danej stanici
        /// </summary>
	    public List<DopravnyProstriedok> Odstavene {
	        get { return aOdstavene; }
	    }

        /// <summary>
        /// Zoznam dopravn��ch prostriedkov, ktor� je mo�n� na danej stanici zak�pi�
        /// </summary>
	    public abstract List<PrototypDp> MozneStroje {get; }

	    protected Stanica()
	    {
            aOdstavene = new List<DopravnyProstriedok>();
	    }

	    public abstract override String ToString();
	    public abstract bool PostavStroj(int paPor);

        /// <summary>
        /// Vr�ti podrobn� inform�cie o niektorom za strojov, ktor� je mo�n� postavi�
        /// </summary>
        /// <param name="paIndex">poradie v zozname</param>
        /// <returns>popis</returns>
	    public string PodrobneInfo(int paIndex)
	    {
	        if (paIndex >=0 && paIndex < MozneStroje.Count)
	        {
	            return MozneStroje[paIndex].PodrobneInfo();
	        }
	        return "";
	    }

        /// <summary>
        /// Odstranenie odkazu na objekt
        /// </summary>
        public void Zburaj()
        {
            Zoskupenie.ZmazPripojenuStanicu(this);
        }

        public void ZobrazForm()
        {
            if (aOkno == null)
            {
                aOkno = new StanicaForm(this);
            }
            aOkno.Show();
            aOkno.Activate();
        }

        public void ZmazOkno()
        {
            aOkno = null;
        }

        /// <summary>
        /// Pridanie odstaveneho dopravn�ho prostriedku
        /// </summary>
        /// <param name="paDp">dp</param>
	    public void PridajOdstavene(DopravnyProstriedok paDp)
	    {
            aOdstavene.Add(paDp);
            aOkno.AktualizujOdstavaneDp();
	    }

        /// <summary>
        /// Odobratie odstaveneho dopravn�ho prostriedku
        /// </summary>
        /// <param name="paDp">dp</param>
        public void OdstranOdstavene(DopravnyProstriedok paDp)
        {
            aOdstavene.Remove(paDp);
            aOkno.AktualizujOdstavaneDp();
        }

	}//end Stanica

}//end namespace infrastruktura