using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02189
    {
        public DateTime? Tb02189Dtcad { get; set; }
        public string Tb02189Opcad { get; set; }
        public DateTime? Tb02189Dtalt { get; set; }
        public string Tb02189Opalt { get; set; }
        public string Tb02189Codigo { get; set; }
        public string Tb02189Produto { get; set; }
        public string Tb02189Numserie { get; set; }
        public string Tb02189Papel { get; set; }
        public string Tb02189Pat { get; set; }
        public int? Tb02189Qtprod { get; set; }
        public int? Tb02189Qtprodb { get; set; }
        public int? Tb02189Medidor { get; set; }
        public string Tb02189Senha { get; set; }
        public decimal? Tb02186Percver { get; set; }
        public decimal? Tb02186Perccon { get; set; }
        public decimal? Tb02189Percver { get; set; }
        public decimal? Tb02189Perccon { get; set; }

        public virtual Tb02188 Tb02189CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02189PapelNavigation { get; set; }
        public virtual Tb01010 Tb02189ProdutoNavigation { get; set; }
    }
}