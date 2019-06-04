using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01020
    {
        public Tb01020()
        {
            Tb01008 = new HashSet<Tb01008>();
        }

        public DateTime? Tb01020Dtcad { get; set; }
        public string Tb01020Opcad { get; set; }
        public DateTime? Tb01020Dtalt { get; set; }
        public string Tb01020Opalt { get; set; }
        public string Tb01020Codigo { get; set; }
        public string Tb01020Nome { get; set; }
        public string Tb01020Situacao { get; set; }
        public decimal? Tb01020Comissao { get; set; }

        public virtual ICollection<Tb01008> Tb01008 { get; set; }
    }
}