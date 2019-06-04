using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02171
    {
        public string Tb02171Codigo { get; set; }
        public string Tb02171Produto { get; set; }
        public int Tb02171Id { get; set; }
        public string Tb02171Peca { get; set; }
        public decimal? Tb02171Qtprod { get; set; }
        public decimal? Tb02171Prunit { get; set; }

        public virtual Tb02168 Tb02171Navigation { get; set; }
        public virtual Tb01010 Tb02171ProdutoNavigation { get; set; }
    }
}