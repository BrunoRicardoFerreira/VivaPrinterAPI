using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01077
    {
        public Tb01077()
        {
            Tb01091 = new HashSet<Tb01091>();
        }

        public DateTime? Tb01077Dtcad { get; set; }
        public string Tb01077Opcad { get; set; }
        public DateTime? Tb01077Dtalt { get; set; }
        public string Tb01077Opalt { get; set; }
        public string Tb01077Codigo { get; set; }
        public string Tb01077Nome { get; set; }
        public string Tb01077Situacao { get; set; }

        public virtual ICollection<Tb01091> Tb01091 { get; set; }
    }
}