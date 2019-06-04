using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01100
    {
        public DateTime? Tb01100Dtcad { get; set; }
        public string Tb01100Opcad { get; set; }
        public DateTime? Tb01100Dtalt { get; set; }
        public string Tb01100Opalt { get; set; }
        public string Tb01100Produto { get; set; }
        public string Tb01100Codemp { get; set; }
        public string Tb01100Tipoestoque { get; set; }
        public decimal? Tb01100Estoquemaximo { get; set; }
        public decimal? Tb01100Estoqueminimo { get; set; }
        public decimal? Tb01100Estoqueseguranca { get; set; }

        public virtual Tb01007 Tb01100CodempNavigation { get; set; }
        public virtual Tb01010 Tb01100ProdutoNavigation { get; set; }
    }
}