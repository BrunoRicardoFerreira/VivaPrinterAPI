using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04008
    {
        public Tb04008()
        {
            Tb01001 = new HashSet<Tb01001>();
            Tb01080 = new HashSet<Tb01080>();
            Tb04009 = new HashSet<Tb04009>();
            Tb04030 = new HashSet<Tb04030>();
            Tb04031 = new HashSet<Tb04031>();
            Tb04043 = new HashSet<Tb04043>();
            Tb04051 = new HashSet<Tb04051>();
        }

        public DateTime? Tb04008Dtcad { get; set; }
        public string Tb04008Opcad { get; set; }
        public DateTime? Tb04008Dtalt { get; set; }
        public string Tb04008Opalt { get; set; }
        public string Tb04008Codigo { get; set; }
        public string Tb04008Nome { get; set; }
        public string Tb04008Situacao { get; set; }

        public virtual ICollection<Tb01001> Tb01001 { get; set; }
        public virtual ICollection<Tb01080> Tb01080 { get; set; }
        public virtual ICollection<Tb04009> Tb04009 { get; set; }
        public virtual ICollection<Tb04030> Tb04030 { get; set; }
        public virtual ICollection<Tb04031> Tb04031 { get; set; }
        public virtual ICollection<Tb04043> Tb04043 { get; set; }
        public virtual ICollection<Tb04051> Tb04051 { get; set; }
    }
}