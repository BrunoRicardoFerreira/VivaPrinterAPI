using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04001
    {
        public Tb04001()
        {
            Tb02087 = new HashSet<Tb02087>();
            Tb04014 = new HashSet<Tb04014>();
            Tb04026 = new HashSet<Tb04026>();
            Tb04036 = new HashSet<Tb04036>();
            Tb04040 = new HashSet<Tb04040>();
            Tb04051 = new HashSet<Tb04051>();
        }

        public DateTime? Tb04001Dtcad { get; set; }
        public string Tb04001Opcad { get; set; }
        public DateTime? Tb04001Dtalt { get; set; }
        public string Tb04001Opalt { get; set; }
        public string Tb04001Codigo { get; set; }
        public string Tb04001Nome { get; set; }
        public string Tb04001Situacao { get; set; }
        public string Tb04001Baixar { get; set; }

        public virtual ICollection<Tb02087> Tb02087 { get; set; }
        public virtual ICollection<Tb04014> Tb04014 { get; set; }
        public virtual ICollection<Tb04026> Tb04026 { get; set; }
        public virtual ICollection<Tb04036> Tb04036 { get; set; }
        public virtual ICollection<Tb04040> Tb04040 { get; set; }
        public virtual ICollection<Tb04051> Tb04051 { get; set; }
    }
}