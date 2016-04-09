using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacnaHra.matematika
{
    /// <summary>
    /// Trieda náhoda poskytuje potrebné funkcie rozdelení
    /// ktoré sa využívajú pri generovaní mapy
    /// herných prvkov, produkcie atď
    /// </summary>
    public class Nahoda
    {
        private static Random aRnd = new Random();

        /// <summary>
        /// Obyčajné desatinné číslo medzi 0 a 1
        /// </summary>
        /// <returns>náhodné desatinné číslo</returns>
        public static double NahodneCislo0az1()
        {
            return aRnd.NextDouble();
        }

        /// <summary>
        /// Náhodné celé číslo v zadanom rozsahu
        /// </summary>
        /// <param name="paOd">dolná hranica</param>
        /// <param name="paDo">horná hranica</param>
        /// <returns>Náhodné celé číslo</returns>
        public static int NahodnyInt(int paOd, int paDo)
        {
            return aRnd.Next(paOd, paDo);
        }

        /// <summary>
        /// Trojuholníkové rozdelenie pre desatinné čísla
        /// </summary>
        /// <param name="paMin">najmenšie číslo</param>
        /// <param name="paStred">stredná hodnota</param>
        /// <param name="paMax">najväčšie číslo</param>
        /// <returns>áhodné desatinné číslo</returns>
        public static double TriaDou(double paMin, double paStred, double paMax)
        {
            double F = (paStred - paMin) / (paMax - paMin);
            double rand = aRnd.NextDouble();
            if (rand < F)
            {
                return paMin + Math.Sqrt(rand * (paMax - paMin) * (paStred - paMin));
            }
            else
            {
                return paMax - Math.Sqrt((1 - rand) * (paMax - paMin) * (paMax - paStred));
            }
        }

        /// <summary>
        /// Trojuholníkové rozdelenie pre celé čísla
        /// </summary>
        /// <param name="paMin">najmenšie číslo</param>
        /// <param name="paStred">stredná hodnota</param>
        /// <param name="paMax">najväčšie číslo</param>
        /// <returns>áhodné celé číslo</returns>
        public static int TriaInt(int paMin, int paStred, int paMax) 
        {
            double min = (double)paMin - 0.5;
            double stred = (double)paStred;
            double max = (double)paMax+0.49999;
        
            double F = (stred - min) / (max - min);
            double rand = aRnd.NextDouble();
            if (rand < F) {
                return (int)Math.Round(min + Math.Sqrt(rand * (max - min) * (stred - min)), MidpointRounding.AwayFromZero);
            } else {
                return (int)Math.Round(max - Math.Sqrt((1 - rand) * (max - min) * (max - stred)), MidpointRounding.AwayFromZero);
            }
        }
    }
}