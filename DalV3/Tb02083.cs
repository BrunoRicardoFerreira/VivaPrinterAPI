using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02083
    {
        public Tb02083()
        {
            Tb02084 = new HashSet<Tb02084>();
            Tb02085 = new HashSet<Tb02085>();
        }

        public DateTime? Tb02083Dtcad { get; set; }
        public string Tb02083Opcad { get; set; }
        public DateTime? Tb02083Dtalt { get; set; }
        public string Tb02083Opalt { get; set; }
        public int Tb02083Codigo { get; set; }
        public string Tb02083Codemp { get; set; }
        public string Tb02083Tipolan { get; set; }
        public int? Tb02083Qtmeta { get; set; }
        public int? Tb02083Qtbase { get; set; }
        public decimal? Tb02083Perc { get; set; }
        public string Tb02083Obs { get; set; }
        public DateTime? Tb02083Dtfecha { get; set; }

        public virtual Tb01007 Tb02083CodempNavigation { get; set; }
        public virtual ICollection<Tb02084> Tb02084 { get; set; }
        public virtual ICollection<Tb02085> Tb02085 { get; set; }
    }
}