using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02082
    {
        public DateTime? Tb02082Dtcad { get; set; }
        public string Tb02082Opcad { get; set; }
        public DateTime? Tb02082Dtalt { get; set; }
        public string Tb02082Opalt { get; set; }
        public string Tb02082Codigo { get; set; }
        public string Tb02082Produto { get; set; }
        public string Tb02082Material { get; set; }
        public string Tb02082Status { get; set; }
        public decimal? Tb02082Qtunit { get; set; }
        public decimal? Tb02082Qtprod { get; set; }
        public decimal? Tb02082Qtdefeito { get; set; }
        public decimal? Tb02082Estant { get; set; }

        public virtual Tb02079 Tb02082CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02082MaterialNavigation { get; set; }
        public virtual Tb01010 Tb02082ProdutoNavigation { get; set; }
        public virtual Tb01043 Tb02082StatusNavigation { get; set; }
    }
}