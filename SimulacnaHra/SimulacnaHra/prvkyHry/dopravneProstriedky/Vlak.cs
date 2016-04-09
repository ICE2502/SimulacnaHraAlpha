using System.Collections.Generic;
using gui;
using SimulacnaHra.gui;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.infrastruktura;
using SimulacnaHra.prvkyHry.mapa;
using SimulacnaHra.prvkyHry.vyroba;
using SimulacnaHra.Properties;

namespace SimulacnaHra.prvkyHry.dopravneProstriedky
{
    /// <summary>
    /// Vlak je dopravný prostriedok, ktorý jazdí po kolajniciach.
    /// Vyznačuje sa veľkou rýchlosťou a kapacitou
    /// </summary>
    public class Vlak : PrototypDp
    {
        private int aAktualnyFrame;
        private Vrchol aZacVrch;
        private Vrchol aKonVrch;
        private Vrchol aAktVrch;
        private List<Hrana> aTrasa;
        private int aHranaNaTrase;
        private int aPoziciaNaHrane;


        public Vlak(Poloha paPoloha, TypPrepravJednotky paTypPreprJ, int paKapacita, int paRychlost, int paCena, string paNazov) :
            base(paPoloha, paTypPreprJ, paKapacita, paRychlost, paCena, paNazov)
        {

        }

        /// <summary>
        /// Kopírovací konštruktor
        /// </summary>
        /// <param name="paPredloha"></param>
        /// <param name="paSmer"></param>
        public Vlak(PrototypDp paPredloha, SmerZast paSmer)
            : base(paPredloha)
        {
            if (paSmer == SmerZast.horizontalny)
            {
                NastavObrazok(Resources.vlakVodorvoneVpravo, "vlakVodorvoneVpravo");

            }
            else
            {
                NastavObrazok(Resources.vlakZvisleDole, "vlakZvisleDole");
            }
            aAktualnyFrame = 0;
            JeVCieli = true;
            Skryte = false;
            Druh = DruhVozidla.kolajove;
            aTrasa = new List<Hrana>();
        }

        /// <summary>
        /// Vyhľadanie trasy pokocou dijkstru
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
                Sprava.Info("Vlak sa stratil");
                Kamera.DajInstanciu().VycentrujPohlad(Poloha);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Vykonanie pohybu
        /// </summary>
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
                        if (aHranaNaTrase < aTrasa.Count)
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
        /// Výber správneho obrázku
        /// </summary>
        /// <param name="paHrana">nasledujuca hrana</param>
        private void VyberObrazok(Hrana paHrana)
        {
            if (paHrana.Vrchol2.Policko.Poloha.Riadok < Poloha.Riadok)
            {
                NastavObrazok(Resources.vlakZvisleHore, "vlakZvisleHore");
            }
            else if (paHrana.Vrchol2.Policko.Poloha.Riadok > Poloha.Riadok)
            {
                NastavObrazok(Resources.vlakZvisleDole, "vlakZvisleDole");
            }
            else if (paHrana.Vrchol2.Policko.Poloha.Stlpec < Poloha.Stlpec)
            {
                NastavObrazok(Resources.vlakVodorovneVlavo, "vlakVodorovneVlavo");
            }
            else if (paHrana.Vrchol2.Policko.Poloha.Stlpec > Poloha.Stlpec)
            {
                NastavObrazok(Resources.vlakVodorvoneVpravo, "vlakVodorvoneVpravo");
            }

        }

        public override bool Zastav()
        {
            return true;
        }

        public override string ToString()
        {
            return "Vlak: " + Nazov;
        }
    }
}
