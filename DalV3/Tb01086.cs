using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01086
    {
        public Tb01086()
        {
            Tb02169 = new HashSet<Tb02169>();
        }

        public DateTime? Tb01086Dtcad { get; set; }
        public string Tb01086Opcad { get; set; }
        public DateTime? Tb01086Dtalt { get; set; }
        public string Tb01086Opalt { get; set; }
        public string Tb01086Codigo { get; set; }
        public string Tb01086Nome { get; set; }
        public string Tb01086Situacao { get; set; }
        public string Tb01086Tipo { get; set; }

        public virtual ICollection<Tb02169> Tb02169 { get; set; }
    }
}