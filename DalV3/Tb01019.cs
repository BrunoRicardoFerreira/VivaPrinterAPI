using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01019
    {
        public Tb01019()
        {
            Tb01008 = new HashSet<Tb01008>();
        }

        public DateTime? Tb01019Dtcad { get; set; }
        public string Tb01019Opcad { get; set; }
        public DateTime? Tb01019Dtalt { get; set; }
        public string Tb01019Opalt { get; set; }
        public string Tb01019Codigo { get; set; }
        public string Tb01019Nome { get; set; }
        public string Tb01019Situacao { get; set; }

        public virtual ICollection<Tb01008> Tb01008 { get; set; }
    }
}