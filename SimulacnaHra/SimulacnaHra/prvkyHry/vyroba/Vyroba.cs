///////////////////////////////////////////////////////////
//  Vyroba.cs
//  Implementation of the Class Vyroba
//  Generated by Enterprise Architect
//  Created on:      17-2-2016 17:13:23
//  Original author: Dobroslav Grygar
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using SimulacnaHra.gui;
using SimulacnaHra.hra;
using SimulacnaHra.matematika;
using SimulacnaHra.prvkyHry.infrastruktura;
using SimulacnaHra.prvkyHry.mapa;
using SimulacnaHra.Properties;

namespace SimulacnaHra.prvkyHry.vyroba {

    /// <summary>
    /// V�roba je z�kladom ekonomiky. Hr�� prepravuje porodukty v�roby
    /// </summary>
	public class Vyroba : ZakladObrazku, IMaRozhranie {

		private String aNazov;
		private List<TypPrepravJednotky> aPrijma;
		private Dictionary<TypPrepravJednotky, int> aProdukuje;
		private ZoskupenieStanic aPrilahlaStanica;
	    private DruhVyroby aDruhVyroby;
        private VyrobaForm aOkno =null;

        private Dok aDok;
        private const int cMinProd = 80;
        private const int cMaxProd = 150;
        private const int cStrProd = 100;

	    public List<TypPrepravJednotky> Prijma{get { return aPrijma; }}
	    public Poloha Poloha { get; set;  }
        public ZoskupenieStanic Zoskupenie { get { return aPrilahlaStanica; } set { aPrilahlaStanica = value; } }
        public Dictionary<TypPrepravJednotky, int> Produkuje { get { return aProdukuje; } }
	    public Dok Dok {
	        get { return aDok; }
	    }

        /// <summary>
        /// Inicializ�cia v�roby. Pre ka�d� druh, je vykonan� nie�o in�
        /// </summary>
        /// <param name="paDruh"></param>
        /// <param name="paPoloha"></param>
	    public Vyroba(DruhVyroby paDruh, Poloha paPoloha)
        {
            aDok = null;
            aPrilahlaStanica = null;
            Poloha = paPoloha;
            OdsadenieZLava = Poloha.Stlpec * Policko.cVelkostPolicka;
            OdsadenieZHora = Poloha.Riadok * Policko.cVelkostPolicka;
            aPrijma = new List<TypPrepravJednotky>();
            aProdukuje = new Dictionary<TypPrepravJednotky, int>();
            aDruhVyroby = paDruh;

            switch (paDruh)
            {
                case DruhVyroby.Elektraren:
                    NastavObrazok(Resources.el, "el");
                    aPrijma.Add(TypPrepravJednotky.uhlie);
                    break;

                case DruhVyroby.Farma:
                    NastavObrazok(Resources.farm, "farm");
                    aProdukuje.Add(TypPrepravJednotky.dobytok, cStrProd);
                    aProdukuje.Add(TypPrepravJednotky.obilie, cStrProd);
                    break;

                case DruhVyroby.Les:
                    NastavObrazok(Resources.forest, "forest");
                    aProdukuje.Add(TypPrepravJednotky.drevo, cStrProd);
                    break;

                case DruhVyroby.Oceliaren:
                    NastavObrazok(Resources.oceliaren, "oceliaren");
                    aPrijma.Add(TypPrepravJednotky.zeleznaRuda);
                    aProdukuje.Add(TypPrepravJednotky.ocel, 0);
                    break;

                case DruhVyroby.Pila:
                    NastavObrazok(Resources.sawmill, "sawmill");
                    aPrijma.Add(TypPrepravJednotky.drevo);
                    aProdukuje.Add(TypPrepravJednotky.tovar, 0);
                    break;

                case DruhVyroby.RopnaRafineria:
                    NastavObrazok(Resources.rafineria, "rafineria");
                    aPrijma.Add(TypPrepravJednotky.ropa);
                    aProdukuje.Add(TypPrepravJednotky.tovar, 0);
                    break;

                case DruhVyroby.Tovaren:
                    NastavObrazok(Resources.farctory, "farctory");
                    aPrijma.Add(TypPrepravJednotky.ocel);
                    aPrijma.Add(TypPrepravJednotky.dobytok);
                    aPrijma.Add(TypPrepravJednotky.obilie);
                    aProdukuje.Add(TypPrepravJednotky.tovar, 0);
                    break;

                case DruhVyroby.UholnaBana:
                    NastavObrazok(Resources.mineCoalM, "mineCoalM");
                    aProdukuje.Add(TypPrepravJednotky.uhlie, cStrProd);
                    break;

                case DruhVyroby.ZelezorudnaBana:
                    NastavObrazok(Resources.mineRudaM, "mineRudaM");
                    aProdukuje.Add(TypPrepravJednotky.zeleznaRuda, cStrProd);
                    break;

                case DruhVyroby.RopnaPlosina:
                    NastavObrazok(Resources.oilPlat, "oilPlat");
                    aProdukuje.Add(TypPrepravJednotky.ropa, cStrProd);

                    aDok = new Dok(Poloha);
                    Zoskupenie = new ZoskupenieStanic();
                    Zoskupenie.PridajStanicu(aDok);
                    Zoskupenie.PridajVyrobu(this);
                    aDok.Zoskupenie = Zoskupenie;
                    break;

                case DruhVyroby.Mesto:
                    NastavObrazok(Resources.city, "city");
                    aPrijma.Add(TypPrepravJednotky.tovar);
                    aPrijma.Add(TypPrepravJednotky.cestujuci);
                    aPrijma.Add(TypPrepravJednotky.posta);
                    aProdukuje.Add(TypPrepravJednotky.cestujuci, 0);
                    aProdukuje.Add(TypPrepravJednotky.posta, 0);
                    break;
            }
            this.ZmenProdukciu();
		}

        /// <summary>
        /// Vyrobanie nejak�ho po�tu v�robn�ch jednotiek. Produkcia je vypo��tana �iasto�ne metematick�mi vz�ahmi 
        /// z celkovej produknie za mesiac a m��e by� upraven� pomocou trojuholn�kov�ho rozdelenia
        /// </summary>
		public void Vyrob(){
            if (aPrilahlaStanica != null && !aPrilahlaStanica.Uzamknute)
            {
                int dnesnaProdukcia = 0;
                double temp = 0;
                foreach (var item in aProdukuje)
                {
                    temp = (double)item.Value / (double)30;
                    dnesnaProdukcia = (int)Math.Round(temp, MidpointRounding.AwayFromZero);

                    if (dnesnaProdukcia > 0)
                    {
                        dnesnaProdukcia = Nahoda.TriaInt(dnesnaProdukcia-1, dnesnaProdukcia, dnesnaProdukcia+1);
                    }

                    for (int i = 0; i < dnesnaProdukcia; i++)
                    {
                        aPrilahlaStanica.NechajCakat(new PrepravJednotka(item.Key));
                    }
                    Console.WriteLine(item.Key + " " + dnesnaProdukcia);
                }
            }
		}

        /// <summary>
        /// Ak m��em dan� jednotku pria�, tak ju pr�jmem a vyrob�m
        /// Ak vyr�bam z "polotovaru" tak sa cca 20% strat� pri v�robnom procese.
        /// </summary>
        /// <param name="paPrepJedn">tdruh prep j</param>
        /// <returns>�i sa podarilo</returns>
        public bool Vyrob(PrepravJednotka paPrepJedn)
        {
            if (aPrilahlaStanica != null && aPrijma.Contains(paPrepJedn.Typ))
            {
                if (aDruhVyroby != DruhVyroby.Mesto && aDruhVyroby != DruhVyroby.Elektraren)
                {
                    double rmd = Nahoda.NahodneCislo0az1();

                    if (rmd < 0.8)
                    {
                        PrepravJednotka prepJ = new PrepravJednotka(aProdukuje.Keys.First());
                        aPrilahlaStanica.NechajCakat(prepJ);
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        ///
        /// Ak je firma prvov�robn�, tak je mo�n�, �e sa jej mno�stvo vyroben�ch produktov zmen�
        ///  Ak nie je prvov�robn�, tak sa vyr�ba pod�a toho, ko�ko sa pr�jme
        /// </summary>
		public void ZmenProdukciu(){
            var kluce = new List<TypPrepravJednotky>(aProdukuje.Keys);

            foreach (TypPrepravJednotky kluc in kluce)
            {
                if (aProdukuje[kluc] != 0)
                {
                    aProdukuje[kluc] = Nahoda.TriaInt(cMinProd, aProdukuje[kluc], cMaxProd);
                }
                
            }
		}

        /// <summary>
        /// Vr�ti inform�ciu o tom, �o vyr�ba
        /// </summary>
        /// <returns>popis toho �o vyr�ba</returns>
	    public String CoVyrabas()
	    {
	        String vystup = "";

	        foreach (var item in aProdukuje)
	        {
	            vystup += item.Key + ", ";
	        }
	        return vystup ;
	    }

        /// <summary>
        /// Vr�ti inform�ciu o tom, �o pr�jma
        /// </summary>
        /// <returns>popis toho �o pr�jma</returns>
	    public String CoPrijmas()
	    {
            String vystup = "";

            foreach (var item in aPrijma)
            {
                vystup += item + ", ";
            }
            return vystup;
	    }

	    public void ZobrazForm()
	    {
            if (aOkno == null)
	        {
                aOkno = new VyrobaForm(this);
	        }
            aOkno.Show();
            aOkno.Activate();
	    }

        public void ZmazOkno()
        {
            aOkno = null;
        }

        public override String ToString()
	    {
	        return aDruhVyroby.ToString();
	    }
	}//end Vyroba
}//end namespace vyroba