using SimulacnaHra.hra;
using SimulacnaHra.prvkyHry.dopravneProstriedky;

namespace SimulacnaHra.gui
{

    public class SpravcaOkien
    {

        private static ZoznamDopravProstForm aLietadla = null;
        private static ZoznamDopravProstForm aLode = null;
        private static ZoznamDopravProstForm aVlaky = null;
        private static ZoznamDopravProstForm aVozidla = null;
        private static ZoznamStanic aStanice = null;
        private static ZoznamVyrobyForm aVyroba = null;
        private static ZoznamVyrobyForm aMesta = null;

        public static DopravnyProstriedokForm AktDopProst { get; set; }

        public static void ZobrazZoznamDoprevProst(DruhVozidla paDruh)
        {
            if (paDruh == DruhVozidla.vzdusne)
            {
                if (aLietadla == null)
                {
                    aLietadla = new ZoznamDopravProstForm(DruhVozidla.cestne);
                }
                aLietadla.Show();
                aLietadla.Activate();
            }else if (paDruh == DruhVozidla.kolajove)
            {
                if (aVlaky == null)
                {
                    aVlaky = new ZoznamDopravProstForm(DruhVozidla.kolajove);
                }
                aVlaky.Show();
                aVlaky.Activate();
            }
            else if(paDruh == DruhVozidla.cestne)
            {
                if (aVozidla == null)
                {
                    aVozidla = new ZoznamDopravProstForm(DruhVozidla.cestne);
                }
                aVozidla.Show();
                aVozidla.Activate();

            }
            else
            {
                if (aLode == null)
                {
                    aLode = new ZoznamDopravProstForm(DruhVozidla.vodne);
                }
                aLode.Show();
                aLode.Activate();
            }
        }

        public static void ZoznamVyroby(bool paJeMesto)
        {
            if (paJeMesto)
            {
                if (aMesta == null)
                {
                    aMesta = new ZoznamVyrobyForm(Hra.DajInstanciu().ZoznamMiest);
                }
                aMesta.Show();
                aMesta.Activate();
            }
            else
            {
                if (aVyroba == null)
                {
                    aVyroba = new ZoznamVyrobyForm(Hra.DajInstanciu().ZoznamVyroby);
                }
                aVyroba.Show();
                aVyroba.Activate();
            }
        }

        public static void ZoznamStanic()
        {
            if (aStanice == null)
            {
                aStanice = new ZoznamStanic();
            }
            aStanice.Show();
            aStanice.Activate();
        }

        public static void VymazStanice()
        {
            aStanice = null;
        }

        public static void VymazZoznamVyroba(bool paJeMesto)
        {
            if (paJeMesto)
            {
                aMesta = null;
            }
            else
            {
                aVyroba = null;
            }
        }

        public static void VymazZoznam(DruhVozidla paDruh)
        {
            switch (paDruh)
            {
                case DruhVozidla.kolajove:
                    aVlaky = null;
                    break;

                case DruhVozidla.cestne:
                    aVozidla = null;
                    break;

                case DruhVozidla.vodne:
                    aLode = null;
                    break;

                case DruhVozidla.vzdusne:
                    aLietadla = null;
                    break;

            }
        }
    }
}
