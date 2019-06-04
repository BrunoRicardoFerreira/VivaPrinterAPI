using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01030
    {
        public Tb01030()
        {
            Tb01010 = new HashSet<Tb01010>();
        }

        public DateTime? Tb01030Dtcad { get; set; }
        public string Tb01030Opcad { get; set; }
        public DateTime? Tb01030Dtalt { get; set; }
        public string Tb01030Opalt { get; set; }
        public string Tb01030Codigo { get; set; }
        public string Tb01030Nome { get; set; }
        public string Tb01030Situacao { get; set; }
        public string Tb01030Clst { get; set; }
        public decimal? Tb01030Mva { get; set; }
        public decimal? Tb01030Percibpt { get; set; }
        public string Tb01030Cest { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
    }
}