using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02202
    {
        public string Tb02202Codigo { get; set; }
        public DateTime? Tb02202Dtcad { get; set; }
        public string Tb02202Opcad { get; set; }
        public DateTime? Tb02202Dtalt { get; set; }
        public string Tb02202Opalt { get; set; }
        public string Tb02202Descricao { get; set; }
        public string Tb02202Compra { get; set; }

        public virtual Tb02073 Tb02202CompraNavigation { get; set; }
    }
}