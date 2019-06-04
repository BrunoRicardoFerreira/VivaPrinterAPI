using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01074
    {
        public Tb01074()
        {
            Tb04045 = new HashSet<Tb04045>();
            Tb04046 = new HashSet<Tb04046>();
        }

        public DateTime? Tb01074Dtcad { get; set; }
        public string Tb01074Opcad { get; set; }
        public DateTime? Tb01074Dtalt { get; set; }
        public string Tb01074Opalt { get; set; }
        public string Tb01074Codigo { get; set; }
        public string Tb01074Nome { get; set; }
        public string Tb01074Plancon { get; set; }
        public string Tb01074Situacao { get; set; }

        public virtual Tb04006 Tb01074PlanconNavigation { get; set; }
        public virtual ICollection<Tb04045> Tb04045 { get; set; }
        public virtual ICollection<Tb04046> Tb04046 { get; set; }
    }
}