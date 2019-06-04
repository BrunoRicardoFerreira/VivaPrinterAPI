using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01002
    {
        public Tb01002()
        {
            Tb01010 = new HashSet<Tb01010>();
            Tb01058 = new HashSet<Tb01058>();
        }

        public DateTime? Tb01002Dtcad { get; set; }
        public string Tb01002Opcad { get; set; }
        public DateTime? Tb01002Dtalt { get; set; }
        public string Tb01002Opalt { get; set; }
        public string Tb01002Codigo { get; set; }
        public string Tb01002Nome { get; set; }
        public string Tb01002Situacao { get; set; }
        public decimal? Tb01002Comissao { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb01058> Tb01058 { get; set; }
    }
}