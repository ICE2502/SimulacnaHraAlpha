using System.Collections.Generic;
using System.Linq;
using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;

namespace SimulacnaHra.prvkyHry.mapa
{
    public class DijkstrovAlg
    {
        private static HernaPlocha aHernaPlocha;
        private static List<Hrana> aTrasa;
        private static Poloha aPolohaZ;
        private static Vrchol aAktVrch;
        private static Vrchol aZacVrch;
        private static Vrchol aKonVrch;

        public DijkstrovAlg()
        {
            //aHernaPlocha = Hra.DajInstanciu().DajHernuPlochu();
        }

        public static List<Hrana> NajdiTrasu(Poloha paZ, Poloha paDo, DruhVozidla paDruhVozidla)
        {
            aHernaPlocha = Hra.DajInstanciu().DajHernuPlochu();
            aTrasa = new List<Hrana>();
            aPolohaZ = paZ;
            aZacVrch = NajdiZaciatocnyVrchol();
            aKonVrch = NajdiCielovyVrchol(paDo);
            if (aZacVrch == null || aKonVrch == null) return null;
            if (aZacVrch == aKonVrch) return aTrasa;
            aZacVrch.NajkratciaVzdialenost = 0;
            aAktVrch = aZacVrch;
            aAktVrch.Docastnost = false;
            PrejdiVystupnuHviezdu();
            Backtracking();
            aHernaPlocha.PovodnyStavVrcholov();
            if (!aTrasa.Any())
            {
                return null;
            }
            return aTrasa;
        }

        private static Vrchol NajdiZaciatocnyVrchol()
        {
            return aHernaPlocha.ZoznamVrcholov.FirstOrDefault(item =>
                item.Policko.Poloha.Riadok == aPolohaZ.Riadok && item.Policko.Poloha.Stlpec == aPolohaZ.Stlpec);
        }

        /// <summary>
        /// Vyhľadanie konečného vrcholu v zozname vrcholov
        /// </summary>
        /// <param name="paPoloha">poloha</param>
        /// <returns>konečný vrchol</returns>
        private static Vrchol NajdiCielovyVrchol(Poloha paPoloha)
        {
            return aHernaPlocha.ZoznamVrcholov.FirstOrDefault(item =>
                item.Policko.Poloha.Riadok == paPoloha.Riadok && item.Policko.Poloha.Stlpec == paPoloha.Stlpec);
        }

        /// <summary>
        /// Metoda kontroluje vystupnu hviezdu vrchola, ktorá je aktualny.
        /// Zistuje, porovnava a pripadne prepisuje vzdialenosti od vychodzieho vrchola
        /// </summary>
        private static void PrejdiVystupnuHviezdu()
        {
            Vrchol druhyVrch;
            int vzdialenostPred;
            int dlzkaPristupu;
            foreach (var item in aHernaPlocha.ZoznamHran)
            {
                if (item.Vrchol1 == aAktVrch && item.Vrchol2 != null)
                {
                    druhyVrch = item.Vrchol2;
                    vzdialenostPred = druhyVrch.NajkratciaVzdialenost;
                    dlzkaPristupu = item.DajHodnotu() + aAktVrch.NajkratciaVzdialenost;

                    if (dlzkaPristupu < vzdialenostPred)
                    {
                        druhyVrch.NajkratciaVzdialenost = dlzkaPristupu;
                        druhyVrch.Predchodca = aAktVrch;
                    }

                }
            }
            Vrchol novy = ZistiKtorymPokracovat();
            if (novy == null) return;

            aAktVrch = novy;
            aAktVrch.Docastnost = false;

            if (aKonVrch.Docastnost)
            {
                PrejdiVystupnuHviezdu();
            }
        }

        /// <summary>
        /// Metoda ma za ulohu zistit, ktory z docasnych vrcholov ma najnizsiu vzdialenost od vychdzieho.
        /// </summary>
        /// <returns>vrchol ktorý je na to najlepší</returns>
        private static Vrchol ZistiKtorymPokracovat()
        {

            int indexNajblizsieho = -1;
            int najkratsiaVzdialenost = int.MaxValue;
            Vrchol vrch;

            for (int i = 0; i < aHernaPlocha.ZoznamVrcholov.Count; i++)
            {
                vrch = aHernaPlocha.ZoznamVrcholov[i];
                if (vrch.NajkratciaVzdialenost < najkratsiaVzdialenost && vrch.Docastnost)
                {
                    najkratsiaVzdialenost = vrch.NajkratciaVzdialenost;
                    indexNajblizsieho = i;
                }
            }

            return indexNajblizsieho == -1 ? null : aHernaPlocha.ZoznamVrcholov[indexNajblizsieho];
        }

        /// <summary>
        /// Vytvorenie trasy podľa grafu
        /// </summary>
        private static void Backtracking()
        {
            aTrasa.Clear();

            Vrchol druhy = aKonVrch;
            Vrchol prvy = aKonVrch.Predchodca;
            if (druhy == null || prvy == null)
            {
                return;
            }
            bool pokracuj = true;

            while (pokracuj)
            {
                foreach (var item in aHernaPlocha.ZoznamHran)
                {
                    if (item.Vrchol2 == druhy && item.Vrchol1 == prvy)
                    {
                        aTrasa.Insert(0, item);
                        if (prvy == aZacVrch)
                        {
                            pokracuj = false;
                        }
                        break;
                    }
                }
                druhy = prvy;
                prvy = druhy.Predchodca;
            }
        }
    }


}
