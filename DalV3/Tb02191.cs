using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02191
    {
        public DateTime? Tb02191Dtcad { get; set; }
        public string Tb02191Opcad { get; set; }
        public DateTime? Tb02191Dtalt { get; set; }
        public string Tb02191Opalt { get; set; }
        public string Tb02191Codigo { get; set; }
        public string Tb02191Codcli { get; set; }
        public string Tb02191Nome { get; set; }
        public string Tb02191Situacao { get; set; }
        public DateTime? Tb02191Obs { get; set; }

        public virtual Tb01008 Tb02191CodcliNavigation { get; set; }
    }
}