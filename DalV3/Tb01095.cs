using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01095
    {
        public string Tb01095Produto { get; set; }
        public string Tb01095Unprod { get; set; }
        public decimal? Tb01095Qtprod { get; set; }

        public virtual Tb01010 Tb01095ProdutoNavigation { get; set; }
        public virtual Tb01004 Tb01095UnprodNavigation { get; set; }
    }
}