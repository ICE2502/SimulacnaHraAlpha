using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacnaHra.prvkyHry.infrastruktura
{
    /// <summary>
    /// Smer ciest
    /// </summary>
    public enum SmerCesty : int
    {
        odbVodorovneDole = 4,
        odbVodorovneHore = 5,
        odbZvysleVlavo = 6,
        odbZvysleVpravo = 7,
        zakDoleVlavo = 8,
        zakDoleVpravo = 11,
        zakHoreVpravo = 10,
        zakHoreVlavo = 9,
        krizovatka = 3,
        vodorovne = 1,
        zvisle = 2
    }
}
