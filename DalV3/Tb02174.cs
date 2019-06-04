using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02174
    {
        public DateTime? Tb02174Dtcad { get; set; }
        public string Tb02174Opcad { get; set; }
        public DateTime? Tb02174Dtalt { get; set; }
        public string Tb02174Opalt { get; set; }
        public string Tb02174Codemp { get; set; }
        public string Tb02174Codemp2 { get; set; }
        public string Tb02174Tabela { get; set; }
        public string Tb02174Codigo { get; set; }
        public string Tb02174Entsai { get; set; }
        public string Tb02174Tipoestoque { get; set; }
        public string Tb02174Produto { get; set; }
        public string Tb02174Locpprod { get; set; }
        public decimal? Tb02174Qtprod { get; set; }
        public decimal? Tb02174Qtprodb { get; set; }

        public virtual Tb01007 Tb02174CodempNavigation { get; set; }
        public virtual Tb01003 Tb02174LocpprodNavigation { get; set; }
        public virtual Tb01010 Tb02174ProdutoNavigation { get; set; }
    }
}