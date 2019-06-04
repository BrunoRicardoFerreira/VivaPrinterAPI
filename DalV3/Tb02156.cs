using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02156
    {
        public DateTime? Tb02156Dtcad { get; set; }
        public string Tb02156Opcad { get; set; }
        public DateTime? Tb02156Dtalt { get; set; }
        public string Tb02156Opalt { get; set; }
        public string Tb02156Codigo { get; set; }
        public string Tb02156Produto { get; set; }
        public string Tb02156Numserie { get; set; }
        public string Tb02156Sup { get; set; }
        public decimal? Tb02156Perc { get; set; }

        public virtual Tb02111 Tb02156CodigoNavigation { get; set; }
        public virtual Tb02112 Tb02156Navigation { get; set; }
        public virtual Tb01010 Tb02156ProdutoNavigation { get; set; }
        public virtual Tb01010 Tb02156SupNavigation { get; set; }
    }
}