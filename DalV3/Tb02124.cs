using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02124
    {
        public DateTime? Tb02124Dtcad { get; set; }
        public string Tb02124Opcad { get; set; }
        public DateTime? Tb02124Dtalt { get; set; }
        public string Tb02124Opalt { get; set; }
        public string Tb02124Codigo { get; set; }
        public string Tb02124Produto { get; set; }
        public int? Tb02124Qtprod { get; set; }
        public decimal? Tb02124Custo { get; set; }
        public int? Tb02124Contador { get; set; }

        public virtual Tb02122 Tb02124CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02124ProdutoNavigation { get; set; }
    }
}