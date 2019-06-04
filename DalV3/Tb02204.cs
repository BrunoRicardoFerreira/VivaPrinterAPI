using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02204
    {
        public DateTime? Tb02204Dtcad { get; set; }
        public string Tb02204Opcad { get; set; }
        public DateTime? Tb02204Dtalt { get; set; }
        public string Tb02204Opalt { get; set; }
        public int Tb02204Coduser { get; set; }
        public string Tb02204Contrato { get; set; }
        public string Tb02204Codcli { get; set; }
        public string Tb02204Site { get; set; }

        public virtual Tb01008 Tb02204CodcliNavigation { get; set; }
        public virtual Tb02111 Tb02204ContratoNavigation { get; set; }
        public virtual Tb02176 Tb02204SiteNavigation { get; set; }
    }
}