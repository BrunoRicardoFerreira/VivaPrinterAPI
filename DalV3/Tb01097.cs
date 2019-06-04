using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01097
    {
        public Tb01097()
        {
            Tb01098 = new HashSet<Tb01098>();
        }

        public DateTime? Tb01097Dtcad { get; set; }
        public string Tb01097Opcad { get; set; }
        public DateTime? Tb01097Dtalt { get; set; }
        public string Tb01097Opalt { get; set; }
        public string Tb01097Codigo { get; set; }
        public string Tb01097Nome { get; set; }
        public string Tb01097Situacao { get; set; }
        public decimal? Tb01097Pontuacao { get; set; }

        public virtual ICollection<Tb01098> Tb01098 { get; set; }
    }
}