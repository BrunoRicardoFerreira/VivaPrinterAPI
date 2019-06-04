using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01016
    {
        public Tb01016()
        {
            Tb01017 = new HashSet<Tb01017>();
        }

        public DateTime? Tb01016Dtcad { get; set; }
        public string Tb01016Opcad { get; set; }
        public DateTime? Tb01016Dtalt { get; set; }
        public string Tb01016Opalt { get; set; }
        public string Tb01016Codigo { get; set; }
        public string Tb01016Nome { get; set; }
        public string Tb01016Situacao { get; set; }

        public virtual ICollection<Tb01017> Tb01017 { get; set; }
    }
}