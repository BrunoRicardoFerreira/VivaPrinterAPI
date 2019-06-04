using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04046
    {
        public DateTime? Tb04046Dtcad { get; set; }
        public string Tb04046Opcad { get; set; }
        public DateTime? Tb04046Dtalt { get; set; }
        public string Tb04046Opalt { get; set; }
        public string Tb04046Codigo { get; set; }
        public string Tb04046Codfor { get; set; }
        public string Tb04046Codemp { get; set; }
        public DateTime Tb04046Dtvenc { get; set; }
        public string Tb04046Tipodesc { get; set; }
        public string Tb04046Tipo { get; set; }
        public decimal? Tb04046Valor { get; set; }
        public decimal? Tb04046Valor2 { get; set; }

        public virtual Tb01074 Tb04046TipodescNavigation { get; set; }
    }
}