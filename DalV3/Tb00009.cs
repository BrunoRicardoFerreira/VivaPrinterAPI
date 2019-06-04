using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb00009
    {
        public Tb00009()
        {
            Tb02112 = new HashSet<Tb02112>();
        }

        public string Tb00009Codigo { get; set; }
        public string Tb00009Nome { get; set; }
        public DateTime? Tb00009Dtcad { get; set; }
        public string Tb00009Opcad { get; set; }
        public DateTime? Tb00009Dtalt { get; set; }
        public string Tb00009Opalt { get; set; }
        public string Tb00009Situacao { get; set; }

        public virtual ICollection<Tb02112> Tb02112 { get; set; }
    }
}