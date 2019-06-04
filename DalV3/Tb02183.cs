using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02183
    {
        public DateTime? Tb02183Dtcad { get; set; }
        public string Tb02183Opcad { get; set; }
        public DateTime? Tb02183Dtalt { get; set; }
        public string Tb02183Opalt { get; set; }
        public string Tb02183Codigo { get; set; }
        public string Tb02183Contrato { get; set; }
        public string Tb02183Status { get; set; }
        public DateTime? Tb02183Data { get; set; }
        public string Tb02183Obs { get; set; }

        public virtual Tb02111 Tb02183ContratoNavigation { get; set; }
        public virtual Tb01089 Tb02183StatusNavigation { get; set; }
    }
}