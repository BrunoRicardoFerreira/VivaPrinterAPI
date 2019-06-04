using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02200
    {
        public string Tb02200Codigo { get; set; }
        public DateTime? Tb02200Dtcad { get; set; }
        public string Tb02200Opcad { get; set; }
        public DateTime? Tb02200Dtalt { get; set; }
        public string Tb02200Opalt { get; set; }
        public string Tb02200Descricao { get; set; }
        public string Tb02200Compra { get; set; }

        public virtual Tb02002 Tb02200CompraNavigation { get; set; }
    }
}