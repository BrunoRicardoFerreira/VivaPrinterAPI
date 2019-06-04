using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb03008
    {
        public Tb03008()
        {
            Tb03001 = new HashSet<Tb03001>();
            Tb03007 = new HashSet<Tb03007>();
        }

        public DateTime? Tb03008Dtcad { get; set; }
        public string Tb03008Opcad { get; set; }
        public DateTime? Tb03008Dtalt { get; set; }
        public string Tb03008Opalt { get; set; }
        public string Tb03008Codigo { get; set; }
        public string Tb03008Nome { get; set; }
        public string Tb03008Situacao { get; set; }

        public virtual ICollection<Tb03001> Tb03001 { get; set; }
        public virtual ICollection<Tb03007> Tb03007 { get; set; }
    }
}