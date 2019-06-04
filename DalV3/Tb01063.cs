using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01063
    {
        public Tb01063()
        {
            Tb01005 = new HashSet<Tb01005>();
        }

        public string Tb01063Codigo { get; set; }
        public string Tb01063Descricao { get; set; }
        public DateTime? Tb01063Dtcad { get; set; }
        public string Tb01063Opcad { get; set; }
        public DateTime? Tb01063Dtalt { get; set; }
        public string Tb01063Opalt { get; set; }
        public string Tb01063Situacao { get; set; }

        public virtual ICollection<Tb01005> Tb01005 { get; set; }
    }
}