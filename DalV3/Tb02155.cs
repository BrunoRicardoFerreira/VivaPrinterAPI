using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02155
    {
        public DateTime? Tb02155Dtcad { get; set; }
        public string Tb02155Opcad { get; set; }
        public DateTime? Tb02155Dtalt { get; set; }
        public string Tb02155Opalt { get; set; }
        public string Tb02155Contrato { get; set; }
        public string Tb02155Vend { get; set; }
        public decimal? Tb02155Comissao { get; set; }

        public virtual Tb02111 Tb02155ContratoNavigation { get; set; }
        public virtual Tb01006 Tb02155VendNavigation { get; set; }
    }
}