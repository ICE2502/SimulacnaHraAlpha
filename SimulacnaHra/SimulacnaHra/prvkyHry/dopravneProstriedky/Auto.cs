///////////////////////////////////////////////////////////
//  Auto.cs
//  Implementation of the Class Auto
//  Generated by Enterprise Architect
//  Created on:      17-2-2016 17:13:21
//  Original author: Dobroslav Grygar
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using gui;
using SimulacnaHra.gui;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.infrastruktura;
using SimulacnaHra.prvkyHry.mapa;
using SimulacnaHra.prvkyHry.vyroba;
using SimulacnaHra.Properties;

namespace SimulacnaHra.prvkyHry.dopravneProstriedky {
    
    /// <summary>
    /// Trieda, ktor� reprezentuje auto
    /// </summary>
	public class Auto : PrototypDp
	{
        private int aAktualnyFrame;
	    private Vrchol aZacVrch;
	    private Vrchol aKonVrch;
	    private Vrchol aAktVrch;
	    private List<Hrana> aTrasa;
	    private int aHranaNaTrase;
	    private int aPoziciaNaHrane;


		public Auto(Poloha paPoloha, TypPrepravJednotky paTypPreprJ, int paKapacita, int paRychlost, int paCena, String paNazov)
            : base(paPoloha, paTypPreprJ, paKapacita, paRychlost, paCena, paNazov)
        {

		}

        public Auto(PrototypDp paPredloha, SmerZast paSmer)
            : base(paPredloha)
	    {
            if (paSmer == SmerZast.horizontalny)
            {
                NastavObrazok(Resources.vozidloVpravo, "vozidloVpravo");

            }
            else
            {
                NastavObrazok(Resources.vozidloHore, "vozidloHore");
            }
            aAktualnyFrame = 0;
            JeVCieli = true;
            Skryte = false;
            Druh = DruhVozidla.cestne;
            aTrasa = new List<Hrana>();
	    }

        /// <summary>
        /// Vyh�ad�vanie trasy pod�a upraven�ho dijkstrov�ho algoritmu
        /// (pre digraf)
        /// </summary>
        /// <param name="paPolohaDo"></param>
        /// <returns></returns>
	    public override bool NajdiTrasu(Poloha paPolohaDo)
	    {
	        JeVCieli = false;
	        aHranaNaTrase = 0;
	        aPoziciaNaHrane = 0;

            aTrasa = DijkstrovAlg.NajdiTrasu(Poloha, paPolohaDo, Druh);
            if (aTrasa == null)
            {
                Strateny = true;
                Sprava.Info("Vozidlo sa stratilo");
                Kamera.DajInstanciu().VycentrujPohlad(Poloha);
                return false;
            }
            return true;
	    }

        /// <summary>
        /// Vyh�adanie za�iato�n�ho vrcholu v zozname vrcholov
        /// </summary>
        /// <returns>za�iato�n� vrchol</returns>

	    public override void VykonajPohyb()
	    {
            if (Strateny) return;
	        aAktualnyFrame++;
	        if (aAktualnyFrame == FramePohyb)
	        {
	            aAktualnyFrame = 0;

                if (aTrasa.Count == 0)
                {
                    JeVCieli = true;
                }
                else
                {
                    if (aTrasa.Count > aHranaNaTrase && aTrasa[aHranaNaTrase].DajHodnotu() > aPoziciaNaHrane + 1)
                    {
                        Poloha = aTrasa[aHranaNaTrase].DajPolicko(aPoziciaNaHrane).Poloha;
                        aPoziciaNaHrane++;
                        VyberObrazok(aTrasa[aHranaNaTrase]);
                    }
                    else if (aTrasa.Count > aHranaNaTrase)
                    {
                        aPoziciaNaHrane = 0;
                        Poloha = aTrasa[aHranaNaTrase].Vrchol2.Policko.Poloha;
                        aHranaNaTrase++;
                        if (aHranaNaTrase<aTrasa.Count)
                        {
                            VyberObrazok(aTrasa[aHranaNaTrase]);
                        }
                    }
                    else
                    {
                        aHranaNaTrase = 0;
                        JeVCieli = true;
                    }

                }
	        }
	        

        }

        /// <summary>
        /// V�ber spr�vneho obr�zku
        /// </summary>
        /// <param name="paHrana">nasledujuca hrana</param>
	    private void VyberObrazok(Hrana paHrana)
        {
            if (paHrana.Vrchol2.Policko.Poloha.Riadok < Poloha.Riadok)
	        {
                NastavObrazok(Resources.vozidloHore, "vozidloHore");
            }
            else if (paHrana.Vrchol2.Policko.Poloha.Riadok > Poloha.Riadok)
	        {
                NastavObrazok(Resources.vozidloDole, "vozidloDole");
	        }
            else if (paHrana.Vrchol2.Policko.Poloha.Stlpec < Poloha.Stlpec)
            {
                NastavObrazok(Resources.vozidloVlavo, "vozidloVlavo");
            }
            else if (paHrana.Vrchol2.Policko.Poloha.Stlpec > Poloha.Stlpec)
            {
                NastavObrazok(Resources.vozidloVpravo, "vozidloVpravo");
            }

	    }

	    public override bool Zastav()
        {
            return true;
        }

        public override string ToString()
        {
            return "Auto: " + Nazov;
        }
	}//end Auto

}//end namespace dopravneProstriedky