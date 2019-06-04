using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01107
    {
        public Tb01107()
        {
            Tb01001 = new HashSet<Tb01001>();
            Tb01008 = new HashSet<Tb01008>();
        }

        public DateTime? Tb01107Dtcad { get; set; }
        public string Tb01107Opcad { get; set; }
        public DateTime? Tb01107Dtalt { get; set; }
        public string Tb01107Opalt { get; set; }
        public string Tb01107Codigo { get; set; }
        public string Tb01107Nome { get; set; }
        public string Tb01107Situacao { get; set; }

        public virtual ICollection<Tb01001> Tb01001 { get; set; }
        public virtual ICollection<Tb01008> Tb01008 { get; set; }
    }
}