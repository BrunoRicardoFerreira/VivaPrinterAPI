using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02114
    {
        public DateTime? Tb02114Dtcad { get; set; }
        public string Tb02114Opcad { get; set; }
        public DateTime? Tb02114Dtalt { get; set; }
        public string Tb02114Opalt { get; set; }
        public string Tb02114Codigo { get; set; }
        public string Tb02114Produto { get; set; }
        public string Tb02114Numserie { get; set; }
        public string Tb02114Acessorio { get; set; }
        public int? Tb02114Qtprod { get; set; }
        public string Tb02114Obs { get; set; }

        public virtual Tb01010 Tb02114AcessorioNavigation { get; set; }
        public virtual Tb02111 Tb02114CodigoNavigation { get; set; }
        public virtual Tb02112 Tb02114Navigation { get; set; }
        public virtual Tb01010 Tb02114ProdutoNavigation { get; set; }
    }
}