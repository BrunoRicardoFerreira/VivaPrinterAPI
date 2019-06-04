using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02173
    {
        public DateTime? Tb02173Dtcad { get; set; }
        public string Tb02173Opcad { get; set; }
        public DateTime? Tb02173Dtalt { get; set; }
        public string Tb02173Opalt { get; set; }
        public string Tb02173Cademp { get; set; }
        public string Tb02173Produto { get; set; }
        public string Tb02173Locpprod { get; set; }
        public decimal? Tb02173Qtprod { get; set; }
        public decimal? Tb02173QtprodI { get; set; }
        public decimal? Tb02173QtprodU { get; set; }
        public decimal? Tb02173Rma { get; set; }
        public decimal? Tb02173Rmat { get; set; }
        public decimal? Tb02173Rmar { get; set; }
        public decimal? Tb02173Rmag { get; set; }

        public virtual Tb01007 Tb02173CadempNavigation { get; set; }
        public virtual Tb01003 Tb02173LocpprodNavigation { get; set; }
        public virtual Tb01010 Tb02173ProdutoNavigation { get; set; }
    }
}